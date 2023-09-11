Imports System.Data.SqlClient
Imports System.Threading
Imports System.Net
Public Class frmMain
	Dim AssyBuf As String 'Comm Buffer for Barcode scanner
	Dim ReadTagFlag As Boolean 'True when Timer1 is reading Tag
	Public Action As Integer
	Dim SlideCount As Integer

	Private Sub Command2_Click(sender As Object, e As EventArgs) Handles Command2.Click 'OK
		GetLastConfig()

		lbl_WOnos.Text = LoadWOfrRFID.JobNos
		lbl_currentref.Text = LoadWOfrRFID.JobModelName
		lbl_wocounter.Text = CStr(LoadWOfrRFID.JobQTy)
		lbl_unitaryCount.Text = CStr(LoadWOfrRFID.JobUnitaryCount)
		lbl_tagnos.Text = LoadWOfrRFID.JobRFIDTag
		lbl_ArticleNos.Text = LoadWOfrRFID.JobArticle

		'Load Parameter from database - Server
		If Not LoadParameter(LoadWOfrRFID.JobModelName) Then
			MsgBox("Unable to load parameters from Database")
			End
		End If

		'Loading Parameter to PLC
		If Not LoadParameter2PLC() Then
			MsgBox("Unable to communicate to PLC")
			End
		End If

		'Load label parameter
		'UPGRADE_WARNING: Couldn't resolve default property of object LabelVar. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		LabelVar = LoadLabelParameter(LoadWOfrRFID.JobModelName)
		Image1.Image = System.Drawing.Image.FromFile(INIPHOTOPATH & LabelVar.UnitImage)
	End Sub

	Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load  'OK
		Dim fullPath As String = System.AppDomain.CurrentDomain.BaseDirectory
		Dim projectFolder As String = fullPath.Replace("XCS-15\bin\Debug\", "")
		SlideCount = 35
		INISLIDEPATH = projectFolder & "Slide\"
		If Dir(projectFolder & "Config\Config.INI") = "" Then
			MsgBox("Config.INI is missing")
			End
		End If

		If Dir(projectFolder & "\Setup\Setup.INI") = "" Then
			MsgBox("Setup.INI is missing")
			End
		End If

		ReadINI(projectFolder & "Config\Config.INI")

		'Modbus
		frmMsg.Show()
		frmMsg.Text1.Text = "Establishing link with PLC..."
		frmModbus.Show()
		frmModbus.Hide()
		If frmModbus.lbl_status.Text <> "Connected" Then
			Ethernet.Image = My.Resources.red
			End
		End If
		frmMsg.Text1.Text = "Connection to PLC established"

		Ethernet.Image = My.Resources.green

		frmMsg.Text1.Text = "Loading CodeSoft..."
		killLPPA()
		OpenCodesoft()

		GetLastConfig()

		lbl_WOnos.Text = LoadWOfrRFID.JobNos
		lbl_currentref.Text = LoadWOfrRFID.JobModelName
		lbl_wocounter.Text = LoadWOfrRFID.JobQTy
		lbl_unitaryCount.Text = LoadWOfrRFID.JobUnitaryCount
		lbl_tagnos.Text = LoadWOfrRFID.JobRFIDTag
		lbl_ArticleNos.Text = LoadWOfrRFID.JobArticle

		'Load Parameter from database - Server
		If Not LoadParameter(LoadWOfrRFID.JobModelName) Then
			MsgBox("Unable to load parameters from Database")
			End
		End If
		'===============================================
		'Loading Parameter to PLC
		If Not LoadParameter2PLC() Then
			MsgBox("Unable to communicate to PLC")
			End
		End If
		'===============================================
		'Load Rack Material List
		If Not LoadRackMaterial() Then
			MsgBox("Unable to load Rack Materials")
			End
		End If

		'Load Model Material
		If Not LoadModelMaterial(LoadWOfrRFID.JobModelName) Then
			MsgBox("Unable to load Model Material")
			End
		End If

		'Update Rack indicator
		If Not ActivateRackLED() Then
			MsgBox("Unable to communicate with PLC")
			End
		End If
		'Load label parameter
		LabelVar = LoadLabelParameter(LoadWOfrRFID.JobModelName)

		Dim strHostName As String = Dns.GetHostName()
		Dim hostname As IPHostEntry = Dns.GetHostByName(strHostName)
		Dim ip As IPAddress() = hostname.AddressList
		lbl_localhostname.Text = "PC Name : " & strHostName
		lbl_localip.Text = "PC IP Address : " & ip(0).ToString

		Image1.Image = Image.FromFile(INIPHOTOPATH & LabelVar.UnitImage)
		RFID_Comm.Open()    'MARK
		Barcode_Comm.Open() 'MARK
		Timer1.Enabled = True 'MARK
		frmMsg.Hide()
	End Sub

	Private Function LoadParameter(csmodel As String) As Boolean    'OK
		Dim query As String
		Dim ds As DataTable

		query = "SELECT * FROM [Parameter] WHERE [ModelName] = '" & csmodel & "'"
		ds = ConnectionDatabase.readData(query).Tables(0)
		With LoadWOfrRFID
			.JobArticle = "" & ds.Rows(0).Item("ArticleNos")
			.JobProductThread = "" & ds.Rows(0).Item("BodyType")
			.JobButtonType = "" & ds.Rows(0).Item("ButtonOpt")
			.JobProductMaterial = "" & ds.Rows(0).Item("MaterialType")
		End With
		Return True
		Exit Function

ErrHandler:
	End Function

	Private Function LoadParameter2PLC() As Boolean 'OK
		Dim kontrol As PictureBox
		Dim kontrol2 As Label
		On Error GoTo ErrorHandler
		If Not frmModbus.tulisModbus(40250, 0) Then Exit Function
		If Not frmModbus.tulisModbus(40252, 0) Then Exit Function
		If Not frmModbus.tulisModbus(40253, 0) Then Exit Function
		If Not frmModbus.tulisModbus(40254, 0) Then Exit Function
		If Not frmModbus.tulisModbus(40255, 0) Then Exit Function
		If Not frmModbus.tulisModbus(40256, 0) Then Exit Function
		For i = 0 To 5
			kontrol = Me.Controls("_Shape1_" & i)
			kontrol.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0C0C0)
			kontrol2 = Me.Controls("_Label11_" & i)
			kontrol2.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0C0C0)
		Next
		If LoadWOfrRFID.JobProductMaterial = "Zamak" Then
			If Not frmModbus.tulisModbus(40100, 1) Then Exit Function
			If Not frmModbus.tulisModbus(40251, 1) Then Exit Function
			If Not frmModbus.tulisModbus(40252, 1) Then Exit Function
			If Not frmModbus.tulisModbus(40254, 1) Then Exit Function
			If Not frmModbus.tulisModbus(40255, 1) Then Exit Function
			If Not frmModbus.tulisModbus(40256, 1) Then Exit Function
			_Shape1_0.BackColor = System.Drawing.Color.Black
			_Shape1_1.BackColor = System.Drawing.Color.Black
			_Shape1_3.BackColor = System.Drawing.Color.Black
			_Shape1_4.BackColor = System.Drawing.Color.Black
			_Label11_0.BackColor = System.Drawing.Color.Black
			_Label11_1.BackColor = System.Drawing.Color.Black
			_Label11_3.BackColor = System.Drawing.Color.Black
			_Label11_4.BackColor = System.Drawing.Color.Black
		Else
			If Not frmModbus.tulisModbus(40100, 0) Then Exit Function
			If Not frmModbus.tulisModbus(40250, 1) Then Exit Function
			If Not frmModbus.tulisModbus(40253, 1) Then Exit Function
			_Label11_2.BackColor = System.Drawing.Color.Black
			_Label11_5.BackColor = System.Drawing.Color.Black
			_Shape1_2.BackColor = System.Drawing.Color.Black
			_Shape1_5.BackColor = System.Drawing.Color.Black
		End If

		Return True
		Exit Function
ErrorHandler:
		Return False
	End Function

	Private Function LoadLabelParameter(csmodel As String) As LabelData	'OK
		Dim query As String
		Dim ds As DataTable
		query = "SELECT * FROM [Label] WHERE [ModelName] = '" & csmodel & "'"
		ds = ConnectionDatabase.readData(query).Tables(0)
		With LoadLabelParameter
			.UnitModelName = "" & ds.Rows(0).Item("Product_Reference")
			.UnitArticleNos = "" & ds.Rows(0).Item("ArticleNos")
			.UnitImage = "" & ds.Rows(0).Item("Product_Img")
			.UnitLabelTemplate = "" & ds.Rows(0).Item("Product_Template")
			'.UnitLabelSymb1 = "" & ds.Rows(0).Item("Product_Symbol1")
			'.UnitLabelSymb2 = "" & ds.Rows(0).Item("Product_Symbol2")
			'.UnitLabelTor = "" & ds.Rows(0).Item("Product_Torque")
		End With
		Exit Function

ErrHandler:
	End Function

	Private Function LoadModelMaterial(ByRef Unitname As String) As Boolean 'OK
		Dim i As Integer
		Dim FNum As Integer
		Dim LineStr As String

		LoadWOfrRFID.Initialize()
		On Error GoTo ErrorHandler
		FNum = FreeFile()
		FileOpen(FNum, INIMATERIALPATH & "Station5\" & Unitname & ".Txt", OpenMode.Input)
		Do While Not EOF(FNum)
			LineStr = LineInput(FNum)
			LoadWOfrRFID.JobModelMaterial(i) = LineStr
			i = i + 1
		Loop
		FileClose(FNum)
		Return True
		Exit Function

ErrorHandler:
		Return False
	End Function

	Private Function LoadRackMaterial() As Boolean  'OK
		Dim FNum As Integer
		Dim ii As Integer
		Dim LineStr As String
		On Error GoTo ErrorHandler
		ii = 0
		FNum = FreeFile()
		Unitmaterial.Init()
		FileOpen(FNum, INIMATERIALPATH & "Rack\" & "Station5", OpenMode.Input)
		Do While Not EOF(FNum)
			LineStr = LineInput(FNum)
			Unitmaterial.PartNos(ii) = LineStr
			Unitmaterial.PartPLCWord(ii) = 40200 + ii
			'Debug.Write("PARTNOS")
			'Debug.Write(ii)
			'Debug.Write("= ")
			'Debug.WriteLine(Unitmaterial.PartNos(ii))
			'Debug.Write("PARTPLC")
			'Debug.Write(ii)
			'Debug.Write("= ")
			'Debug.WriteLine(Unitmaterial.PartPLCWord(ii))
			ii = ii + 1
		Loop
		FileClose(FNum)
		Return True
		Exit Function
ErrorHandler:
		Return False
	End Function

	Public Sub PrintLabel() 'OK
		ActiveDoc.Variables.FormVariables.Item("Var14").Value = LabelVar.UnitImage 'INIPHOTOPATH & LabelVar.UnitImage
		ActiveDoc.Variables.FormVariables.Item("Var10").Value = PSNFileInfo.PSN
		ActiveDoc.Variables.FormVariables.Item("Var8").Value = "20" & Mid(PSNFileInfo.PSN, 10, 2)
		ActiveDoc.Variables.FormVariables.Item("Var9").Value = Mid(PSNFileInfo.PSN, 12, 2)
		ActiveDoc.CopyToClipboard()
		'Image_preview_unitary = Clipboard.GetData(vbCFMetafile)

		'lbl_msg.Caption = "Please Wait......" & vbCrLf & "Printing Product Label .... " & vbCrLf
		'-------------------------------------------------------------------
		If PrintLab(1) = False Then 'necessary for printing
			'UPGRADE_WARNING: Couldn't resolve default property of object CsErr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			MsgBox("Error", MsgBoxStyle.Critical)
		End If
		'------------------------------------------------------------------

		'exist = False 'initialize back to false if nt can always print
		'UPGRADE_WARNING: Couldn't resolve default property of object printedbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'

		'Open INIPRINTPATH & "Print.Txt" For Append As #4
		'    Print #4, unitPSN
		'Close #4

	End Sub

	Private Function ValidiateWONos(strName As String) As String    'OK
		Dim query As String
		Dim ds As DataTable
		Dim temp As String

		On Error GoTo ErrorHandler

		query = "SELECT *FROM [CSUNIT] WHERE [WONOS] = '" & strName & "'"
		ds = ConnectionDatabase.readData(query).Tables(0)
		If ds.Rows.Count > 0 Then
			temp = ds.Rows(0).Item("STATUS")
			Return temp
		Else
			Return "NOK"
		End If
		Exit Function

ErrorHandler:
		Return "NOK"
	End Function

	Private Function ActivateRackLED() As Boolean   'OK
		On Error GoTo ErrorHandler
		For i = 0 To 40
			If LoadWOfrRFID.JobModelMaterial(i) <> "" Then
				For N = 0 To 40
					If LoadWOfrRFID.JobModelMaterial(i) = Unitmaterial.PartNos(N) Then
						'Debug.WriteLine(Unitmaterial.PartPLCWord(N))
						If Not frmModbus.tulisModbus(Unitmaterial.PartPLCWord(N), 1) Then
							GoTo ErrorHandler
						End If
					End If
				Next
			End If
		Next
		Return True
		Exit Function
ErrorHandler:
		Return False
	End Function

	Private Sub Reset_PLC() 'OK
		frmModbus.tulisModbus(40500, 1)
	End Sub

	Private Sub Image2_Click(sender As Object, e As EventArgs) Handles Image2.Click 'OK
		Frame2.Visible = False
	End Sub

	Private Sub Image1_Click(sender As Object, e As EventArgs) Handles Image1.Click 'OK
		Frame2.Visible = True
	End Sub

	Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click 'OK
		If PrinterApp.Visible = True Then
			SuperVisible(False)
		Else
			SuperVisible(True)
		End If
	End Sub

	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick   'OK
		Dim Tagref As String
		Dim Tagnos As String
		Dim TagQty As String
		Dim Tagid As String
		Dim CheckWO As String

		ReadTagFlag = True
		Ethernet.Image = My.Resources.circle_black
		Tagnos = RD_MULTI_RFID("0000", 10)
		If Tagnos = "NOK" Then GoTo NoChange
		Tagid = RD_MULTI_RFID("0040", 3) 'Read Tag ID
		If Tagnos = "MASTER" Then
			If Tagid = lbl_tagnos.Text Then GoTo NoChange
			If lbl_WOnos.Text <> "MASTER" Then
				'update the Current WO into the database before changing
				If CheckWOExist((lbl_WOnos.Text)) Then
					UpdateWO((lbl_WOnos.Text), (lbl_unitaryCount.Text))
				Else
					AddWO((lbl_WOnos.Text))
					UpdateWO((lbl_WOnos.Text), (lbl_unitaryCount.Text))
				End If
				GoTo WOChange
			ElseIf lbl_WOnos.Text = "MASTER" Then
				GoTo WOChange
			End If
		ElseIf Tagnos <> LoadWOfrRFID.JobNos Then
Master:
			If lbl_WOnos.Text <> "MASTER" Then
				'Checking Current WO first b4 Change Series is allowed. If WO status is open, check Quantity
				CheckWO = ValidiateWONos(Tagnos)
				If CheckWO = "NOK" Then
					Txt_Msg.Text = "Invalid WO - WO is not registered in Server"
					GoTo NoChange
				ElseIf CheckWO = "OPEN" Then

				ElseIf CheckWO = "CLOSED" Then

				ElseIf CheckWO = "FORCED" Then

				ElseIf CheckWO = "DISTRUP" Then

				End If
				'update the Current WO into the database before changing
				If CheckWOExist((lbl_WOnos.Text)) Then
					UpdateWO((lbl_WOnos.Text), (lbl_unitaryCount.Text))
				Else
					AddWO((lbl_WOnos.Text))
					UpdateWO((lbl_WOnos.Text), (lbl_unitaryCount.Text))
				End If

			End If
WOChange:
			Txt_Msg.Text = "Changing Series..." & vbCrLf
			Txt_Msg.Text = Txt_Msg.Text & "Reading info from RFID Tag..." & vbCrLf
			LoadWOfrRFID.JobNos = Tagnos
			Tagref = RD_MULTI_RFID("0014", 10) 'Read WO Reference from Tag
			If Tagref = "NOK" Then
				Txt_Msg.Text = Txt_Msg.Text & "--> Unable to read from RFID Tag" & vbCrLf
				Txt_Msg.Text = Txt_Msg.Text & "--> Change Series fail" & vbCrLf
				ReadTagFlag = False
				Exit Sub
			End If
			TagQty = RD_MULTI_RFID("0028", 10) 'Read WO Qty from Tag
			If TagQty = "NOK" Then
				Txt_Msg.Text = Txt_Msg.Text & "--> Unable to read from RFID Tag" & vbCrLf
				Txt_Msg.Text = Txt_Msg.Text & "--> Change Series fail" & vbCrLf
				ReadTagFlag = False
				Exit Sub
			End If
			Tagid = RD_MULTI_RFID("0040", 3) 'Read Tag ID
			If Tagid = "NOK" Then
				Txt_Msg.Text = Txt_Msg.Text & "--> Unable to read from RFID Tag" & vbCrLf
				Txt_Msg.Text = Txt_Msg.Text & "--> Change Series fail" & vbCrLf
				ReadTagFlag = False
				Exit Sub
			End If
			'Check if reference is valid from the database
			If Not RefCheck(Tagref) Then
				Txt_Msg.Text = Txt_Msg.Text & "--> Invalid Reference" & vbCrLf
				Txt_Msg.Text = Txt_Msg.Text & "--> Change Series fail" & vbCrLf
				ReadTagFlag = False
				Exit Sub
			End If
			Txt_Msg.Text = Txt_Msg.Text & "loading parameters of new reference..." & vbCrLf
			If Not LoadModelMaterial(Tagref) Then
				Txt_Msg.Text = Txt_Msg.Text & "--> Unable to load Model parameter" & vbCrLf
				Txt_Msg.Text = Txt_Msg.Text & "--> Change Series fail" & vbCrLf
				ReadTagFlag = False
				Exit Sub
			End If
			If Not LoadParameter(Tagref) Then
				Txt_Msg.Text = Txt_Msg.Text & "--> Unable to Load parameter from Server" & vbCrLf
				Txt_Msg.Text = Txt_Msg.Text & "--> Change Series fail" & vbCrLf
				ReadTagFlag = False
				Exit Sub
			End If
			Reset_PLC()
			Txt_Msg.Text = Txt_Msg.Text & "loading parameters to PLC..." & vbCrLf
			Thread.Sleep(50)
			If Not LoadParameter2PLC() Then
				Txt_Msg.Text = Txt_Msg.Text & "--> Unable to communicate with PLC..."
				Txt_Msg.Text = Txt_Msg.Text & "--> Change Series fail" & vbCrLf
				ReadTagFlag = False
				Exit Sub
			End If

			If Not ActivateRackLED() Then
				Txt_Msg.Text = Txt_Msg.Text & "--> Unable to communicate with PLC" & vbCrLf
				Txt_Msg.Text = Txt_Msg.Text & "--> Change Series fail" & vbCrLf
				ReadTagFlag = False
				Exit Sub
			End If
			lbl_WOnos.Text = Tagnos
			LoadWOfrRFID.JobNos = Tagnos
			lbl_currentref.Text = Tagref
			LoadWOfrRFID.JobModelName = Tagref
			lbl_wocounter.Text = TagQty
			LoadWOfrRFID.JobQTy = CShort(TagQty)
			lbl_tagnos.Text = Tagid
			LoadWOfrRFID.JobRFIDTag = Tagid
			lbl_ArticleNos.Text = LoadWOfrRFID.JobArticle
			'UPGRADE_WARNING: Couldn't resolve default property of object LabelVar. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			LabelVar = LoadLabelParameter(LoadWOfrRFID.JobModelName)
			Image1.Image = System.Drawing.Image.FromFile(INIPHOTOPATH & LabelVar.UnitImage)

			If Tagnos <> "MASTER" Then
				If CheckWOExist(Tagnos) Then
					LoadWOfrRFID.JobUnitaryCount = Val(RetrieveWOQty(Tagnos))
					lbl_unitaryCount.Text = CStr(LoadWOfrRFID.JobUnitaryCount)
				Else
					Call AddWO(Tagnos)
					LoadWOfrRFID.JobUnitaryCount = 0 'Reset output counter
					lbl_unitaryCount.Text = "0"
				End If
			Else
				lbl_unitaryCount.Text = "0"
				LoadWOfrRFID.JobUnitaryCount = 0
			End If


			LoadWOfrRFID.JobUnitaryCount = Val(lbl_unitaryCount.Text)
			UpdateStnStatus()
			Txt_Msg.Text = Txt_Msg.Text & "Change Series completed" & vbCrLf
		End If
		ReadTagFlag = False
NoChange:

		For i = 0 To 5
			Dim controls As PictureBox
			Dim controls2 As Control
			controls = Me.Controls("_Shape1_" & i)
			controls2 = Me.Controls("_Label11_" & i)
			If controls.BackColor.Equals(System.Drawing.Color.Black) Then
				controls.BackColor = System.Drawing.Color.Red
				controls2.BackColor = System.Drawing.Color.Red
			ElseIf controls.BackColor.Equals(System.Drawing.Color.Red) Then
				controls.BackColor = System.Drawing.Color.Black
				controls2.BackColor = System.Drawing.Color.Black
			End If
		Next
		Dim Station_status As Integer
		Text4.Text = ""
		Station_status = frmModbus.bacaModbus(40101)
		Ethernet.Image = My.Resources.green
		Text4.Text = CStr(Station_status)
		Select Case Station_status
			Case 0
				lbl_msg.Text = "Please scan the PSN on the product..."
			Case 1
				lbl_msg.Text = "Please assembly and screw cover"
			Case 2

			Case 3

			Case 4
				If frmModbus.bacaModbus(40102) = 1 Then 'Pass
					Action = 1
				Else 'Fail
					PSNFileInfo.Stn5Status = "FAIL"
					Image2.Image = System.Drawing.Image.FromFile(INIPHOTOPATH & "FAIL.Emf")
					'Updating the PSN text file
					If Command1.Text = "Eye Open" Then '
						PSNFileInfo.Stn5CheckOut = Today & "," & TimeOfDay
						Txt_Msg.Text = Txt_Msg.Text & "Updating " & PSNFileInfo.PSN & ".Txt..." & vbCrLf
						lbl_msg.Text = "Please wait..."
						If Not WRITEPSNFILE(PSNFileInfo.PSN) Then
							Txt_Msg.Text = Txt_Msg.Text & "--> Unable to access " & PSNFileInfo.PSN & ".Txt in the server" & vbCrLf
							Txt_Msg.BackColor = System.Drawing.Color.Red
						End If
						Txt_Msg.Text = Txt_Msg.Text & PSNFileInfo.PSN & ".Txt updated" & vbCrLf
						UpdateStnStatus()
					End If
					If Not frmModbus.tulisModbus(40101, 10) Then 'Inform PLC that PC already read result
						Txt_Msg.Text = Txt_Msg.Text & "--> Unable to communicate with PLC - MW101" & vbCrLf
						Txt_Msg.BackColor = System.Drawing.Color.Red
						Exit Sub
					End If
					Action = 0
				End If
			Case 5

		End Select

		Select Case Action
			Case 0

			Case 1
				Dim fullPath As String = System.AppDomain.CurrentDomain.BaseDirectory
				Dim projectFolder As String = fullPath.Replace("XCS-15\bin\Debug\", "")
				Image2.Image = System.Drawing.Image.FromFile(INIPHOTOPATH & "PASS.Emf")
				'==================== Unitary Printing Sequence ===================
				Txt_Msg.Text = "Loading Label template..."
				If LabelVar.UnitLabelTemplate <> "" Then 'If no define template, skip print unitary
					If Not OpenDocument(INITEMPLATEPATH & LabelVar.UnitLabelTemplate) Then
						Txt_Msg.Text = "--> Unable to open label template" & vbCrLf
						Txt_Msg.BackColor = System.Drawing.Color.Red
						Exit Sub
					End If
					Txt_Msg.Text = "Setting Printer..."
					If Not SetPrinter("Zebra 110XiIII Plus (300 dpi)", "USB001") Then
						'If Not PrinterSelect("Zebra 110XiIII Plus (600 dpi)", "LPT1:") Then
						Txt_Msg.Text = "--> Unable to select Printer" & vbCrLf
						Txt_Msg.BackColor = System.Drawing.Color.Red
						Exit Sub
					End If
					Txt_Msg.Text = "Printing label..."
					PrintLabel()
					CloseDocument()
				End If
				PSNFileInfo.Stn5Status = "PASS"
				Txt_Msg.Text = "Updating " & PSNFileInfo.PSN & ".Txt..." & vbCrLf
				lbl_msg.Text = "Please wait..."
				PSNFileInfo.Stn5CheckOut = Today & "," & TimeOfDay
				If Not WRITEPSNFILE(PSNFileInfo.PSN) Then
					Txt_Msg.Text = "--> Unable to access " & PSNFileInfo.PSN & ".Txt in the server" & vbCrLf
					Txt_Msg.BackColor = System.Drawing.Color.Red
					Exit Sub
				End If
				Txt_Msg.Text = Txt_Msg.Text & PSNFileInfo.PSN & ".Txt updated" & vbCrLf
				UpdateStnStatus()
				'Skip increment if repeated
				If PSNFileInfo.Stn5Status <> "PASS" Then
					lbl_unitaryCount.Text = CStr(Val(lbl_unitaryCount.Text) + 1)
				End If

				If Not frmModbus.tulisModbus(40101, 10) Then 'Inform PLC that PC already read result
					Txt_Msg.Text = "--> Unable to communicate with PLC - MW101" & vbCrLf
					Txt_Msg.BackColor = System.Drawing.Color.Red
					Exit Sub
				End If
				Action = 0

		End Select
	End Sub

	Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
		Image3.Image = System.Drawing.Image.FromFile(INISLIDEPATH & "Slide" & SlideCount & ".JPG")
		SlideCount = SlideCount + 1
		If SlideCount = 41 Then SlideCount = 35
	End Sub

	Private Sub cmd_quit_Click(sender As Object, e As EventArgs) Handles cmd_quit.Click
		SuperVisible(False)
		killLPPA()
		PutLastConfig()
		'RFID_Comm.PortOpen = False
		'Barcode_Comm.Close()
		End
	End Sub



	Private Sub cmd_testspec_Click(sender As Object, e As EventArgs) Handles cmd_testspec.Click
		Me.Hide()
		frm_labelspec.ShowDialog()
	End Sub

	Private Sub cmd_reprint_Click(sender As Object, e As EventArgs) Handles cmd_reprint.Click
		Barcode_Comm.Close()
		Me.Hide()
		frm_Reprint.ShowDialog()
	End Sub

	Private Sub cmd_material_Click(sender As Object, e As EventArgs) Handles cmd_material.Click
		'Me.Hide()
		'FrmMaterial.ShowDialog()
	End Sub

	Private Sub cmd_database_Click(sender As Object, e As EventArgs) Handles cmd_database.Click
		'Me.Hide()
		'frmDatabase.showDialog()
	End Sub

	Private Sub Command1_Click(sender As Object, e As EventArgs) Handles Command1.Click
		If Command1.Text = "Eye Open" Then
			If Not frmModbus.tulisModbus(40109, 1) Then
				Txt_Msg.Text = "--> Unable to communicate with PLC - %MW109"
				Exit Sub
			End If
			Command1.Image = My.Resources.close_eyes
			Command1.Text = "Eye Close"

		ElseIf Command1.Text = "Eye Close" Then
			If Not frmModbus.tulisModbus(40109, 0) Then
				Txt_Msg.Text = "--> Unable to communicate with PLC - %MW109"
				Exit Sub
			End If
			Command1.Image = My.Resources.eye
			Command1.Text = "Eye Open"
		End If
	End Sub



	Private Function RefCheck(strName As String) As Boolean
		Dim query As String
		Dim ds As DataTable
		Dim temp As String

		query = "SELECT * FROM [Label] WHERE [ModelName] ='" & strName & "'"
		ds = ConnectionDatabase.readData(query).Tables(0)
		If ds.Rows.Count > 0 Then
			temp = ds.Rows(0).Item("ModelName")
			Return True
		Else
			Return False
		End If
		Exit Function

ErrorHandler:
		Return False
	End Function

	Public Function RetrieveWOQty(ByRef WO As String) As String
		Dim query As String
		Dim ds As DataTable
		Dim readqty As String

		query = "SELECT * FROM [STN5] WHERE [WONOS]='" & WO & "'"
		ds = ConnectionDatabase.readData(query).Tables(0)
		If ds.Rows.Count > 0 Then
			readqty = ds.Rows(0).Item("OUTPUT")
			Return readqty
		End If
		Return ""
	End Function

	Public Sub UpdateStnStatus()
		Dim Filenum1 As Integer

		Filenum1 = FreeFile()
		FileOpen(Filenum1, INISTATUSPATH, OpenMode.Output)
		PrintLine(Filenum1, LoadWOfrRFID.JobNos & "," & LoadWOfrRFID.JobModelName & "," & LoadWOfrRFID.JobQTy & "," & LoadWOfrRFID.JobRFIDTag & "," & LoadWOfrRFID.JobUnitaryCount)
		FileClose(Filenum1)
	End Sub

	Private Sub Barcode_Comm_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles Barcode_Comm.DataReceived
		Dim CheckWO As String
		Dim fullPath As String = System.AppDomain.CurrentDomain.BaseDirectory
		Dim projectFolder As String = fullPath.Replace("XCS-15\bin\Debug\", "")
		AssyBuf = Barcode_Comm.ReadExisting()
		If InStr(1, AssyBuf, vbCrLf) <> 0 Then
			Me.Invoke(Sub()
						  Txt_Msg.BackColor = Color.FromArgb(224, 224, 224)
						  Txt_Msg.Text = ""
						  AssyBuf = Mid(AssyBuf, 1, InStr(1, AssyBuf, vbCr) - 1)
						  If Microsoft.VisualBasic.Right(AssyBuf, 3) <> "X13" Then
							  MsgBox("Tolong Yaa, Scan label yang ada pada bagian depan / skematik", MsgBoxStyle.Critical)
							  AssyBuf = ""
							  Exit Sub
						  End If
						  AssyBuf = Mid(AssyBuf, 1, Len(AssyBuf) - 3)

						  Image2.Image = Nothing

						  If lbl_WOnos.Text <> "MASTER" Then
							  CheckWO = ValidiateWONos((lbl_WOnos.Text))
							  If CheckWO = "NOK" Then
								  Txt_Msg.Text = "Invalid WO - WO is not registered in Server"
								  lbl_msg.Text = "PLEASE ASK FOR TECHNICAL ASSISTANCE"
								  AssyBuf = ""
								  Exit Sub
							  End If
							  If CheckWO <> "DISTRUP" Then
								  'If Command1.Caption = "Eye Open" Then
								  '    If Val(lbl_unitaryCount.Caption) >= (lbl_wocounter.Caption) Then
								  '        Txt_Msg.Text = "WO Quantity Reached - WO Completed"
								  '        lbl_msg.Caption = "STOP PROCESS"
								  '       AssyBuf = ""
								  '        Exit Sub
								  '    End If
								  'End If
							  Else
								  Txt_Msg.Text = "WO Distrupted"
								  lbl_msg.Text = "PLEASE CHANGE SERIES"
								  AssyBuf = ""
								  Exit Sub
							  End If
						  Else 'If MASTER TAG in use
							  'If Val(lbl_unitaryCount.Caption) >= Val(lbl_wocounter.Caption) Then
							  '    Txt_Msg.Text = "Quantity reached. WO Completed"
							  '    lbl_msg.Caption = "STOP PROCESS"
							  '    AssyBuf = ""
							  '    Exit Sub
							  'End If
						  End If


						  If Microsoft.VisualBasic.Left(AssyBuf, 6) <> LoadWOfrRFID.JobArticle Then
							  Txt_Msg.Text = "--> PSN - " & AssyBuf & " = wrong reference"
							  Image2.Image = System.Drawing.Image.FromFile(projectFolder & "\Icons\FAIL.Emf")
							  AssyBuf = ""
							  Exit Sub
						  Else
							  Txt_Msg.Text = "PSN - " & AssyBuf & vbCrLf
							  PSNFileInfo.PSN = AssyBuf
							  Txt_Msg.Text = Txt_Msg.Text & "PSN Verified" & vbCrLf
						  End If
						  'GoTo skip
						  Txt_Msg.Text = Txt_Msg.Text & "Loading" & AssyBuf & ".Txt..." & vbCrLf

						  'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
						  If Dir(INIPSNFOLDERPATH & AssyBuf & ".Txt") = "" Then
							  Txt_Msg.Text = Txt_Msg.Text & "--> Unable to find" & AssyBuf & ".Txt" & vbCrLf
							  Image2.Image = System.Drawing.Image.FromFile(projectFolder & "\Icons\FAIL.Emf")
							  AssyBuf = ""
							  Exit Sub
						  End If

						  If Not LOADPSNFILE(AssyBuf) Then
							  Txt_Msg.Text = Txt_Msg.Text & "--> Unable to load" & AssyBuf & ".Txt" & vbCrLf
							  Image2.Image = System.Drawing.Image.FromFile(projectFolder & "\Icons\FAIL.Emf")
							  AssyBuf = ""
							  Exit Sub
						  End If
						  PSNFileInfo.Stn5CheckIn = Today & "," & TimeOfDay
						  Txt_Msg.Text = Txt_Msg.Text & "Verifying PSN..." & vbCrLf
						  If PSNFileInfo.FTStatus <> "PASS" Then
							  Image2.Image = System.Drawing.Image.FromFile(projectFolder & "\Icons\FAIL.Emf")
							  Txt_Msg.Text = "--> PSN skip process" & vbCrLf
							  lbl_msg.Text = "PLEASE GO BACK TO PREVIOUS STATION" & vbCrLf
							  AssyBuf = ""
							  Exit Sub
						  Else
skip: 'If PSNFileInfo.Stn5Status <> "PASS" Then 'Never Print before
							  If LabelVar.UnitLabelTemplate <> "" Then 'If no define template, skip print unitary
								  If Not OpenDocument(INITEMPLATEPATH & LabelVar.UnitLabelTemplate) Then
									  Txt_Msg.Text = "--> Unable to open label template" & vbCrLf
									  Image2.Image = System.Drawing.Image.FromFile(projectFolder & "\Icons\FAIL.Emf")
									  AssyBuf = ""
									  Exit Sub
								  End If
								  Txt_Msg.Text = "Setting Printer..."
								  If Not SetPrinter("Zebra 110XiIII Plus (300 dpi)", "USB001") Then
									  'If Not PrinterSelect("Zebra 110XiIII Plus (600 dpi)", "LPT1:") Then
									  Txt_Msg.Text = "--> Unable to select Printer" & vbCrLf
									  Image2.Image = System.Drawing.Image.FromFile(projectFolder & "\Icons\FAIL.Emf")
									  AssyBuf = ""
									  Exit Sub
								  End If


								  If PSNFileInfo.Stn5Status <> "PASS" Then
									  Txt_Msg.Text = "Printing label..."
									  PrintLabel()
									  lbl_unitaryCount.Text = CStr(Val(lbl_unitaryCount.Text) + 1)
									  LoadWOfrRFID.JobUnitaryCount = Val(lbl_unitaryCount.Text)
									  UpdateStnStatus()
								  Else
									  Txt_Msg.Text = "Repeat label Print - No Printing"
								  End If
								  CloseDocument()
								  Txt_Msg.Text = ""
								  PSNFileInfo.Stn5Status = "PASS"
								  PSNFileInfo.Stn5CheckOut = Today & "," & TimeOfDay
								  If Not WRITEPSNFILE(PSNFileInfo.PSN) Then
									  Txt_Msg.Text = Txt_Msg.Text & "--> Unable to write " & PSNFileInfo.PSN & ".Txt in the server" & vbCrLf
									  Image2.Image = System.Drawing.Image.FromFile(projectFolder & "\Icons\FAIL.Emf")
									  AssyBuf = ""
									  Exit Sub
								  End If
								  Image2.Image = System.Drawing.Image.FromFile(projectFolder & "\Icons\PASS.Emf")

								  If Val(lbl_unitaryCount.Text) >= Val(lbl_wocounter.Text) Then
									  Txt_Msg.Text = "WO Quantity reached - WO Completed"
									  lbl_msg.Text = "STOP PROCESS"
								  End If
							  End If
							  'Else 'Printed Before
							  '    Txt_Msg.Text = "PSN - Already printed before"
							  '    Image2.Picture = LoadPicture(App.Path & "\Icons\PASS.Emf")
							  'End If
						  End If

						  AssyBuf = ""
					  End Sub)
		End If
	End Sub
End Class
