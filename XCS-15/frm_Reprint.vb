Public Class frm_Reprint
    Dim reprintBuf As String
    Private Sub frm_Reprint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MSComm1.Open() 'MARK
    End Sub

    Private Sub cmdback_Click(sender As Object, e As EventArgs) Handles cmdback.Click
        MSComm1.Close()
        frmMain.Barcode_Comm.Open() 'MARK
        Me.Dispose()
        frmMain.Show()
    End Sub

	Private Sub MSComm1_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles MSComm1.DataReceived
		reprintBuf = MSComm1.ReadExisting()
		If InStr(1, reprintBuf, vbCrLf) <> 0 Then
            Me.Invoke(Sub()
                          reprintBuf = Mid(reprintBuf, 1, InStr(1, reprintBuf, vbCr) - 1)
                          If Microsoft.VisualBasic.Left(reprintBuf, 3) <> "X13" Then
                              MsgBox("Tolong Yaa, Scan label pada bagian depan / label skematik", MsgBoxStyle.Critical)
                              reprintBuf = ""
                              Exit Sub
                          End If
                          reprintBuf = Mid(reprintBuf, 1, Len(reprintBuf) - 3)

                          Text2.Text = reprintBuf
                          If Dir(INIPSNFOLDERPATH & reprintBuf & ".Txt") = "" Then
                              If Dir(INIACHIEVEPATH & reprintBuf & ".Txt") = "" Then
                                  Label1.Text = "--> Unable to find" & reprintBuf & ".Txt" & vbCrLf
                                  reprintBuf = ""
                                  Exit Sub
                              End If
                          End If
                          rprintlabel.JobArticle = Microsoft.VisualBasic.Left(reprintBuf, 6)
                          rprintlabel.JobModelName = Article2Model(rprintlabel.JobArticle)
                          ReprintlabelVar = LoadLabelParameter(rprintlabel.JobModelName)


                          'If Left(reprintBuf, 6) <> LoadWOfrRFID.JobArticle Then
                          '    Label1.Caption = "--> Incorrect reference" & vbCrLf
                          '    'Image2.Picture = LoadPicture(App.Path & "\Icons\FAIL.Emf")
                          '    reprintBuf = ""
                          '    Exit Sub
                          'End If

                          '   If Not OpenLab(INITEMPLATEPATH & ReprintlabelVar.UnitLabelTemplate) Then
                          '       Label1.Caption = "--> Unable to open label template" & vbCrLf
                          '        reprintBuf = ""
                          '        Exit Sub
                          '      End If

                          '      If Not SetPrinters("Zebra 110XiIII Plus (600 dpi),USB001") Then
                          'If Not PrinterSelect("Zebra 110XiIII Plus (600 dpi)", "LPT1:") Then
                          '          Label1.Caption = "--> Unable to select Printer" & vbCrLf
                          '         reprintBuf = ""
                          '         Exit Sub
                          '    End If
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
                              Exit Sub '
                          End If


                          ActiveDoc.Variables.FormVariables.Item("Var14").Value = ReprintlabelVar.UnitImage 'INIPHOTOPATH & ReprintlabelVar.UnitImage
                          ActiveDoc.Variables.FormVariables.Item("Var10").Value = reprintBuf
                          ActiveDoc.Variables.FormVariables.Item("Var8").Value = "20" & Mid(reprintBuf, 10, 2)
                          ActiveDoc.Variables.FormVariables.Item("Var9").Value = Mid(reprintBuf, 12, 2)

                          If PrintLab(1) = False Then 'necessary for printing
                              MsgBox("Error", MsgBoxStyle.Critical)
                          End If
                          CloseDocument()
                          reprintBuf = ""
                      End Sub)
        End If
	End Sub

	Public Function Article2Model(ByRef ArtNos As String) As String
		Dim Ref As String
		Dim query As String
		Dim ds As DataTable
		On Error GoTo ErrorHandler
		query = "SELECT * FROM [Parameter] WHERE [ArticleNOS] = '" & ArtNos & "'"
		ds = ConnectionDatabase.readData(query).Tables(0)
		If ds.Rows.Count > 0 Then
			Ref = ds.Rows(0).Item("MODELNAME")
		Else
			Ref = ""
		End If
		Return Ref
		Exit Function

ErrorHandler:
	End Function

	Private Function LoadLabelParameter(ByRef csmodel As String) As LabelData
		Dim query As String
		Dim ds As DataTable
		On Error Resume Next

		query = "SELECT * FROM [Label] WHERE [ModelName] = '" & csmodel & "'"
		ds = ConnectionDatabase.readData(query).Tables(0)
		'Set RSGRP = DBLABEL.OpenRecordset("Select * FROM GROUPING WHERE MODELNAME = '" & csmodel & "'", dbOpenDynaset)
		If ds.Rows.Count > 0 Then
			With LoadLabelParameter
				.UnitModelName = "" & ds.Rows(0).Item("Product_Reference")
				.UnitArticleNos = "" & ds.Rows(0).Item("ArticleNos")
				.UnitImage = "" & ds.Rows(0).Item("Product_Img")
				.UnitLabelTemplate = "" & ds.Rows(0).Item("Product_Template")
				.UnitLabelSymb1 = "" & ds.Rows(0).Item("Product_Symbol1")
				.UnitLabelSymb2 = "" & ds.Rows(0).Item("Product_Symbol2")
				.UnitLabelTor = "" & ds.Rows(0).Item("Product_Torque")
			End With
		End If

		Exit Function

ErrHandler:
	End Function
End Class