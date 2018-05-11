Imports System.Windows.Forms.MonthCalendar
Imports System.IO
Imports System.Threading

Public Class frm_mailicerik

    Dim baslamaNoktasi As Point
    Dim gelenMail As frm_mailGelen
    Dim kullanici As KullaniciBilgileri
    Dim sr As StreamReader
    Dim sw As StreamWriter
    Dim renk As ColorDialog
    Dim result As DialogResult
    Dim mdiControl As Control
    Private Sub btn_kapat_Click(sender As Object, e As EventArgs) Handles btn_kapat.Click
        Application.Exit()
    End Sub

    Private Sub btn_simgeDurumu_Click(sender As Object, e As EventArgs) Handles btn_simgeDurumu.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pnl_mail_MouseDown(sender As Object, e As MouseEventArgs) Handles pnl_mail.MouseDown
        baslamaNoktasi = New Point(e.X, e.Y) ' tıklanan yerin kordinatını alıyor
    End Sub

    Private Sub pnl_mail_MouseMove(sender As Object, e As MouseEventArgs) Handles pnl_mail.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim p As Point = PointToScreen(e.Location)
            Location = New Point(p.X - Me.baslamaNoktasi.X, p.Y - Me.baslamaNoktasi.Y)
        End If
    End Sub

    Private Sub lbl_gelenMail_MouseDown(sender As Object, e As MouseEventArgs) Handles lbl_gelenMail.MouseDown
        baslamaNoktasi = New Point(e.X, e.Y) ' tıklanan yerin kordinatını alıyor
    End Sub

    Private Sub lbl_gelenMail_MouseMove(sender As Object, e As MouseEventArgs) Handles lbl_gelenMail.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim p As Point = PointToScreen(e.Location)
            Location = New Point(p.X - Me.baslamaNoktasi.X, p.Y - Me.baslamaNoktasi.Y)
        End If
    End Sub

    Private Sub btn_kayitOl_Click(sender As Object, e As EventArgs) Handles btn_kayitOl.Click
        mc_Takvim.Visible = False
        lbl_silinenler.Visible = False
        lbl_taslakSayisi.Visible = False

        If Not pnl_kısaYollar.Visible Then
            pnl_kısaYollar.Location = New Point(0, 95)
            pnl_kısaYollar.Visible = True
        Else
            pnl_kısaYollar.Visible = False
            lbl_silinenler.Visible = True
            lbl_taslakSayisi.Visible = True
        End If
    End Sub

    Private Sub btn_ayarlar_Click(sender As Object, e As EventArgs) Handles btn_ayarlar.Click
        If Not pnl_ayarlar.Visible Then
            pnl_ayarlar.Visible = True
            If pnl_hesap.Visible = True Then
                pnl_hesap.Visible = False
            End If
        Else
            pnl_ayarlar.Visible = False
        End If
    End Sub

    Private Sub btn_hesap_Click(sender As Object, e As EventArgs) Handles btn_hesap.Click
        If Not pnl_hesap.Visible Then
            pnl_hesap.Location = New Point(999, 92)
            pnl_hesap.Visible = True
            If pnl_ayarlar.Visible Then
                pnl_ayarlar.Visible = False
            End If
        Else
            pnl_hesap.Visible = False
        End If

    End Sub

    Sub SablonRenklendirHex()
        pnl_mail.BackColor = ColorTranslator.FromHtml("#" & renkAdi)
        btn_gelenKutusu.BackColor = ColorTranslator.FromHtml("#" & renkAdi)
        btn_taslaklar.BackColor = ColorTranslator.FromHtml("#" & renkAdi)
        btn_silinmisler.BackColor = ColorTranslator.FromHtml("#" & renkAdi)
        btn_gonderilenler.BackColor = ColorTranslator.FromHtml("#" & renkAdi)
        lbl_gelenMail.BackColor = ColorTranslator.FromHtml("#" & renkAdi)
        lbl_gonderilenMailSayisi.BackColor = ColorTranslator.FromHtml("#" & renkAdi)
        lbl_silinenler.BackColor = ColorTranslator.FromHtml("#" & renkAdi)
        lbl_taslakSayisi.BackColor = ColorTranslator.FromHtml("#" & renkAdi)
        lbl_gelenlerinSayisi.BackColor = ColorTranslator.FromHtml("#" & renkAdi)
        lbl_Kullanici.BackColor = ColorTranslator.FromHtml("#" & renkAdi)
        lbl_KullaniciHesap.BackColor = ColorTranslator.FromHtml("#" & renkAdi)
        btn_ayarlar.BackColor = ColorTranslator.FromHtml("#" & renkAdi)
        btn_hesap.BackColor = ColorTranslator.FromHtml("#" & renkAdi)

    End Sub
    Sub SablonGenelRenkler()
        pnl_mail.BackColor = ColorTranslator.FromHtml(renkAdi)
        btn_gelenKutusu.BackColor = ColorTranslator.FromHtml(renkAdi)
        btn_taslaklar.BackColor = ColorTranslator.FromHtml(renkAdi)
        btn_silinmisler.BackColor = ColorTranslator.FromHtml(renkAdi)
        btn_gonderilenler.BackColor = ColorTranslator.FromHtml(renkAdi)
        lbl_gelenMail.BackColor = ColorTranslator.FromHtml(renkAdi)
        lbl_gonderilenMailSayisi.BackColor = ColorTranslator.FromHtml(renkAdi)
        lbl_silinenler.BackColor = ColorTranslator.FromHtml(renkAdi)
        lbl_taslakSayisi.BackColor = ColorTranslator.FromHtml(renkAdi)
        lbl_gelenlerinSayisi.BackColor = ColorTranslator.FromHtml(renkAdi)
        lbl_Kullanici.BackColor = ColorTranslator.FromHtml(renkAdi)
        lbl_KullaniciHesap.BackColor = ColorTranslator.FromHtml(renkAdi)
        btn_ayarlar.BackColor = ColorTranslator.FromHtml(renkAdi)
        btn_hesap.BackColor = ColorTranslator.FromHtml(renkAdi)
    End Sub
    Sub SablonGetir()
        sr = New StreamReader("tema/sablon.txt", FileMode.Open)
        While Not sr.EndOfStream
            MailRenk = sr.ReadLine()
            MailAry = MailRenk.Split(" ")
            If Email = MailAry(0) Then
                renkAdi = MailAry(1)
                If renkAdi.Contains("ff") Then
                    SablonRenklendirHex()
                Else
                    SablonGenelRenkler()
                End If
            End If
        End While
        sr.Close()
        sr.Dispose()
    End Sub
    Sub ArkaPlanGetir()

        sr = New StreamReader("tema/renkler.txt", FileMode.Open)
        While Not sr.EndOfStream
            MailRenk = sr.ReadLine()
            MailAry = MailRenk.Split(" ")

            If Email = MailAry(0) Then
                MailRenk = MailAry(1)

                If MailRenk.Contains("ff") Then
                    mdiControl.BackColor = System.Drawing.ColorTranslator.FromHtml("#" & MailRenk)
                    btn_kayitOl.BackColor = System.Drawing.ColorTranslator.FromHtml("#" & MailRenk)
                Else
                    mdiControl.BackColor = System.Drawing.ColorTranslator.FromHtml(MailRenk)
                    btn_kayitOl.BackColor = System.Drawing.ColorTranslator.FromHtml(MailRenk)
                End If
                Exit While
            End If
        End While
        sr.Close()
        sr.Dispose()
    End Sub

    Sub ArkaPlanDegistir()
        Dim okunan As String
        If arkaplanRenkKayitVarmi Then
            sr = New StreamReader("tema/renkler.txt", FileMode.Open)
            sw = New StreamWriter("tema/temp", FileMode.Append)
            While Not sr.EndOfStream
                okunan = sr.ReadLine()
                If okunan = MailRenk Then

                    sw.WriteLine(Email & " " & renkAdi)
                Else
                    sw.WriteLine(okunan)
                End If
            End While

            sw.Close()
            sw.Dispose()
            sr.Close()
            sr.Dispose()
            File.Delete("tema/renkler.txt")
            File.Copy("tema/temp", "tema/renkler.txt")
            File.Delete("tema/temp")

        Else

            mdiControl.BackColor = renk.Color
            renkAdi = renk.Color.Name

            sw = New StreamWriter("tema/renkler.txt", FileMode.Append)
            sw.WriteLine(kullanici.Pro_Email & " " & renkAdi)

            sw.Close()
            sw.Dispose()
            renk.Dispose()
        End If

        sr.Close()
        sr.Dispose()
    End Sub
    Sub SablonDegistir()
        Dim okunan As String
        If sablonKayitVarmi Then
            sr = New StreamReader("tema/sablon.txt", FileMode.Open)
            sw = New StreamWriter("tema/sablontemp", FileMode.Append)
            While Not sr.EndOfStream
                okunan = sr.ReadLine()
                If okunan = MailRenk Then

                    sw.WriteLine(Email & " " & renkAdi)
                Else
                    sw.WriteLine(okunan)
                End If
            End While

            sw.Close()
            sw.Dispose()
            sr.Close()
            sr.Dispose()
            File.Delete("tema/sablon.txt")
            File.Copy("tema/sablontemp", "tema/sablon.txt")
            File.Delete("tema/sablontemp")

        Else

            mdiControl.BackColor = renk.Color
            renkAdi = renk.Color.Name

            sw = New StreamWriter("tema/sablon.txt", FileMode.Append)
            sw.WriteLine(kullanici.Pro_Email & " " & renkAdi)

            sw.Close()
            sw.Dispose()
            renk.Dispose()
        End If

        sr.Close()
        sr.Dispose()
    End Sub



    Dim ms As MailSilmeIslemleri
    Dim ts As MailTaslak
    Dim Email As String
    Dim MailRenk As String
    Dim MailAry() As String
    Dim mailAlma As MailAlma
    Private Sub frm_mailicerik_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        kullanici = New KullaniciBilgileri
        Dim isimSoyisim As String = kullanici.VTDENisimSoyisimGetir()
        lbl_Kullanici.Text = "Hoş Geldiniz, " & isimSoyisim & "."
        lbl_KullaniciHesap.Text = "Bulunduğunuz Hesap : " & " " & kullanici.Pro_Email
        ts = New MailTaslak()
        ms = New MailSilmeIslemleri()
        mailAlma = New MailAlma()
        mdiControl = Me.Controls(Me.Controls.Count - 1)
        btn_kayitOl.BackColor = Color.Transparent
        Dim mail As New MailGonderme
        Email = mail.Pro_Email

        lbl_gonderilenMailSayisi.Text = mail.KisininGonderilenMailSayisi()
        lbl_taslakSayisi.Text = ts.taslakSayisi()
        lbl_silinenler.Text = ms.SilinenlerinSayisi()
        lbl_gelenlerinSayisi.Text = mailAlma.GelenMaillerinSayisi()
        SablonGetir()
        ArkaPlanGetir()

        AddHandler mdiControl.Click, AddressOf midi_Click
        If durum = False Then
            gelenMail = New frm_mailGelen
            gelenMail.MdiParent = Me
            gelenMail.Show()
            gelenMail.Activate()
            durum = False
        Else
            gelenMail.Activate()
            gelenMail.BringToFront()

        End If

        frm_aciklama.Dispose()

    End Sub

    Private Sub midi_Click(sender As Object, e As EventArgs)
        If pnl_kısaYollar.Visible Then
            pnl_kısaYollar.Visible = False
        End If
        If pnl_ayarlar.Visible Then
            pnl_ayarlar.Visible = False
        End If
        If pnl_hesap.Visible Then
            pnl_hesap.Visible = False
        End If
        If mc_Takvim.Visible Then
            mc_Takvim.Visible = False
        End If

    End Sub
    Dim mailGonder As New MailGonderme

    Dim durum As Boolean = False
    Dim sayac As Integer = 0
    Dim kontrol As Boolean = False
    Dim mailgelen(1) As frm_mailGelen
    Private Sub btn_gelenKutusu_Click(sender As Object, e As EventArgs) Handles btn_gelenKutusu.Click

        If durum = False Then

            If kontrol = True Then
                mailgelen(1).Dispose()
            End If

            mailgelen(sayac) = New frm_mailGelen
            mailgelen(sayac).MdiParent = Me
            mailgelen(sayac).Show()
            mailgelen(sayac).Activate()
            durum = True
            sayac += 1
            kontrol = False
        Else


            mailgelen(0).Dispose()
            mailgelen(sayac) = New frm_mailGelen
            mailgelen(sayac).MdiParent = Me
            mailgelen(sayac).Show()
            mailgelen(sayac).Activate()
            mailgelen(sayac).BringToFront()
            durum = False
            sayac = 0
            kontrol = True
        End If
    End Sub

    Dim durum2 As Boolean = False
    Dim sayac2 As Integer = 0
    Dim kontrol2 As Boolean = False
    Dim gonderilenMailPlatform(1) As frm_gonderilenMaillerPlatformu
    Private Sub btn_gonderilenler_Click(sender As Object, e As EventArgs) Handles btn_gonderilenler.Click
        If durum2 = False Then

            If kontrol2 = True Then
                gonderilenMailPlatform(1).Dispose()
            End If

            gonderilenMailPlatform(sayac2) = New frm_gonderilenMaillerPlatformu
            gonderilenMailPlatform(sayac2).MdiParent = Me
            gonderilenMailPlatform(sayac2).Show()
            gonderilenMailPlatform(sayac2).Activate()
            durum2 = True
            sayac2 += 1
            kontrol2 = False
        Else


            gonderilenMailPlatform(0).Dispose()
            gonderilenMailPlatform(sayac2) = New frm_gonderilenMaillerPlatformu
            gonderilenMailPlatform(sayac2).MdiParent = Me
            gonderilenMailPlatform(sayac2).Show()
            gonderilenMailPlatform(sayac2).Activate()
            gonderilenMailPlatform(sayac2).BringToFront()
            durum2 = False
            sayac2 = 0
            kontrol2 = True
        End If
    End Sub


    Dim durum3 As Boolean = False
    Dim sayac3 As Integer = 0
    Dim kontrol3 As Boolean = False
    Dim taslaklar(1) As frm_taslak
    Private Sub btn_taslaklar_Click(sender As Object, e As EventArgs) Handles btn_taslaklar.Click
        If durum3 = False Then

            If kontrol3 = True Then
                taslaklar(1).Dispose()
            End If

            taslaklar(sayac3) = New frm_taslak()
            taslaklar(sayac3).MdiParent = Me
            taslaklar(sayac3).Show()
            taslaklar(sayac3).Activate()
            durum3 = True
            sayac3 += 1
            kontrol3 = False
        Else

            taslaklar(0).Hide()
            taslaklar(0).Dispose()
            taslaklar(sayac3) = New frm_taslak()
            taslaklar(sayac3).MdiParent = Me
            taslaklar(sayac3).Show()
            taslaklar(sayac3).Activate()
            taslaklar(sayac3).BringToFront()
            durum3 = False
            sayac3 = 0
            kontrol3 = True
        End If

    End Sub

    Dim durum4 As Boolean = False
    Dim sayac4 As Integer = 0
    Dim kontrol4 As Boolean = False
    Dim silinenler(1) As frm_Silinenler
    Private Sub btn_silinmisler_Click(sender As Object, e As EventArgs) Handles btn_silinmisler.Click
        If durum4 = False Then

            If kontrol4 = True Then
                silinenler(1).Dispose()
            End If

            silinenler(sayac4) = New frm_Silinenler()
            silinenler(sayac4).MdiParent = Me
            silinenler(sayac4).Show()
            silinenler(sayac4).Activate()
            durum4 = True
            sayac4 += 1
            kontrol4 = False
        Else


            silinenler(0).Dispose()
            silinenler(sayac4) = New frm_Silinenler()
            silinenler(sayac4).MdiParent = Me
            silinenler(sayac4).Show()
            silinenler(sayac4).Activate()
            silinenler(sayac4).BringToFront()
            durum4 = False
            sayac4 = 0
            kontrol4 = True
        End If
    End Sub

    Private Sub btn_skype_Click(sender As Object, e As EventArgs) Handles btn_skype.Click
        System.Diagnostics.Process.Start("https://login.skype.com/login?client_id=578134&redirect_uri=https%3A%2F%2Fweb.skype.com%2F%3Fsource%3Dowa")
    End Sub

    Private Sub btn_word_Click(sender As Object, e As EventArgs) Handles btn_word.Click
        System.Diagnostics.Process.Start("https://office.live.com/start/Word.aspx?auth=1&nf=1#")
    End Sub

    Private Sub btn_excell_Click(sender As Object, e As EventArgs) Handles btn_excell.Click
        System.Diagnostics.Process.Start("https://office.live.com/start/Excel.aspx?auth=1&nf=1")
    End Sub

    Private Sub btn_takvim_Click(sender As Object, e As EventArgs) Handles btn_takvim.Click

        If Not mc_Takvim.Visible Then
            mc_Takvim.Visible = True
            mc_Takvim.Location = New Point(0, 380)

        Else
            mc_Takvim.Visible = False
        End If

    End Sub
    Private Sub btn_powerpoint_Click(sender As Object, e As EventArgs) Handles btn_powerpoint.Click
        System.Diagnostics.Process.Start("https://office.live.com/start/PowerPoint.aspx?auth=1&nf=1")
    End Sub

    Private Sub btn_bing_Click(sender As Object, e As EventArgs) Handles btn_bing.Click
        System.Diagnostics.Process.Start("http://www.bing.com/?FORM=MO0027")
    End Sub

    Private Sub btn_oneDrive_Click(sender As Object, e As EventArgs) Handles btn_oneDrive.Click
        System.Diagnostics.Process.Start("https://onedrive.live.com/")
    End Sub

    Private Sub btn_twitter_Click(sender As Object, e As EventArgs) Handles btn_msn.Click
        System.Diagnostics.Process.Start("https://twitter.com/")
    End Sub

    Private Sub btn_facebook_Click(sender As Object, e As EventArgs) Handles btn_kisiler.Click
        System.Diagnostics.Process.Start("https://www.facebook.com")
    End Sub



    Private Sub btn_cikis_Click(sender As Object, e As EventArgs) Handles btn_cikis.Click
        Me.Dispose()

        Dim giris As New frm_Giris
        giris.Show()

    End Sub
    Dim renkAdi As String
    Dim arkaplanRenkKayitVarmi As Boolean = False



    Dim sablonKayitVarmi As Boolean = False
    Private Sub btn_tema_Click(sender As Object, e As EventArgs) Handles btn_tema.Click

        kullanici = New KullaniciBilgileri()
        mdiControl = Me.Controls(Me.Controls.Count - 1)


        sr = New StreamReader("tema/renkler.txt", FileMode.Open)

        While Not sr.EndOfStream
            MailRenk = sr.ReadLine()
            MailAry = MailRenk.Split(" ")
            If Email = MailAry(0) Then
                arkaplanRenkKayitVarmi = True
                Exit While
            End If
        End While

        sr.Close()
        sr.Dispose()

        renk = New ColorDialog
        result = renk.ShowDialog()

        If result = Windows.Forms.DialogResult.Cancel Then
            renk.Dispose()
            Exit Sub
        End If

        renkAdi = renk.Color.Name
        If renkAdi.Contains("ff") Then
            mdiControl.BackColor = ColorTranslator.FromHtml("#" & renkAdi)
            btn_kayitOl.BackColor = ColorTranslator.FromHtml("#" & renkAdi)
        Else

            mdiControl.BackColor = ColorTranslator.FromHtml(renkAdi)
            btn_kayitOl.BackColor = ColorTranslator.FromHtml(renkAdi)
        End If

        ArkaPlanDegistir()


    End Sub



    Private Sub btn_sablon_Click(sender As Object, e As EventArgs) Handles btn_sablon.Click


        kullanici = New KullaniciBilgileri()
        renk = New ColorDialog()

        sr = New StreamReader("tema/sablon.txt", FileMode.Open)

        While Not sr.EndOfStream
            MailRenk = sr.ReadLine()
            MailAry = MailRenk.Split(" ")
            If Email = MailAry(0) Then
                sablonKayitVarmi = True
                Exit While
            End If
        End While

        sr.Close()
        sr.Dispose()


        result = renk.ShowDialog()
        If result = Windows.Forms.DialogResult.Cancel Then
            renk.Dispose()
            Exit Sub
        End If
        renkAdi = renk.Color.Name
        If renkAdi.Contains("ff") Then
            SablonRenklendirHex()
        Else
            SablonGenelRenkler()

        End If


        SablonDegistir()

    End Sub

    'Private Sub btn_yardim_Click(sender As Object, e As EventArgs) Handles btn_yardim.Click
    '    Dim a As Boolean = True
    '    frm_aciklama.Show()
    'End Sub
End Class