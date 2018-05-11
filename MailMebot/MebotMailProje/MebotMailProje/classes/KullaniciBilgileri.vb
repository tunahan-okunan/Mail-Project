
Public Class KullaniciBilgileri
    Inherits SqlDB
    Implements IKullaniciBilgileri
    Private Shared Email As String
    Private Shared Sifre As String
    Private Shared Ad As String
    Private Shared Soyad As String
    Private DogumTarihi As String
    Public Property Pro_Ad As String Implements IKullaniciBilgileri.Pro_Ad
        Set(value As String)
            Ad = value
        End Set
        Get
            Return Ad
        End Get
    End Property
    Public Property Pro_DogumTarihi As String Implements IKullaniciBilgileri.Pro_DogumTarihi
        Set(value As String)
            DogumTarihi = value
        End Set
        Get
            Return DogumTarihi
        End Get
    End Property
    Public Property Pro_Email As String Implements IKullaniciBilgileri.Pro_Email
        Set(value As String)
            Email = value
        End Set
        Get
            Return Email
        End Get
    End Property
    Public Property Pro_Sifre As String Implements IKullaniciBilgileri.Pro_Sifre
        Set(value As String)
            Sifre = value
        End Set
        Get
            Return Sifre
        End Get
    End Property
    Public Property Pro_Soyad As String Implements IKullaniciBilgileri.Pro_Soyad
        Set(value As String)
            Soyad = value
        End Set
        Get
            Return Soyad
        End Get
    End Property
    'Veri tabanına bilgileri ekledik
    Public Sub Kullanici_Ekle()
        MyBase.Connect()
        MyBase.komut.CommandText = "INSERT INTO Kullanici(kullaniciAdi,sifre,ad,soyad,dogumTarihi) values('" & Email & "','" & Sifre & "','" & Ad & "','" & Soyad & "','" & DogumTarihi & "')"
        MyBase.komut.ExecuteNonQuery()
        MyBase.DisConnect()
    End Sub
    'beni hatırla ile mail adresi getiriyor 
    Public Function BeniHatirla_Kullanici() As String
        MyBase.Connect()
        MyBase.komut.CommandText = "SELECT * FROM Kullanici"
        MyBase.bilgi = MyBase.komut.ExecuteReader()
        While bilgi.Read()
            Dim drm As Boolean = bilgi("durum").ToString()
            If drm Then
                Dim mail As String
                mail = bilgi("kullaniciAdi").ToString()
                MyBase.DisConnect()
                Return mail
            End If
        End While

        MyBase.DisConnect()
        Return False
    End Function
    'beni hatırla ile şifre getiriyor
    Public Function BeniHatirla_Sifre() As String
        MyBase.Connect()
        MyBase.komut.CommandText = "SELECT * FROM Kullanici"
        MyBase.bilgi = MyBase.komut.ExecuteReader()
        While bilgi.Read()
            Dim sfr As Boolean = bilgi("durum").ToString()
            If sfr Then
                Dim sifre As String
                sifre = bilgi("sifre").ToString()
                MyBase.DisConnect()
                Return sifre
            End If
        End While

        MyBase.DisConnect()
        Return False
    End Function
    Public Function BeniHatirla_kullaniciID() As String
        'kullanici dondurme işlemi
        MyBase.Connect()
        MyBase.komut.CommandText = "SELECT * FROM Kullanici"
        MyBase.bilgi = MyBase.komut.ExecuteReader()
        While bilgi.Read()
            Dim drm As Boolean = bilgi("durum").ToString
            If drm Then
                Dim kID As String
                kID = bilgi("kullanici_ID").ToString
                MyBase.DisConnect()
                Return kID
            End If
        End While
        MyBase.DisConnect()
        Return False
    End Function
    Public Sub BeniHatırla_Update() 'diğer true olanlar false yapıldı
        'kullaniciID gore güncelleme işlemi

        If Not BeniHatirla_kullaniciID() = "False" Then
            Dim KID As Integer = BeniHatirla_kullaniciID()
            MyBase.Connect()
            MyBase.komut.CommandText = "Update Kullanici set durum = 'False' where kullanici_ID ='" & KID & "'"
            MyBase.komut.ExecuteNonQuery()
            MyBase.DisConnect()

        End If
    End Sub

    Public Function Kullanici_GirisYap_Secili(ByVal mail As String, ByVal sifre As String)
        'kullanici giris yapma işlemi beni hatırla secili ise
        MyBase.Connect()
        MyBase.komut.CommandText = "SELECT * FROM Kullanici where kullaniciAdi like '" & mail & "' and sifre like '" & sifre & "'"
        MyBase.bilgi = MyBase.komut.ExecuteReader()
        If bilgi.Read() Then
            MyBase.DisConnect()

            'burda secilen kişidurumu true yapılıyor
            MyBase.Connect()
            MyBase.komut.CommandText = "Update Kullanici set durum ='True' where kullaniciAdi like '" & mail & "' and sifre like '" & sifre & "'"
            MyBase.komut.ExecuteNonQuery()
            MyBase.DisConnect()
            Return True
        Else
            MyBase.DisConnect()
            Return False
        End If

    End Function

    Public Function Kullanici_GirisYap(ByVal mail As String, ByVal sifre As String)


        'eğer secili degilse giriş yap,
        MyBase.Connect()
        MyBase.komut.CommandText = "SELECT * FROM Kullanici where kullaniciAdi like '" & mail & "' and sifre like '" & sifre & "'"
        MyBase.bilgi = MyBase.komut.ExecuteReader()
        If bilgi.Read() Then
            Dim drm As Boolean = bilgi("durum").ToString
            MyBase.DisConnect()
            If drm Then
                'durum true ise durum false yapıyoruz guncellıyoruz
                MyBase.Connect()
                MyBase.komut.CommandText = "Update Kullanici set durum='False' where kullaniciAdi like '" & mail & "' and sifre like '" & sifre & "'"
                MyBase.komut.ExecuteNonQuery()
                MyBase.DisConnect()

            End If
            Return True
        Else
            MyBase.DisConnect()
            Return False
        End If
    End Function
    Protected Function KullaniciIDDondur()
        Connect()
        komut.CommandText = "Select kullanici_ID from Kullanici where kullaniciAdi like '" & Pro_Email & "'"
        bilgi = komut.ExecuteReader()
        bilgi.Read()
        Dim dondurulecekID As Integer = bilgi("kullanici_ID").ToString()
        DisConnect()
        Return dondurulecekID
    End Function



    Public Function VTDENisimSoyisimGetir() As String
        Connect()
        komut.CommandText = "Select ad,soyad from Kullanici where durum = 'True'"
        bilgi = komut.ExecuteReader()
        bilgi.Read()
        Dim isimsoyisim As String = bilgi("ad").ToString() & " " & bilgi("soyad").ToString()
        DisConnect()
        Return isimsoyisim
    End Function
    Public Sub VTMailSayisiGuncelle(mailsay As Integer)
        MyBase.Connect()
        MyBase.komut.CommandText = "Update Kullanici Set durum = 'True ' where mailSayisi = '" & mailsay & "'"
        MyBase.komut.ExecuteNonQuery()
        MyBase.DisConnect()

    End Sub

End Class
