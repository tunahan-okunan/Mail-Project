Imports System.IO

Public Class frm_gonderilenMaillerDetay



    Dim mail As New MailGonderme
    Private Sub frm_gonderilenMaillerDetay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mail.AliciGetir(lbl_alici, lbl_tarih, txt_konu, rtxt_icerik)
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
End Class