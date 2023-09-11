Option Strict Off
Option Explicit On
Module modReadWrite

	Public INICSINFOPATH As String 'Path to WOEntry.Mdb
	Public INIDATABASEPATH As String 'Path to local Model.mdb
	Public INIUSERPATH As String 'Path to local User.mdb
	Public INISERVERPATH As String 'PATH TO SERVER DIR - to access Serial.mdb & Signal.Txt
	Public INISTATUSPATH As String 'PATH TO SERVER\FRIDGE
	Public INITEMPLATEPATH As String 'PATH TO LABEL Template
	Public INIPHOTOPATH As String 'PATH TO THE PHOTO FOR THE LABEL TEMPLATE
	Public INIPSNFOLDERPATH As String 'Path to the PSN.Txt
	Public INITEMPPATH As String
	Public INIMATERIALPATH As String
	Public INISLIDEPATH As String

	Public INIHISPATH As String
	Public INIMPCode As String
	Public INIHISDBNAME As String
	Public INIACHIEVEPATH As String 'Path to achieve folder

	Public INIPRINTPATH As String 'PATH TO PRINT.TXT
	Public INITMPSERIALPATH As String 'PATH TO LOCAL TEMP SERIAL.TXT
	Public INIREPRINTPATH As String

	Dim FNum As Short
	Dim LineStr As String

	'Read settings from INI file
	Public Sub ReadINI(ByRef Filename As String)
		Dim ItemStr As String
		Dim SectionHeading As String
		Dim pos As Short

		FNum = FreeFile()
		'If Dir(App.Path & "\Config.ini") = "" Then
		'    SetDefaultINIValues
		'    WriteINI
		'End If

		FileOpen(FNum, Filename, OpenMode.Input)

		Do While Not EOF(FNum)

			LineStr = LineInput(FNum)

			'Check for Section heading
			If Left(LineStr, 1) = "[" Then
				SectionHeading = Mid(LineStr, 2, Len(LineStr) - 2)
			Else
				If InStr(LineStr, "=") > 0 Then
					pos = InStr(LineStr, "=")
					ItemStr = Left(LineStr, pos - 1)

					Select Case UCase(SectionHeading)

						Case "LABEL PHOTO PATH" 'Shared FILE
							Select Case UCase(ItemStr)
								Case "PATH" : INIPHOTOPATH = Mid(LineStr, pos + 1)
							End Select

						Case "LABEL TEMPLATE PATH" 'Shared FILE
							Select Case UCase(ItemStr)
								Case "PATH" : INITEMPLATEPATH = Mid(LineStr, pos + 1)
							End Select

						Case "PSN FOLDER PATH" 'Share FILE
							Select Case UCase(ItemStr)
								Case "PATH" : INIPSNFOLDERPATH = Mid(LineStr, pos + 1)
							End Select

						Case "MATERIAL PATH" 'RACK MATERIAL LIST
							Select Case UCase(ItemStr)
								Case "PATH" : INIMATERIALPATH = Mid(LineStr, pos + 1)
							End Select

						Case "ACHIEVE PATH"
							Select Case UCase(ItemStr)
								Case "PATH" : INIACHIEVEPATH = Mid(LineStr, pos + 1)
							End Select

						Case "TEMP PATH" 'LOCAL DIR
							Select Case UCase(ItemStr)
								Case "PATH" : INITEMPPATH = Mid(LineStr, pos + 1)
							End Select

						Case "SERVER PATH"
							Select Case UCase(ItemStr)
								Case "PATH" : INISERVERPATH = Mid(LineStr, pos + 1)
							End Select

						Case "CSUNIT PATH"
							Select Case UCase(ItemStr)
								Case "PATH" : INICSINFOPATH = Mid(LineStr, pos + 1)
							End Select

						Case "STATUS PATH"
							Select Case UCase(ItemStr)
								Case "PATH" : INISTATUSPATH = Mid(LineStr, pos + 1)
							End Select

						Case "PRINT PATH" 'LOCAL FILE
							Select Case UCase(ItemStr)
								Case "PATH" : INIPRINTPATH = Mid(LineStr, pos + 1)
							End Select

						Case "TEMPSERIAL PATH" 'LOCAL DIR
							Select Case UCase(ItemStr)
								Case "PATH" : INITMPSERIALPATH = Mid(LineStr, pos + 1)
							End Select

						Case "USER PATH" 'LOCAL FILE
							Select Case UCase(ItemStr)
								Case "PATH" : INIUSERPATH = Mid(LineStr, pos + 1)
							End Select

							'Case "DATABASE BACKUP INFORMATION"
							'    Select Case UCase(ItemStr)
							'        Case "BACKUP DESTINATION PATH": INIBackUpPath = Mid$(LineStr, pos + 1)
							'        Case "LAST BACKUP DATE": INIBackUpDate = Mid$(LineStr, pos + 1)
							'        Case "LAST BACKUP TIME": INIBackUpTime = Mid$(LineStr, pos + 1)
							'    End Select

							'Case "COMPACT DATABASE INFORMATION"
							'    Select Case UCase(ItemStr)
							'        Case "LAST COMPACT DATE": INICompactDate = Mid$(LineStr, pos + 1)
							'    End Select

							'Case "NAME PLATE LABEL" 'LOCAL DIR
							'    Select Case UCase(ItemStr)
							'        Case "LABEL PATH": INICSPATH = Mid$(LineStr, pos + 1)
							'    End Select

						Case "HISTORY DATABASE"
							Select Case UCase(ItemStr)
								Case "PATH" : INIHISPATH = Mid(LineStr, pos + 1)
								Case "NAME" : INIHISDBNAME = Mid(LineStr, pos + 1)
							End Select

						Case "MANUFACTURING PLANT CODE"
							Select Case UCase(ItemStr)
								Case "CODE" : INIMPCode = Mid(LineStr, pos + 1)
							End Select
					End Select
				End If
			End If
		Loop

		FileClose(FNum)
	End Sub

	'Write data to PSN file
	Public Function WRITEPSNFILE(ByRef ProductPSN As String) As Boolean
		On Error GoTo ErrorHandler
		FNum = FreeFile()
		FileOpen(FNum, INIPSNFOLDERPATH & ProductPSN & ".Txt", OpenMode.Output)

		PrintLine(FNum)
		PrintLine(FNum, "[MODEL] : " & PSNFileInfo.ModelName)
		PrintLine(FNum)
		PrintLine(FNum, "[DATE CREATED] : " & PSNFileInfo.DateCreated)
		PrintLine(FNum)
		PrintLine(FNum, "[DATE COMPLETED] : " & PSNFileInfo.DateCompleted)
		PrintLine(FNum)
		PrintLine(FNum, "[OPERATOR ID] : " & PSNFileInfo.OperatorID)
		PrintLine(FNum)
		PrintLine(FNum, "[WORK ORDER NO] : " & PSNFileInfo.WONos)
		PrintLine(FNum)
		PrintLine(FNum, "[MAIN PCBA S/N] : " & PSNFileInfo.MainPCBA)
		PrintLine(FNum)
		PrintLine(FNum, "[SECONDARY PCBA S/N] : " & PSNFileInfo.SecondaryPCBA)
		PrintLine(FNum)
		PrintLine(FNum, "[ELECTROMAGNET S/N] : " & PSNFileInfo.ElectroMagnet)
		PrintLine(FNum)
		PrintLine(FNum, "[PSN] : " & PSNFileInfo.PSN)
		PrintLine(FNum)
		PrintLine(FNum, "[BODY ASSY STATION CHECK IN DATE] : " & PSNFileInfo.BodyAssyCheckIn)
		PrintLine(FNum)
		PrintLine(FNum, "[BODY ASSY STATION CHECK OUT DATE] : " & PSNFileInfo.BodyAssyCheckOut)
		PrintLine(FNum)
		PrintLine(FNum, "[BODY ASSY STATION STATUS] : " & PSNFileInfo.BodyAssyStatus)
		PrintLine(FNum)
		PrintLine(FNum, "[SCREWING STATION CHECK IN DATE] : " & PSNFileInfo.ScrewStnCheckIn)
		PrintLine(FNum)
		PrintLine(FNum, "[SCREWING STATION CHECK OUT DATE] : " & PSNFileInfo.ScrewStnCheckOut)
		PrintLine(FNum)
		PrintLine(FNum, "[SCREWING STATION STATUS] : " & PSNFileInfo.ScrewStnStatus)
		PrintLine(FNum)
		PrintLine(FNum, "[FINAL TEST CHECK IN DATE] : " & PSNFileInfo.FTCheckIn)
		PrintLine(FNum)
		PrintLine(FNum, "[FINAL TEST CHECK OUT DATE] : " & PSNFileInfo.FTCheckOut)
		PrintLine(FNum)
		PrintLine(FNum, "[FINAL TEST SYNCH MEASUREMENT] : " & PSNFileInfo.FTSycMeas)
		PrintLine(FNum)
		PrintLine(FNum, "[FINAL TEST STATUS] : " & PSNFileInfo.FTStatus)
		PrintLine(FNum)
		PrintLine(FNum, "[STATION 5 CHECK IN DATE] : " & PSNFileInfo.Stn5CheckIn)
		PrintLine(FNum)
		PrintLine(FNum, "[STATION 5 CHECK OUT DATE] : " & PSNFileInfo.Stn5CheckOut)
		PrintLine(FNum)
		PrintLine(FNum, "[STATION 5 STATUS] : " & PSNFileInfo.Stn5Status)
		PrintLine(FNum)
		PrintLine(FNum, "[VACUUM CHECK IN DATE] : " & PSNFileInfo.VacuumCheckIn)
		PrintLine(FNum)
		PrintLine(FNum, "[VACUUM CHECK OUT DATE] : " & PSNFileInfo.VacummCheckOut)
		PrintLine(FNum)
		PrintLine(FNum, "[CONNECTOR TEST CHECK IN DATE] : " & PSNFileInfo.ConnTestCheckIn)
		PrintLine(FNum)
		PrintLine(FNum, "[CONNECTOR TEST CHECK OUT DATE] : " & PSNFileInfo.ConnTestCheckOut)
		PrintLine(FNum)
		PrintLine(FNum, "[CONNECTOR TEST STATUS] : " & PSNFileInfo.ConnTestStatus)
		PrintLine(FNum)
		PrintLine(FNum, "[VACUUM #2 CHECK IN DATE] : " & PSNFileInfo.Vacuum2CheckIn)
		PrintLine(FNum)
		PrintLine(FNum, "[VACUUM #2 CHECK OUT DATE] : " & PSNFileInfo.Vacumm2CheckOut)
		PrintLine(FNum)
		PrintLine(FNum, "[VACUUM #2 STATUS] : " & PSNFileInfo.Vacuum2Status)
		PrintLine(FNum)
		PrintLine(FNum, "[VACUUM STATUS] : " & PSNFileInfo.VacuumStatus)
		PrintLine(FNum)
		PrintLine(FNum, "[PACKAGING CHECK IN DATE] : " & PSNFileInfo.PackagingCheckIn)
		PrintLine(FNum)
		PrintLine(FNum, "[PACKAGING CHECK OUT DATE] : " & PSNFileInfo.PackagingCheckOut)
		PrintLine(FNum)
		PrintLine(FNum, "[PACKAGING STATUS] : " & PSNFileInfo.PackagingStatus)
		PrintLine(FNum)
		PrintLine(FNum, "[DEBUG STATION #10 STATUS] : " & PSNFileInfo.DebugStatus)
		PrintLine(FNum)
		PrintLine(FNum, "[DEBUG COMMENTS] : " & PSNFileInfo.DebugComment)
		PrintLine(FNum)
		PrintLine(FNum, "[DEBUG TECHNICIANS ID] : " & PSNFileInfo.DebugTechnican)
		PrintLine(FNum)
		PrintLine(FNum, "[DEBUG DATE REPAIRED] : " & PSNFileInfo.RepairDate)
		FileClose(FNum)
		WRITEPSNFILE = True
		Exit Function

ErrorHandler:
		WRITEPSNFILE = False
	End Function

	Public Function LOADPSNFILE(ByRef ProductPSN As String) As Boolean
		Dim ItemStr As String
		Dim SectionHeading As String
		Dim pos1, pos2 As Object
		Dim pos3 As Short

		FNum = FreeFile()
		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		If Dir(INIPSNFOLDERPATH & ProductPSN & ".Txt") = "" Then
			'SetDefaultINIValues
			'WriteINI
			Return False
			Exit Function
		End If

		FileOpen(FNum, INIPSNFOLDERPATH & ProductPSN & ".Txt", OpenMode.Input)

		Do While Not EOF(FNum)

			LineStr = LineInput(FNum)

			'Check for Section heading
			If InStr(LineStr, "[") > 0 And InStr(LineStr, "]") > 0 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object pos1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				pos1 = InStr(LineStr, "[")
				'UPGRADE_WARNING: Couldn't resolve default property of object pos2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				pos2 = InStr(LineStr, "]")
				pos3 = InStr(LineStr, ":")

				'UPGRADE_WARNING: Couldn't resolve default property of object pos1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object pos2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				SectionHeading = Mid(LineStr, pos1 + 1, pos2 - pos1 - 1)

				Select Case UCase(SectionHeading)
					Case "MODEL"
						PSNFileInfo.ModelName = Trim(Mid(LineStr, pos3 + 1))

					Case "DATE CREATED"
						PSNFileInfo.DateCreated = Trim(Mid(LineStr, pos3 + 1))

					Case "DATE COMPLETED"
						PSNFileInfo.DateCompleted = Trim(Mid(LineStr, pos3 + 1))

					Case "OPERATOR ID"
						PSNFileInfo.OperatorID = Trim(Mid(LineStr, pos3 + 1))

					Case "WORK ORDER NO"
						PSNFileInfo.WONos = Trim(Mid(LineStr, pos3 + 1))

					Case "MAIN PCBA S/N"
						PSNFileInfo.MainPCBA = Trim(Mid(LineStr, pos3 + 1))

					Case "SECONDARY PCBA S/N"
						PSNFileInfo.SecondaryPCBA = Trim(Mid(LineStr, pos3 + 1))

					Case "ELECTROMAGNET S/N"
						PSNFileInfo.ElectroMagnet = Trim(Mid(LineStr, pos3 + 1))

					Case "PSN"
						PSNFileInfo.PSN = Trim(Mid(LineStr, pos3 + 1))

					Case "BODY ASSY STATION CHECK IN DATE"
						PSNFileInfo.BodyAssyCheckIn = Trim(Mid(LineStr, pos3 + 1))

					Case "BODY ASSY STATION CHECK OUT DATE"
						PSNFileInfo.BodyAssyCheckOut = Trim(Mid(LineStr, pos3 + 1))

					Case "BODY ASSY STATION STATUS"
						PSNFileInfo.BodyAssyStatus = Trim(Mid(LineStr, pos3 + 1))

					Case "SCREWING STATION CHECK IN DATE"
						PSNFileInfo.ScrewStnCheckIn = Trim(Mid(LineStr, pos3 + 1))

					Case "SCREWING STATION CHECK OUT DATE"
						PSNFileInfo.ScrewStnCheckOut = Trim(Mid(LineStr, pos3 + 1))

					Case "SCREWING STATION STATUS"
						PSNFileInfo.ScrewStnStatus = Trim(Mid(LineStr, pos3 + 1))

					Case "FINAL TEST CHECK IN DATE"
						PSNFileInfo.FTCheckIn = Trim(Mid(LineStr, pos3 + 1))

					Case "FINAL TEST CHECK OUT DATE"
						PSNFileInfo.FTCheckOut = Trim(Mid(LineStr, pos3 + 1))

					Case "FINAL TEST SYNCH MEASUREMENT"
						PSNFileInfo.FTSycMeas = Trim(Mid(LineStr, pos3 + 1))

					Case "FINAL TEST STATUS"
						PSNFileInfo.FTStatus = Trim(Mid(LineStr, pos3 + 1))

					Case "STATION 5 CHECK IN DATE"
						PSNFileInfo.Stn5CheckIn = Trim(Mid(LineStr, pos3 + 1))

					Case "STATION 5 CHECK OUT DATE"
						PSNFileInfo.Stn5CheckOut = Trim(Mid(LineStr, pos3 + 1))

					Case "STATION 5 STATUS"
						PSNFileInfo.Stn5Status = Trim(Mid(LineStr, pos3 + 1))

					Case "VACUUM CHECK IN DATE"
						PSNFileInfo.VacuumCheckIn = Trim(Mid(LineStr, pos3 + 1))

					Case "VACUUM CHECK OUT DATE"
						PSNFileInfo.VacummCheckOut = Trim(Mid(LineStr, pos3 + 1))

					Case "VACUUM STATUS"
						PSNFileInfo.VacuumStatus = Trim(Mid(LineStr, pos3 + 1))

					Case "CONNECTOR TEST CHECK IN DATE"
						PSNFileInfo.ConnTestCheckIn = Trim(Mid(LineStr, pos3 + 1))

					Case "CONNECTOR TEST CHECK OUT DATE"
						PSNFileInfo.ConnTestCheckOut = Trim(Mid(LineStr, pos3 + 1))

					Case "CONNECTOR TEST STATUS"
						PSNFileInfo.ConnTestStatus = Trim(Mid(LineStr, pos3 + 1))

					Case "VACUUM #2 CHECK IN DATE"
						PSNFileInfo.Vacuum2CheckIn = Trim(Mid(LineStr, pos3 + 1))

					Case "VACUUM #2 CHECK OUT DATE"
						PSNFileInfo.Vacumm2CheckOut = Trim(Mid(LineStr, pos3 + 1))

					Case "VACUUM #2 STATUS"
						PSNFileInfo.Vacuum2Status = Trim(Mid(LineStr, pos3 + 1))

					Case "PACKAGING CHECK IN DATE"
						PSNFileInfo.PackagingCheckIn = Trim(Mid(LineStr, pos3 + 1))

					Case "PACKAGING CHECK OUT DATE"
						PSNFileInfo.PackagingCheckOut = Trim(Mid(LineStr, pos3 + 1))

					Case "PACKAGING STATUS"
						PSNFileInfo.PackagingStatus = Trim(Mid(LineStr, pos3 + 1))

					Case "DEBUG STATION #10 STATUS"
						PSNFileInfo.DebugStatus = Trim(Mid(LineStr, pos3 + 1))

					Case "DEBUG COMMENTS"
						PSNFileInfo.DebugComment = Trim(Mid(LineStr, pos3 + 1))

					Case "DEBUG TECHNICIANS ID"
						PSNFileInfo.DebugTechnican = Trim(Mid(LineStr, pos3 + 1))

					Case "DEBUG DATE REPAIRED"
						PSNFileInfo.RepairDate = Trim(Mid(LineStr, pos3 + 1))

				End Select
			End If
		Loop
		FileClose(FNum)
		Return True
	End Function
End Module