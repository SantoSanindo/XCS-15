
Module modGeneral

	Public Function AddWO(ByRef WO As String) As Boolean
		Dim query As String
		Dim dbNull As String = ""
		query = "INSERT INTO [STN5] ([WONOS],[OUTPUT]) VALUES (ISNULL('" & WO & "','" & dbNull & "'),ISNULL('" & WO & "','" & dbNull & "'))"
		If ConnectionDatabase.insertData(query) Then
			MsgBox("SUCCESS ADD WO")
			Return True
		Else
			MsgBox("FAILED ADD WO")
			Return False
		End If
	End Function

	Public Function CheckWOExist(ByRef WO As String) As Boolean
		Dim query As String
		Dim ds As DataTable
		Dim temp As String

		On Error GoTo ErrorHandler
		query = "SELECT * FROM [STN5] WHERE [WONOS] = '" & WO & "'"
		ds = ConnectionDatabase.readData(query).Tables(0)
		If ds.Rows.Count > 0 Then
			temp = ds.Rows(0).Item("WONOS")
		End If
		Return True
		Exit Function

ErrorHandler:
		Return False
	End Function

	Public Function UpdateWO(ByRef WO As String, ByRef updateqty As String) As Boolean
		Dim query As String
		Dim ds As DataTable

		query = "UPDATE * FROM [STN5] SET [WONOS] ='" & WO & "', [OUTPUT] = '" & updateqty & "' WHERE [WONOS] = '" & WO & "'"
		If ConnectionDatabase.updateData(query) Then
			MsgBox("SUCCESS UPDATE WO")
			Return True
		Else
			MsgBox("FAILED UPDATE WO")
			Return False
		End If
		Exit Function

ErrHandler:
		Return False
	End Function

	Public Function Model2Article(ByRef csmodel As String) As String
		Dim Ref As String
		Dim query As String
		Dim ds As DataTable
		On Error GoTo ErrorHandler

		query = "SELECT * FROM [Parameter] WHERE [ModelName] = '" & csmodel & "'"
		ds = ConnectionDatabase.readData(query).Tables(0)
		Ref = ds.Rows(0).Item("ArticleNOS")
		Debug.WriteLine(Ref)
		Return Ref
		Exit Function

ErrorHandler:
	End Function

	Public Sub GetLastConfig()
		Dim Filenum As Short
		Filenum = FreeFile()
		Dim tempcode As String
		Dim pos3, pos1, pos2, pos4 As Object
		Dim pos5 As Short

		FileOpen(Filenum, INISTATUSPATH, OpenMode.Input)
		tempcode = LineInput(Filenum)
		FileClose(Filenum)
		pos1 = InStr(1, tempcode, ",")
		pos2 = InStr(pos1 + 1, tempcode, ",")
		pos3 = InStr(pos2 + 1, tempcode, ",")
		pos4 = InStr(pos3 + 1, tempcode, ",")
		LoadWOfrRFID.JobNos = Mid(tempcode, 1, pos1 - 1)
		LoadWOfrRFID.JobModelName = Mid(tempcode, pos1 + 1, (pos2 - pos1) - 1)
		LoadWOfrRFID.JobQTy = CShort(Mid(tempcode, pos2 + 1, (pos3 - pos2) - 1))
		LoadWOfrRFID.JobArticle = Model2Article(LoadWOfrRFID.JobModelName)
		LoadWOfrRFID.JobRFIDTag = Mid(tempcode, pos3 + 1, (pos4 - pos3) - 1)
		LoadWOfrRFID.JobUnitaryCount = CShort(Mid(tempcode, pos4 + 1))
	End Sub

	Public Sub PutLastConfig()
		Dim TotalGrpCount As Object
		Dim Filenum As Integer
		Dim fullPath As String = System.AppDomain.CurrentDomain.BaseDirectory
		Dim projectFolder As String = fullPath.Replace("XCS-15\bin\Debug\", "")
		Filenum = FreeFile()

		FileOpen(Filenum, projectFolder & "\Setup\Setup.INI", OpenMode.Output)
		'UPGRADE_WARNING: Couldn't resolve default property of object TotalGrpCount. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		PrintLine(Filenum, LoadWOfrRFID.JobNos & "," & LoadWOfrRFID.JobModelName & "," & LoadWOfrRFID.JobQTy & "," & LoadWOfrRFID.JobUnitaryCount & "," & TotalGrpCount & "," & LoadWOfrRFID.JobRFIDTag)
		FileClose(Filenum)
	End Sub
End Module