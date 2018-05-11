Imports System.Net
Imports System.Net.Mail
Imports System.IO
Imports System.Text

Public Class MailGonderme
    Inherits TumMailler
    Private Sifreli_İcerik As String
    Private durum As Boolean


    Property Pro_durum
        Set(value)
            durum = value
        End Set
        Get
            Return durum
        End Get
    End Property
#Region "MailGonderme"
    Public Function mail_Varmi() As Boolean
        Connect()
        komut.CommandText = "SELECT * FROM Kullanici WHERE kullaniciAdi like '" & Pro_Email() & "'"
        bilgi = komut.ExecuteReader()
        If bilgi.Read() Then
            DisConnect()
            Return True
        Else
            DisConnect()
            Return False
        End If

    End Function

    Public Function mail_Kontrol() As Boolean
        Dim durumSayac As Byte
        Dim mailGonderen As String = Pro_Email()
        Dim sifre As String = Pro_Sifre()
        Dim smtpBicimi As String
        If mailGonderen.Contains("@") Then
            durumSayac = 1
        Else
            durumSayac = 0
        End If

        Dim mailArray() As String = mailGonderen.Split("@")

        If mailArray(durumSayac) = "gmail.com" Then
            smtpBicimi = "gmail.com"
        ElseIf mailArray(durumSayac) = "hotmail.com" Or mailArray(durumSayac) = "outlook.com" Or mailArray(durumSayac) = "outlook.com.tr" Then
            smtpBicimi = "live.com"
        ElseIf mailArray(durumSayac) = "yandex.com" Then
            smtpBicimi = "yandex.ru"
        ElseIf mailArray(durumSayac) = "trakya.edu.tr" Then
            smtpBicimi = "mail.trakya.edu.tr"

        Else
            smtpBicimi = mailArray(durumSayac)
        End If

        Try
            Dim mail As New MailMessage
            mail.Subject = "Kayıt Onaylama"
            mail.From = New MailAddress(mailGonderen)
            mail.To.Add("mebotadm@outlook.com")
            mail.Body = "Kayıt Oldum " & Pro_Ad & " " & Pro_Soyad
            If mailArray(durumSayac) = "trakya.edu.tr" Then
                Dim smtp As New SmtpClient(smtpBicimi)
                smtp.EnableSsl = False
                smtp.Credentials = New System.Net.NetworkCredential(mailGonderen, sifre)
                smtp.Port = "587"
                smtp.Host = smtpBicimi
                smtp.Send(mail)
            Else
                Dim smtp As New SmtpClient("smtp." & smtpBicimi)
                smtp.EnableSsl = True
                smtp.Credentials = New System.Net.NetworkCredential(mailGonderen, sifre)
                smtp.Port = "587"
                smtp.Host = "smtp." & smtpBicimi
                smtp.Send(mail)
            End If
            
            
            Return True
        Catch ex As Exception
            MessageBox.Show("Mail adresi veya şifre hatalıdır.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function mailGondermeIslemi() As Boolean
        Dim mailGonderen As String = Pro_Email()
        Dim sifre As String = Pro_Sifre()
        Dim smtpBicimi As String = ""
        Dim mailArray() As String = mailGonderen.Split("@")
        If mailArray(1) = "gmail.com" Then
            smtpBicimi = "gmail.com"
        ElseIf mailArray(1) = "hotmail.com" Or mailArray(1) = "outlook.com" Or mailArray(1) = "outlook.com.tr" Then
            smtpBicimi = "live.com"
        ElseIf mailArray(1) = "yandex.com" Then
            smtpBicimi = "yandex.ru"
        ElseIf mailArray(1) = "trakya.edu.tr" Then
            smtpBicimi = "mail.edu.tr"
        End If
        Try
            Dim mail As New MailMessage
            mail.Subject = Pro_Konu()
            mail.From = New MailAddress(mailGonderen)

            For i = 0 To kimlere.Length - 1
                mail.To.Add(kimlere(i))
            Next


            'sifreleme burda
            If durum Then
                Dim nesne As New Sifreleme
                Sifreli_İcerik = nesne.TestEncoding(icerik, "mebot74185296a")
                ' mail.Body = Pro_Icerik()
                mail.Body = Sifreli_İcerik
            Else
                mail.Body = Pro_Icerik()
            End If

            Dim smtp As New SmtpClient("smtp." & smtpBicimi)
            smtp.EnableSsl = True
            smtp.Credentials = New System.Net.NetworkCredential(mailGonderen, sifre)
            smtp.Port = "587"
            smtp.Host = "smtp." & smtpBicimi

            For Each d As String In dosyaListe
                mail.Attachments.Add(New Attachment(d))
            Next

            smtp.Send(mail)

            GonderilenMailVeriTabaninaEkle()


            dosyaKopyalama()



            Return True
        Catch ex As Exception
            MessageBox.Show("Mail Gönderilemedi.. " & ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    
    Public Function KisininGonderilenMailSayisi() As Integer
        Dim dondurulecekMailID = KullaniciIDDondur()
        Connect()
        komut.CommandText = "SELECT Count(*) FROM Mailbox where kullanici_No like '" & dondurulecekMailID & "' and durum_No=1"
        Dim Sayi As Integer = komut.ExecuteScalar()
        DisConnect()
        Return Sayi
    End Function
    Private Sub GonderilenMailVeriTabaninaEkle()
        Dim dondurulecekMailID = KullaniciIDDondur()
        For i = 0 To kimlere.Length - 1
            Connect()
            komut.CommandText = "INSERT INTO MailBox(durum_No,kullanici_No,gonderen,alici,konu,icerik,tarih) values('1','" & dondurulecekMailID & "','" & Pro_Email() & "','" & kimlere(i) & "','" & konu & "','" & icerik & "','" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & "')"
            komut.ExecuteNonQuery()
            DisConnect()
        Next
    End Sub

    Public Sub GonderilenleriGuncelle()
        Dim dondurulecekMailID = KullaniciIDDondur()
        Connect()
        komut.CommandText = "UPDATE Mailbox SET durum_No=3 where kullanici_No like '" & dondurulecekMailID & "' AND mailbox_ID like '" & mailBoxID & "'"
        komut.ExecuteNonQuery()
        DisConnect()
    End Sub

    Public Sub AliciGetir(ByVal lbl_alici As Label, ByVal lbl_tarih As Label, ByVal txt_konu As TextBox, ByVal rtxt_icerik As RichTextBox)

        Connect()
        komut.CommandText = "SELECT mailbox_ID,alici,konu,icerik,tarih FROM Mailbox where mailbox_ID like '" & mailBoxID & "'"
        bilgi = komut.ExecuteReader()
        bilgi.Read()
        lbl_alici.Text = bilgi("alici")
        lbl_tarih.Text = bilgi("tarih")
        txt_konu.Text = bilgi("konu")
        rtxt_icerik.Text = bilgi("icerik")
        DisConnect()
    End Sub
    Public Sub GonderenGetir(ByVal lbl_gonderen As Label, ByVal lbl_tarih As Label, ByVal txt_konu As TextBox, ByVal rtxt_icerik As RichTextBox)

        Connect()
        komut.CommandText = "SELECT mailbox_ID,gonderen,konu,icerik,tarih FROM Mailbox where mailbox_ID like '" & mailBoxID & "'"
        bilgi = komut.ExecuteReader()
        bilgi.Read()
        lbl_gonderen.Text = bilgi("gonderen")
        lbl_tarih.Text = bilgi("tarih")
        txt_konu.Text = bilgi("konu")
        rtxt_icerik.Text = bilgi("icerik")
        DisConnect()
    End Sub

#End Region

End Class
