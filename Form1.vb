Public Class Form1
    Private Sub StartBF_Click(sender As Object, e As EventArgs) Handles StartBF.Click
        Dim CommandX As String
        CommandX = HC.Text + " -m 1500 " + hash.Text + " -a 3 ?1?1?1?1?1?1?1?1 -1 ?l?u?d -2 ?l?u --outfile=_hash.txt --session des"
        Dim ksMax As String
        ksMax = "916132832"
        Dim ks2 As String
        ks2 = "458066416"
        Dim ks3 As String
        ks3 = "305377611"
        Dim ks31 As String
        ks31 = "610755222"

        If hash.Text.Length = 0 Then
            MsgBox("Please enter Hash !!")
        Else
            If xNC1.SelectedItem = "1" Then
                Process.Start("cmd", "/k " + CommandX)
                comSent.Text = CommandX
            End If

            If xNC1.SelectedItem = "2" And xNC2.SelectedItem = "1" Then
                Process.Start("cmd", "/k " + CommandX + " -s 0 -l " + ks2)
                comSent.Text = CommandX
            End If
            If xNC1.SelectedItem = "2" And xNC2.SelectedItem = "2" Then
                Process.Start("cmd", "/k " + CommandX + " -s " + ks2 + " -l " + ksMax)
                comSent.Text = CommandX
            End If

            If xNC1.SelectedItem = "3" And xNC2.SelectedItem = "1" Then
                Process.Start("cmd", "/k " + CommandX + " -s 0 -l " + ks3)
                comSent.Text = CommandX
            End If
            If xNC1.SelectedItem = "3" And xNC2.SelectedItem = "2" Then
                Process.Start("cmd", "/k " + CommandX + " -s " + ks3 + " -l " + ks31)
                comSent.Text = CommandX
            End If
            If xNC1.SelectedItem = "3" And xNC2.SelectedItem = "3" Then
                Process.Start("cmd", "/k " + CommandX + " -s " + ks31 + " -l " + ksMax)
                comSent.Text = CommandX
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
        If xNC1.SelectedItem = "3" Then
            xNC2.Items.Clear()
            xNC2.Items.Add("1")
            xNC2.Items.Add("2")
            xNC2.Items.Add("3")
            xNC2.SelectedItem = "1"
        End If
    End Sub

    Private Sub hash_TextChanged(sender As Object, e As EventArgs) Handles hash.TextChanged
        If hash.Text = "mobista" Then
            comSent.Visible = True
        End If
    End Sub
End Class
