Public Class frm_labelspec
	Private Sub frm_labelspec_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		LOADREFERENCE()
	End Sub

	Private Sub LOADREFERENCE()
		Dim query As String
		Dim ds As DataTable
		query = "SELECT * FROM [Label]"
		ds = ConnectionDatabase.readData(query).Tables(0)
		If ds.Rows.Count > 0 Then
			For index As Integer = 0 To ds.Rows.Count - 1
				Cmbo_Select.Items.Add(ds.Rows(index).Item("ModelName"))
			Next
		End If
	End Sub

	Private Sub Cmd_Back_Click(sender As Object, e As EventArgs) Handles Cmd_Back.Click
		Me.Dispose()
		frmMain.Show()
	End Sub

	Private Sub Cmbo_Select_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmbo_Select.SelectedIndexChanged
		Dim query As String
		Dim ds As DataTable

		On Error Resume Next
		If Cmbo_Select.Text = "" Then Exit Sub
		CLEARDATA()
		query = "SELECT * FROM [Label] WHERE [ModelName] = '" & Cmbo_Select.Text & "'"
		ds = ConnectionDatabase.readData(query).Tables(0)
		If ds.Rows.Count > 0 Then

			_lbl_Detail_1.Text = ds.Rows(0).Item("Product_Detail1")
			_lbl_Detail_2.Text = ds.Rows(0).Item("Product_Detail2")
			_lbl_Detail_3.Text = ds.Rows(0).Item("Product_Detail3")
			_lbl_Detail_4.Text = ds.Rows(0).Item("Product_Detail4")
			_lbl_Detail_5.Text = ds.Rows(0).Item("Product_Detail5")
			_lbl_Detail_6.Text = ds.Rows(0).Item("Product_Detail6")
			_lbl_Detail_7.Text = ds.Rows(0).Item("Product_Detail7")
			_lbl_Detail_8.Text = ds.Rows(0).Item("Product_Detail8")
			_lbl_Detail_9.Text = ds.Rows(0).Item("Product_Torque")
			_lbl_Detail_1.Text = ds.Rows(0).Item("Product_Detail10")
			_Text1_1.Text = ds.Rows(0).Item("ArticleNos")
			_Text1_8.Text = ds.Rows(0).Item("Product_Template")
			_Text1_5.Text = ds.Rows(0).Item("Product_Reference")
			_lbl_Detail_0.Text = ds.Rows(0).Item("Product_Reference")
		End If
	End Sub

	Private Sub CLEARDATA()
		_Text1_1.Text = ""
		_Text1_5.Text = ""
		Combo1.Text = ""
	End Sub

	Private Sub Combo1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo1.SelectedIndexChanged

	End Sub
End Class