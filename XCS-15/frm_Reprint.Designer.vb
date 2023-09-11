<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Reprint
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
        Me.Text2 = New System.Windows.Forms.TextBox()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.Txt_Msg = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdback = New System.Windows.Forms.Button()
        Me.MSComm1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Text2
        '
        Me.Text2.AcceptsReturn = True
        Me.Text2.BackColor = System.Drawing.SystemColors.Window
        Me.Text2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text2.Location = New System.Drawing.Point(76, 23)
        Me.Text2.MaxLength = 0
        Me.Text2.Name = "Text2"
        Me.Text2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text2.Size = New System.Drawing.Size(313, 26)
        Me.Text2.TabIndex = 6
        Me.Text2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.Txt_Msg)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(20, 87)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(457, 201)
        Me.Frame1.TabIndex = 5
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Message"
        '
        'Txt_Msg
        '
        Me.Txt_Msg.AcceptsReturn = True
        Me.Txt_Msg.BackColor = System.Drawing.SystemColors.Window
        Me.Txt_Msg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Msg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Msg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_Msg.Location = New System.Drawing.Point(56, 80)
        Me.Txt_Msg.MaxLength = 0
        Me.Txt_Msg.Multiline = True
        Me.Txt_Msg.Name = "Txt_Msg"
        Me.Txt_Msg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Msg.Size = New System.Drawing.Size(337, 73)
        Me.Txt_Msg.TabIndex = 4
        Me.Txt_Msg.Text = "-"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(425, 161)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Please load the print list of your desired work week by clicking the <Load> butto" &
    "n."
        '
        'cmdback
        '
        Me.cmdback.BackColor = System.Drawing.SystemColors.Control
        Me.cmdback.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdback.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdback.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdback.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdback.Image = Global.XCS_15.My.Resources.Resources.previous
        Me.cmdback.Location = New System.Drawing.Point(396, 303)
        Me.cmdback.Name = "cmdback"
        Me.cmdback.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdback.Size = New System.Drawing.Size(81, 73)
        Me.cmdback.TabIndex = 4
        Me.cmdback.Text = "Back"
        Me.cmdback.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdback.UseVisualStyleBackColor = False
        '
        'MSComm1
        '
        Me.MSComm1.PortName = "COM8"
        Me.MSComm1.WriteBufferSize = 1024
        '
        'frm_Reprint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 398)
        Me.Controls.Add(Me.Text2)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdback)
        Me.Name = "frm_Reprint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Re Print Feature"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Text2 As TextBox
    Public WithEvents Frame1 As GroupBox
    Public WithEvents Txt_Msg As TextBox
    Public WithEvents Label1 As Label
    Public WithEvents cmdback As Button
    Friend WithEvents MSComm1 As IO.Ports.SerialPort
End Class
