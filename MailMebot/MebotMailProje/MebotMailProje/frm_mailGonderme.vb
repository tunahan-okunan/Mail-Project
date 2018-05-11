Imports System.IO
Imports System.Threading

Public Class frm_mailGonderme

    Dim ts As New MailTaslak
    Dim dosyaListe As List(Of String) = New List(Of String)()
    Dim dosyaAdiListesi As List(Of String) = New List(Of String)()
    Dim boolDurum As Boolean

    Private Sub btn_gonder_Click(sender As Object, e As EventArgs) Handles btn_gonder.Click

        If txt_konu.Text <> "" And txt_kime.Text <> "" And rtxt_icerik.Text <> "" Then
            Dim kimlere() As String = txt_kime.Text.Split(",")
            Dim mailGonderme As New MailGonderme


            mailGonderme.kimlere_set(kimlere)
            mailGonderme.Pro_Konu = txt_konu.Text
            mailGonderme.Pro_Icerik = rtxt_icerik.Text
            mailGonderme.Pro_durum = boolDurum
            ' Dim t1 As Thread = New Thread(AddressOf mailGonderme.mailGondermeIslemi)
            Dim durum As Boolean = mailGonderme.mailGondermeIslemi()

            't1.Start()





            If durum Then
                MessageBox.Show("Mail gönderildi.", "Mail Gönderme Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information)

                txt_kime.Clear()
                txt_konu.Clear()
                rtxt_icerik.Clear()
                dosyaListe.Clear()
                dosyaAdiListesi.Clear()
                lb_dosya.Items.Clear()


                frm_mailicerik.lbl_gonderilenMailSayisi.Text = mailGonderme.KisininGonderilenMailSayisi()
                If frm_taslak.taslakDurumu = True Then
                    ts.taslakSil()
                    frm_mailicerik.lbl_taslakSayisi.Text = ts.taslakSayisi()
                    frm_taslak.taslakDurumu = False
                End If
                If btn_taslak.Enabled = False Then
                    Me.btn_taslak.Enabled = True
                End If

            End If
        Else
            MessageBox.Show("Boş bırakmayınız!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
    Public Sub dosyaListele()
        lb_dosya.Items.Clear()
        For Each d As String In dosyaListe
            lb_dosya.Items.Add(d)
        Next
    End Sub
    Dim mailGonder As New MailGonderme
    Private Sub btn_dosyaSec_Click(sender As Object, e As EventArgs) Handles btn_dosyaSec.Click
        Dim kontrol As Boolean = False
        Dim dosya As OpenFileDialog = New OpenFileDialog
        dosya.ShowDialog()
        If dosya.FileName <> "" Then
            For Each d As String In dosyaAdiListesi
                If d.Contains(Path.GetFileName(dosya.FileName)) Then
                    kontrol = True
                End If
            Next
            If kontrol = False Then
                dosyaListe.Add(dosya.FileName)
                dosyaAdiListesi.Add(Path.GetFileName(dosya.FileName))
            Else
                MessageBox.Show("Bu dosyayı daha önce eklendiniz!")
            End If
        End If

        dosyaListele()
        mailGonder.pro_dosyaListe = dosyaListe
        mailGonder.pro_dosyaAdiListe = dosyaAdiListesi
    End Sub

    Private Sub txt_kime_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_kime.KeyDown
        Dim aranan As Integer = txt_kime.Text.IndexOf("@")
        Dim uzunluk As Integer = 0
        If e.Modifiers = Keys.Control And e.KeyCode = Keys.G And aranan <> -1 Then
            uzunluk = txt_kime.TextLength
            If Mid(txt_kime.Text, uzunluk, 1) = "@" Then
                txt_kime.Text += "gmail.com"
                txt_kime.SelectionStart = txt_kime.Text.Length
            End If

        ElseIf e.Modifiers = Keys.Control And e.KeyCode = Keys.H And aranan <> -1 Then
            uzunluk = txt_kime.TextLength
            If Mid(txt_kime.Text, uzunluk, 1) = "@" Then
                txt_kime.Text += "hotmail.comm"
                txt_kime.SelectionStart = txt_kime.Text.Length
            End If

        ElseIf e.Modifiers = Keys.Control And e.KeyCode = Keys.Y And aranan <> -1 Then
            uzunluk = txt_kime.TextLength
            If Mid(txt_kime.Text, uzunluk, 1) = "@" Then
                txt_kime.Text += "yandex.com"
                txt_kime.SelectionStart = txt_kime.Text.Length
            End If

        ElseIf e.Modifiers = Keys.Control And e.KeyCode = Keys.O And aranan <> -1 Then
            uzunluk = txt_kime.TextLength
            If Mid(txt_kime.Text, uzunluk, 1) = "@" Then
                txt_kime.Text += "outlook.com"
                txt_kime.SelectionStart = txt_kime.Text.Length
            End If
        End If
    End Sub

    Private Sub SilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SilToolStripMenuItem.Click


        Dim durumKontrol As Boolean = False
        If dosyaAdiListesi.Count <> 0 Then
            For Each d As String In dosyaListe
                For Each dal As String In dosyaAdiListesi
                    If d.Contains(lb_dosya.SelectedItem) Then
                        dosyaListe.Remove(lb_dosya.SelectedItem)
                        dosyaAdiListesi.Remove(dal)
                        durumKontrol = True
                        Exit For
                    End If
                Next
                If durumKontrol = True Then
                    Exit For
                End If

            Next
            dosyaListele()
            Cms_dosyaIslem.Enabled = False
        End If





    End Sub

    Private Sub lb_dosya_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb_dosya.SelectedIndexChanged
        If lb_dosya.SelectedIndex <> -1 Then
            Cms_dosyaIslem.Enabled = True
        End If
    End Sub

    Private Sub frm_mailGonderme_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If frm_GelenKutusuDetay.yanitlaDurum = True Then
            txt_kime.Text = frm_GelenKutusuDetay.gonderenGec
            txt_konu.Text = frm_GelenKutusuDetay.konuGec
            For i = 0 To 8
                rtxt_icerik.Text += Environment.NewLine()
            Next

            rtxt_icerik.Text += frm_GelenKutusuDetay.tarihGec & " :" & Environment.NewLine() & frm_GelenKutusuDetay.icerikGec
        End If

        If frm_taslak.taslakDurumu = True Then
            btn_taslak.Enabled = False
            ts.taslakYazdir(txt_konu, txt_kime, rtxt_icerik)

        Else
            btn_taslak.Enabled = True
        End If

        Cms_dosyaIslem.Enabled = False
    End Sub

    Private Sub btn_taslak_Click(sender As Object, e As EventArgs) Handles btn_taslak.Click
        If txt_kime.Text.Trim = "" And txt_konu.Text.Trim = "" And rtxt_icerik.Text.Trim = "" And dosyaAdiListesi.Count = 0 Then
            MessageBox.Show("Taslağa Kayıt Edilemedi...")
        Else
            Dim kimlere() As String = txt_kime.Text.Trim.Split(",")
            mailGonder.kimlere_set(kimlere)
            mailGonder.Pro_Konu = txt_konu.Text.Trim
            mailGonder.Pro_Icerik = rtxt_icerik.Text.Trim
            ts.TaslakEkle()
            btn_taslak.Enabled = False
            dosyaListe.Clear()
            dosyaAdiListesi.Clear()
            MessageBox.Show("Taslağa Kayıt Edildi..(Dosyalar Kayıt Edilmeyecektir!)")
            frm_mailicerik.lbl_taslakSayisi.Text = ts.taslakSayisi()
            btn_dosyaSec.Enabled = False
            btn_gonder.Enabled = False
            txt_kime.ReadOnly = True
            txt_konu.ReadOnly = True
            rtxt_icerik.ReadOnly = True
        End If

    End Sub

    Private Sub cb_Sifreleme_CheckedChanged(sender As Object, e As EventArgs) Handles cb_Sifreleme.CheckedChanged

        If cb_Sifreleme.Checked Then
            boolDurum = True
        Else
            boolDurum = False
        End If
    End Sub
End Class