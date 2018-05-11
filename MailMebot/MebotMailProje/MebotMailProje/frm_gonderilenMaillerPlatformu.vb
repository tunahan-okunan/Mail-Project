Public Class frm_gonderilenMaillerPlatformu
    Dim baslamaNoktasi As Point
    Private Sub pnl_giris_MouseDown(sender As Object, e As MouseEventArgs)
        baslamaNoktasi = New Point(e.X, e.Y) ' tıklanan yerin kordinatını alıyor
    End Sub

    Private Sub pnl_giris_MouseMove(sender As Object, e As MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim p As Point = PointToScreen(e.Location)
            Location = New Point(p.X - Me.baslamaNoktasi.X, p.Y - Me.baslamaNoktasi.Y)
        End If
    End Sub

    Private Sub frm_gonderilenMaillerPlatformu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtp_Baslangic.MaxDate = bugun
        dtp_bitis.MaxDate = bugun

        dtp_Baslangic.Enabled = False
        dtp_bitis.Enabled = False
        btn_aralik_ara.Enabled = False
        Dim mg As New MailGonderme
        mg.MailleriAl(dgv_mail, 1)
        Me.dgv_mail.Sort(Me.dgv_mail.Columns("cmb_Tarih"), System.ComponentModel.ListSortDirection.Descending)
        Me.dgv_mail.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 10)
        dgv_mail.Columns(0).HeaderCell.Style.Font = New Font("Tahoma", 8.75F, FontStyle.Bold)
        dgv_mail.Columns(1).HeaderCell.Style.Font = New Font("Tahoma", 8.75F, FontStyle.Bold)
        dgv_mail.Columns(2).HeaderCell.Style.Font = New Font("Tahoma", 8.75F, FontStyle.Bold)
        dgv_mail.Columns(3).HeaderCell.Style.Font = New Font("Tahoma", 8.75F, FontStyle.Bold)
        dgv_mail.Columns(4).HeaderCell.Style.Font = New Font("Tahoma", 8.75F, FontStyle.Bold)
    End Sub


    Dim ms As New MailSilmeIslemleri
    Dim mailler As New MailGonderme
    Dim tm As New TumMailler
    
    Private Sub txt_ara_TextChanged(sender As Object, e As EventArgs) Handles txt_ara.TextChanged
        If txt_ara.TextLength >= 1 Then
            If rb_tumu.Checked Then
                tm.Arama(dgv_mail, txt_ara.Text)
            ElseIf rb_son7Gun.Checked Then
                tm.Arama(dgv_mail, txt_ara.Text, "Month(tarih)=Month(GETDATE()) and YEAR(tarih)=YEAR(Getdate()) and Day(GETDATE())-Day(tarih)<=7")
            ElseIf rb_BuAy.Checked Then
                tm.Arama(dgv_mail, txt_ara.Text, "MONTH(getdate())=MONTH(tarih) and YEAR(getdate())=YEAR(tarih)")
            ElseIf rb__buYil.Checked Then
                tm.Arama(dgv_mail, txt_ara.Text, "YEAR(getdate())=YEAR(tarih)")
            ElseIf rb_aralik.Checked Then
                tm.Arama(dgv_mail, txt_ara.Text, "YEAR(tarih) BETWEEN '" & basYil & "' AND '" & bitisYil & "' and month(tarih) BETWEEN '" & basAy & "' and '" & bitisAy & "' and day(tarih) BETWEEN '" & basGun & "' and '" & bitisGun & "'")
            End If


            pb_ara.Visible = False
        Else
            If rb_tumu.Checked Then
                tm.MailleriAl(dgv_mail, 1)
            ElseIf rb_son7Gun.Checked Then
                tm.sonYediFiltre(dgv_mail)
            ElseIf rb_BuAy.Checked Then
                tm.buAyFiltre(dgv_mail)
            ElseIf rb__buYil.Checked Then
                tm.buYilFiltre(dgv_mail)
            ElseIf rb_aralik.Checked Then
                tm.buAraliktaFiltre(dgv_mail, basGun, basAy, basYil, bitisGun, bitisAy, bitisYil)
            End If



            pb_ara.Visible = True
        End If
    End Sub

    Private Sub SilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SilToolStripMenuItem.Click
        Dim mailBox_ID As Integer = dgv_mail.CurrentRow.Cells(0).Value.ToString()
        mailler.Pro_mailBoxID = mailBox_ID
        mailler.GonderilenleriGuncelle()


        mailler.MailleriAl(dgv_mail, 1)
        frm_mailicerik.lbl_gonderilenMailSayisi.Text = mailler.KisininGonderilenMailSayisi()
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

                mailler.Pro_mailBoxID = dgv_mail.CurrentRow().Cells(0).Value.ToString()
                maillerDetay(sayac) = New frm_gonderilenMaillerDetay()
                maillerDetay(sayac).MdiParent = frm_mailicerik
                maillerDetay(sayac).Show()
                maillerDetay(sayac).Activate()
                durum = True
                sayac += 1
                kontrol = False
            Else
                maillerDetay(0).Dispose()
                mailler.Pro_mailBoxID = dgv_mail.CurrentRow().Cells(0).Value.ToString()
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

    Private Sub GoruntuleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoruntuleToolStripMenuItem.Click

        If durum = False Then

            If kontrol = True Then
                maillerDetay(1).Dispose()
            End If

            mailler.Pro_mailBoxID = dgv_mail.CurrentRow().Cells(0).Value.ToString()
            maillerDetay(sayac) = New frm_gonderilenMaillerDetay()
            maillerDetay(sayac).MdiParent = frm_mailicerik
            maillerDetay(sayac).Show()
            maillerDetay(sayac).Activate()
            durum = True
            sayac += 1
            kontrol = False
        Else
            maillerDetay(0).Dispose()
            mailler.Pro_mailBoxID = dgv_mail.CurrentRow().Cells(0).Value.ToString()
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

    Private Sub rb_tumu_CheckedChanged(sender As Object, e As EventArgs) Handles rb_tumu.CheckedChanged
        If rb_tumu.Checked Then
            If txt_ara.Text = "" Then
                mailler.MailleriAl(dgv_mail, 1)
            Else
                tm.Arama(dgv_mail, txt_ara.Text)
            End If
            If dtp_Baslangic.Enabled = True And dtp_bitis.Enabled = True And btn_aralik_ara.Enabled = True Then
                dtp_Baslangic.Enabled = False
                dtp_bitis.Enabled = False
                btn_aralik_ara.Enabled = False
            End If

        End If


    End Sub

    Private Sub rb_son7Gun_CheckedChanged(sender As Object, e As EventArgs) Handles rb_son7Gun.CheckedChanged
        If rb_son7Gun.Checked Then
            If txt_ara.Text = "" Then
                tm.sonYediFiltre(dgv_mail)
            Else
                tm.Arama(dgv_mail, txt_ara.Text, "Month(tarih)=Month(GETDATE()) and YEAR(tarih)=YEAR(Getdate()) and Day(GETDATE())-Day(tarih)<=7")
            End If

            If dtp_Baslangic.Enabled = True And dtp_bitis.Enabled = True And btn_aralik_ara.Enabled = True Then
                dtp_Baslangic.Enabled = False
                dtp_bitis.Enabled = False
                btn_aralik_ara.Enabled = False
            End If
        End If


    End Sub

    Private Sub rb_BuAy_CheckedChanged(sender As Object, e As EventArgs) Handles rb_BuAy.CheckedChanged
        If rb_BuAy.Checked Then
            If txt_ara.Text = "" Then
                tm.buAyFiltre(dgv_mail)
            Else
                tm.Arama(dgv_mail, txt_ara.Text, "MONTH(getdate())=MONTH(tarih) and YEAR(getdate())=YEAR(tarih)")
            End If

            If dtp_Baslangic.Enabled = True And dtp_bitis.Enabled = True And btn_aralik_ara.Enabled = True Then
                dtp_Baslangic.Enabled = False
                dtp_bitis.Enabled = False
                btn_aralik_ara.Enabled = False
            End If
        End If
    End Sub

    Private Sub rb__buYil_CheckedChanged(sender As Object, e As EventArgs) Handles rb__buYil.CheckedChanged
        If rb__buYil.Checked Then
            If txt_ara.Text = "" Then
                tm.buYilFiltre(dgv_mail)
            Else
                tm.Arama(dgv_mail, txt_ara.Text, "YEAR(getdate())=YEAR(tarih)")
            End If

            If dtp_Baslangic.Enabled = True And dtp_bitis.Enabled = True And btn_aralik_ara.Enabled = True Then
                dtp_Baslangic.Enabled = False
                dtp_bitis.Enabled = False
                btn_aralik_ara.Enabled = False
            End If
        End If


    End Sub
    Private Sub rb_aralik_CheckedChanged(sender As Object, e As EventArgs) Handles rb_aralik.CheckedChanged
        If rb_aralik.Checked Then
            dtp_Baslangic.Enabled = True
            dtp_bitis.Enabled = True
            btn_aralik_ara.Enabled = True
        End If

    End Sub
   
    Dim tarihBaslangic As String
    Dim basGun, basAy, basYil As Integer
    Dim bitisGun, bitisAy, bitisYil As Integer
    Dim bugun As String = Now.Date.ToString("yyyy-MM-dd")
    Dim tarihBitis As String

    Dim baslangicSecilme As Boolean = False

    Private Sub dtp_Baslangic_ValueChanged(sender As Object, e As EventArgs) Handles dtp_Baslangic.ValueChanged

        tarihBaslangic = dtp_Baslangic.Value.ToString("yyyy-MM-dd")
        Dim basArry() As String = tarihBaslangic.Split("-")
        basGun = basArry(2)
        basAy = basArry(1)
        basYil = basArry(0)
        baslangicSecilme = True
        dtp_bitis.MinDate = tarihBaslangic
    End Sub


 
    Private Sub dtp_bitis_ValueChanged(sender As Object, e As EventArgs) Handles dtp_bitis.ValueChanged


       
        tarihBitis = dtp_bitis.Value.ToString("yyyy-MM-dd")
        Dim bitisArry() As String = tarihBitis.Split("-")
        bitisGun = bitisArry(2)
        bitisAy = bitisArry(1)
        bitisYil = bitisArry(0)
        dtp_Baslangic.MaxDate = tarihBitis
    End Sub

    Private Sub btn_aralik_ara_Click(sender As Object, e As EventArgs) Handles btn_aralik_ara.Click
        Dim bas As String = dtp_Baslangic.Value.ToString("yyyy-MM-dd")
        Dim bitis As String = dtp_bitis.Value.ToString("yyyy-MM-dd")


       
        If baslangicSecilme = False Then

            Dim bitisArry() As String = bugun.Split("-")
            bitisGun = bitisArry(2)
            bitisAy = bitisArry(1)
            bitisYil = bitisArry(0)
        End If

        If bas = bugun And bitis = bugun Then
            Dim basArry() As String = bas.Split("-")
            basGun = basArry(2)
            basAy = basArry(1)
            basYil = basArry(0)

            bitisGun = basArry(2)
            bitisAy = basArry(1)
            bitisYil = basArry(0)

        End If
       


        If txt_ara.Text = "" Then
            tm.buAraliktaFiltre(dgv_mail, basGun, basAy, basYil, bitisGun, bitisAy, bitisYil)
        Else

            tm.Arama(dgv_mail, txt_ara.Text, "tarih Between '" & basYil & "/" & basAy & "/" & basGun & " 00:00:00.000' and '" & bitisYil & "/" & bitisAy & "/" & bitisGun & " 23:59:59.999'")
        End If



    End Sub

   

End Class