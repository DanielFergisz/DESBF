Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim CommandX As String
        CommandX = HC.Text + " -m 1500 " + hash.Text + " -a 3 ?1?1?1?1?1?1?1?1 -1 ?l?u?d -2 ?l?u --outfile=_hash.txt --session des"
        Dim ksMax As String
        ksMax = "916132832"

        If hash.Text.Length = 0 Then
            MsgBox("Please enter Hash !!")
        Else
            If xNC1.SelectedItem = "1" Then
                Process.Start("cmd", "/k " + CommandX)
                comSent.Text = CommandX
            End If
            If xNC1.SelectedItem = "2" And xNC2.SelectedItem = "1" Then
                Process.Start("cmd", "/k " + CommandX + " -s 0 -l " + cOne.Text)
            End If
            If xNC1.SelectedItem = "2" And xNC2.SelectedItem = "2" Then
                Process.Start("cmd", "/k " + CommandX + " -s " + cOne.Text + " -l " + ksMax)
            End If
        End If
        'hashcat -m 1500 UGCfzJmLNga36 -a 3 ?1?1?1?1?1?1?1?1 -1 ?l?u?d -2 ?l?u --outfile=_hash.txt --session des
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HC.SelectedItem = "hashcat"
        xNC1.SelectedItem = "1"
    End Sub

    Private Sub NC1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles xNC1.SelectedIndexChanged
        If xNC1.SelectedItem = "1" Then
            xNC2.Items.Clear()
        End If
        If xNC1.SelectedItem = "2" Then
            xNC2.Items.Clear()
            xNC2.Items.Add("1")
            xNC2.Items.Add("2")
            xNC2.SelectedItem = "1"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If xNC1.SelectedItem = "2" Then
            cOne.Text = 916132832 / 2
        End If
    End Sub
End Class
