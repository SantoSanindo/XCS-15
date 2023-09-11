Public Class frmDatabase
	Private Sub frmDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		LoadRefCombo()
		For i As Integer = 0 To 47
			Dim controls() As ComboBox = {_Combo1_0, _Combo1_1, _Combo1_2, _Combo1_3, _Combo1_4, _Combo1_5, _Combo1_6, _Combo1_7, _Combo1_8, _Combo1_9, _Combo1_10, _Combo1_11, _Combo1_12, _Combo1_13, _Combo1_14, _Combo1_15, _Combo1_16, _Combo1_17, _Combo1_18, _Combo1_19, _Combo1_20, _Combo1_21, _Combo1_22, _Combo1_23, _Combo1_24, _Combo1_25, _Combo1_26, _Combo1_27, _Combo1_28, _Combo1_29, _Combo1_30, _Combo1_31, _Combo1_32, _Combo1_33, _Combo1_34, _Combo1_35, _Combo1_36, _Combo1_37, _Combo1_38, _Combo1_39, _Combo1_40, _Combo1_41, _Combo1_42, _Combo1_43, _Combo1_44, _Combo1_45, _Combo1_46, _Combo1_47}
			controls(i).Items.Add("0")
			controls(i).Items.Add("1")
		Next
	End Sub

	Private Sub cmdback_Click(sender As Object, e As EventArgs) Handles cmdback.Click
		Me.Dispose()
		frmMain.Show()
	End Sub

	Private Sub LoadRefCombo() 'ISSUE DATABASE MATERIALCONFIG.MDB IS MISSING
		Dim query As String
		Dim ds As DataTable
		'query = "SELECT * FROM [LOCATION]"
		'ds = ConnectionDatabase.readData(query).Tables(0)
		'If ds.Rows().Count > 0 Then
		'	For index As Integer = 0 To ds.Rows.Count - 1
		'		Combo2.Items.Add(ds.Rows(index).Item("MODELNAME"))
		'	Next
		'End If

		'query = "SELECT * FROM [MATERIAL]"
		'ds = ConnectionDatabase.readData(query).Tables(0)
		'If ds.Rows().Count > 0 Then
		'	For index As Integer = 0 To 47
		'		Dim controls As Control
		'		controls = Me.Controls("_Text1_" & index)
		'		controls.Text = ds.Rows(index).Item("")
		'	Next
		'	_Text2_1.Text = ds.Rows(50).Item("")
		'	_Text2_2.Text = ds.Rows(51).Item("")
		'	_Text2_3.Text = ds.Rows(52).Item("")
		'	_Text2_4.Text = ds.Rows(53).Item("")
		'	_Text2_5.Text = ds.Rows(54).Item("")
		'	_Text2_6.Text = ds.Rows(55).Item("")
		'	_Text2_7.Text = ds.Rows(56).Item("")
		'	_Text2_8.Text = ds.Rows(57).Item("")
		'End If
	End Sub

	Private Sub cmdclear_Click(sender As Object, e As EventArgs) Handles cmdclear.Click
		Combo2.Text = ""
		For i As Integer = 0 To 47
			Dim controls() As ComboBox = {_Combo1_0, _Combo1_1, _Combo1_2, _Combo1_3, _Combo1_4, _Combo1_5, _Combo1_6, _Combo1_7, _Combo1_8, _Combo1_9, _Combo1_10, _Combo1_11, _Combo1_12, _Combo1_13, _Combo1_14, _Combo1_15, _Combo1_16, _Combo1_17, _Combo1_18, _Combo1_19, _Combo1_20, _Combo1_21, _Combo1_22, _Combo1_23, _Combo1_24, _Combo1_25, _Combo1_26, _Combo1_27, _Combo1_28, _Combo1_29, _Combo1_30, _Combo1_31, _Combo1_32, _Combo1_33, _Combo1_34, _Combo1_35, _Combo1_36, _Combo1_37, _Combo1_38, _Combo1_39, _Combo1_40, _Combo1_41, _Combo1_42, _Combo1_43, _Combo1_44, _Combo1_45, _Combo1_46, _Combo1_47}
			Dim controls2 As Control
			controls2 = Me.Controls("_Text1_" & i)
			controls(i).Text = "0"
			controls2.Text = ""
		Next
	End Sub
End Class