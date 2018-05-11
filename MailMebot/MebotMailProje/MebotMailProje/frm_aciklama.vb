Imports System.Threading

Public Class frm_aciklama

    Private Sub frm_aciklama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
  
        Timer1.Start()
    End Sub
    Dim sayac As Byte = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        sayac += 1
        If sayac = 3 Then
            frm_mailicerik.Show()
        End If

    End Sub
End Class