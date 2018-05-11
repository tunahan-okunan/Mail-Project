Public Class frm_Silinenler
    Dim ms As New MailSilmeIslemleri
    Private Sub frm_Silinenler_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ms.MailleriAl(dgv_mail, 3)
        Me.dgv_mail.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 10)
        dgv_mail.Columns(0).HeaderCell.Style.Font = New Font("Tahoma", 8.75F, FontStyle.Bold)
        dgv_mail.Columns(1).HeaderCell.Style.Font = New Font("Tahoma", 8.75F, FontStyle.Bold)
        dgv_mail.Columns(2).HeaderCell.Style.Font = New Font("Tahoma", 8.75F, FontStyle.Bold)
        dgv_mail.Columns(3).HeaderCell.Style.Font = New Font("Tahoma", 8.75F, FontStyle.Bold)
        dgv_mail.Columns(4).HeaderCell.Style.Font = New Font("Tahoma", 8.75F, FontStyle.Bold)
    End Sub

    Private Sub SilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SilToolStripMenuItem.Click
        Dim mailBox_ID As Integer = dgv_mail.CurrentRow.Cells(0).Value.ToString()
        ms.Pro_mailBoxID = mailBox_ID
        ms.ArkaplanDosyaSil()
        ms.SilinenlerMailSil()
        ms.SilinenlerDosyaSil()
        ms.MailleriAl(dgv_mail, 3)
        frm_mailicerik.lbl_silinenler.Text = ms.SilinenlerinSayisi()
    End Sub

    Dim durum As Boolean = False
    Dim durum2 As Boolean = False
    Dim maillerDetay(1) As frm_gonderilenMaillerDetay
    Dim sayac As Integer = 0
    Dim kontrol As Boolean = False
    Private Sub dgv_mail_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_mail.CellDoubleClick
        If e.RowIndex <> -1 Then
            If durum = False Then

                If kontrol = True Then
                    maillerDetay(1).Dispose()
                End If

                ms.Pro_mailBoxID = dgv_mail.CurrentRow().Cells(0).Value.ToString()
                maillerDetay(sayac) = New frm_gonderilenMaillerDetay()
                maillerDetay(sayac).MdiParent = frm_mailicerik
                maillerDetay(sayac).Show()
                maillerDetay(sayac).Activate()
                durum = True
                sayac += 1
                kontrol = False
            Else
                maillerDetay(0).Dispose()
                ms.Pro_mailBoxID = dgv_mail.CurrentRow().Cells(0).Value.ToString()
                maillerDetay(sayac) = New frm_gonderilenMaillerDetay()
                maillerDetay(sayac).MdiParent = frm_mailicerik
                maillerDetay(sayac).Show()
                maillerDetay(sayac).Activate()
                maillerDetay(sayac).BringToFront()
                durum = False
                sayac = 0
                kontrol = True
            End If
        End If
    End Sub

    Private Sub GörüntüleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GörüntüleToolStripMenuItem.Click
            If durum = False Then

                If kontrol = True Then
                    maillerDetay(1).Dispose()
                End If

            ms.Pro_mailBoxID = dgv_mail.CurrentRow().Cells(0).Value.ToString()
                maillerDetay(sayac) = New frm_gonderilenMaillerDetay()
                maillerDetay(sayac).MdiParent = frm_mailicerik
                maillerDetay(sayac).Show()
                maillerDetay(sayac).Activate()
                durum = True
                sayac += 1
                kontrol = False
            Else
                maillerDetay(0).Dispose()
            ms.Pro_mailBoxID = dgv_mail.CurrentRow().Cells(0).Value.ToString()
                maillerDetay(sayac) = New frm_gonderilenMaillerDetay()
                maillerDetay(sayac).MdiParent = frm_mailicerik
                maillerDetay(sayac).Show()
                maillerDetay(sayac).Activate()
                maillerDetay(sayac).BringToFront()
                durum = False
                sayac = 0
                kontrol = True
            End If
    End Sub

    Private Sub dgv_mail_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_mail.CellContentClick

    End Sub
End Class