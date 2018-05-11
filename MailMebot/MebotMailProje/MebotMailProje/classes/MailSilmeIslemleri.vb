Imports System.IO
Public Class MailSilmeIslemleri
    Inherits TumMailler
#Region "Silme İşlemi"
    Public Sub SilinenlerMailSil()
        Dim dondurulecekMailID = KullaniciIDDondur()
        Connect()
        komut.CommandText = "DELETE FROM Mailbox where kullanici_No like '" & dondurulecekMailID & "' AND mailbox_ID like '" & mailBoxID & "'"
        komut.ExecuteNonQuery()
        DisConnect()
    End Sub


    Public Function SilinenlerinSayisi() As Integer
        Dim dondurulecekMailID = KullaniciIDDondur()
        Connect()
        komut.CommandText = "SELECT Count(*) FROM Mailbox where kullanici_No like '" & dondurulecekMailID & "' and durum_No=3"
        Dim Sayi As Integer = komut.ExecuteScalar()
        DisConnect()
        Return Sayi
    End Function
    Public Sub SilinenlerDosyaSil()
        Connect()
        komut.CommandText = "DELETE FROM Dosyalar where mail_ID like '" & mailBoxID & "'"
        komut.ExecuteNonQuery()
        DisConnect()
    End Sub

    Public Sub ArkaplanDosyaSil()
        Connect()
        komut.CommandText = "SELECT dosyaUzantisi FROM Dosyalar where mail_ID like '" & mailBoxID & "'"
        bilgi = komut.ExecuteReader()
        While bilgi.Read()
            Dim str As String = bilgi("dosyaUzantisi")
            File.Delete(str)
        End While
        DisConnect()
    End Sub


#End Region
End Class
