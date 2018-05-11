Public Class frm_taslak
    Dim ts As New MailTaslak

    Private Sub frm_taslak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mg As New MailGonderme
        mg.MailleriAl(dgv_mail, 4)
        Me.dgv_mail.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 10)
        dgv_mail.Columns(0).HeaderCell.Style.Font = New Font("Tahoma", 8.75F, FontStyle.Bold)
        dgv_mail.Columns(1).HeaderCell.Style.Font = New Font("Tahoma", 8.75F, FontStyle.Bold)
        dgv_mail.Columns(2).HeaderCell.Style.Font = New Font("Tahoma", 8.75F, FontStyle.Bold)
        dgv_mail.Columns(3).HeaderCell.Style.Font = New Font("Tahoma", 8.75F, FontStyle.Bold)
        dgv_mail.Columns(4).HeaderCell.Style.Font = New Font("Tahoma", 6.75F, FontStyle.Bold)
    End Sub


    Public Shared taslakDurumu As Boolean
    Dim durum As Boolean = False
    Dim sayac As Integer = 0
    Dim kontrol As Boolean = False
    Dim gonderme(1) As frm_mailGonderme
    Dim mg As New MailGonderme


    Private Sub dgv_mail_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_mail.CellDoubleClick
        If e.RowIndex <> -1 Then

            If durum = False Then

                If kontrol = True Then
                    gonderme(1).Dispose()
                End If
                taslakDurumu = True
                mg.Pro_mailBoxID = dgv_mail.CurrentRow().Cells(0).Value.ToString()

                gonderme(sayac) = New frm_mailGonderme()
                gonderme(sayac).MdiParent = frm_mailicerik
                gonderme(sayac).Show()
                gonderme(sayac).Activate()
                durum = True
                sayac += 1
                kontrol = False

            Else
                taslakDurumu = True
                gonderme(0).Dispose()
                mg.Pro_mailBoxID = dgv_mail.CurrentRow().Cells(0).Value.ToString()

                gonderme(sayac) = New frm_mailGonderme()
                gonderme(sayac).MdiParent = frm_mailicerik
                gonderme(sayac).Show()
                gonderme(sayac).Activate()
                gonderme(sayac).BringToFront()
                durum = False
                sayac = 0
                kontrol = True
            End If
        End If
    End Sub

    Private Sub SilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SilToolStripMenuItem.Click
        mg.Pro_mailBoxID = dgv_mail.CurrentRow().Cells(0).Value.ToString()
        ts.taslakSil()
        mg.MailleriAl(dgv_mail, 4)
        frm_mailicerik.lbl_taslakSayisi.Text = ts.taslakSayisi()
    End Sub

    Private Sub GörüntüleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GörüntüleToolStripMenuItem.Click
        If durum = False Then

            If kontrol = True Then
                gonderme(1).Dispose()
            End If
            taslakDurumu = True
            mg.Pro_mailBoxID = dgv_mail.CurrentRow().Cells(0).Value.ToString()
            gonderme(sayac) = New frm_mailGonderme()
            gonderme(sayac).MdiParent = frm_mailicerik
            gonderme(sayac).Show()
            gonderme(sayac).Activate()
            durum = True
            sayac += 1
            kontrol = False

        Else
            taslakDurumu = True
            gonderme(0).Dispose()
            mg.Pro_mailBoxID = dgv_mail.CurrentRow().Cells(0).Value.ToString()
            gonderme(sayac) = New frm_mailGonderme()
            gonderme(sayac).MdiParent = frm_mailicerik
            gonderme(sayac).Show()
            gonderme(sayac).Activate()
            gonderme(sayac).BringToFront()
            durum = False
            sayac = 0
            kontrol = True
        End If
    End Sub

   
  
    Private Sub dgv_mail_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_mail.CellContentClick

    End Sub
End Class