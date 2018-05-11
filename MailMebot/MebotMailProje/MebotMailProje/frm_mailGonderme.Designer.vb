<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mailGonderme
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_mailGonderme))
        Me.txt_konu = New System.Windows.Forms.TextBox()
        Me.txt_kime = New System.Windows.Forms.TextBox()
        Me.lbl_konu = New System.Windows.Forms.Label()
        Me.rtxt_icerik = New System.Windows.Forms.RichTextBox()
        Me.btn_dosyaSec = New System.Windows.Forms.Button()
        Me.btn_gonder = New System.Windows.Forms.Button()
        Me.lbl_kime = New System.Windows.Forms.Label()
        Me.lb_dosya = New System.Windows.Forms.ListBox()
        Me.Cms_dosyaIslem = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_taslak = New System.Windows.Forms.Button()
        Me.cb_Sifreleme = New System.Windows.Forms.CheckBox()
        Me.Cms_dosyaIslem.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_konu
        '
        Me.txt_konu.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_konu.Location = New System.Drawing.Point(102, 98)
        Me.txt_konu.Name = "txt_konu"
        Me.txt_konu.Size = New System.Drawing.Size(517, 31)
        Me.txt_konu.TabIndex = 1
        '
        'txt_kime
        '
        Me.txt_kime.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_kime.Location = New System.Drawing.Point(103, 52)
        Me.txt_kime.Name = "txt_kime"
        Me.txt_kime.Size = New System.Drawing.Size(516, 31)
        Me.txt_kime.TabIndex = 0
        '
        'lbl_konu
        '
        Me.lbl_konu.AutoSize = True
        Me.lbl_konu.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_konu.Location = New System.Drawing.Point(24, 98)
        Me.lbl_konu.Name = "lbl_konu"
        Me.lbl_konu.Size = New System.Drawing.Size(55, 28)
        Me.lbl_konu.TabIndex = 74
        Me.lbl_konu.Text = "Konu"
        '
        'rtxt_icerik
        '
        Me.rtxt_icerik.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.rtxt_icerik.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.rtxt_icerik.Location = New System.Drawing.Point(0, 147)
        Me.rtxt_icerik.Name = "rtxt_icerik"
        Me.rtxt_icerik.Size = New System.Drawing.Size(652, 299)
        Me.rtxt_icerik.TabIndex = 2
        Me.rtxt_icerik.Text = ""
        '
        'btn_dosyaSec
        '
        Me.btn_dosyaSec.BackColor = System.Drawing.Color.Transparent
        Me.btn_dosyaSec.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_dosyaSec.FlatAppearance.BorderSize = 0
        Me.btn_dosyaSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_dosyaSec.Font = New System.Drawing.Font("Comic Sans MS", 10.2!)
        Me.btn_dosyaSec.Image = CType(resources.GetObject("btn_dosyaSec.Image"), System.Drawing.Image)
        Me.btn_dosyaSec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_dosyaSec.Location = New System.Drawing.Point(128, 6)
        Me.btn_dosyaSec.Name = "btn_dosyaSec"
        Me.btn_dosyaSec.Size = New System.Drawing.Size(131, 40)
        Me.btn_dosyaSec.TabIndex = 4
        Me.btn_dosyaSec.Text = "Dosya Seç"
        Me.btn_dosyaSec.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_dosyaSec.UseVisualStyleBackColor = False
        '
        'btn_gonder
        '
        Me.btn_gonder.BackColor = System.Drawing.Color.Transparent
        Me.btn_gonder.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_gonder.FlatAppearance.BorderSize = 0
        Me.btn_gonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_gonder.Font = New System.Drawing.Font("Comic Sans MS", 10.2!)
        Me.btn_gonder.Image = CType(resources.GetObject("btn_gonder.Image"), System.Drawing.Image)
        Me.btn_gonder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_gonder.Location = New System.Drawing.Point(16, 6)
        Me.btn_gonder.Name = "btn_gonder"
        Me.btn_gonder.Size = New System.Drawing.Size(106, 40)
        Me.btn_gonder.TabIndex = 3
        Me.btn_gonder.Text = "Gönder"
        Me.btn_gonder.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_gonder.UseVisualStyleBackColor = False
        '
        'lbl_kime
        '
        Me.lbl_kime.AutoSize = True
        Me.lbl_kime.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_kime.Location = New System.Drawing.Point(24, 52)
        Me.lbl_kime.Name = "lbl_kime"
        Me.lbl_kime.Size = New System.Drawing.Size(56, 28)
        Me.lbl_kime.TabIndex = 77
        Me.lbl_kime.Text = "Kime"
        '
        'lb_dosya
        '
        Me.lb_dosya.ContextMenuStrip = Me.Cms_dosyaIslem
        Me.lb_dosya.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lb_dosya.FormattingEnabled = True
        Me.lb_dosya.ItemHeight = 16
        Me.lb_dosya.Location = New System.Drawing.Point(0, 445)
        Me.lb_dosya.Name = "lb_dosya"
        Me.lb_dosya.Size = New System.Drawing.Size(652, 68)
        Me.lb_dosya.TabIndex = 78
        '
        'Cms_dosyaIslem
        '
        Me.Cms_dosyaIslem.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Cms_dosyaIslem.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SilToolStripMenuItem})
        Me.Cms_dosyaIslem.Name = "Cms_dosyaIslem"
        Me.Cms_dosyaIslem.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.Cms_dosyaIslem.Size = New System.Drawing.Size(101, 30)
        '
        'SilToolStripMenuItem
        '
        Me.SilToolStripMenuItem.Name = "SilToolStripMenuItem"
        Me.SilToolStripMenuItem.Size = New System.Drawing.Size(100, 26)
        Me.SilToolStripMenuItem.Text = "Sil"
        '
        'btn_taslak
        '
        Me.btn_taslak.BackColor = System.Drawing.Color.Transparent
        Me.btn_taslak.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_taslak.FlatAppearance.BorderSize = 0
        Me.btn_taslak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_taslak.Font = New System.Drawing.Font("Comic Sans MS", 10.2!)
        Me.btn_taslak.Image = CType(resources.GetObject("btn_taslak.Image"), System.Drawing.Image)
        Me.btn_taslak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_taslak.Location = New System.Drawing.Point(265, 6)
        Me.btn_taslak.Name = "btn_taslak"
        Me.btn_taslak.Size = New System.Drawing.Size(166, 40)
        Me.btn_taslak.TabIndex = 79
        Me.btn_taslak.Text = "Taslağa Kaydet"
        Me.btn_taslak.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_taslak.UseVisualStyleBackColor = False
        '
        'cb_Sifreleme
        '
        Me.cb_Sifreleme.AutoSize = True
        Me.cb_Sifreleme.Location = New System.Drawing.Point(437, 19)
        Me.cb_Sifreleme.Name = "cb_Sifreleme"
        Me.cb_Sifreleme.Size = New System.Drawing.Size(133, 21)
        Me.cb_Sifreleme.TabIndex = 80
        Me.cb_Sifreleme.Text = "Şifreli gönderme"
        Me.cb_Sifreleme.UseVisualStyleBackColor = True
        '
        'frm_mailGonderme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(652, 513)
        Me.Controls.Add(Me.cb_Sifreleme)
        Me.Controls.Add(Me.btn_taslak)
        Me.Controls.Add(Me.lb_dosya)
        Me.Controls.Add(Me.lbl_kime)
        Me.Controls.Add(Me.txt_konu)
        Me.Controls.Add(Me.txt_kime)
        Me.Controls.Add(Me.lbl_konu)
        Me.Controls.Add(Me.rtxt_icerik)
        Me.Controls.Add(Me.btn_dosyaSec)
        Me.Controls.Add(Me.btn_gonder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_mailGonderme"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_mailGonderme"
        Me.Cms_dosyaIslem.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_konu As System.Windows.Forms.TextBox
    Friend WithEvents txt_kime As System.Windows.Forms.TextBox
    Friend WithEvents lbl_konu As System.Windows.Forms.Label
    Friend WithEvents rtxt_icerik As System.Windows.Forms.RichTextBox
    Friend WithEvents btn_dosyaSec As System.Windows.Forms.Button
    Friend WithEvents btn_gonder As System.Windows.Forms.Button
    Friend WithEvents lbl_kime As System.Windows.Forms.Label
    Friend WithEvents lb_dosya As System.Windows.Forms.ListBox
    Friend WithEvents Cms_dosyaIslem As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_taslak As System.Windows.Forms.Button
    Friend WithEvents cb_Sifreleme As System.Windows.Forms.CheckBox
End Class
