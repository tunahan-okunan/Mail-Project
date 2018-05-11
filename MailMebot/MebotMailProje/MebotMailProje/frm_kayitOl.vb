Public Class frm_kayitOl
    Dim baslamaNoktasi As Point


    Public Function RasgeleKelimeGetir() As String
        Dim yeniOlusanKelime As String = ""
        Dim rasgele As New Random
        Dim harfler As String = "ABCDEFGHIJKLMNOPRSTUVYZabcdefghijklmnoprstuvyz0123456789"
        Dim rasgeleDizi(3) As String
        For index = 0 To rasgeleDizi.Length - 1
            rasgeleDizi(index) = harfler(rasgele.Next(0, harfler.Length - 1))
            yeniOlusanKelime += rasgeleDizi(index)
        Next
        Return yeniOlusanKelime
    End Function

    Private Sub btn_kayitOl_Click(sender As Object, e As EventArgs) Handles btn_kayitOl.Click
        Dim Email, Sifre, Ad, Soyad, DogumTarihi As String
        Dim Yil_Bul As Integer
       

        Email = txt_kullaniciAd.Text
        Sifre = txt_sifre.Text
        Ad = txt_Ad.Text
        Soyad = txt_soyad.Text
        DogumTarihi = dtp_dogumTarihi.Value.ToString("yyyy-MM-dd")
        Yil_Bul = Now.Year() - dtp_dogumTarihi.Value.Year()

        If Email <> "" And Sifre <> "" And Ad <> "" And Soyad <> "" Then
            If Yil_Bul >= 7 Then
                If lbl_random.Text = txt_random.Text Then

                    Dim mailGonder As New MailGonderme
                    mailGonder.Pro_Email = Email
                    mailGonder.Pro_Sifre = Sifre
                    mailGonder.Pro_Ad = Ad
                    mailGonder.Pro_Soyad = Soyad
                    If Not mailGonder.mail_Varmi() Then
                        If mailGonder.mail_Kontrol() Then
                            mailGonder.Pro_DogumTarihi = DogumTarihi
                            mailGonder.Kullanici_Ekle()
                            Dim result As DialogResult = MessageBox.Show("Kayıt Başarıyla Eklenmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If result = DialogResult.OK Or result = Windows.Forms.DialogResult.Cancel Then
                                Me.Dispose()

                                If frm_Giris.Opacity = 0.5 Then
                                    frm_Giris.Opacity = 1

                                End If

                                frm_Giris.Show()
                            End If

                        End If
                    Else
                        MessageBox.Show("Böyle bir kayıt bulunmaktadır.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Girilen karakterler uyuşmamaktadır", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Kayıt olmak için 7 yaşından büyük olmalısınız!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Boş Bırakmayınız...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        
    End Sub

    Private Sub frm_kayitOl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_random.Text = ""
        lbl_random.Text = RasgeleKelimeGetir()
        dtp_dogumTarihi.MaxDate = Today
    End Sub

    Private Sub btn_Random_Click(sender As Object, e As EventArgs) Handles btn_Random.Click
        lbl_random.Text = ""
        lbl_random.Text = RasgeleKelimeGetir()
    End Sub

    Private Sub txt_kullaniciAd_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_kullaniciAd.KeyDown
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
        End If
    End Sub

    Private Sub btn_kapat_Click(sender As Object, e As EventArgs) Handles btn_kapat.Click
        Me.Dispose()
    
        If frm_Giris.Opacity = 0.5 Then
            frm_Giris.Opacity = 1

        End If

        frm_Giris.Show()

    End Sub

    Private Sub btn_simgeDurumu_Click(sender As Object, e As EventArgs) Handles btn_simgeDurumu.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pnl_giris_MouseMove(sender As Object, e As MouseEventArgs) Handles pnl_giris.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim p As Point = PointToScreen(e.Location)
            Location = New Point(p.X - Me.baslamaNoktasi.X, p.Y - Me.baslamaNoktasi.Y)
        End If

    End Sub

    Private Sub pnl_giris_MouseDown(sender As Object, e As MouseEventArgs) Handles pnl_giris.MouseDown
        baslamaNoktasi = New Point(e.X, e.Y) ' tıklanan yerin kordinatını alıyor
    End Sub

    Private Sub lbl_kayıtOl_MouseMove(sender As Object, e As MouseEventArgs) Handles lbl_kayıtOl.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim p As Point = PointToScreen(e.Location)
            Location = New Point(p.X - Me.baslamaNoktasi.X, p.Y - Me.baslamaNoktasi.Y)
        End If
    End Sub

    Private Sub lbl_kayıtOl_MouseDown(sender As Object, e As MouseEventArgs) Handles lbl_kayıtOl.MouseDown
        baslamaNoktasi = New Point(e.X, e.Y) ' tıklanan yerin kordinatını alıyor
    End Sub


    Private Sub mebot_simge_MouseDown(sender As Object, e As MouseEventArgs) Handles mebot_simge.MouseDown
        baslamaNoktasi = New Point(e.X, e.Y) ' tıklanan yerin kordinatını alıyor
    End Sub

    Private Sub mebot_simge_MouseMove(sender As Object, e As MouseEventArgs) Handles mebot_simge.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim p As Point = PointToScreen(e.Location)
            Location = New Point(p.X - Me.baslamaNoktasi.X, p.Y - Me.baslamaNoktasi.Y)
        End If

    End Sub

    Private Sub txt_Ad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Ad.KeyPress

        If Char.IsNumber(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If

  
    End Sub

    Private Sub txt_soyad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_soyad.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub


End Class