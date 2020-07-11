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
        Me.StartBF = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.hash = New System.Windows.Forms.TextBox()
        Me.HC = New System.Windows.Forms.ComboBox()
        Me.xNC1 = New System.Windows.Forms.ComboBox()
        Me.xNC2 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.comSent = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StartBF
        '
        Me.StartBF.Location = New System.Drawing.Point(478, 27)
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 75)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "HASH:"
        '
        'hash
        '
        Me.hash.Location = New System.Drawing.Point(74, 27)
        Me.hash.Name = "hash"
        Me.hash.Size = New System.Drawing.Size(374, 22)
        Me.hash.TabIndex = 1
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
        Me.xNC1.Location = New System.Drawing.Point(316, 12)
        Me.xNC1.Name = "xNC1"
        Me.xNC1.Size = New System.Drawing.Size(45, 24)
        Me.xNC1.TabIndex = 3
        '
        'xNC2
        '
        Me.xNC2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xNC2.FormattingEnabled = True
        Me.xNC2.Location = New System.Drawing.Point(465, 12)
        Me.xNC2.Name = "xNC2"
        Me.xNC2.Size = New System.Drawing.Size(45, 24)
        Me.xNC2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(162, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Number of computers:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(386, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Select PC:"
        '
        'comSent
        '
        Me.comSent.Location = New System.Drawing.Point(21, 231)
        Me.comSent.Name = "comSent"
        Me.comSent.Size = New System.Drawing.Size(544, 22)
        Me.comSent.TabIndex = 10
        Me.comSent.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 191)
        Me.Controls.Add(Me.comSent)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.xNC2)
        Me.Controls.Add(Me.xNC1)
        Me.Controls.Add(Me.HC)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DECBF v1.00"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
End Class
