Public Class FrmMaterial
	Dim frameUpdate As Boolean = False
	Dim frameVal As Integer
	Private Sub cmd_back_Click(sender As Object, e As EventArgs) Handles cmd_back.Click
		Me.Dispose()
		frmMain.Show()
	End Sub

	Private Sub FrmMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		LoadParameter()
		frameUpdate = True
		_Option1_1.Checked = True
		Frame2.Visible = True
		Frame1.Visible = False
	End Sub

	Private Sub LoadParameter() 'ISSUE DATABASE MaterialConfig.mdb is MISSING!
		'Dim i As Object
		Dim textControl1, textControl2 As Control
		Dim query As String
		Dim ds As DataTable

		On Error GoTo ErrorHandler
		query = "SELECT * FROM [MATERIAL]"
		ds = ConnectionDatabase.readData(query).Tables(0)
		If ds.Rows.Count > 0 Then
			For i As Integer = 0 To 47
				textControl1 = Me.Controls("_Txt_slot_" & i + 1)
				textControl2 = Me.Controls("_Txt_slot_" & i + 49)
				textControl1.Text = ds.Rows(i).Item("")
				textControl1.Text = ds.Rows(i).Item("")
			Next
		End If

		query = "SELECT * FROM [SLAVEADDR]"
		ds = ConnectionDatabase.readData(query).Tables(0)
		If ds.Rows.Count > 0 Then
			For i As Integer = 0 To 47
				Dim controls As Control
				controls = Me.Controls("_Text1_" & i + 1)
				controls.Text = ds.Rows(i).Item("")
			Next
		End If

		query = "SELECT * FROM [BITNOS]"
		ds = ConnectionDatabase.readData(query).Tables(0)
		If ds.Rows.Count > 0 Then
			For i As Integer = 0 To 47
				Dim controls As Control
				controls = Me.Controls("_Text3_1" & i + 1)
				'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				controls.Text = ds.Rows(i).Item("")
			Next
		End If

		query = "SELECT * FROM RSLAVEADDR"
		ds = ConnectionDatabase.readData(query).Tables(0)
		If ds.Rows.Count > 0 Then
			For i As Integer = 0 To 47
				Dim controls As Control
				controls = Me.Controls("_Text4_" & i + 1)
				'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				controls.Text = ds.Rows(i).Item("")
			Next
		End If

		query = "SELECT * FROM [RBITNOS]"
		ds = ConnectionDatabase.readData(query).Tables(0)
		If ds.Rows.Count > 0 Then
			For i As Integer = 0 To 47
				Dim controls As Control
				controls = Me.Controls("_Text5_" & i + 1)
				'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				controls.Text = ds.Rows(i).Item("")
			Next
		End If
		Exit Sub

ErrorHandler:
		MsgBox("Unable to extract data from the database")
	End Sub

	Private Sub cmd_save_Click(sender As Object, e As EventArgs) Handles cmd_save.Click 'ISSUE DATABASE MATERIALCONFIG.MDB MISSING!
		MsgBox("DATABASE HILANG, MASIH DALAM PENCARIAN~")
	End Sub

	Private Sub _Option1_0_CheckedChanged(sender As Object, e As EventArgs) Handles _Option1_0.CheckedChanged
		frameVal = 1
		frameUpdate = True
		If frameUpdate Then
			If frameVal = 0 Then
				Frame1.Visible = True
				Frame2.Visible = False
			ElseIf frameVal = 1 Then
				Frame1.Visible = False
				Frame2.Visible = True
			End If
			frameUpdate = False
		End If
	End Sub

	Private Sub _Option1_1_CheckedChanged(sender As Object, e As EventArgs) Handles _Option1_1.CheckedChanged
		frameVal = 0
		frameUpdate = True
		If frameUpdate Then
			If frameVal = 0 Then
				Frame1.Visible = True
				Frame2.Visible = False
			ElseIf frameVal = 1 Then
				Frame1.Visible = False
				Frame2.Visible = True
			End If
			frameUpdate = False
		End If
	End Sub
End Class