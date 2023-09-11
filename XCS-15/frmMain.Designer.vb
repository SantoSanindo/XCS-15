<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me._Label2_0 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me._Label5_0 = New System.Windows.Forms.Label()
        Me._Label5_1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me._Label11_5 = New System.Windows.Forms.Label()
        Me._Label11_3 = New System.Windows.Forms.Label()
        Me._Label11_1 = New System.Windows.Forms.Label()
        Me._Label11_2 = New System.Windows.Forms.Label()
        Me._Label11_0 = New System.Windows.Forms.Label()
        Me._Label11_4 = New System.Windows.Forms.Label()
        Me.lbl_WOnos = New System.Windows.Forms.Label()
        Me.lbl_currentref = New System.Windows.Forms.Label()
        Me.lbl_wocounter = New System.Windows.Forms.Label()
        Me.lbl_tagnos = New System.Windows.Forms.Label()
        Me.lbl_ArticleNos = New System.Windows.Forms.Label()
        Me._label6_1 = New System.Windows.Forms.Label()
        Me.lbl_unitaryCount = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me._Label8_0 = New System.Windows.Forms.Label()
        Me.Txt_Msg = New System.Windows.Forms.TextBox()
        Me.t_state = New System.Windows.Forms.TextBox()
        Me._Label8_1 = New System.Windows.Forms.Label()
        Me.lbl_msg = New System.Windows.Forms.Label()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.lbl_localip = New System.Windows.Forms.Label()
        Me.lbl_localhostname = New System.Windows.Forms.Label()
        Me._Label1_0 = New System.Windows.Forms.Label()
        Me.lbl_plcip = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Text4 = New System.Windows.Forms.TextBox()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Text1 = New System.Windows.Forms.TextBox()
        Me.Text3 = New System.Windows.Forms.TextBox()
        Me.Text5 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Barcode_Comm = New System.IO.Ports.SerialPort(Me.components)
        Me.RFID_Comm = New System.IO.Ports.SerialPort(Me.components)
        Me.Ethernet = New System.Windows.Forms.PictureBox()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.Command2 = New System.Windows.Forms.Button()
        Me.cmd_database = New System.Windows.Forms.Button()
        Me.cmd_material = New System.Windows.Forms.Button()
        Me.cmd_reprint = New System.Windows.Forms.Button()
        Me.cmd_testspec = New System.Windows.Forms.Button()
        Me.cmd_quit = New System.Windows.Forms.Button()
        Me.Image3 = New System.Windows.Forms.PictureBox()
        Me.Image1 = New System.Windows.Forms.PictureBox()
        Me.Image2 = New System.Windows.Forms.PictureBox()
        Me._Shape1_0 = New System.Windows.Forms.PictureBox()
        Me._Shape1_1 = New System.Windows.Forms.PictureBox()
        Me._Shape1_2 = New System.Windows.Forms.PictureBox()
        Me._Shape1_3 = New System.Windows.Forms.PictureBox()
        Me._Shape1_4 = New System.Windows.Forms.PictureBox()
        Me._Shape1_5 = New System.Windows.Forms.PictureBox()
        Me.Frame1.SuspendLayout()
        Me.Frame2.SuspendLayout()
        CType(Me.Ethernet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Image3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Image2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Shape1_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Shape1_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Shape1_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Shape1_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Shape1_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Shape1_5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_Label2_0
        '
        Me._Label2_0.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label2_0.ForeColor = System.Drawing.Color.Green
        Me._Label2_0.Location = New System.Drawing.Point(-29, 8)
        Me._Label2_0.Name = "_Label2_0"
        Me._Label2_0.Size = New System.Drawing.Size(201, 17)
        Me._Label2_0.TabIndex = 0
        Me._Label2_0.Text = "Work Order Nos : "
        Me._Label2_0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(-16, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Work Order Reference :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        '_Label5_0
        '
        Me._Label5_0.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label5_0.ForeColor = System.Drawing.Color.Green
        Me._Label5_0.Location = New System.Drawing.Point(16, 56)
        Me._Label5_0.Name = "_Label5_0"
        Me._Label5_0.Size = New System.Drawing.Size(153, 25)
        Me._Label5_0.TabIndex = 2
        Me._Label5_0.Text = "Work Order Qty :"
        Me._Label5_0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        '_Label5_1
        '
        Me._Label5_1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label5_1.ForeColor = System.Drawing.Color.Green
        Me._Label5_1.Location = New System.Drawing.Point(20, 80)
        Me._Label5_1.Name = "_Label5_1"
        Me._Label5_1.Size = New System.Drawing.Size(153, 25)
        Me._Label5_1.TabIndex = 3
        Me._Label5_1.Text = "RFID Tag Nos : "
        Me._Label5_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(17, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Article Nos :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(56, 152)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(193, 25)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "ScrewDriver"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label11_5
        '
        Me._Label11_5.BackColor = System.Drawing.Color.Silver
        Me._Label11_5.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label11_5.ForeColor = System.Drawing.SystemColors.HighlightText
        Me._Label11_5.Location = New System.Drawing.Point(24, 192)
        Me._Label11_5.Name = "_Label11_5"
        Me._Label11_5.Size = New System.Drawing.Size(25, 33)
        Me._Label11_5.TabIndex = 6
        Me._Label11_5.Text = "1"
        Me._Label11_5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label11_3
        '
        Me._Label11_3.BackColor = System.Drawing.Color.Silver
        Me._Label11_3.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label11_3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me._Label11_3.Location = New System.Drawing.Point(72, 192)
        Me._Label11_3.Name = "_Label11_3"
        Me._Label11_3.Size = New System.Drawing.Size(25, 33)
        Me._Label11_3.TabIndex = 14
        Me._Label11_3.Text = "2"
        Me._Label11_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label11_1
        '
        Me._Label11_1.BackColor = System.Drawing.Color.Silver
        Me._Label11_1.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label11_1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me._Label11_1.Location = New System.Drawing.Point(120, 192)
        Me._Label11_1.Name = "_Label11_1"
        Me._Label11_1.Size = New System.Drawing.Size(25, 33)
        Me._Label11_1.TabIndex = 15
        Me._Label11_1.Text = "3"
        Me._Label11_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label11_2
        '
        Me._Label11_2.BackColor = System.Drawing.Color.Silver
        Me._Label11_2.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label11_2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me._Label11_2.Location = New System.Drawing.Point(168, 192)
        Me._Label11_2.Name = "_Label11_2"
        Me._Label11_2.Size = New System.Drawing.Size(25, 33)
        Me._Label11_2.TabIndex = 16
        Me._Label11_2.Text = "4"
        Me._Label11_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label11_0
        '
        Me._Label11_0.BackColor = System.Drawing.Color.Silver
        Me._Label11_0.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label11_0.ForeColor = System.Drawing.SystemColors.HighlightText
        Me._Label11_0.Location = New System.Drawing.Point(216, 192)
        Me._Label11_0.Name = "_Label11_0"
        Me._Label11_0.Size = New System.Drawing.Size(25, 33)
        Me._Label11_0.TabIndex = 17
        Me._Label11_0.Text = "5"
        Me._Label11_0.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label11_4
        '
        Me._Label11_4.BackColor = System.Drawing.Color.Silver
        Me._Label11_4.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label11_4.ForeColor = System.Drawing.SystemColors.HighlightText
        Me._Label11_4.Location = New System.Drawing.Point(264, 192)
        Me._Label11_4.Name = "_Label11_4"
        Me._Label11_4.Size = New System.Drawing.Size(25, 33)
        Me._Label11_4.TabIndex = 18
        Me._Label11_4.Text = "6"
        Me._Label11_4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_WOnos
        '
        Me.lbl_WOnos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_WOnos.ForeColor = System.Drawing.Color.Green
        Me.lbl_WOnos.Location = New System.Drawing.Point(168, 8)
        Me.lbl_WOnos.Name = "lbl_WOnos"
        Me.lbl_WOnos.Size = New System.Drawing.Size(161, 17)
        Me.lbl_WOnos.TabIndex = 19
        Me.lbl_WOnos.Text = "WOnos"
        '
        'lbl_currentref
        '
        Me.lbl_currentref.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_currentref.ForeColor = System.Drawing.Color.Green
        Me.lbl_currentref.Location = New System.Drawing.Point(168, 32)
        Me.lbl_currentref.Name = "lbl_currentref"
        Me.lbl_currentref.Size = New System.Drawing.Size(281, 25)
        Me.lbl_currentref.TabIndex = 20
        Me.lbl_currentref.Text = "CurrentRef"
        '
        'lbl_wocounter
        '
        Me.lbl_wocounter.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_wocounter.ForeColor = System.Drawing.Color.Green
        Me.lbl_wocounter.Location = New System.Drawing.Point(168, 62)
        Me.lbl_wocounter.Name = "lbl_wocounter"
        Me.lbl_wocounter.Size = New System.Drawing.Size(281, 25)
        Me.lbl_wocounter.TabIndex = 21
        Me.lbl_wocounter.Text = "wocounter"
        '
        'lbl_tagnos
        '
        Me.lbl_tagnos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tagnos.ForeColor = System.Drawing.Color.Green
        Me.lbl_tagnos.Location = New System.Drawing.Point(168, 84)
        Me.lbl_tagnos.Name = "lbl_tagnos"
        Me.lbl_tagnos.Size = New System.Drawing.Size(281, 25)
        Me.lbl_tagnos.TabIndex = 22
        Me.lbl_tagnos.Text = "tagnos"
        '
        'lbl_ArticleNos
        '
        Me.lbl_ArticleNos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ArticleNos.ForeColor = System.Drawing.Color.Green
        Me.lbl_ArticleNos.Location = New System.Drawing.Point(168, 108)
        Me.lbl_ArticleNos.Name = "lbl_ArticleNos"
        Me.lbl_ArticleNos.Size = New System.Drawing.Size(281, 25)
        Me.lbl_ArticleNos.TabIndex = 23
        Me.lbl_ArticleNos.Text = "ArticleNos"
        '
        '_label6_1
        '
        Me._label6_1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._label6_1.ForeColor = System.Drawing.Color.Green
        Me._label6_1.Location = New System.Drawing.Point(536, 16)
        Me._label6_1.Name = "_label6_1"
        Me._label6_1.Size = New System.Drawing.Size(113, 25)
        Me._label6_1.TabIndex = 24
        Me._label6_1.Text = "Qty Output:"
        Me._label6_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_unitaryCount
        '
        Me.lbl_unitaryCount.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_unitaryCount.ForeColor = System.Drawing.Color.Green
        Me.lbl_unitaryCount.Location = New System.Drawing.Point(504, 40)
        Me.lbl_unitaryCount.Name = "lbl_unitaryCount"
        Me.lbl_unitaryCount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_unitaryCount.Size = New System.Drawing.Size(185, 57)
        Me.lbl_unitaryCount.TabIndex = 25
        Me.lbl_unitaryCount.Text = "0"
        Me.lbl_unitaryCount.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Green
        Me.Label7.Location = New System.Drawing.Point(736, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(185, 89)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "SC"
        '
        '_Label8_0
        '
        Me._Label8_0.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label8_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label8_0.Location = New System.Drawing.Point(8, 280)
        Me._Label8_0.Name = "_Label8_0"
        Me._Label8_0.Size = New System.Drawing.Size(201, 25)
        Me._Label8_0.TabIndex = 29
        Me._Label8_0.Text = "System Information"
        '
        'Txt_Msg
        '
        Me.Txt_Msg.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Txt_Msg.Location = New System.Drawing.Point(8, 304)
        Me.Txt_Msg.Multiline = True
        Me.Txt_Msg.Name = "Txt_Msg"
        Me.Txt_Msg.Size = New System.Drawing.Size(305, 153)
        Me.Txt_Msg.TabIndex = 30
        '
        't_state
        '
        Me.t_state.BackColor = System.Drawing.SystemColors.Window
        Me.t_state.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_state.Location = New System.Drawing.Point(-176, 424)
        Me.t_state.Multiline = True
        Me.t_state.Name = "t_state"
        Me.t_state.Size = New System.Drawing.Size(185, 25)
        Me.t_state.TabIndex = 31
        Me.t_state.Text = "Text1"
        Me.t_state.Visible = False
        '
        '_Label8_1
        '
        Me._Label8_1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label8_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label8_1.Location = New System.Drawing.Point(8, 488)
        Me._Label8_1.Name = "_Label8_1"
        Me._Label8_1.Size = New System.Drawing.Size(201, 25)
        Me._Label8_1.TabIndex = 32
        Me._Label8_1.Text = "Operator's Instruction"
        '
        'lbl_msg
        '
        Me.lbl_msg.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_msg.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_msg.ForeColor = System.Drawing.Color.Red
        Me.lbl_msg.Location = New System.Drawing.Point(8, 512)
        Me.lbl_msg.Name = "lbl_msg"
        Me.lbl_msg.Size = New System.Drawing.Size(297, 89)
        Me.lbl_msg.TabIndex = 33
        Me.lbl_msg.Text = "Please scan the PSN barcode..."
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.Ethernet)
        Me.Frame1.Controls.Add(Me.lbl_localip)
        Me.Frame1.Controls.Add(Me.lbl_localhostname)
        Me.Frame1.Controls.Add(Me._Label1_0)
        Me.Frame1.Controls.Add(Me.lbl_plcip)
        Me.Frame1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.Color.Green
        Me.Frame1.Location = New System.Drawing.Point(16, 600)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(225, 89)
        Me.Frame1.TabIndex = 35
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Ethernet Connection"
        '
        'lbl_localip
        '
        Me.lbl_localip.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_localip.ForeColor = System.Drawing.Color.Green
        Me.lbl_localip.Location = New System.Drawing.Point(9, 49)
        Me.lbl_localip.Name = "lbl_localip"
        Me.lbl_localip.Size = New System.Drawing.Size(210, 17)
        Me.lbl_localip.TabIndex = 50
        Me.lbl_localip.Text = "localIP"
        '
        'lbl_localhostname
        '
        Me.lbl_localhostname.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_localhostname.ForeColor = System.Drawing.Color.Green
        Me.lbl_localhostname.Location = New System.Drawing.Point(9, 33)
        Me.lbl_localhostname.Name = "lbl_localhostname"
        Me.lbl_localhostname.Size = New System.Drawing.Size(210, 17)
        Me.lbl_localhostname.TabIndex = 49
        Me.lbl_localhostname.Text = "localhost"
        '
        '_Label1_0
        '
        Me._Label1_0.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_0.ForeColor = System.Drawing.Color.Green
        Me._Label1_0.Location = New System.Drawing.Point(9, 17)
        Me._Label1_0.Name = "_Label1_0"
        Me._Label1_0.Size = New System.Drawing.Size(113, 17)
        Me._Label1_0.TabIndex = 48
        Me._Label1_0.Text = "Connect"
        '
        'lbl_plcip
        '
        Me.lbl_plcip.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_plcip.ForeColor = System.Drawing.Color.Green
        Me.lbl_plcip.Location = New System.Drawing.Point(9, 66)
        Me.lbl_plcip.Name = "lbl_plcip"
        Me.lbl_plcip.Size = New System.Drawing.Size(199, 17)
        Me.lbl_plcip.TabIndex = 51
        Me.lbl_plcip.Text = "PLC IP Address : 126.254.108.2"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(317, 600)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "%MW101"
        '
        'Text4
        '
        Me.Text4.Location = New System.Drawing.Point(368, 600)
        Me.Text4.Name = "Text4"
        Me.Text4.Size = New System.Drawing.Size(41, 20)
        Me.Text4.TabIndex = 37
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Frame2.Controls.Add(Me.TextBox2)
        Me.Frame2.Controls.Add(Me.Text1)
        Me.Frame2.Location = New System.Drawing.Point(304, 680)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Size = New System.Drawing.Size(145, 113)
        Me.Frame2.TabIndex = 38
        Me.Frame2.TabStop = False
        Me.Frame2.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(8, 80)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(129, 25)
        Me.TextBox2.TabIndex = 40
        '
        'Text1
        '
        Me.Text1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text1.Location = New System.Drawing.Point(8, 32)
        Me.Text1.Multiline = True
        Me.Text1.Name = "Text1"
        Me.Text1.Size = New System.Drawing.Size(129, 25)
        Me.Text1.TabIndex = 39
        '
        'Text3
        '
        Me.Text3.Location = New System.Drawing.Point(776, 648)
        Me.Text3.Multiline = True
        Me.Text3.Name = "Text3"
        Me.Text3.Size = New System.Drawing.Size(121, 25)
        Me.Text3.TabIndex = 39
        Me.Text3.Visible = False
        '
        'Text5
        '
        Me.Text5.Location = New System.Drawing.Point(776, 679)
        Me.Text5.Multiline = True
        Me.Text5.Name = "Text5"
        Me.Text5.Size = New System.Drawing.Size(121, 25)
        Me.Text5.TabIndex = 40
        Me.Text5.Text = "Text1"
        Me.Text5.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 3000
        '
        'Barcode_Comm
        '
        Me.Barcode_Comm.BaudRate = 38400
        Me.Barcode_Comm.PortName = "COM8"
        Me.Barcode_Comm.ReadBufferSize = 1024
        Me.Barcode_Comm.WriteBufferSize = 512
        '
        'RFID_Comm
        '
        Me.RFID_Comm.BaudRate = 19200
        Me.RFID_Comm.Parity = System.IO.Ports.Parity.Even
        Me.RFID_Comm.PortName = "COM2"
        Me.RFID_Comm.ReadBufferSize = 1024
        Me.RFID_Comm.WriteBufferSize = 512
        '
        'Ethernet
        '
        Me.Ethernet.Location = New System.Drawing.Point(65, 18)
        Me.Ethernet.Name = "Ethernet"
        Me.Ethernet.Size = New System.Drawing.Size(16, 16)
        Me.Ethernet.TabIndex = 48
        Me.Ethernet.TabStop = False
        '
        'Command1
        '
        Me.Command1.Image = Global.XCS_15.My.Resources.Resources.eye
        Me.Command1.Location = New System.Drawing.Point(936, 639)
        Me.Command1.Name = "Command1"
        Me.Command1.Size = New System.Drawing.Size(73, 65)
        Me.Command1.TabIndex = 47
        Me.Command1.Text = "Eye Open"
        Me.Command1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Command1.UseVisualStyleBackColor = True
        '
        'Command2
        '
        Me.Command2.Image = Global.XCS_15.My.Resources.Resources.Refresh
        Me.Command2.Location = New System.Drawing.Point(936, 335)
        Me.Command2.Name = "Command2"
        Me.Command2.Size = New System.Drawing.Size(73, 65)
        Me.Command2.TabIndex = 46
        Me.Command2.Text = "Refresh"
        Me.Command2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Command2.UseVisualStyleBackColor = True
        '
        'cmd_database
        '
        Me.cmd_database.Image = Global.XCS_15.My.Resources.Resources.material
        Me.cmd_database.Location = New System.Drawing.Point(936, 264)
        Me.cmd_database.Name = "cmd_database"
        Me.cmd_database.Size = New System.Drawing.Size(73, 65)
        Me.cmd_database.TabIndex = 45
        Me.cmd_database.Text = "Material"
        Me.cmd_database.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmd_database.UseVisualStyleBackColor = True
        '
        'cmd_material
        '
        Me.cmd_material.Image = Global.XCS_15.My.Resources.Resources.rack
        Me.cmd_material.Location = New System.Drawing.Point(936, 200)
        Me.cmd_material.Name = "cmd_material"
        Me.cmd_material.Size = New System.Drawing.Size(73, 65)
        Me.cmd_material.TabIndex = 44
        Me.cmd_material.Text = "Rack"
        Me.cmd_material.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmd_material.UseVisualStyleBackColor = True
        '
        'cmd_reprint
        '
        Me.cmd_reprint.Image = Global.XCS_15.My.Resources.Resources.printer
        Me.cmd_reprint.Location = New System.Drawing.Point(936, 136)
        Me.cmd_reprint.Name = "cmd_reprint"
        Me.cmd_reprint.Size = New System.Drawing.Size(73, 65)
        Me.cmd_reprint.TabIndex = 43
        Me.cmd_reprint.Text = "Print Again"
        Me.cmd_reprint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmd_reprint.UseVisualStyleBackColor = True
        '
        'cmd_testspec
        '
        Me.cmd_testspec.Image = Global.XCS_15.My.Resources.Resources.Parameter
        Me.cmd_testspec.Location = New System.Drawing.Point(936, 72)
        Me.cmd_testspec.Name = "cmd_testspec"
        Me.cmd_testspec.Size = New System.Drawing.Size(73, 65)
        Me.cmd_testspec.TabIndex = 42
        Me.cmd_testspec.Text = "Parameter"
        Me.cmd_testspec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmd_testspec.UseVisualStyleBackColor = True
        '
        'cmd_quit
        '
        Me.cmd_quit.Image = Global.XCS_15.My.Resources.Resources.Quit
        Me.cmd_quit.Location = New System.Drawing.Point(936, 8)
        Me.cmd_quit.Name = "cmd_quit"
        Me.cmd_quit.Size = New System.Drawing.Size(73, 65)
        Me.cmd_quit.TabIndex = 41
        Me.cmd_quit.Text = "Quit"
        Me.cmd_quit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmd_quit.UseVisualStyleBackColor = True
        '
        'Image3
        '
        Me.Image3.Location = New System.Drawing.Point(456, 144)
        Me.Image3.Name = "Image3"
        Me.Image3.Size = New System.Drawing.Size(465, 497)
        Me.Image3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Image3.TabIndex = 34
        Me.Image3.TabStop = False
        '
        'Image1
        '
        Me.Image1.Location = New System.Drawing.Point(320, 296)
        Me.Image1.Name = "Image1"
        Me.Image1.Size = New System.Drawing.Size(121, 241)
        Me.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Image1.TabIndex = 28
        Me.Image1.TabStop = False
        '
        'Image2
        '
        Me.Image2.Location = New System.Drawing.Point(328, 144)
        Me.Image2.Name = "Image2"
        Me.Image2.Size = New System.Drawing.Size(105, 129)
        Me.Image2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Image2.TabIndex = 27
        Me.Image2.TabStop = False
        '
        '_Shape1_0
        '
        Me._Shape1_0.BackColor = System.Drawing.Color.Silver
        Me._Shape1_0.Location = New System.Drawing.Point(208, 184)
        Me._Shape1_0.Name = "_Shape1_0"
        Me._Shape1_0.Size = New System.Drawing.Size(41, 49)
        Me._Shape1_0.TabIndex = 13
        Me._Shape1_0.TabStop = False
        '
        '_Shape1_1
        '
        Me._Shape1_1.BackColor = System.Drawing.Color.Silver
        Me._Shape1_1.Location = New System.Drawing.Point(112, 184)
        Me._Shape1_1.Name = "_Shape1_1"
        Me._Shape1_1.Size = New System.Drawing.Size(41, 49)
        Me._Shape1_1.TabIndex = 12
        Me._Shape1_1.TabStop = False
        '
        '_Shape1_2
        '
        Me._Shape1_2.BackColor = System.Drawing.Color.Silver
        Me._Shape1_2.Location = New System.Drawing.Point(160, 184)
        Me._Shape1_2.Name = "_Shape1_2"
        Me._Shape1_2.Size = New System.Drawing.Size(41, 49)
        Me._Shape1_2.TabIndex = 11
        Me._Shape1_2.TabStop = False
        '
        '_Shape1_3
        '
        Me._Shape1_3.BackColor = System.Drawing.Color.Silver
        Me._Shape1_3.Location = New System.Drawing.Point(64, 184)
        Me._Shape1_3.Name = "_Shape1_3"
        Me._Shape1_3.Size = New System.Drawing.Size(41, 49)
        Me._Shape1_3.TabIndex = 10
        Me._Shape1_3.TabStop = False
        '
        '_Shape1_4
        '
        Me._Shape1_4.BackColor = System.Drawing.Color.Silver
        Me._Shape1_4.Location = New System.Drawing.Point(256, 184)
        Me._Shape1_4.Name = "_Shape1_4"
        Me._Shape1_4.Size = New System.Drawing.Size(41, 49)
        Me._Shape1_4.TabIndex = 9
        Me._Shape1_4.TabStop = False
        '
        '_Shape1_5
        '
        Me._Shape1_5.BackColor = System.Drawing.Color.Silver
        Me._Shape1_5.Location = New System.Drawing.Point(16, 184)
        Me._Shape1_5.Name = "_Shape1_5"
        Me._Shape1_5.Size = New System.Drawing.Size(41, 49)
        Me._Shape1_5.TabIndex = 7
        Me._Shape1_5.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1014, 709)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.Command2)
        Me.Controls.Add(Me.cmd_database)
        Me.Controls.Add(Me.cmd_material)
        Me.Controls.Add(Me.cmd_reprint)
        Me.Controls.Add(Me.cmd_testspec)
        Me.Controls.Add(Me.cmd_quit)
        Me.Controls.Add(Me.Text5)
        Me.Controls.Add(Me.Text3)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Text4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Image3)
        Me.Controls.Add(Me.lbl_msg)
        Me.Controls.Add(Me._Label8_1)
        Me.Controls.Add(Me.t_state)
        Me.Controls.Add(Me.Txt_Msg)
        Me.Controls.Add(Me._Label8_0)
        Me.Controls.Add(Me.Image1)
        Me.Controls.Add(Me.Image2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl_unitaryCount)
        Me.Controls.Add(Me._label6_1)
        Me.Controls.Add(Me.lbl_ArticleNos)
        Me.Controls.Add(Me.lbl_tagnos)
        Me.Controls.Add(Me.lbl_wocounter)
        Me.Controls.Add(Me.lbl_currentref)
        Me.Controls.Add(Me.lbl_WOnos)
        Me.Controls.Add(Me._Label11_4)
        Me.Controls.Add(Me._Label11_0)
        Me.Controls.Add(Me._Label11_2)
        Me.Controls.Add(Me._Label11_1)
        Me.Controls.Add(Me._Label11_3)
        Me.Controls.Add(Me._Shape1_0)
        Me.Controls.Add(Me._Shape1_1)
        Me.Controls.Add(Me._Shape1_2)
        Me.Controls.Add(Me._Shape1_3)
        Me.Controls.Add(Me._Shape1_4)
        Me.Controls.Add(Me._Label11_5)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me._Label5_1)
        Me.Controls.Add(Me._Label5_0)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me._Label2_0)
        Me.Controls.Add(Me._Shape1_5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cover Assembly - Developed by SESEA"
        Me.Frame1.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        CType(Me.Ethernet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Image3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Image2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Shape1_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Shape1_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Shape1_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Shape1_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Shape1_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Shape1_5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _Label2_0 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents _Label5_0 As Label
    Friend WithEvents _Label5_1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents _Label11_5 As Label
    Friend WithEvents _Shape1_5 As PictureBox
    Friend WithEvents _Shape1_4 As PictureBox
    Friend WithEvents _Shape1_3 As PictureBox
    Friend WithEvents _Shape1_2 As PictureBox
    Friend WithEvents _Shape1_1 As PictureBox
    Friend WithEvents _Shape1_0 As PictureBox
    Friend WithEvents _Label11_3 As Label
    Friend WithEvents _Label11_1 As Label
    Friend WithEvents _Label11_2 As Label
    Friend WithEvents _Label11_0 As Label
    Friend WithEvents _Label11_4 As Label
    Friend WithEvents lbl_WOnos As Label
    Friend WithEvents lbl_currentref As Label
    Friend WithEvents lbl_wocounter As Label
    Friend WithEvents lbl_tagnos As Label
    Friend WithEvents lbl_ArticleNos As Label
    Friend WithEvents _label6_1 As Label
    Friend WithEvents lbl_unitaryCount As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Image2 As PictureBox
    Friend WithEvents Image1 As PictureBox
    Friend WithEvents _Label8_0 As Label
    Friend WithEvents Txt_Msg As TextBox
    Friend WithEvents t_state As TextBox
    Friend WithEvents _Label8_1 As Label
    Friend WithEvents lbl_msg As Label
    Friend WithEvents Image3 As PictureBox
    Friend WithEvents Frame1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Text4 As TextBox
    Friend WithEvents Frame2 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Text1 As TextBox
    Friend WithEvents Text3 As TextBox
    Friend WithEvents Text5 As TextBox
    Friend WithEvents cmd_quit As Button
    Friend WithEvents cmd_testspec As Button
    Friend WithEvents cmd_reprint As Button
    Friend WithEvents cmd_material As Button
    Friend WithEvents cmd_database As Button
    Friend WithEvents Command2 As Button
    Friend WithEvents Command1 As Button
    Friend WithEvents lbl_localip As Label
    Friend WithEvents lbl_localhostname As Label
    Friend WithEvents _Label1_0 As Label
    Friend WithEvents lbl_plcip As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Barcode_Comm As IO.Ports.SerialPort
    Friend WithEvents RFID_Comm As IO.Ports.SerialPort
    Friend WithEvents Ethernet As PictureBox
End Class
