Imports System.Net
Imports OpenPop
Imports OpenPop.Pop3
Imports OpenPop.Mime
Imports System.Net.Mail
Imports System.IO
Public Class frm_mailGelen
    Dim durum As Boolean = False
    Dim mailGonder As frm_mailGonderme
    Dim kullanici As New KullaniciBilgileri
    Dim EmailListele As New List(Of MailAlma)
    Dim mail As New MailAlma
    Public dosyaAdlari(1) As String
    Shared temp As Integer
    Dim ms As Integer
    Dim degisenms As Integer = 1
    Dim DosyaAd(25) As String
    Dim DosyaUzanti(25) As String
    Dim DosyaID As Integer
    Dim mAl As MailAlma
    Dim sifrenesne As New TumMailler
    Dim dizi() As String = mail.Pro_Email.Split("@")
    Public karakterC As Char = Chr(226)

    Public karakterS As String = karakterC + karakterC + karakterC + karakterC + karakterC
    Private Sub btn_yeni_Click(sender As Object, e As EventArgs) Handles btn_yeni.Click

        If durum = False Then
            frm_taslak.taslakDurumu = False
            mailGonder = New frm_mailGonderme()
            mailGonder.MdiParent = frm_mailicerik
            mailGonder.Show()
            mailGonder.Activate()
            durum = True
        Else
            frm_taslak.taslakDurumu = False
            mailGonder.Activate()
            mailGonder.BringToFront()

        End If
    End Sub

    Dim uzantiListe As List(Of String) = New List(Of String)()
    Dim adListe As List(Of String) = New List(Of String)()
    Private Sub frm_mailGelen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mailIDdizi(25) As Integer
        Dim count As Integer
        Dim kullaniciDurum As Integer = mail.kullaniciDurumuAl()
        mAl = New MailAlma()
        Dim tm As New TumMailler

        Try
            Dim pop As New Pop3Client
            If dizi(1) = "yandex.com" Or dizi(1) = "yandex.com.tr" Then
                pop.Connect("pop.yandex.com", "995", True)
                btn_sil.Visible = False
                btn_bilgi.Visible = False
            ElseIf dizi(1) = "gmail.com" Then
                pop.Connect("pop.gmail.com", "995", True)
                btn_sil.Visible = False
                btn_bilgi.Visible = False
            ElseIf dizi(1) = "outlook.com" Or dizi(1) = "hotmail.com" Then
                pop.Connect("pop3.live.com", "995", True)
            ElseIf dizi(1) = "trakya.edu.tr" Then
                pop.Connect("mail.trakya.edu.tr", "110", False)
            End If

            pop.Authenticate(kullanici.Pro_Email, kullanici.Pro_Sifre, AuthenticationMethod.UsernameAndPassword)
            temp = mail.MailSayisiniDondur()
            ms = pop.GetMessageCount
            frm_mailicerik.lbl_gelenlerinSayisi.Text = mAl.GelenMaillerinSayisi()
            ReDim Preserve dosyaAdlari(ms)

            If kullaniciDurum = 1 And temp <> ms Then

                For i As Integer = 1 To ms
                    EmailListele.Add(New MailAlma With {.sKonu = pop.GetMessage(i).ToMailMessage.Subject, .sMetin = pop.GetMessage(i).ToMailMessage.Body, .sGonderen = pop.GetMessage(i).ToMailMessage.From.ToString(), .sTarih = pop.GetMessage(i).Headers.Date})
                    Dim icerikSifreleme As String
                    icerikSifreleme = pop.GetMessage(i).ToMailMessage.Body
                    If icerikSifreleme.Contains(karakterS) Then
                        Dim kripto As New Sifreleme
                        sifrenesne.Pro_Sifİcerik = kripto.TestDecoding("mebot74185296a")
                    End If
                    

                    For Each dsyAl In pop.GetMessage(i).FindAllAttachments
                        dosyaAdlari(i) = dsyAl.FileName
                        If dosyaAdlari(i).Contains("jpg") Or dosyaAdlari(i).Contains("ico") Or dosyaAdlari(i).Contains("PNG") Or dosyaAdlari(i).Contains("png") Or dosyaAdlari(i).Contains("JPG") Or dosyaAdlari(i).Contains("ICO") Then
                            If File.Exists("dosyalar/resimler/" & dosyaAdlari(i)) Then
                                Dim str As String = dosyaAdlari(i)

                                dosyaAdlari(i) = tm.simdiki_tarihi_getir() & str
                                DosyaAd(i) = dosyaAdlari(i)
                                DosyaUzanti(i) = "dosyalar/resimler/" & dosyaAdlari(i)
                                Dim dosyalar = New FileStream(Path.Combine("dosyalar/resimler/", dosyaAdlari(i)), FileMode.Create) 'Buraya dosya uzantısı yazılacak
                                Dim binaryStream = New BinaryWriter(dosyalar)
                                binaryStream.Write(dsyAl.Body)
                                binaryStream.Close()

                            Else
                                DosyaAd(i) = dosyaAdlari(i)
                                DosyaUzanti(i) = "dosyalar/resimler/" & dosyaAdlari(i)
                                Dim dosyalar = New FileStream(Path.Combine("dosyalar/resimler/", dosyaAdlari(i)), FileMode.Create) 'Buraya dosya uzantısı yazılacak
                                Dim binaryStream = New BinaryWriter(dosyalar)
                                binaryStream.Write(dsyAl.Body)
                                binaryStream.Close()

                            End If

                        ElseIf dosyaAdlari(i).Contains("doc") Or dosyaAdlari(i).Contains("docx") Or dosyaAdlari(i).Contains("txt") Or dosyaAdlari(i).Contains("xlsx") Or dosyaAdlari(i).Contains("pptx") Or dosyaAdlari(i).Contains("pptm") Or dosyaAdlari(i).Contains("pdf") Then
                            If File.Exists("dosyalar/word/" & dosyaAdlari(i)) Then
                                Dim str As String = dosyaAdlari(i)
                                dosyaAdlari(i) = tm.simdiki_tarihi_getir() & str
                                DosyaAd(i) = dosyaAdlari(i)
                                DosyaUzanti(i) = "dosyalar/word/" & dosyaAdlari(i)
                                Dim dosyalar = New FileStream(Path.Combine("dosyalar/word/", dosyaAdlari(i)), FileMode.Create) 'Buraya dosya uzantısı yazılacak
                                Dim binaryStream = New BinaryWriter(dosyalar)
                                binaryStream.Write(dsyAl.Body)
                                binaryStream.Close()

                            Else
                                DosyaAd(i) = dosyaAdlari(i)
                                DosyaUzanti(i) = "dosyalar/word/" & dosyaAdlari(i)
                                Dim dosyalar = New FileStream(Path.Combine("dosyalar/word/", dosyaAdlari(i)), FileMode.Create) 'Buraya dosya uzantısı yazılacak
                                Dim binaryStream = New BinaryWriter(dosyalar)
                                binaryStream.Write(dsyAl.Body)
                                binaryStream.Close()
                            End If

                        ElseIf dosyaAdlari(i).Contains("mp3") Or dosyaAdlari(i).Contains("mp4") Or dosyaAdlari(i).Contains("avi") Or dosyaAdlari(i).Contains("wav") Or dosyaAdlari(i).Contains("flv") Or dosyaAdlari(i).Contains("ts") Or dosyaAdlari(i).Contains("TS") Or dosyaAdlari(i).Contains("MP4") Or dosyaAdlari(i).Contains("mov") Or dosyaAdlari(i).Contains("MKV") Then
                            If File.Exists("dosyalar/videolar/" & dosyaAdlari(i)) Then
                                Dim str As String = dosyaAdlari(i)
                                dosyaAdlari(i) = tm.simdiki_tarihi_getir() & str
                                DosyaAd(i) = dosyaAdlari(i)
                                DosyaUzanti(i) = "dosyalar/videolar/" & dosyaAdlari(i)
                                Dim dosyalar = New FileStream(Path.Combine("dosyalar/videolar/", dosyaAdlari(i)), FileMode.Create) 'Buraya dosya uzantısı yazılacak
                                Dim binaryStream = New BinaryWriter(dosyalar)
                                binaryStream.Write(dsyAl.Body)
                                binaryStream.Close()
                            Else
                                DosyaAd(i) = dosyaAdlari(i)
                                DosyaUzanti(i) = "dosyalar/videolar/" & dosyaAdlari(i)
                                Dim dosyalar = New FileStream(Path.Combine("dosyalar/videolar/", dosyaAdlari(i)), FileMode.Create) 'Buraya dosya uzantısı yazılacak
                                Dim binaryStream = New BinaryWriter(dosyalar)
                                binaryStream.Write(dsyAl.Body)
                                binaryStream.Close()

                            End If

                        ElseIf dosyaAdlari(i).Contains("zip") Or dosyaAdlari(i).Contains("rar") Or dosyaAdlari(i).Contains("rar5") Or dosyaAdlari(i).Contains("ZIP") Or dosyaAdlari(i).Contains("RAR") Or dosyaAdlari(i).Contains("RAR5") Then
                            If File.Exists("dosyalar/rar/" & dosyaAdlari(i)) Then
                                Dim str As String = dosyaAdlari(i)
                                dosyaAdlari(i) = tm.simdiki_tarihi_getir() & str
                                DosyaAd(i) = dosyaAdlari(i)
                                DosyaUzanti(i) = "dosyalar/rar/" & dosyaAdlari(i)
                                Dim dosyalar = New FileStream(Path.Combine("dosyalar/rar/", dosyaAdlari(i)), FileMode.Create) 'Buraya dosya uzantısı yazılacak
                                Dim binaryStream = New BinaryWriter(dosyalar)
                                binaryStream.Write(dsyAl.Body)
                                binaryStream.Close()
                            Else
                                DosyaAd(i) = dosyaAdlari(i)
                                DosyaUzanti(i) = "dosyalar/rar/" & dosyaAdlari(i)
                                Dim dosyalar = New FileStream(Path.Combine("dosyalar/rar/", dosyaAdlari(i)), FileMode.Create) 'Buraya dosya uzantısı yazılacak
                                Dim binaryStream = New BinaryWriter(dosyalar)
                                binaryStream.Write(dsyAl.Body)
                                binaryStream.Close()
                            End If

                        Else
                            If File.Exists("dosyalar/diger/" & dosyaAdlari(i)) Then
                                Dim str As String = dosyaAdlari(i)
                                dosyaAdlari(i) = tm.simdiki_tarihi_getir() & str
                                DosyaAd(i) = dosyaAdlari(i)
                                DosyaUzanti(i) = "dosyalar/diger/" & dosyaAdlari(i)
                                Dim dosyalar = New FileStream(Path.Combine("dosyalar/diger/", dosyaAdlari(i)), FileMode.Create) 'Buraya dosya uzantısı yazılacak
                                Dim binaryStream = New BinaryWriter(dosyalar)
                                binaryStream.Write(dsyAl.Body)
                                binaryStream.Close()
                            Else
                                DosyaAd(i) = dosyaAdlari(i)
                                DosyaUzanti(i) = "dosyalar/diger/" & dosyaAdlari(i)
                                Dim dosyalar = New FileStream(Path.Combine("dosyalar/diger/", dosyaAdlari(i)), FileMode.Create) 'Buraya dosya uzantısı yazılacak
                                Dim binaryStream = New BinaryWriter(dosyalar)
                                binaryStream.Write(dsyAl.Body)
                                binaryStream.Close()
                            End If

                        End If

                        'Dosya Alma İşlemleri
                        'dosyaAdlari(i) = dsyAl.FileName
                        'Dim dosyalar = New FileStream(Path.Combine("C:\Users\ENESSS\Desktop\Mebot_Degistirme\MailMebot\MebotMailProje\MebotMailProje\bin\Debug\dosyalar\", dosyaAdlari(i)), FileMode.Create) 'Buraya dosya uzantısı yazılacak
                        'Dim binaryStream = New BinaryWriter(dosyalar)
                        'binaryStream.Write(dsyAl.Body)
                        'binaryStream.Close()
                    Next

                Next


                For Each email In EmailListele

                    If dosyaAdlari(degisenms) = Nothing Then
                        email.GelenMailVeriTabaninaEkle()

                        If degisenms < ms Then
                            degisenms += 1
                        End If
                    Else
                        email.GelenMailVeriTabaninaEkle()
                        mailIDdizi(count) = mail.GelenMailBoxID()
                        DosyaID = mailIDdizi(count)
                        email.DosyaAdiMailIDEkle(DosyaAd(degisenms), DosyaUzanti(degisenms), DosyaID)
                        count += 1
                        If degisenms < ms Then
                            degisenms += 1
                        End If
                    End If

                Next

                mail.kullaniciDurumuDegistir()
                temp = mail.MailSayisiniDondur()

            ElseIf dizi(1) = "gmail.com" And kullaniciDurum = 0 Then
                For i As Integer = 1 To ms
                    EmailListele.Add(New MailAlma With {.sKonu = pop.GetMessage(i).ToMailMessage.Subject, .sMetin = pop.GetMessage(i).ToMailMessage.Body, .sGonderen = pop.GetMessage(i).ToMailMessage.From.ToString(), .sTarih = pop.GetMessage(i).Headers.Date})
                    Dim icerikSifreleme As String
                    icerikSifreleme = pop.GetMessage(i).ToMailMessage.Body
                    If icerikSifreleme.Contains(karakterS) Then
                        Dim kripto As New Sifreleme
                        sifrenesne.Pro_Sifİcerik = kripto.TestDecoding("mebot74185296a")
                    End If
                    For Each dsyAl In pop.GetMessage(i).FindAllAttachments
                        dosyaAdlari(i) = dsyAl.FileName
                        If dosyaAdlari(i).Contains("jpg") Or dosyaAdlari(i).Contains("ico") Or dosyaAdlari(i).Contains("PNG") Or dosyaAdlari(i).Contains("png") Or dosyaAdlari(i).Contains("JPG") Or dosyaAdlari(i).Contains("ICO") Then
                            If File.Exists("dosyalar/resimler/" & dosyaAdlari(i)) Then
                                Dim str As String = dosyaAdlari(i)

                                dosyaAdlari(i) = tm.simdiki_tarihi_getir() & str
                                DosyaAd(i) = dosyaAdlari(i)
                                DosyaUzanti(i) = "dosyalar/resimler/" & dosyaAdlari(i)
                                Dim dosyalar = New FileStream(Path.Combine("dosyalar/resimler/", dosyaAdlari(i)), FileMode.Create) 'Buraya dosya uzantısı yazılacak
                                Dim binaryStream = New BinaryWriter(dosyalar)
                                binaryStream.Write(dsyAl.Body)
                                binaryStream.Close()

                            Else
                                DosyaAd(i) = dosyaAdlari(i)
                                DosyaUzanti(i) = "dosyalar/resimler/" & dosyaAdlari(i)
                                Dim dosyalar = New FileStream(Path.Combine("dosyalar/resimler/", dosyaAdlari(i)), FileMode.Create) 'Buraya dosya uzantısı yazılacak
                                Dim binaryStream = New BinaryWriter(dosyalar)
                                binaryStream.Write(dsyAl.Body)
                                binaryStream.Close()

                            End If

                        ElseIf dosyaAdlari(i).Contains("doc") Or dosyaAdlari(i).Contains("docx") Or dosyaAdlari(i).Contains("txt") Or dosyaAdlari(i).Contains("xlsx") Or dosyaAdlari(i).Contains("pptx") Or dosyaAdlari(i).Contains("pptm") Or dosyaAdlari(i).Contains("pdf") Then
                            If File.Exists("dosyalar/word/" & dosyaAdlari(i)) Then
                                Dim str As String = dosyaAdlari(i)
                                dosyaAdlari(i) = tm.simdiki_tarihi_getir() & str
                                DosyaAd(i) = dosyaAdlari(i)
                                DosyaUzanti(i) = "dosyalar/word/" & dosyaAdlari(i)
                                Dim dosyalar = New FileStream(Path.Combine("dosyalar/word/", dosyaAdlari(i)), FileMode.Create) 'Buraya dosya uzantısı yazılacak
                                Dim binaryStream = New BinaryWriter(dosyalar)
                                binaryStream.Write(dsyAl.Body)
                                binaryStream.Close()

                            Else
                                DosyaAd(i) = dosyaAdlari(i)
                                DosyaUzanti(i) = "dosyalar/word/" & dosyaAdlari(i)
                                Dim dosyalar = New FileStream(Path.Combine("dosyalar/word/", dosyaAdlari(i)), FileMode.Create) 'Buraya dosya uzantısı yazılacak
                                Dim binaryStream = New BinaryWriter(dosyalar)
                                binaryStream.Write(dsyAl.Body)
                                binaryStream.Close()
                            End If

                        ElseIf dosyaAdlari(i).Contains("mp3") Or dosyaAdlari(i).Contains("mp4") Or dosyaAdlari(i).Contains("avi") Or dosyaAdlari(i).Contains("wav") Or dosyaAdlari(i).Contains("flv") Or dosyaAdlari(i).Contains("ts") Or dosyaAdlari(i).Contains("TS") Or dosyaAdlari(i).Contains("MP4") Or dosyaAdlari(i).Contains("mov") Or dosyaAdlari(i).Contains("MKV") Then
                            If File.Exists("dosyalar/videolar/" & dosyaAdlari(i)) Then
                                Dim str As String = dosyaAdlari(i)
                                dosyaAdlari(i) = tm.simdiki_tarihi_getir() & str
                                DosyaAd(i) = dosyaAdlari(i)
                                DosyaUzanti(i) = "dosyalar/videolar/" & dosyaAdlari(i)
                                Dim dosyalar = New FileStream(Path.Combine("dosyalar/videolar/", dosyaAdlari(i)), FileMode.Create) 'Buraya dosya uzantısı yazılacak
                                Dim binaryStream = New BinaryWriter(dosyalar)
                                binaryStream.Write(dsyAl.Body)
                                binaryStream.Close()
                            Else
                                DosyaAd(i) = dosyaAdlari(i)
                                DosyaUzanti(i) = "dosyalar/videolar/" & dosyaAdlari(i)
                                Dim dosyalar = New FileStream(Path.Combine("dosyalar/videolar/", dosyaAdlari(i)), FileMode.Create) 'Buraya dosya uzantısı yazılacak
                                Dim binaryStream = New BinaryWriter(dosyalar)
                                binaryStream.Write(dsyAl.Body)
                                binaryStream.Close()

                            End If

                        ElseIf dosyaAdlari(i).Contains("zip") Or dosyaAdlari(i).Contains("rar") Or dosyaAdlari(i).Contains("rar5") Or dosyaAdlari(i).Contains("ZIP") Or dosyaAdlari(i).Contains("RAR") Or dosyaAdlari(i).Contains("RAR5") Then
                            If File.Exists("dosyalar/rar/" & dosyaAdlari(i)) Then
                                Dim str As String = dosyaAdlari(i)
                                dosyaAdlari(i) = tm.simdiki_tarihi_getir() & str
                                DosyaAd(i) = dosyaAdlari(i)
                                DosyaUzanti(i) = "dosyalar/rar/" & dosyaAdlari(i)
                                Dim dosyalar = New FileStream(Path.Combine("dosyalar/rar/", dosyaAdlari(i)), FileMode.Create) 'Buraya dosya uzantısı yazılacak
                                Dim binaryStream = New BinaryWriter(dosyalar)
                                binaryStream.Write(dsyAl.Body)
                                binaryStream.Close()
                            Else
                                DosyaAd(i) = dosyaAdlari(i)
                                DosyaUzanti(i) = "dosyalar/rar/" & dosyaAdlari(i)
                                Dim dosyalar = New FileStream(Path.Combine("dosyalar/rar/", dosyaAdlari(i)), FileMode.Create) 'Buraya dosya uzantısı yazılacak
                                Dim binaryStream = New BinaryWriter(dosyalar)
                                binaryStream.Write(dsyAl.Body)
                                binaryStream.Close()
                            End If

                        Else
                            If File.Exists("dosyalar/diger/" & dosyaAdlari(i)) Then
                                Dim str As String = dosyaAdlari(i)
                                dosyaAdlari(i) = tm.simdiki_tarihi_getir() & str
                                DosyaAd(i) = dosyaAdlari(i)
                                DosyaUzanti(i) = "dosyalar/diger/" & dosyaAdlari(i)
                                Dim dosyalar = New FileStream(Path.Combine("dosyalar/diger/", dosyaAdlari(i)), FileMode.Create) 'Buraya dosya uzantısı yazılacak
                                Dim binaryStream = New BinaryWriter(dosyalar)
                                binaryStream.Write(dsyAl.Body)
                                binaryStream.Close()
                            Else
                                DosyaAd(i) = dosyaAdlari(i)
                                DosyaUzanti(i) = "dosyalar/diger/" & dosyaAdlari(i)
                                Dim dosyalar = New FileStream(Path.Combine("dosyalar/diger/", dosyaAdlari(i)), FileMode.Create) 'Buraya dosya uzantısı yazılacak
                                Dim binaryStream = New BinaryWriter(dosyalar)
                                binaryStream.Write(dsyAl.Body)
                                binaryStream.Close()
                            End If

                        End If

                        'dosyaAdlari(i) = dsyAl.FileName
                        'Dim dosyalar = New FileStream(Path.Combine("C:\Users\ENESSS\Desktop\Mebot_Degistirme\MailMebot\MebotMailProje\MebotMailProje\bin\Debug\dosyalar\", dosyaAdlari(i)), FileMode.Create) 'Buraya dosya uzantısı yazılacak
                        'Dim binaryStream = New BinaryWriter(dosyalar)
                        'binaryStream.Write(dsyAl.Body)
                        'binaryStream.Close()
                    Next
                Next


                For Each email In EmailListele

                    If dosyaAdlari(degisenms) = Nothing Then
                        email.GelenMailVeriTabaninaEkle()

                        If degisenms < ms Then
                            degisenms += 1
                        End If
                    Else
                        email.GelenMailVeriTabaninaEkle()
                        mailIDdizi(count) = mail.GelenMailBoxID()
                        DosyaID = mailIDdizi(count)
                        email.DosyaAdiMailIDEkle(DosyaAd(degisenms), DosyaUzanti(degisenms), DosyaID)
                        count += 1
                        If degisenms < ms Then
                            degisenms += 1
                        End If
                    End If

                Next

            ElseIf ms > temp And kullaniciDurum = 0 Then
                For i As Integer = temp + 1 To ms
                    EmailListele.Add(New MailAlma With {.sKonu = pop.GetMessage(i).ToMailMessage.Subject, .sMetin = pop.GetMessage(i).ToMailMessage.Body, .sGonderen = pop.GetMessage(i).ToMailMessage.From.ToString(), .sTarih = pop.GetMessage(i).Headers.Date})
                    Dim icerikSifreleme As String
                    icerikSifreleme = pop.GetMessage(i).ToMailMessage.Body
                    If icerikSifreleme.Contains(karakterS) Then
                        Dim kripto As New Sifreleme
                        sifrenesne.Pro_Sifİcerik = kripto.TestDecoding("mebot74185296a")
                    End If
                    For Each dsyAl In pop.GetMessage(i).FindAllAttachments
                        dosyaAdlari(i) = dsyAl.FileName
                        If dosyaAdlari(i).Contains("jpg") Or dosyaAdlari(i).Contains("ico") Or dosyaAdlari(i).Contains("PNG") Or dosyaAdlari(i).Contains("png") Or dosyaAdlari(i).Contains("JPG") Or dosyaAdlari(i).Contains("ICO") Then
                            If File.Exists("dosyalar/resimler/" & dosyaAdlari(i)) Then
                                Dim str As String = dosyaAdlari(i)

                                dosyaAdlari(i) = tm.simdiki_tarihi_getir() & str
                                DosyaAd(i) = dosyaAdlari(i)
                                DosyaUzanti(i) = "dosyalar/resimler/" & dosyaAdlari(i)
                                Dim dosyalar = New FileStream(Path.Combine("dosyalar/resimler/", dosyaAdlari(i)), FileMode.Create) 'Buraya dosya uzantısı yazılacak
                                Dim binaryStream = New BinaryWriter(dosyalar)
                                binaryStream.Write(dsyAl.Body)
                                binaryStream.Close()

                            Else
                                DosyaAd(i) = dosyaAdlari(i)
                                DosyaUzanti(i) = "dosyalar/resimler/" & dosyaAdlari(i)
                                Dim dosyalar = New FileStream(Path.Combine("dosyalar/resimler/", dosyaAdlari(i)), FileMode.Create) 'Buraya dosya uzantısı yazılacak
                                Dim binaryStream = New BinaryWriter(dosyalar)
                                binaryStream.Write(dsyAl.Body)
                                binaryStream.Close()

                            End If

                        ElseIf dosyaAdlari(i).Contains("doc") Or dosyaAdlari(i).Contains("docx") Or dosyaAdlari(i).Contains("txt") Or dosyaAdlari(i).Contains("xlsx") Or dosyaAdlari(i).Contains("pptx") Or dosyaAdlari(i).Contains("pptm") Or dosyaAdlari(i).Contains("pdf") Then
                            If File.Exists("dosyalar/word/" & dosyaAdlari(i)) Then
                                Dim str As String = dosyaAdlari(i)
                                dosyaAdlari(i) = tm.simdiki_tarihi_getir() & str
                                DosyaAd(i) = dosyaAdlari(i)
                                DosyaUzanti(i) = "dosyalar/word/" & dosyaAdlari(i)
                                Dim dosyalar = New FileStream(Path.Combine("dosyalar/word/", dosyaAdlari(i)), FileMode.Create) 'Buraya dosya uzantısı yazılacak
                                Dim binaryStream = New BinaryWriter(dosyalar)
                                binaryStream.Write(dsyAl.Body)
                                binaryStream.Close()

                            Else
                                DosyaAd(i) = dosyaAdlari(i)
                                DosyaUzanti(i) = "dosyalar/word/" & dosyaAdlari(i)
                                Dim dosyalar = New FileStream(Path.Combine("dosyalar/word/", dosyaAdlari(i)), FileMode.Create) 'Buraya dosya uzantısı yazılacak
                                Dim binaryStream = New BinaryWriter(dosyalar)
                                binaryStream.Write(dsyAl.Body)
                                binaryStream.Close()
                            End If

                        ElseIf dosyaAdlari(i).Contains("mp3") Or dosyaAdlari(i).Contains("mp4") Or dosyaAdlari(i).Contains("avi") Or dosyaAdlari(i).Contains("wav") Or dosyaAdlari(i).Contains("flv") Or dosyaAdlari(i).Contains("ts") Or dosyaAdlari(i).Contains("TS") Or dosyaAdlari(i).Contains("MP4") Or dosyaAdlari(i).Contains("mov") Or dosyaAdlari(i).Contains("MKV") Then
                            If File.Exists("dosyalar/videolar/" & dosyaAdlari(i)) Then
                                Dim str As String = dosyaAdlari(i)
                                dosyaAdlari(i) = tm.simdiki_tarihi_getir() & str
                                DosyaAd(i) = dosyaAdlari(i)
                                DosyaUzanti(i) = "dosyalar/videolar/" & dosyaAdlari(i)
                                Dim dosyalar = New FileStream(Path.Combine("dosyalar/videolar/", dosyaAdlari(i)), FileMode.Create) 'Buraya dosya uzantısı yazılacak
                                Dim binaryStream = New BinaryWriter(dosyalar)
                                binaryStream.Write(dsyAl.Body)
                                binaryStream.Close()
                            Else
                                DosyaAd(i) = dosyaAdlari(i)
                                DosyaUzanti(i) = "dosyalar/videolar/" & dosyaAdlari(i)
                                Dim dosyalar = New FileStream(Path.Combine("dosyalar/videolar/", dosyaAdlari(i)), FileMode.Create) 'Buraya dosya uzantısı yazılacak
                                Dim binaryStream = New BinaryWriter(dosyalar)
                                binaryStream.Write(dsyAl.Body)
                                binaryStream.Close()

                            End If

                        ElseIf dosyaAdlari(i).Contains("zip") Or dosyaAdlari(i).Contains("rar") Or dosyaAdlari(i).Contains("rar5") Or dosyaAdlari(i).Contains("ZIP") Or dosyaAdlari(i).Contains("RAR") Or dosyaAdlari(i).Contains("RAR5") Then
                            If File.Exists("dosyalar/rar/" & dosyaAdlari(i)) Then
                                Dim str As String = dosyaAdlari(i)
                                dosyaAdlari(i) = tm.simdiki_tarihi_getir() & str
                                DosyaAd(i) = dosyaAdlari(i)
                                DosyaUzanti(i) = "dosyalar/rar/" & dosyaAdlari(i)
                                Dim dosyalar = New FileStream(Path.Combine("dosyalar/rar/", dosyaAdlari(i)), FileMode.Create) 'Buraya dosya uzantısı yazılacak
                                Dim binaryStream = New BinaryWriter(dosyalar)
                                binaryStream.Write(dsyAl.Body)
                                binaryStream.Close()
                            Else
                                DosyaAd(i) = dosyaAdlari(i)
                                DosyaUzanti(i) = "dosyalar/rar/" & dosyaAdlari(i)
                                Dim dosyalar = New FileStream(Path.Combine("dosyalar/rar/", dosyaAdlari(i)), FileMode.Create) 'Buraya dosya uzantısı yazılacak
                                Dim binaryStream = New BinaryWriter(dosyalar)
                                binaryStream.Write(dsyAl.Body)
                                binaryStream.Close()
                            End If

                        Else
                            If File.Exists("dosyalar/diger/" & dosyaAdlari(i)) Then
                                Dim str As String = dosyaAdlari(i)
                                dosyaAdlari(i) = tm.simdiki_tarihi_getir() & str
                                DosyaAd(i) = dosyaAdlari(i)
                                DosyaUzanti(i) = "dosyalar/diger/" & dosyaAdlari(i)
                                Dim dosyalar = New FileStream(Path.Combine("dosyalar/diger/", dosyaAdlari(i)), FileMode.Create) 'Buraya dosya uzantısı yazılacak
                                Dim binaryStream = New BinaryWriter(dosyalar)
                                binaryStream.Write(dsyAl.Body)
                                binaryStream.Close()
                            Else
                                DosyaAd(i) = dosyaAdlari(i)
                                DosyaUzanti(i) = "dosyalar/diger/" & dosyaAdlari(i)
                                Dim dosyalar = New FileStream(Path.Combine("dosyalar/diger/", dosyaAdlari(i)), FileMode.Create) 'Buraya dosya uzantısı yazılacak
                                Dim binaryStream = New BinaryWriter(dosyalar)
                                binaryStream.Write(dsyAl.Body)
                                binaryStream.Close()
                            End If

                        End If

                    Next

                Next

                For Each email In EmailListele

                    If dosyaAdlari(degisenms) = Nothing Then
                        email.GelenMailVeriTabaninaEkle()

                        If degisenms < ms Then
                            degisenms += 1
                        End If
                    Else
                        email.GelenMailVeriTabaninaEkle()
                        mailIDdizi(count) = mail.GelenMailBoxID()
                        DosyaID = mailIDdizi(count)
                        email.DosyaAdiMailIDEkle(DosyaAd(degisenms), DosyaUzanti(degisenms), DosyaID)
                        count += 1
                        If degisenms < ms Then
                            degisenms += 1
                        End If
                    End If

                Next
                'For Each email In EmailListele
                '    email.GelenMailVeriTabaninaEkle()
                'Next

                'temp = mail.MailSayisiniDondur()
            End If

            'For Each obj In EmailListele
            '    dgv_mail.Rows.Add(obj.sGonderen, obj.sKonu, obj.sTarih)
            'Next

            mail.VTMailCek(dgv_mail)
            mail.smailSayisi = ms
            mail.mailSayisiEkle()
            pop.Disconnect()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.dgv_mail.Sort(Me.dgv_mail.Columns("cmb_Tarih"), System.ComponentModel.ListSortDirection.Descending)

    End Sub

    Dim mailGelen As frm_GelenKutusuDetay
    Private Sub dgv_mail_Click(sender As Object, e As EventArgs)
        Dim str As String = mail.VTdenMailIcerikCekme(dgv_mail)
        If durum = False Then
            frm_taslak.taslakDurumu = False
            mailGelen = New frm_GelenKutusuDetay()
            mailGelen.MdiParent = frm_mailicerik
            mailGelen.Show()
            mailGelen.Activate()
            durum = True
        Else
            frm_taslak.taslakDurumu = False
            mailGelen.Activate()
            mailGelen.BringToFront()

        End If


    End Sub

    Dim drm As Boolean = False
    Dim maillerDetay(1) As frm_GelenKutusuDetay
    Dim sayac As Integer = 0
    Dim kontrol As Boolean = False
    Dim tm As TumMailler
    Private Sub dgv_mail_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_mail.CellDoubleClick
        If e.RowIndex <> -1 Then
            tm = New TumMailler()
            If durum = False Then

                If kontrol = True Then
                    maillerDetay(1).Dispose()
                End If

                tm.Pro_mailBoxID = dgv_mail.CurrentRow().Cells(0).Value.ToString()
                maillerDetay(sayac) = New frm_GelenKutusuDetay()
                maillerDetay(sayac).MdiParent = frm_mailicerik
                maillerDetay(sayac).Show()
                maillerDetay(sayac).Activate()
                drm = True
                sayac += 1
                kontrol = False
            Else
                maillerDetay(0).Dispose()
                tm.Pro_mailBoxID = dgv_mail.CurrentRow().Cells(0).Value.ToString()
                maillerDetay(sayac) = New frm_GelenKutusuDetay()
                maillerDetay(sayac).MdiParent = frm_mailicerik
                maillerDetay(sayac).Show()
                maillerDetay(sayac).Activate()
                maillerDetay(sayac).BringToFront()
                drm = False
                sayac = 0
                kontrol = True
            End If
        End If
    End Sub

    Private Sub GoruntuleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoruntuleToolStripMenuItem.Click

        tm = New TumMailler()
        If durum = False Then

            If kontrol = True Then
                maillerDetay(1).Dispose()
            End If
            tm.Pro_mailBoxID = dgv_mail.CurrentRow().Cells(0).Value.ToString()
            maillerDetay(sayac) = New frm_GelenKutusuDetay()
            maillerDetay(sayac).MdiParent = frm_mailicerik
            maillerDetay(sayac).Show()
            maillerDetay(sayac).Activate()
            drm = True
            sayac += 1
            kontrol = False
        Else
            maillerDetay(0).Dispose()
            tm.Pro_mailBoxID = dgv_mail.CurrentRow().Cells(0).Value.ToString()
            maillerDetay(sayac) = New frm_GelenKutusuDetay()
            maillerDetay(sayac).MdiParent = frm_mailicerik
            maillerDetay(sayac).Show()
            maillerDetay(sayac).Activate()
            maillerDetay(sayac).BringToFront()
            drm = False
            sayac = 0
            kontrol = True
        End If

    End Sub

    Dim mailAl As MailAlma
    Dim mailBox_ID As Integer
    Dim mailSilme As MailSilmeIslemleri
    Private Sub SilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SilToolStripMenuItem.Click
        mailAl = New MailAlma()
        mailBox_ID = dgv_mail.CurrentRow.Cells(0).Value.ToString()
        mailAl.Pro_mailBoxID = mailBox_ID
        mailAl.GelenleriGuncelle()

        mailAl.MailleriAl(dgv_mail, 2)
        frm_mailicerik.lbl_gelenlerinSayisi.Text = mailAl.GelenMaillerinSayisi()
        mailSilme = New MailSilmeIslemleri()
        frm_mailicerik.lbl_silinenler.Text = mailSilme.SilinenlerinSayisi()

    End Sub

    Private Sub rb_tumu_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_yanıtla_Click(sender As Object, e As EventArgs)
        frm_mailGonderme.Show()

    End Sub

    Private Sub btn_sil_Click(sender As Object, e As EventArgs) Handles btn_sil.Click
        Dim MailS As New MailSilmeIslemleri
        mailAl = New MailAlma()
        Dim mesajS As Integer

        mesajS = dgv_mail.CurrentCell.RowIndex + 1
        Using pop As New Pop3Client
            If dizi(1) = "outlook.com" Or dizi(1) = "hotmail.com" Then
                pop.Connect("pop3.live.com", "995", True)
                pop.Authenticate(kullanici.Pro_Email, kullanici.Pro_Sifre, AuthenticationMethod.UsernameAndPassword)
                pop.DeleteMessage(ms - mesajS + 1)
            ElseIf dizi(1) = "trakya.edu.tr" Then
                pop.Connect("mail.trakya.edu.tr", "110", False)
                pop.Authenticate(kullanici.Pro_Email, kullanici.Pro_Sifre, AuthenticationMethod.UsernameAndPassword)
                pop.DeleteMessage(ms - mesajS + 1)
            End If

        End Using

        mailBox_ID = dgv_mail.CurrentRow.Cells(0).Value.ToString()
        mailAl.Pro_mailBoxID = mailBox_ID
        mailAl.GelenleriGuncelle()

        mailAl.MailleriAl(dgv_mail, 2)
        frm_mailicerik.lbl_gelenlerinSayisi.Text = mailAl.GelenMaillerinSayisi()
        kullanici.VTMailSayisiGuncelle(ms - 1)

        MailS.Pro_mailBoxID = mailBox_ID
        MailS.ArkaplanDosyaSil()
        MailS.SilinenlerMailSil()
        MailS.SilinenlerDosyaSil()
        frm_mailicerik.lbl_silinenler.Text = MailS.SilinenlerinSayisi()


    End Sub
    Shared b As Boolean = False
    Private Sub btn_bilgi_Click(sender As Object, e As EventArgs) Handles btn_bilgi.Click

        If b = False Then
            lbl_Bilgilendirme.Visible = True
            b = True
        ElseIf b = True Then
            lbl_Bilgilendirme.Visible = False
            b = False
        End If
    End Sub
End Class