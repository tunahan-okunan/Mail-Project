Imports System.IO
Imports System.Text

Public Class TumMailler
    Inherits KullaniciBilgileri
    Implements IMailGonderme
    Protected Shared konu As String
    Protected Shared icerik As String
    Protected Shared kimlere(1) As String
    Protected Shared dosyaListe As List(Of String) = New List(Of String)()
    Protected Shared dosyaAdiListe As List(Of String) = New List(Of String)()
    Protected Shared mailBoxID As Integer
    Protected Shared Sifİcerik As String

#Region "Properties"

    Public Property Pro_Icerik As String Implements IMailGonderme.Pro_Icerik
        Set(value As String)
            icerik = value
        End Set
        Get
            Return icerik
        End Get
    End Property
    Public Property Pro_Sifİcerik As String Implements IMailGonderme.Pro_Sifİcerik
        Set(value As String)
            Sifİcerik = value
        End Set
        Get
            Return Sifİcerik
        End Get
    End Property


    Public Property Pro_Konu As String Implements IMailGonderme.Pro_Konu
        Set(value As String)
            konu = value
        End Set
        Get
            Return konu
        End Get
    End Property

    Public Property pro_dosyaListe() As List(Of String)
        Set(value As List(Of String))
            dosyaListe = value
        End Set
        Get
            Return dosyaListe
        End Get
    End Property

    Public Property pro_dosyaAdiListe() As List(Of String)
        Set(value As List(Of String))
            dosyaAdiListe = value
        End Set
        Get
            Return dosyaAdiListe
        End Get
    End Property

    Public Sub kimlere_set(ByRef d() As String)
        ReDim kimlere(d.Length - 1)
        For index = 0 To d.Length - 1
            kimlere(index) = d(index)
        Next
    End Sub

    Public Function kimlere_get() As String()
        Return kimlere
    End Function


    WriteOnly Property Pro_mailBoxID
        Set(value)
            mailBoxID = value
        End Set
    End Property
#End Region
#Region "Dosya"
    Public Function simdiki_tarihi_getir() As String
        Dim tarih As New StringBuilder(DateTime.Now)

        For index = 0 To tarih.Length - 1
            If tarih(index) = ":" Or tarih(index) = "." Then
                tarih(index) = "-"
            End If
        Next
        Return tarih.ToString()
    End Function
    Public Sub dosyaVeritabaninaYazdir(ByVal dosyaAdi As String, ByVal dosyaUzantisi As String)
        Dim mailBoxID() As Integer = MailBoxIDDondur()
        For index = 0 To mailBoxID.Length - 1
            Connect()
            komut.CommandText = "INSERT INTO Dosyalar(dosyaAdi,dosyaUzantisi,mail_ID) values('" & dosyaAdi & "', '" & dosyaUzantisi & "','" & mailBoxID(index) & "')"
            komut.ExecuteNonQuery()
            DisConnect()
        Next
    End Sub

    Public Sub dosyaKopyalama()
        Dim uzanti As String
        For Each dl As String In dosyaListe
            For Each dal As String In dosyaAdiListe
                If dl.Contains(dal) Then
                    If dal.Contains("png") Or dal.Contains("jpg") Or dal.Contains("ico") Or dal.Contains("PNG") Or dal.Contains("JPG") Or dal.Contains("ICO") Then
                        If File.Exists("dosyalar/resimler/" & dal) Then
                            Dim str As String = dal

                            dal = simdiki_tarihi_getir() & str
                            File.Copy(dl, "dosyalar/resimler/" & dal)
                            uzanti = "dosyalar/resimler/" & dal
                            dosyaVeritabaninaYazdir(dal, uzanti)
                        Else
                            File.Copy(dl, "dosyalar/resimler/" & dal)
                            uzanti = "dosyalar/resimler/" & dal
                            dosyaVeritabaninaYazdir(dal, uzanti)
                        End If
                    ElseIf dal.Contains("doc") Or dal.Contains("docx") Or dal.Contains("txt") Or dal.Contains("xlsx") Or dal.Contains("pptx") Or dal.Contains("pptm") Or dal.Contains("pdf") Then
                        If File.Exists("dosyalar/word/" & dal) Then
                            Dim str As String = dal
                            dal = simdiki_tarihi_getir() & str
                            File.Copy(dl, "dosyalar/word/" & dal)
                            uzanti = "dosyalar/word/" & dal
                            dosyaVeritabaninaYazdir(dal, uzanti)
                        Else
                            File.Copy(dl, "dosyalar/word/" & dal)
                            uzanti = "dosyalar/word/" & dal
                            dosyaVeritabaninaYazdir(dal, uzanti)
                        End If
                    ElseIf dal.Contains("mp3") Or dal.Contains("mp4") Or dal.Contains("avi") Or dal.Contains("wav") Or dal.Contains("flv") Or dal.Contains("ts") Or dal.Contains("TS") Or dal.Contains("MP4") Or dal.Contains("mov") Or dal.Contains("MKV") Then
                        If File.Exists("dosyalar/videolar/" & dal) Then
                            Dim str As String = dal
                            dal = simdiki_tarihi_getir() & str
                            File.Copy(dl, "dosyalar/videolar/" & dal)
                            uzanti = "dosyalar/videolar/" & dal
                            dosyaVeritabaninaYazdir(dal, uzanti)
                        Else
                            File.Copy(dl, "dosyalar/videolar/" & dal)
                            uzanti = "dosyalar/videolar/" & dal
                            dosyaVeritabaninaYazdir(dal, uzanti)

                        End If
                    ElseIf dal.Contains("zip") Or dal.Contains("rar") Or dal.Contains("rar5") Or dal.Contains("ZIP") Or dal.Contains("RAR") Or dal.Contains("RAR5") Then
                        If File.Exists("dosyalar/rar/" & dal) Then
                            Dim str As String = dal
                            dal = simdiki_tarihi_getir() & str
                            File.Copy(dl, "dosyalar/rar/" & dal)
                            uzanti = "dosyalar/rar/" & dal
                            dosyaVeritabaninaYazdir(dal, uzanti)
                        Else
                            File.Copy(dl, "dosyalar/rar/" & dal)
                            uzanti = "dosyalar/rar/" & dal
                            dosyaVeritabaninaYazdir(dal, uzanti)
                        End If


                    Else
                        If File.Exists("dosyalar/diger/" & dal) Then
                            Dim str As String = dal
                            dal = simdiki_tarihi_getir() & str
                            File.Copy(dl, "dosyalar/diger/" & dal)
                            uzanti = "dosyalar/diger/" & dal
                            dosyaVeritabaninaYazdir(dal, uzanti)
                        Else
                            File.Copy(dl, "dosyalar/diger/" & dal)
                            uzanti = "dosyalar/diger/" & dal
                            dosyaVeritabaninaYazdir(dal, uzanti)
                        End If


                    End If

                End If
            Next
        Next

    End Sub
    Public Sub DosyaGetir(ByVal dgv As DataGridView)
        Dim kolon1 As DataGridViewImageColumn = New DataGridViewImageColumn()
        dgv.Columns.Add(kolon1)
        Dim i As Integer = 0
        Connect()
        komut.CommandText = "SELECT dosyaAdi,dosyaUzantisi from Dosyalar where mail_ID like '" & mailBoxID & "'"
        bilgi = komut.ExecuteReader()
        While bilgi.Read()
            dgv.Rows.Add()
            dgv.Rows(i).Cells(0).Value = bilgi("dosyaUzantisi").ToString()
            dgv.Rows(i).Cells(1).Value = bilgi("dosyaAdi").ToString()

            If bilgi("dosyaUzantisi").ToString().Contains("resimler") Then
                dgv.Rows(i).Cells(2).Value = Image.FromFile("dosyaIcon/picture.png")
            End If
            If bilgi("dosyaUzantisi").ToString().Contains("word") Then
                dgv.Rows(i).Cells(2).Value = Image.FromFile("dosyaIcon/doc.png")
            End If
            If bilgi("dosyaUzantisi").ToString().Contains("videolar") Then
                dgv.Rows(i).Cells(2).Value = Image.FromFile("dosyaIcon/video.png")
            End If
            If bilgi("dosyaUzantisi").ToString().Contains("rar") Then
                dgv.Rows(i).Cells(2).Value = Image.FromFile("dosyaIcon/rar.png")
            End If
            If bilgi("dosyaUzantisi").ToString().Contains("diger") Then
                dgv.Rows(i).Cells(2).Value = Image.FromFile("dosyaIcon/folder.png")
            End If


            i += 1

        End While
        DisConnect()

    End Sub
#End Region
    Protected Function MailBoxIDDondur() As Integer()

        Dim dondurulecekkullaniciID = KullaniciIDDondur()
        Dim dizi(1) As Integer
        Dim i As Integer = 0
        Connect()
        komut.CommandText = "Select TOP " & kimlere.Length & " mailbox_ID from MailBox  where kullanici_No like '" & dondurulecekkullaniciID & "' order by mailbox_ID DESC"
        bilgi = komut.ExecuteReader()
        While bilgi.Read()
            dizi(i) = bilgi("mailbox_ID").ToString()
            i += 1
            ReDim Preserve dizi(i)
        End While
        i -= 1
        ReDim Preserve dizi(i)
        DisConnect()
        Return dizi
    End Function
    Public Sub MailleriAl(ByVal dgv As DataGridView, ByVal mailDurumu As Byte)
        Dim dondurulecekMailID = KullaniciIDDondur()
        Connect()
        komut.CommandText = "SELECT mailbox_ID,alici,konu,icerik,tarih FROM Mailbox where kullanici_No like '" & dondurulecekMailID & "' and durum_No=" & mailDurumu & ""
        adapter = New SqlClient.SqlDataAdapter(komut.CommandText, komut.Connection)
        table = New DataTable("tablo")
        adapter.Fill(table)
        dgv.DataSource = table
        DisConnect()
    End Sub


#Region "TarihFiltrele"

    Public Sub sonYediFiltre(ByVal dgv As DataGridView)
        Dim dondurulecekMailID = KullaniciIDDondur()
        Connect()
        komut.CommandText = "SELECT mailbox_ID,alici,konu,icerik,tarih FROM Mailbox where kullanici_No like '" & dondurulecekMailID & "' and durum_No=1 and Month(tarih)=Month(GETDATE()) and YEAR(tarih)=YEAR(Getdate()) and Day(GETDATE())-Day(tarih)<=7"
        adapter = New SqlClient.SqlDataAdapter(komut.CommandText, komut.Connection)
        table = New DataTable("tablo")
        adapter.Fill(table)
        dgv.DataSource = table
        DisConnect()
    End Sub

    Public Sub buAyFiltre(ByVal dgv As DataGridView)
        Dim dondurulecekMailID = KullaniciIDDondur()
        Connect()
        komut.CommandText = "SELECT mailbox_ID,alici,konu,icerik,tarih FROM Mailbox where kullanici_No like '" & dondurulecekMailID & "' and durum_No=1 and MONTH(getdate())=MONTH(tarih) and YEAR(getdate())=YEAR(tarih)"
        adapter = New SqlClient.SqlDataAdapter(komut.CommandText, komut.Connection)
        table = New DataTable("tablo")
        adapter.Fill(table)
        dgv.DataSource = table
        DisConnect()
    End Sub

    Public Sub buYilFiltre(ByVal dgv As DataGridView)
        Dim dondurulecekMailID = KullaniciIDDondur()
        Connect()
        komut.CommandText = "SELECT mailbox_ID,alici,konu,icerik,tarih FROM Mailbox where kullanici_No like '" & dondurulecekMailID & "' and durum_No=1 and YEAR(getdate())=YEAR(tarih)"
        adapter = New SqlClient.SqlDataAdapter(komut.CommandText, komut.Connection)
        table = New DataTable("tablo")
        adapter.Fill(table)
        dgv.DataSource = table
        DisConnect()
    End Sub

    Public Sub buAraliktaFiltre(ByVal dgv As DataGridView, ByVal basGun As Integer, ByVal basAy As Integer, ByVal basYil As Integer, ByVal bitisGun As Integer, ByVal bitisAy As Integer, ByVal bitisYil As Integer)
        Dim dondurulecekMailID = KullaniciIDDondur()
        Connect()
        komut.CommandText = " SELECT mailbox_ID,alici,konu,icerik,tarih FROM Mailbox where kullanici_No like  '" & dondurulecekMailID & "' and durum_No=1 and tarih Between '" & basYil & "/" & basAy & "/" & basGun & " 00:00:00.000' and '" & bitisYil & "/" & bitisAy & "/" & bitisGun & " 23:59:59.999'"
        adapter = New SqlClient.SqlDataAdapter(komut.CommandText, komut.Connection)
        table = New DataTable("tablo")
        adapter.Fill(table)
        dgv.DataSource = table
        DisConnect()

    End Sub

#End Region

#Region "Arama"

    Public Overloads Sub Arama(ByVal dgv As DataGridView, ByVal arananKelime As String)
        Dim dondurulecekMailID = KullaniciIDDondur()
        Connect()
        komut.CommandText = "SELECT mailbox_ID,alici,konu,icerik,tarih FROM Mailbox where kullanici_No like '" & dondurulecekMailID & "' and durum_No=1 and (konu like '%" & arananKelime & "%' or icerik like '%" & arananKelime & "%' or alici like '%" & arananKelime & "%')"
        adapter = New SqlClient.SqlDataAdapter(komut.CommandText, komut.Connection)
        table = New DataTable("tablo")
        adapter.Fill(table)
        dgv.DataSource = table
        DisConnect()
    End Sub

    Public Overloads Sub Arama(ByVal dgv As DataGridView, ByVal arananKelime As String, ByVal filtre As String)
        Dim dondurulecekMailID = KullaniciIDDondur()
        Connect()
        komut.CommandText = "SELECT mailbox_ID,alici,konu,icerik,tarih FROM Mailbox where kullanici_No like '" & dondurulecekMailID & "' and durum_No=1 and (konu like '%" & arananKelime & "%' or icerik like '%" & arananKelime & "%' or alici like '%" & arananKelime & "%') and " & filtre & ""
        adapter = New SqlClient.SqlDataAdapter(komut.CommandText, komut.Connection)
        table = New DataTable("tablo")
        adapter.Fill(table)
        dgv.DataSource = table
        DisConnect()
    End Sub
#End Region



End Class
