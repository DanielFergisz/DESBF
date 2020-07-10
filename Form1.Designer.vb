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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.HC = New System.Windows.Forms.ComboBox()
        Me.NC1 = New System.Windows.Forms.ComboBox()
        Me.NC2 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(478, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 26)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Start BF"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 75)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
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
        'NC1
        '
        Me.NC1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NC1.FormattingEnabled = True
        Me.NC1.Items.AddRange(New Object() {"1", "2"})
        Me.NC1.Location = New System.Drawing.Point(325, 12)
        Me.NC1.Name = "NC1"
        Me.NC1.Size = New System.Drawing.Size(45, 24)
        Me.NC1.TabIndex = 3
        '
        'NC2
        '
        Me.NC2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NC2.FormattingEnabled = True
        Me.NC2.Location = New System.Drawing.Point(520, 12)
        Me.NC2.Name = "NC2"
        Me.NC2.Size = New System.Drawing.Size(45, 24)
        Me.NC2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(171, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Number of computers:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(441, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Select PC:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(74, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(374, 22)
        Me.TextBox1.TabIndex = 1
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 248)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NC2)
        Me.Controls.Add(Me.NC1)
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

    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents HC As ComboBox
    Friend WithEvents NC1 As ComboBox
    Friend WithEvents NC2 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
