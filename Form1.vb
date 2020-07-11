Imports System.IO
Imports System.Net
Imports System.Net.Mail

Public Class Form1
    Private Sub StartBF_Click(sender As Object, e As EventArgs) Handles StartBF.Click
        Date_Now.Text = Date.Today
        Dim CommandX As String
        CommandX = HC.Text + " -m 1500 " + hash.Text + " -a 3 ?1?1?1?1?1?1?1?1 -1 ?l?u?d -2 ?l?u --outfile=DES_Code\" + Date_Now.Text + "_" + FileL.Text + "_Code.txt - -session des"
        Dim ksMax As String = "916132832"
        Dim ks2 As String = "458066416"
        Dim ks3 As String = "305377611"
        Dim ks31 As String = "610755222"

        If hash.Text.Length = 0 Then
            MsgBox("Please enter Hash !!")
        Else
            If xNC1.SelectedItem = "1" Then
                Process.Start("cmd", "/k " + CommandX)
                comSent.Text = CommandX
            End If

            If xNC1.SelectedItem = "2" And xNC2.SelectedItem = "1" Then
                Process.Start("cmd", "/k " + CommandX + " -s 0 -l " + ks2)
                comSent.Text = CommandX + " -s 0 -l " + ks2
            End If
            If xNC1.SelectedItem = "2" And xNC2.SelectedItem = "2" Then
                Process.Start("cmd", "/k " + CommandX + " -s " + ks2 + " -l " + ksMax)
                comSent.Text = CommandX + " -s " + ks2 + " -l " + ksMax
            End If

            If xNC1.SelectedItem = "3" And xNC2.SelectedItem = "1" Then
                Process.Start("cmd", "/k " + CommandX + " -s 0 -l " + ks3)
                comSent.Text = CommandX + " -s 0 -l " + ks3
            End If
            If xNC1.SelectedItem = "3" And xNC2.SelectedItem = "2" Then
                Process.Start("cmd", "/k " + CommandX + " -s " + ks3 + " -l " + ks31)
                comSent.Text = CommandX + " -s " + ks3 + " -l " + ks31
            End If
            If xNC1.SelectedItem = "3" And xNC2.SelectedItem = "3" Then
                Process.Start("cmd", "/k " + CommandX + " -s " + ks31 + " -l " + ksMax)
                comSent.Text = CommandX + " -s " + ks31 + " -l " + ksMax
            End If
        End If
        If M1.Text.Length = 0 Or M2.Text.Length = 0 Or M3.Text.Length = 0 Or M4.Text.Length = 0 Or M5.Text.Length = 0 Or M6.Text.Length = 0 Or M7.Text.Length = 0 Then
        Else
            fileCodCheck.Enabled = True
        End If
        'hashcat -m 1500 UGCfzJmLNga36 -a 3 ?1?1?1?1?1?1?1?1 -1 ?l?u?d -2 ?l?u --outfile=_hash.txt --session des
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HC.SelectedItem = "hashcat"
        xNC1.SelectedItem = "1"
        If Directory.Exists("DES_Code") Then
        Else
            Directory.CreateDirectory("DES_Code")
        End If
        If My.Computer.FileSystem.FileExists("Mail_Data.tds") Then
            mailData.LoadFile("Mail_Data.tds", RichTextBoxStreamType.PlainText)
            M1.Text = mailData.Lines(0)
            M2.Text = mailData.Lines(1)
            M3.Text = mailData.Lines(2)
            M4.Text = mailData.Lines(3)
            M5.Text = mailData.Lines(4)
            M6.Text = mailData.Lines(5)
            M7.Text = mailData.Lines(6)
        End If
        Dim FileNo As Integer = Directory.GetFiles("DES_Code").Length
        FileL.Text = FileNo + 1
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
            Datetxt.Visible = True
            Date_Now.Visible = True
            DesCode.Visible = True
            FileL.Visible = True
            mailData.Visible = True
            hash.Clear()
        End If
    End Sub

    Private Sub Restore_Click(sender As Object, e As EventArgs) Handles Restore.Click
        Process.Start("cmd", "/k " + HC.Text + " --session=des --restore")
    End Sub

    Private Sub Benchmark_Click(sender As Object, e As EventArgs) Handles Benchmark.Click
        Process.Start("cmd", "/k " + HC.Text + " -b")
    End Sub

    Private Sub saveMailData_Click(sender As Object, e As EventArgs) Handles saveMailData.Click
        If M1.Text.Length = 0 Or M2.Text.Length = 0 Or M3.Text.Length = 0 Or M4.Text.Length = 0 Or M5.Text.Length = 0 Or M6.Text.Length = 0 Or M7.Text.Length = 0 Then
            MsgBox("Please check all textbox !!")
        Else
            If My.Computer.FileSystem.FileExists("Mail_Data.tds") Then
                My.Computer.FileSystem.DeleteFile("Mail_Data.tds")
                My.Computer.FileSystem.WriteAllText("Mail_Data.tds", M1.Text + vbCrLf + M2.Text + vbCrLf + M3.Text + vbCrLf + M4.Text + vbCrLf + M5.Text + vbCrLf + M6.Text + vbCrLf + M7.Text, True)
                mailData.Clear()
                mailData.LoadFile("Mail_Data.tds", RichTextBoxStreamType.PlainText)
                TimerSaveOK.Enabled = True
                saveInfo.Visible = True
            Else
                My.Computer.FileSystem.WriteAllText("Mail_Data.tds", M1.Text + vbCrLf + M2.Text + vbCrLf + M3.Text + vbCrLf + M4.Text + vbCrLf + M5.Text + vbCrLf + M6.Text + vbCrLf + M7.Text, True)
                mailData.Clear()
                mailData.LoadFile("Mail_Data.tds", RichTextBoxStreamType.PlainText)
                TimerSaveOK.Enabled = True
                saveInfo.Visible = True
            End If
        End If
    End Sub

    Private Sub TimerSaveOK_Tick(sender As Object, e As EventArgs) Handles TimerSaveOK.Tick
        TimerSaveOK.Enabled = False
        saveInfo.Visible = False
    End Sub

    Private Sub clearMailConfig_Click(sender As Object, e As EventArgs) Handles clearMailConfig.Click
        If My.Computer.FileSystem.FileExists("Mail_Data.tds") Then
            My.Computer.FileSystem.DeleteFile("Mail_Data.tds")
            mailData.Clear()
            M1.Clear()
            M2.Clear()
            M3.Clear()
            M4.Clear()
            M5.Clear()
            M6.Clear()
            M7.Clear()
        Else
        End If
    End Sub

    Private Sub fileCodCheck_Tick(sender As Object, e As EventArgs) Handles fileCodCheck.Tick
        If My.Computer.FileSystem.FileExists("DES_Code\" + Date_Now.Text + "_" + FileL.Text + "_Code.txt") Then
            fileCodCheck.Enabled = False

            '***********************************************************************************************************************
            Try
                Dim mailfrom As New MailAddress(M1.Text, "DESBF") ' adres mail do wysyłki + nazwa
                Dim mailto As New MailAddress(M2.Text, "BM") ' adres docelowy + nazwa
                Dim message As New MailMessage(mailfrom, mailto)
                Dim smtp As New SmtpClient(M3.Text) 'serwer smtp
                Dim zaloncznik As String
                zaloncznik = "DES_Code\" + Date_Now.Text + "_" + FileL.Text + "_Code.txt" 'nazwa pliku
                If File.Exists(zaloncznik) Then
                    Dim data As New Attachment(zaloncznik)
                    message.Attachments.Add(data)
                End If

                message.Subject = M6.Text 'temat wiadomości


                message.BodyEncoding = System.Text.Encoding.UTF8
                message.Body = M7.Text 'tekst wiadomości

                smtp.Credentials = New NetworkCredential(M4.Text, M5.Text) 'login i hasło

                smtp.DeliveryMethod = SmtpDeliveryMethod.Network

                smtp.Send(message)

                Log.AppendText(Environment.NewLine)
                Log.AppendText(Environment.NewLine + "Mail has been sent")


            Catch ex As SmtpException
                Log.AppendText(Environment.NewLine + ex.Message)
            End Try

            DesCode.LoadFile("DES_Code\" + Date_Now.Text + "Code.txt", RichTextBoxStreamType.PlainText)
            Log.AppendText(Environment.NewLine + "Reading data...")
            Log.AppendText(Environment.NewLine)
            Log.AppendText(Environment.NewLine + "Master Code: ")
            Log.SelectionColor = Color.DarkBlue
            Log.AppendText(Mid(DesCode.Text, 66, 10))
            Log.SelectionColor = Color.Empty
            Log.AppendText(Environment.NewLine + "Hash: " + Mid(DesCode.Text, 1, 40))

        Else

        End If
    End Sub
End Class
