<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.cmd_Find = New System.Windows.Forms.Button()
        Me.cmb_Interfaces = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_FTString = New System.Windows.Forms.TextBox()
        Me.cmd_OpenInterface = New System.Windows.Forms.Button()
        Me.cmd_CloseInterface = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.openInterface = New System.Windows.Forms.CheckBox()
        Me.txt_log = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Baud = New System.Windows.Forms.TextBox()
        Me.chk_MaxClk = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmd_Find
        '
        Me.cmd_Find.Location = New System.Drawing.Point(12, 12)
        Me.cmd_Find.Name = "cmd_Find"
        Me.cmd_Find.Size = New System.Drawing.Size(226, 23)
        Me.cmd_Find.TabIndex = 0
        Me.cmd_Find.Text = "Find All FTDI Interfaces"
        Me.cmd_Find.UseVisualStyleBackColor = True
        '
        'cmb_Interfaces
        '
        Me.cmb_Interfaces.FormattingEnabled = True
        Me.cmb_Interfaces.Location = New System.Drawing.Point(12, 85)
        Me.cmb_Interfaces.Name = "cmb_Interfaces"
        Me.cmb_Interfaces.Size = New System.Drawing.Size(226, 23)
        Me.cmb_Interfaces.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Custom String"
        '
        'txt_FTString
        '
        Me.txt_FTString.Location = New System.Drawing.Point(75, 48)
        Me.txt_FTString.Name = "txt_FTString"
        Me.txt_FTString.Size = New System.Drawing.Size(163, 23)
        Me.txt_FTString.TabIndex = 3
        '
        'cmd_OpenInterface
        '
        Me.cmd_OpenInterface.Location = New System.Drawing.Point(12, 120)
        Me.cmd_OpenInterface.Name = "cmd_OpenInterface"
        Me.cmd_OpenInterface.Size = New System.Drawing.Size(71, 39)
        Me.cmd_OpenInterface.TabIndex = 4
        Me.cmd_OpenInterface.Text = "Open Interface"
        Me.cmd_OpenInterface.UseVisualStyleBackColor = True
        '
        'cmd_CloseInterface
        '
        Me.cmd_CloseInterface.Location = New System.Drawing.Point(167, 121)
        Me.cmd_CloseInterface.Name = "cmd_CloseInterface"
        Me.cmd_CloseInterface.Size = New System.Drawing.Size(71, 39)
        Me.cmd_CloseInterface.TabIndex = 5
        Me.cmd_CloseInterface.Text = "Close Interface"
        Me.cmd_CloseInterface.UseVisualStyleBackColor = True
        '
        'openInterface
        '
        Me.openInterface.Location = New System.Drawing.Point(89, 121)
        Me.openInterface.Name = "openInterface"
        Me.openInterface.Size = New System.Drawing.Size(72, 39)
        Me.openInterface.TabIndex = 6
        Me.openInterface.Text = "Interface Opened"
        Me.openInterface.UseVisualStyleBackColor = True
        '
        'txt_log
        '
        Me.txt_log.Location = New System.Drawing.Point(12, 351)
        Me.txt_log.Name = "txt_log"
        Me.txt_log.Size = New System.Drawing.Size(880, 162)
        Me.txt_log.TabIndex = 7
        Me.txt_log.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 35)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Divisor:  Clk = 3MHz/"
        '
        'txt_Baud
        '
        Me.txt_Baud.Location = New System.Drawing.Point(104, 175)
        Me.txt_Baud.Name = "txt_Baud"
        Me.txt_Baud.Size = New System.Drawing.Size(26, 23)
        Me.txt_Baud.TabIndex = 9
        Me.txt_Baud.Text = "3"
        '
        'chk_MaxClk
        '
        Me.chk_MaxClk.AutoSize = True
        Me.chk_MaxClk.Checked = True
        Me.chk_MaxClk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_MaxClk.Location = New System.Drawing.Point(167, 178)
        Me.chk_MaxClk.Name = "chk_MaxClk"
        Me.chk_MaxClk.Size = New System.Drawing.Size(69, 19)
        Me.chk_MaxClk.TabIndex = 10
        Me.chk_MaxClk.Text = "Max Clk"
        Me.chk_MaxClk.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 249)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "TMS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "TCK"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(131, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 15)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "TDO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(131, 281)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 15)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "TDI"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 311)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Start BitBang Mode"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(208, 15)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "ISP Setup assuming SparkFun FT232RL"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 528)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chk_MaxClk)
        Me.Controls.Add(Me.txt_Baud)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_log)
        Me.Controls.Add(Me.openInterface)
        Me.Controls.Add(Me.cmd_CloseInterface)
        Me.Controls.Add(Me.cmd_OpenInterface)
        Me.Controls.Add(Me.txt_FTString)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_Interfaces)
        Me.Controls.Add(Me.cmd_Find)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_Find As Button
    Friend WithEvents cmb_Interfaces As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_FTString As TextBox
    Friend WithEvents cmd_OpenInterface As Button
    Friend WithEvents cmd_CloseInterface As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents openInterface As CheckBox
    Friend WithEvents txt_log As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_Baud As TextBox
    Friend WithEvents chk_MaxClk As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
End Class
