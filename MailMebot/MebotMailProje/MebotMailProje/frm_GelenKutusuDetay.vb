Imports System.IO

Public Class frm_GelenKutusuDetay

    Dim mail As MailGonderme
    Private Sub frm_GelenKutusuDetay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mail = New MailGonderme()
        mail.GonderenGetir(lbl_gonderen, lbl_tarih, txt_konu, rtxt_icerik)
        mail.DosyaGetir(dgv_dosyalar)
        If dgv_dosyalar.RowCount = 0 Then
            İndirToolStripMenuItem.Visible = False
        End If

    End Sub


    Private Sub İndirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles İndirToolStripMenuItem.Click
        Dim uzanti As String
        Dim dosyaAdi As String

        Dim result As New FolderBrowserDialog
        result.ShowDialog()
        Dim yol As String = result.SelectedPath
        If yol <> "" Then

            uzanti = dgv_dosyalar.CurrentRow.Cells(0).Value.ToString()
            dosyaAdi = dgv_dosyalar.CurrentRow.Cells(1).Value.ToString()

            If File.Exists(uzanti) Then


                Try
                    File.Copy(uzanti, yol & "\" & dosyaAdi)
                    MessageBox.Show("Dosya Kopyalama İşlemi Tamamlandı")
                Catch ex As Exception
                    MessageBox.Show("Hata" & ex.Message)
                End Try
            End If

            ' File.Copy("C:\Users\ENESSS\Desktop\Mebot_Degistirme\MailMebot\MebotMailProje\MebotMailProje\bin\Debug\dosyalar\resimler\adsız.png", yol & "\" & "adsız.png")
            '  File.Copy("dosyalar\resimler\adsız.png", yol & "\" & "adsız.png")
        End If
    End Sub


    Dim durum As Boolean = False
    Dim sayac As Integer = 0
    Dim kontrol As Boolean = False
    Dim gonderilenMailPlatform(1) As frm_mailGonderme
    Public Shared yanitlaDurum As Boolean = False
    Public Shared konuGec As String
    Public Shared gonderenGec As String
    Public Shared icerikGec As String
    Public Shared tarihGec As String
    Dim tarihnesne As New MailAlma
    Private Sub btn_yanitla_Click(sender As Object, e As EventArgs) Handles btn_yanitla.Click
        If durum = False Then

            If kontrol = True Then
                gonderilenMailPlatform(1).Dispose()
            End If
            yanitlaDurum = True
            konuGec = txt_konu.Text
            gonderenGec = lbl_gonderen.Text
            icerikGec = rtxt_icerik.Text
            tarihGec = tarihnesne.VTdenTarihCek
            gonderilenMailPlatform(sayac) = New frm_mailGonderme
            gonderilenMailPlatform(sayac).MdiParent = frm_mailicerik
            gonderilenMailPlatform(sayac).Show()
            gonderilenMailPlatform(sayac).Activate()
            durum = True
            sayac += 1
            kontrol = False

        Else

            konuGec = txt_konu.Text
            gonderenGec = lbl_gonderen.Text
            icerikGec = rtxt_icerik.Text
            tarihGec = tarihnesne.VTdenTarihCek
            yanitlaDurum = True
            gonderilenMailPlatform(0).Dispose()
            gonderilenMailPlatform(sayac) = New frm_mailGonderme
            gonderilenMailPlatform(sayac).MdiParent = frm_mailicerik
            gonderilenMailPlatform(sayac).Show()
            gonderilenMailPlatform(sayac).Activate()
            gonderilenMailPlatform(sayac).BringToFront()
            durum = False
            sayac = 0
            kontrol = True

        End If
    End Sub
End Class