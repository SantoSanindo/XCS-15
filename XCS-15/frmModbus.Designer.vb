<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmModbus
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModbus))
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cboRegType = New System.Windows.Forms.ComboBox()
        Me.btnWrite = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.txtNewValue = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.lbl_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_status.ForeColor = System.Drawing.Color.Red
        Me.lbl_status.Location = New System.Drawing.Point(94, 116)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_status.Size = New System.Drawing.Size(116, 20)
        Me.lbl_status.TabIndex = 40
        Me.lbl_status.Text = "Not Connected"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(345, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 57)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Back"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cboRegType
        '
        Me.cboRegType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRegType.Font = New System.Drawing.Font("Consolas", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRegType.Items.AddRange(New Object() {"Coil Outputs      (00000)", "Digital Inputs    (10000)", "Analogue Inputs   (30000)", "Holding Registers (40000)"})
        Me.cboRegType.Location = New System.Drawing.Point(98, 139)
        Me.cboRegType.Name = "cboRegType"
        Me.cboRegType.Size = New System.Drawing.Size(230, 26)
        Me.cboRegType.TabIndex = 38
        '
        'btnWrite
        '
        Me.btnWrite.Location = New System.Drawing.Point(214, 223)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(114, 34)
        Me.btnWrite.TabIndex = 36
        Me.btnWrite.Text = "Write"
        Me.btnWrite.UseVisualStyleBackColor = True
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(214, 171)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(114, 46)
        Me.btnRead.TabIndex = 37
        Me.btnRead.Text = "Read"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Enabled = False
        Me.btnDisconnect.Location = New System.Drawing.Point(181, 67)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(147, 35)
        Me.btnDisconnect.TabIndex = 34
        Me.btnDisconnect.Text = "DISCONNECT"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(27, 67)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(147, 35)
        Me.btnConnect.TabIndex = 35
        Me.btnConnect.Text = "CONNECT"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(263, 25)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(65, 20)
        Me.txtPort.TabIndex = 29
        Me.txtPort.Text = "502"
        '
        'txtNewValue
        '
        Me.txtNewValue.Location = New System.Drawing.Point(98, 231)
        Me.txtNewValue.Name = "txtNewValue"
        Me.txtNewValue.Size = New System.Drawing.Size(110, 20)
        Me.txtNewValue.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(228, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Port:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "New Value :"
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(98, 197)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(110, 20)
        Me.txtValue.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Value :"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(98, 171)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(110, 20)
        Me.txtAddress.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Reg Type :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Address :"
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(84, 25)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(124, 20)
        Me.txtIP.TabIndex = 33
        Me.txtIP.Text = "127.0.0.1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Server IP:"
        '
        'frmModbus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 282)
        Me.Controls.Add(Me.lbl_status)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cboRegType)
        Me.Controls.Add(Me.btnWrite)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnDisconnect)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.txtNewValue)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtIP)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmModbus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modbus"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_status As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents cboRegType As ComboBox
    Friend WithEvents btnWrite As Button
    Friend WithEvents btnRead As Button
    Friend WithEvents btnDisconnect As Button
    Friend WithEvents btnConnect As Button
    Friend WithEvents txtPort As TextBox
    Friend WithEvents txtNewValue As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtValue As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIP As TextBox
    Friend WithEvents Label1 As Label
End Class
