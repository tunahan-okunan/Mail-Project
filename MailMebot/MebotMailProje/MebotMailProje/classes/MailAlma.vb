Imports System.Text.RegularExpressions
Public Class MailAlma
    Inherits TumMailler
    Dim nesne As New Sifreleme

    Public sGonderen As String
    Public sKonu As String
    Public sMetin As String
    Public sTarih As String
    Public smailSayisi As Integer
    Public karakterC As Char = Chr(226)

    Public karakterS As String = karakterC + karakterC + karakterC + karakterC + karakterC
    '#Region "Properties"
    '    Public Property sGonderen As String
    '        Set(value As String)
    '            value = Gonderen
    '        End Set
    '        Get
    '            Return Gonderen
    '        End Get
    '    End Property

    '    Public Property sKonu As String
    '        Set(value As String)
    '            value = Konu
    '        End Set
    '        Get
    '            Return Konu
    '        End Get
    '    End Property
    
    '    Public Property sTarih As String
    '        Set(value As String)
    '            value = Tarih
    '        End Set
    '        Get
    '            Return Tarih
    '        End Get
    '    End Property
    '#End Region

    Public Sub GelenMailVeriTabaninaEkle()

        Dim d As Date
        Dim dondurulecekMailID = KullaniciIDDondur()

        If sTarih.Contains("-") Then
            Dim str() As String = sTarih.Split("-")
            d = str(0).TrimEnd()
        Else
            d = sTarih
        End If


        Connect()
        If nesne.ciphertxt <> Nothing Then
            If nesne.ciphertxt.Contains(Chr(226)) Then
                komut.CommandText = "INSERT INTO MailBox(durum_No,kullanici_No,gonderen,alici,konu,icerik,tarih) values ('2','" & dondurulecekMailID & "','" & sGonderen & "','" & Pro_Email & "','" & sKonu & "','" & kontrol(Pro_Sifİcerik) & "','" & d.ToString("yyyy-MM-dd HH:mm:ss") & "')"
            End If
        Else
            komut.CommandText = "INSERT INTO MailBox(durum_No,kullanici_No,gonderen,alici,konu,icerik,tarih) values ('2','" & dondurulecekMailID & "','" & sGonderen & "','" & Pro_Email & "','" & sKonu & "','" & kontrol(sMetin) & "','" & d.ToString("yyyy-MM-dd HH:mm:ss") & "')"
        End If
        komut.ExecuteNonQuery()
        DisConnect()
    End Sub

    Public Function GelenMailBoxID() As Integer
        Connect()
        komut.CommandText = "select TOP 1 mailbox_ID from MailBox order by mailbox_ID desc "
        bilgi = komut.ExecuteReader()
        bilgi.Read()
        Dim al As Integer = bilgi("mailbox_ID")
        DisConnect()
        Return al
    End Function

    Public Sub DosyaAdiMailIDEkle(ByVal ad As String, ByVal uzanti As String, ByVal mailID As Integer)
        Connect()
        komut.CommandText = "INSERT INTO Dosyalar(dosyaAdi,dosyaUzantisi,mail_ID) values ('" & ad & "','" & uzanti & "','" & mailID & "')"
        komut.ExecuteNonQuery()
        DisConnect()
    End Sub
    Public Function MailSayisiniDondur()
        Connect()
        komut.CommandText = "Select mailSayisi from Kullanici where kullaniciAdi like '" & Pro_Email & "'"
        bilgi = komut.ExecuteReader()
        bilgi.Read()
        Dim dondurulecekMailSayisi As Integer = bilgi("mailSayisi").ToString()
        DisConnect()
        Return dondurulecekMailSayisi
    End Function
    Public Sub mailSayisiEkle()
        Connect()
        komut.CommandText = "UPDATE Kullanici set mailSayisi = '" & smailSayisi & "' where kullaniciAdi = '" & Pro_Email & "'"
        komut.ExecuteNonQuery()
        DisConnect()
    End Sub
    Public Function kullaniciDurumuAl()
        Connect()
        komut.CommandText = "Select kulDurum from Kullanici where kullaniciAdi like '" & Pro_Email & "'"
        bilgi = komut.ExecuteReader()
        bilgi.Read()
        Dim durum As Integer = bilgi("kulDurum").ToString()
        DisConnect()
        Return durum
    End Function
    Public Sub kullaniciDurumuDegistir()
        Connect()
        komut.CommandText = "UPDATE Kullanici set kulDurum = '" & 0 & "' where kullaniciAdi = '" & Pro_Email & "'"
        komut.ExecuteNonQuery()
        DisConnect()
    End Sub
    Function htmltotext(ByVal source As String) As String
        Dim out As String
        out = Regex.Replace(source, "<[^>]*>", String.Empty)
        out = Regex.Replace(out, "^\s*$\n", String.Empty, RegexOptions.Multiline)
        Return out
    End Function
    Function kontrol(ByVal source As String) As String
        Dim ayrac() As String = Pro_Email.Split("@")
        Dim str() As String
        If sMetin.Contains(">") Then
            str = source.Split(">")
            If ayrac(1) = "outlook.com" Or ayrac(1) = "hotmail.com" Then
                source = str(1) & ">" & str(2) & ">"
            ElseIf ayrac(1) = "yandex.com" Then
                source = str(1) & ">" & str(2)
            End If
        End If

        Return htmltotext(source)

    End Function

    Public Function VTdenMailIcerikCekme(ByVal index As DataGridView) As String
        Dim str As String
        str = index.CurrentRow.Cells(1).Value ' tıkladığım satırın konusunu alıyor
        Connect()
        komut.CommandText = "Select icerik from MailBox where konu like '" & str & "' and durum_No = '2'"
        bilgi = komut.ExecuteReader()
        bilgi.Read()
        Dim durum As String = bilgi("icerik").ToString()
        Return durum

    End Function
    Public Sub VTMailCek(ByVal dgv As DataGridView)
        Connect()
        komut.CommandText = "Select mailbox_ID,gonderen,konu,icerik,tarih from MailBox where alici like '" & Pro_Email & "' and   durum_No = '2'"
        adapter = New SqlClient.SqlDataAdapter(komut.CommandText, komut.Connection)
        Dim tb As DataTable = New DataTable()
        adapter.Fill(tb)
        dgv.DataSource = tb
    End Sub
    'Sub VTDosyaEkle()
    '    Dim dondurulecekMailID = KullaniciIDDondur()
    '    Connect()
    '    komut.CommandText = "INSERT INTO Dosyalar(dosyaAdi,mail_ID,dosyaUzantisi) values ('" & frm_mailGelen.dosyaAdlari(1) & "',,)"
    '    komut.ExecuteNonQuery()
    '    DisConnect()
    'End Sub

    Public Sub GelenleriGuncelle()
        Dim dondurulecekMailID = KullaniciIDDondur()
        Connect()
        komut.CommandText = "UPDATE Mailbox SET durum_No=3 where kullanici_No like '" & dondurulecekMailID & "' AND mailbox_ID like '" & mailBoxID & "'"
        komut.ExecuteNonQuery()
        DisConnect()
    End Sub

    Public Function GelenMaillerinSayisi() As Integer
        Dim dondurulecekMailID = KullaniciIDDondur()
        Connect()
        komut.CommandText = "SELECT Count(*) FROM Mailbox where kullanici_No like '" & dondurulecekMailID & "' and durum_No=2"
        Dim Sayi As Integer = komut.ExecuteScalar()
        DisConnect()
        Return Sayi

    End Function
    Public Function VTdenTarihCek() As String
        Connect()
        komut.CommandText = "Select tarih from MailBox where konu like '" & frm_GelenKutusuDetay.konuGec & "' and   gonderen like '" & frm_GelenKutusuDetay.gonderenGec & "'"
        Dim tarih As String = komut.ExecuteScalar()
        DisConnect()
        Return tarih
    End Function
End Class

