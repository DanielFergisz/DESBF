Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'hashcat -m 1500 3.3eTrJawunXI -a 3 ?1?1?1?1?1?1?1?1 -1 ?l?u?d -2 ?l?u --outfile=_hash.txt --session des
        'hashcat -m 1500 UGCfzJmLNga36 -a 3 ?1?1?1?1?1?1?1?1 -1 ?l?u?d -2 ?l?u --outfile=_hash.txt --session des
        'hashcat --keyspace -a 3 ?l?l?l?l?l?l?l?l (Dla DEC)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HC.SelectedItem = "hashcat"
        NC1.SelectedItem = "1"
    End Sub

    Private Sub NC1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NC1.SelectedIndexChanged
        If NC1.SelectedItem = "1" Then
            NC2.Items.Clear()
        End If
        If NC1.SelectedItem = "2" Then
            NC2.Items.Clear()
            NC2.Items.Add("1")
            NC2.Items.Add("2")
            NC2.SelectedItem = "1"
        End If
    End Sub
End Class
