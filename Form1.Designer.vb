<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.StartBF = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.hash = New System.Windows.Forms.TextBox()
        Me.Restore = New System.Windows.Forms.Button()
        Me.HC = New System.Windows.Forms.ComboBox()
        Me.xNC1 = New System.Windows.Forms.ComboBox()
        Me.xNC2 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.comSent = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Log = New System.Windows.Forms.RichTextBox()
        Me.Benchmark = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.saveInfo = New System.Windows.Forms.Label()
        Me.clearMailConfig = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.M7 = New System.Windows.Forms.TextBox()
        Me.saveMailData = New System.Windows.Forms.Button()
        Me.M6 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.M5 = New System.Windows.Forms.TextBox()
        Me.M4 = New System.Windows.Forms.TextBox()
        Me.M3 = New System.Windows.Forms.TextBox()
        Me.M2 = New System.Windows.Forms.TextBox()
        Me.M1 = New System.Windows.Forms.TextBox()
        Me.mailData = New System.Windows.Forms.RichTextBox()
        Me.TimerSaveOK = New System.Windows.Forms.Timer(Me.components)
        Me.fileCodCheck = New System.Windows.Forms.Timer(Me.components)
        Me.Date_Now = New System.Windows.Forms.TextBox()
        Me.DesCode = New System.Windows.Forms.RichTextBox()
        Me.FileL = New System.Windows.Forms.TextBox()
        Me.Datetxt = New System.Windows.Forms.Label()
        Me.manualCheck = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Manual = New System.Windows.Forms.TextBox()
        Me.SendManual = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StartBF
        '
        Me.StartBF.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.StartBF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StartBF.Location = New System.Drawing.Point(485, 27)
        Me.StartBF.Name = "StartBF"
        Me.StartBF.Size = New System.Drawing.Size(75, 26)
        Me.StartBF.TabIndex = 0
        Me.StartBF.Text = "Start BF"
        Me.StartBF.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.hash)
        Me.GroupBox1.Controls.Add(Me.StartBF)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 74)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "HASH:"
        '
        'hash
        '
        Me.hash.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.hash.Location = New System.Drawing.Point(78, 27)
        Me.hash.Name = "hash"
        Me.hash.Size = New System.Drawing.Size(384, 23)
        Me.hash.TabIndex = 1
        '
        'Restore
        '
        Me.Restore.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Restore.Location = New System.Drawing.Point(491, 86)
        Me.Restore.Name = "Restore"
        Me.Restore.Size = New System.Drawing.Size(75, 26)
        Me.Restore.TabIndex = 3
        Me.Restore.Text = "Restore"
        Me.Restore.UseVisualStyleBackColor = True
        '
        'HC
        '
        Me.HC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HC.FormattingEnabled = True
        Me.HC.Items.AddRange(New Object() {"hashcat", "hashcat32", "hashcat64"})
        Me.HC.Location = New System.Drawing.Point(12, 12)
        Me.HC.Name = "HC"
        Me.HC.Size = New System.Drawing.Size(121, 24)
        Me.HC.TabIndex = 2
        '
        'xNC1
        '
        Me.xNC1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xNC1.FormattingEnabled = True
        Me.xNC1.Items.AddRange(New Object() {"1", "2", "3"})
        Me.xNC1.Location = New System.Drawing.Point(358, 12)
        Me.xNC1.Name = "xNC1"
        Me.xNC1.Size = New System.Drawing.Size(45, 24)
        Me.xNC1.TabIndex = 3
        '
        'xNC2
        '
        Me.xNC2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xNC2.FormattingEnabled = True
        Me.xNC2.Location = New System.Drawing.Point(507, 12)
        Me.xNC2.Name = "xNC2"
        Me.xNC2.Size = New System.Drawing.Size(45, 24)
        Me.xNC2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(204, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Number of computers:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(428, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Select PC:"
        '
        'comSent
        '
        Me.comSent.Location = New System.Drawing.Point(12, 330)
        Me.comSent.Name = "comSent"
        Me.comSent.Size = New System.Drawing.Size(544, 22)
        Me.comSent.TabIndex = 10
        Me.comSent.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 51)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(605, 273)
        Me.TabControl1.TabIndex = 11
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Log)
        Me.TabPage1.Controls.Add(Me.Benchmark)
        Me.TabPage1.Controls.Add(Me.Restore)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(597, 244)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "DES"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Log
        '
        Me.Log.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Log.Location = New System.Drawing.Point(27, 86)
        Me.Log.Name = "Log"
        Me.Log.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.Log.Size = New System.Drawing.Size(441, 139)
        Me.Log.TabIndex = 5
        Me.Log.Text = ""
        '
        'Benchmark
        '
        Me.Benchmark.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Benchmark.Location = New System.Drawing.Point(491, 118)
        Me.Benchmark.Name = "Benchmark"
        Me.Benchmark.Size = New System.Drawing.Size(75, 23)
        Me.Benchmark.TabIndex = 4
        Me.Benchmark.Text = "Bench"
        Me.Benchmark.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.saveInfo)
        Me.TabPage2.Controls.Add(Me.clearMailConfig)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.M7)
        Me.TabPage2.Controls.Add(Me.saveMailData)
        Me.TabPage2.Controls.Add(Me.M6)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.M5)
        Me.TabPage2.Controls.Add(Me.M4)
        Me.TabPage2.Controls.Add(Me.M3)
        Me.TabPage2.Controls.Add(Me.M2)
        Me.TabPage2.Controls.Add(Me.M1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(597, 244)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Notifications"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'saveInfo
        '
        Me.saveInfo.AutoSize = True
        Me.saveInfo.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.saveInfo.ForeColor = System.Drawing.Color.ForestGreen
        Me.saveInfo.Location = New System.Drawing.Point(502, 176)
        Me.saveInfo.Name = "saveInfo"
        Me.saveInfo.Size = New System.Drawing.Size(58, 18)
        Me.saveInfo.TabIndex = 33
        Me.saveInfo.Text = "Saved !!"
        Me.saveInfo.Visible = False
        '
        'clearMailConfig
        '
        Me.clearMailConfig.Location = New System.Drawing.Point(494, 89)
        Me.clearMailConfig.Name = "clearMailConfig"
        Me.clearMailConfig.Size = New System.Drawing.Size(75, 28)
        Me.clearMailConfig.TabIndex = 32
        Me.clearMailConfig.Text = "Clear"
        Me.clearMailConfig.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(74, 179)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 17)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Subject:"
        '
        'M7
        '
        Me.M7.Location = New System.Drawing.Point(138, 208)
        Me.M7.Name = "M7"
        Me.M7.Size = New System.Drawing.Size(309, 22)
        Me.M7.TabIndex = 30
        '
        'saveMailData
        '
        Me.saveMailData.Location = New System.Drawing.Point(481, 34)
        Me.saveMailData.Name = "saveMailData"
        Me.saveMailData.Size = New System.Drawing.Size(100, 40)
        Me.saveMailData.TabIndex = 29
        Me.saveMailData.Text = "Save"
        Me.saveMailData.UseVisualStyleBackColor = True
        '
        'M6
        '
        Me.M6.Location = New System.Drawing.Point(139, 176)
        Me.M6.Name = "M6"
        Me.M6.Size = New System.Drawing.Size(308, 22)
        Me.M6.TabIndex = 28
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(43, 83)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 17)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "SMTP Client:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(40, 211)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 17)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "MessageText:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 51)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 17)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "SenderAddress:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 17)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "RecipientAddress:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(61, 147)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 17)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Password:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(87, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 17)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Login:"
        '
        'M5
        '
        Me.M5.Location = New System.Drawing.Point(138, 144)
        Me.M5.Name = "M5"
        Me.M5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.M5.Size = New System.Drawing.Size(309, 22)
        Me.M5.TabIndex = 21
        '
        'M4
        '
        Me.M4.Location = New System.Drawing.Point(138, 112)
        Me.M4.Name = "M4"
        Me.M4.Size = New System.Drawing.Size(309, 22)
        Me.M4.TabIndex = 20
        '
        'M3
        '
        Me.M3.Location = New System.Drawing.Point(138, 80)
        Me.M3.Name = "M3"
        Me.M3.Size = New System.Drawing.Size(309, 22)
        Me.M3.TabIndex = 19
        '
        'M2
        '
        Me.M2.Location = New System.Drawing.Point(138, 48)
        Me.M2.Name = "M2"
        Me.M2.Size = New System.Drawing.Size(309, 22)
        Me.M2.TabIndex = 18
        '
        'M1
        '
        Me.M1.Location = New System.Drawing.Point(138, 16)
        Me.M1.Name = "M1"
        Me.M1.Size = New System.Drawing.Size(309, 22)
        Me.M1.TabIndex = 17
        '
        'mailData
        '
        Me.mailData.Location = New System.Drawing.Point(12, 358)
        Me.mailData.Name = "mailData"
        Me.mailData.Size = New System.Drawing.Size(370, 161)
        Me.mailData.TabIndex = 12
        Me.mailData.Text = ""
        Me.mailData.Visible = False
        '
        'TimerSaveOK
        '
        Me.TimerSaveOK.Interval = 1000
        '
        'fileCodCheck
        '
        Me.fileCodCheck.Interval = 15000
        '
        'Date_Now
        '
        Me.Date_Now.Location = New System.Drawing.Point(456, 358)
        Me.Date_Now.Name = "Date_Now"
        Me.Date_Now.Size = New System.Drawing.Size(100, 22)
        Me.Date_Now.TabIndex = 13
        Me.Date_Now.Visible = False
        '
        'DesCode
        '
        Me.DesCode.Location = New System.Drawing.Point(388, 386)
        Me.DesCode.Name = "DesCode"
        Me.DesCode.Size = New System.Drawing.Size(229, 133)
        Me.DesCode.TabIndex = 14
        Me.DesCode.Text = ""
        Me.DesCode.Visible = False
        '
        'FileL
        '
        Me.FileL.Location = New System.Drawing.Point(585, 358)
        Me.FileL.Name = "FileL"
        Me.FileL.Size = New System.Drawing.Size(28, 22)
        Me.FileL.TabIndex = 15
        Me.FileL.Visible = False
        '
        'Datetxt
        '
        Me.Datetxt.AutoSize = True
        Me.Datetxt.Location = New System.Drawing.Point(408, 361)
        Me.Datetxt.Name = "Datetxt"
        Me.Datetxt.Size = New System.Drawing.Size(42, 17)
        Me.Datetxt.TabIndex = 16
        Me.Datetxt.Text = "Date:"
        Me.Datetxt.Visible = False
        '
        'manualCheck
        '
        Me.manualCheck.Location = New System.Drawing.Point(568, 12)
        Me.manualCheck.Name = "manualCheck"
        Me.manualCheck.Size = New System.Drawing.Size(40, 23)
        Me.manualCheck.TabIndex = 17
        Me.manualCheck.Text = "M"
        Me.manualCheck.UseVisualStyleBackColor = True
        Me.manualCheck.Visible = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(597, 244)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Manual"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Manual
        '
        Me.Manual.Location = New System.Drawing.Point(15, 31)
        Me.Manual.Name = "Manual"
        Me.Manual.Size = New System.Drawing.Size(423, 22)
        Me.Manual.TabIndex = 0
        '
        'SendManual
        '
        Me.SendManual.Location = New System.Drawing.Point(453, 31)
        Me.SendManual.Name = "SendManual"
        Me.SendManual.Size = New System.Drawing.Size(75, 23)
        Me.SendManual.TabIndex = 1
        Me.SendManual.Text = "Send"
        Me.SendManual.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Manual)
        Me.GroupBox2.Controls.Add(Me.SendManual)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(553, 77)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dos Command"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(620, 526)
        Me.Controls.Add(Me.manualCheck)
        Me.Controls.Add(Me.Datetxt)
        Me.Controls.Add(Me.FileL)
        Me.Controls.Add(Me.DesCode)
        Me.Controls.Add(Me.Date_Now)
        Me.Controls.Add(Me.mailData)
        Me.Controls.Add(Me.comSent)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.xNC2)
        Me.Controls.Add(Me.xNC1)
        Me.Controls.Add(Me.HC)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DESBF v1.03"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StartBF As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents HC As ComboBox
    Friend WithEvents xNC1 As ComboBox
    Friend WithEvents xNC2 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents hash As TextBox
    Friend WithEvents comSent As TextBox
    Friend WithEvents Restore As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Benchmark As Button
    Friend WithEvents saveInfo As Label
    Friend WithEvents clearMailConfig As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents M7 As TextBox
    Friend WithEvents saveMailData As Button
    Friend WithEvents M6 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents M5 As TextBox
    Friend WithEvents M4 As TextBox
    Friend WithEvents M3 As TextBox
    Friend WithEvents M2 As TextBox
    Friend WithEvents M1 As TextBox
    Friend WithEvents mailData As RichTextBox
    Friend WithEvents TimerSaveOK As Timer
    Friend WithEvents Log As RichTextBox
    Friend WithEvents fileCodCheck As Timer
    Friend WithEvents Date_Now As TextBox
    Friend WithEvents DesCode As RichTextBox
    Friend WithEvents FileL As TextBox
    Friend WithEvents Datetxt As Label
    Friend WithEvents manualCheck As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Manual As TextBox
    Friend WithEvents SendManual As Button
End Class
