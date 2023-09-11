Option Strict Off
Option Explicit On
Module Declaration
	'UPGRADE_WARNING: Arrays in structure LoadWOfrRFID may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
	Public LoadWOfrRFID As JobOrder
	'UPGRADE_WARNING: Arrays in structure rprintlabel may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
	Public rprintlabel As JobOrder
	'UPGRADE_WARNING: Arrays in structure Unitmaterial may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
	Public Unitmaterial As RackConfig
	Public UnitaryDateCode As String
	Public LabelVar As LabelData 'Used in the main page
	Public Parameter As ControlSpec
	Public ReprintlabelVar As LabelData 'Used in the reprint page
	Public UnitaryMaterial(60) As String 'Variable holding material info for the selected reference
	Public UnitaryMaterialFlag(60) As Boolean 'Truewhen part had successfully transfer to main bench
	Public Login As Boolean
	Public PSNFileInfo As PSNText

	Public Structure ControlSpec
		Dim UnitTagNos As String
		Dim UnitPartNos As String
		Dim UnitModel As String
		Dim UnitType As String
		Dim UnitFunction As String
		Dim UnitTension As String
		Dim UnitContact1_WO_Trig As String
		Dim UnitContact2_WO_Trig As String
		Dim UnitContact3_WO_Trig As String
		Dim UnitContact4_WO_Trig As String
		Dim UnitContact5_WO_Trig As String
		Dim UnitContact6_WO_Trig As String
		Dim UnitContact_WO_Trig As Long
		Dim UnitContact1_W_Key As String
		Dim UnitContact2_W_Key As String
		Dim UnitContact3_W_Key As String
		Dim UnitContact4_W_Key As String
		Dim UnitContact5_W_Key As String
		Dim UnitContact6_W_Key As String
		Dim UnitContact_W_Key As Long

		Dim UnitContact1_W_Key_Ten As String
		Dim UnitContact2_W_Key_Ten As String
		Dim UnitContact3_W_Key_Ten As String
		Dim UnitContact4_W_Key_Ten As String
		Dim UnitContact5_W_Key_Ten As String
		Dim UnitContact6_W_Key_Ten As String
		Dim UnitContact_W_Key_Ten As Long
		Dim UnitLabelTemplate As String
		Dim UnitLabelPhoto As String
		Dim UnitSycUL As Double
		Dim UnitSycLL As Double
	End Structure

	Structure JobOrder
		Dim JobNos As String
		Dim JobModelName As String
		Dim JobQTy As Short
		Dim JobArticle As String
		Dim JobModelFW As String
		Dim JobModelAssy As String
		Dim JobInternalNos As String
		Dim JobRFIDTag As String
		Dim JobUnitaryCount As Short
		Dim JobModelMaterial() As String
		Dim JobProductMaterial As String 'Zamak or Plastic
		Dim JobProductThread As String
		Dim JobButtonType As String 'With PushButton?

		'UPGRADE_TODO: "Initialize" must be called to initialize instances of this structure. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B4BFF9E0-8631-45CF-910E-62AB3970F27B"'
		Public Sub Initialize()
			ReDim JobModelMaterial(45)
		End Sub
	End Structure

	Structure RackConfig
		Dim PartPLCWord As Integer()
		Dim PartNos As String()

		Public Sub Init()
			ReDim PartPLCWord(45)
			ReDim PartNos(45)
		End Sub
	End Structure

	Structure LabelData
		Dim UnitModelName As String
		Dim UnitRefLogistique As String
		Dim UnitArticleNos As String
		Dim UnitDetail1 As String 'String
		Dim UnitDetail2 As String
		Dim UnitDetail3 As String
		Dim UnitDetail4 As String
		Dim UnitDetail5 As String
		Dim UnitDetail6 As String
		Dim UnitDetail7 As String
		Dim UnitDetail8 As String
		Dim UnitDetail9 As String
		Dim UnitDetail10 As String
		Dim UnitImage As String
		Dim UnitLabelTemplate As String
		Dim UnitLabelSymb1 As String
		Dim UnitLabelSymb2 As String
		Dim UnitLabelTor As String
	End Structure

	Structure PSNText
		Dim ModelName As String
		Dim DateCreated As String
		Dim DateCompleted As String
		Dim OperatorID As String
		Dim WONos As String
		Dim MainPCBA As String
		Dim SecondaryPCBA As String
		Dim ElectroMagnet As String
		Dim PSN As String
		Dim BodyAssyCheckIn As String
		Dim BodyAssyCheckOut As String
		Dim BodyAssyStatus As String
		Dim ScrewStnCheckIn As String
		Dim ScrewStnCheckOut As String
		Dim ScrewStnStatus As String
		Dim FTCheckIn As String
		Dim FTCheckOut As String
		Dim FTSycMeas As String
		Dim FTStatus As String
		Dim Stn5CheckIn As String
		Dim Stn5CheckOut As String
		Dim Stn5Status As String
		Dim VacuumCheckIn As String
		Dim VacummCheckOut As String
		Dim VacuumStatus As String
		Dim ConnTestCheckIn As String
		Dim ConnTestCheckOut As String
		Dim ConnTestStatus As String
		Dim Vacuum2CheckIn As String
		Dim Vacumm2CheckOut As String
		Dim Vacuum2Status As String
		Dim PackagingCheckIn As String
		Dim PackagingCheckOut As String
		Dim PackagingStatus As String
		Dim DebugStatus As String
		Dim DebugComment As String
		Dim DebugTechnican As String
		Dim RepairDate As String
	End Structure
End Module