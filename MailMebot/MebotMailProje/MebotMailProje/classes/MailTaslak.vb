Public Class MailTaslak
    Inherits TumMailler
#Region "Taslak İşlemieri"

    Public Sub TaslakEkle()
        Dim dondurulecekMailID = KullaniciIDDondur()
        For i = 0 To kimlere.Length - 1
            Connect()
            komut.CommandText = "INSERT INTO MailBox(durum_No,kullanici_No,gonderen,alici,konu,icerik,tarih) values('4','" & dondurulecekMailID & "','" & Pro_Email() & "','" & kimlere(i) & "','" & konu & "','" & icerik & "','" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & "')"
            komut.ExecuteNonQuery()
            DisConnect()
        Next
    End Sub


    Public Function taslakSayisi() As Integer
        Dim dondurulecekMailID = KullaniciIDDondur()
        Connect()
        komut.CommandText = "SELECT Count(*) FROM Mailbox where kullanici_No like '" & dondurulecekMailID & "' and durum_No=4"
        Dim Sayi As Integer = komut.ExecuteScalar()
        DisConnect()
        Return Sayi
    End Function

    Public Sub taslakYazdir(ByVal txt_konu As TextBox, ByVal txt_kime As TextBox, ByVal rtxt_icerik As RichTextBox)
        Connect()
        komut.CommandText = "SELECT mailbox_ID,alici,konu,icerik,tarih FROM Mailbox where mailbox_ID like '" & mailBoxID & "' and durum_No=4"
        bilgi = komut.ExecuteReader()
        bilgi.Read()
        txt_kime.Text = bilgi("alici")
        txt_konu.Text = bilgi("konu")
        rtxt_icerik.Text = bilgi("icerik")
        DisConnect()
    End Sub

    Public Sub taslakSil()
        Dim dondurulecekMailID = KullaniciIDDondur()
        Connect()
        komut.CommandText = "DELETE FROM Mailbox where kullanici_No like '" & dondurulecekMailID & "' AND mailbox_ID like '" & mailBoxID & "' and durum_No=4"
        komut.ExecuteNonQuery()
        DisConnect()
    End Sub
#End Region
End Class
