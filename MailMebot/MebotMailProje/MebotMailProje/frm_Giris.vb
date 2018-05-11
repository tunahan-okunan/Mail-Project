Public Class frm_Giris
    Dim baslamaNoktasi As Point
    Private Sub btn_kapat_Click(sender As Object, e As EventArgs) Handles btn_kapat.Click
        Application.Exit()
      
    End Sub

    Private Sub btn_simgeDurumu_Click(sender As Object, e As EventArgs) Handles btn_simgeDurumu.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub llbl_hesapOlustur_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbl_hesapOlustur.LinkClicked

        Me.Opacity = 0.5
        frm_kayitOl.StartPosition = FormStartPosition.CenterScreen
        frm_kayitOl.ShowDialog()
    End Sub

    Private Sub frm_Giris_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llbl_hesapOlustur.TabStop = False
        Dim kullanici As New KullaniciBilgileri
        Dim MailDurum, SifreDurum As String

        MailDurum = kullanici.BeniHatirla_Kullanici()
        SifreDurum = kullanici.BeniHatirla_Sifre()
        If MailDurum <> "False" And SifreDurum <> "False" Then
            txt_kullaniciAd.Text = MailDurum
            txt_sifre.Text = SifreDurum
            cb_beniHatirla.Checked = True
        End If
    End Sub

    Private Sub btn_giris_Click(sender As Object, e As EventArgs) Handles btn_giris.Click
        Dim Email, Sifre As String
        Email = txt_kullaniciAd.Text
        Sifre = txt_sifre.Text
        If Email <> "" And Sifre <> "" Then
            Dim kullanici As New KullaniciBilgileri
            kullanici.Pro_Email = txt_kullaniciAd.Text
            kullanici.Pro_Sifre = txt_sifre.Text
            If cb_beniHatirla.Checked Then
                kullanici.BeniHatırla_Update()
                If kullanici.Kullanici_GirisYap_Secili(Email, Sifre) Then



                    Me.Hide()
                    frm_aciklama.ShowDialog()
                    
                Else
                    MessageBox.Show("Giriş Hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            ElseIf Not cb_beniHatirla.Checked Then
                If kullanici.Kullanici_GirisYap(Email, Sifre) Then
                    Me.Hide()
                    frm_aciklama.ShowDialog()
                Else
                    MessageBox.Show("Giriş Hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If
        Else
            MessageBox.Show("Boş Geçilemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txt_kullaniciAd_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_kullaniciAd.KeyDown
        If e.KeyCode = Keys.Enter Then

            'Giris_click eventini çağırdık.
            btn_giris_Click(btn_giris, e)

        End If

        Dim aranan As Integer = txt_kullaniciAd.Text.IndexOf("@")
        If e.Modifiers = Keys.Control And e.KeyCode = Keys.G And aranan <> -1 And Not txt_kullaniciAd.Text.Contains("gmail.com") And Not txt_kullaniciAd.Text.Contains("hotmail.com") And Not txt_kullaniciAd.Text.Contains("yandex.com") And Not txt_kullaniciAd.Text.Contains("outlook.com") Then
            txt_kullaniciAd.Text += "gmail.com"
            txt_sifre.Focus()
        ElseIf e.Modifiers = Keys.Control And e.KeyCode = Keys.H And aranan <> -1 And Not txt_kullaniciAd.Text.Contains("gmail.com") And Not txt_kullaniciAd.Text.Contains("hotmail.com") And Not txt_kullaniciAd.Text.Contains("yandex.com") And Not txt_kullaniciAd.Text.Contains("outlook.com") Then
            txt_kullaniciAd.Text += "hotmail.com"
            txt_sifre.Focus()
        ElseIf e.Modifiers = Keys.Control And e.KeyCode = Keys.Y And aranan <> -1 And Not txt_kullaniciAd.Text.Contains("gmail.com") And Not txt_kullaniciAd.Text.Contains("hotmail.com") And Not txt_kullaniciAd.Text.Contains("yandex.com") And Not txt_kullaniciAd.Text.Contains("outlook.com") Then
            txt_kullaniciAd.Text += "yandex.com"
            txt_sifre.Focus()
        ElseIf e.Modifiers = Keys.Control And e.KeyCode = Keys.O And aranan <> -1 And Not txt_kullaniciAd.Text.Contains("gmail.com") And Not txt_kullaniciAd.Text.Contains("hotmail.com") And Not txt_kullaniciAd.Text.Contains("yandex.com") And Not txt_kullaniciAd.Text.Contains("outlook.com") Then
            txt_kullaniciAd.Text += "outlook.com"
            txt_sifre.Focus()
        ElseIf e.Modifiers = Keys.Control And e.KeyCode = Keys.T And aranan <> -1 And Not txt_kullaniciAd.Text.Contains("gmail.com") And Not txt_kullaniciAd.Text.Contains("hotmail.com") And Not txt_kullaniciAd.Text.Contains("yandex.com") And Not txt_kullaniciAd.Text.Contains("outlook.com") Then
            txt_kullaniciAd.Text += "trakya.edu.tr"
            txt_sifre.Focus()
        End If
    End Sub


    Private Sub btn_kapat_MouseHover(sender As Object, e As EventArgs) Handles btn_kapat.MouseHover
        Dim aciklama As New ToolTip
        aciklama.SetToolTip(btn_kapat, "Kapat")
    End Sub


    Private Sub mebot_SimgeGiris_MouseMove(sender As Object, e As MouseEventArgs) Handles mebot_SimgeGiris.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim p As Point = PointToScreen(e.Location)
            Location = New Point(p.X - Me.baslamaNoktasi.X, p.Y - Me.baslamaNoktasi.Y)
        End If
    End Sub

    Private Sub mebot_SimgeGiris_MouseDown(sender As Object, e As MouseEventArgs) Handles mebot_SimgeGiris.MouseDown
        baslamaNoktasi = New Point(e.X, e.Y)
    End Sub

    Private Sub mebot_Yazi_MouseMove(sender As Object, e As MouseEventArgs) Handles mebot_Yazi.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim p As Point = PointToScreen(e.Location)
            Location = New Point(p.X - Me.baslamaNoktasi.X, p.Y - Me.baslamaNoktasi.Y)
        End If
    End Sub

    Private Sub mebot_Yazi_MouseDown(sender As Object, e As MouseEventArgs) Handles mebot_Yazi.MouseDown
        baslamaNoktasi = New Point(e.X, e.Y)
    End Sub

    Private Sub pnl_giris_MouseMove(sender As Object, e As MouseEventArgs) Handles pnl_giris.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim p As Point = PointToScreen(e.Location)
            Location = New Point(p.X - Me.baslamaNoktasi.X, p.Y - Me.baslamaNoktasi.Y)
        End If
    End Sub

    Private Sub pnl_giris_MouseDown(sender As Object, e As MouseEventArgs) Handles pnl_giris.MouseDown
        baslamaNoktasi = New Point(e.X, e.Y)
    End Sub

   
   
    Private Sub txt_sifre_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_sifre.KeyDown
        If e.KeyCode = Keys.Enter Then

            'Giris_click eventini çağırdık.
            btn_giris_Click(btn_giris, e)

        End If
    End Sub
End Class
