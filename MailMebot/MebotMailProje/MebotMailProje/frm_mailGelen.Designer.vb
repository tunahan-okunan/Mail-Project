<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mailGelen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_mailGelen))
        Me.btn_yeni = New System.Windows.Forms.Button()
        Me.dgv_mail = New System.Windows.Forms.DataGridView()
        Me.cmn_mailBoxID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmn_gonderen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmb_konu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmb_icerik = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmb_Tarih = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cms_gelenler = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GoruntuleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_sil = New System.Windows.Forms.Button()
        Me.btn_bilgi = New System.Windows.Forms.Button()
        Me.lbl_Bilgilendirme = New System.Windows.Forms.Label()
        CType(Me.dgv_mail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_gelenler.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_yeni
        '
        Me.btn_yeni.BackColor = System.Drawing.Color.Transparent
        Me.btn_yeni.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_yeni.FlatAppearance.BorderSize = 0
        Me.btn_yeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_yeni.Font = New System.Drawing.Font("Comic Sans MS", 10.2!)
        Me.btn_yeni.Image = CType(resources.GetObject("btn_yeni.Image"), System.Drawing.Image)
        Me.btn_yeni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_yeni.Location = New System.Drawing.Point(6, 12)
        Me.btn_yeni.Name = "btn_yeni"
        Me.btn_yeni.Size = New System.Drawing.Size(80, 40)
        Me.btn_yeni.TabIndex = 69
        Me.btn_yeni.Text = "Yeni"
        Me.btn_yeni.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_yeni.UseVisualStyleBackColor = False
        '
        'dgv_mail
        '
        Me.dgv_mail.AllowUserToAddRows = False
        Me.dgv_mail.AllowUserToResizeColumns = False
        Me.dgv_mail.AllowUserToResizeRows = False
        Me.dgv_mail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_mail.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgv_mail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_mail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_mail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cmn_mailBoxID, Me.cmn_gonderen, Me.cmb_konu, Me.cmb_icerik, Me.cmb_Tarih})
        Me.dgv_mail.ContextMenuStrip = Me.cms_gelenler
        Me.dgv_mail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv_mail.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgv_mail.Location = New System.Drawing.Point(0, 80)
        Me.dgv_mail.MultiSelect = False
        Me.dgv_mail.Name = "dgv_mail"
        Me.dgv_mail.ReadOnly = True
        Me.dgv_mail.RowHeadersVisible = False
        Me.dgv_mail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgv_mail.RowTemplate.Height = 24
        Me.dgv_mail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_mail.Size = New System.Drawing.Size(652, 433)
        Me.dgv_mail.StandardTab = True
        Me.dgv_mail.TabIndex = 83
        '
        'cmn_mailBoxID
        '
        Me.cmn_mailBoxID.DataPropertyName = "mailbox_ID"
        Me.cmn_mailBoxID.HeaderText = "MailBoxID"
        Me.cmn_mailBoxID.Name = "cmn_mailBoxID"
        Me.cmn_mailBoxID.ReadOnly = True
        Me.cmn_mailBoxID.Visible = False
        '
        'cmn_gonderen
        '
        Me.cmn_gonderen.DataPropertyName = "gonderen"
        Me.cmn_gonderen.HeaderText = "Gönderen"
        Me.cmn_gonderen.Name = "cmn_gonderen"
        Me.cmn_gonderen.ReadOnly = True
        '
        'cmb_konu
        '
        Me.cmb_konu.DataPropertyName = "konu"
        Me.cmb_konu.HeaderText = "Konu"
        Me.cmb_konu.Name = "cmb_konu"
        Me.cmb_konu.ReadOnly = True
        '
        'cmb_icerik
        '
        Me.cmb_icerik.DataPropertyName = "icerik"
        Me.cmb_icerik.HeaderText = "İçerik"
        Me.cmb_icerik.Name = "cmb_icerik"
        Me.cmb_icerik.ReadOnly = True
        '
        'cmb_Tarih
        '
        Me.cmb_Tarih.DataPropertyName = "tarih"
        Me.cmb_Tarih.HeaderText = "Gönderilen Tarih"
        Me.cmb_Tarih.Name = "cmb_Tarih"
        Me.cmb_Tarih.ReadOnly = True
        '
        'cms_gelenler
        '
        Me.cms_gelenler.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cms_gelenler.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoruntuleToolStripMenuItem, Me.SilToolStripMenuItem})
        Me.cms_gelenler.Name = "cms_gonderilenler"
        Me.cms_gelenler.Size = New System.Drawing.Size(150, 56)
        '
        'GoruntuleToolStripMenuItem
        '
        Me.GoruntuleToolStripMenuItem.Name = "GoruntuleToolStripMenuItem"
        Me.GoruntuleToolStripMenuItem.Size = New System.Drawing.Size(149, 26)
        Me.GoruntuleToolStripMenuItem.Text = "Görüntüle"
        '
        'SilToolStripMenuItem
        '
        Me.SilToolStripMenuItem.Name = "SilToolStripMenuItem"
        Me.SilToolStripMenuItem.Size = New System.Drawing.Size(149, 26)
        Me.SilToolStripMenuItem.Text = "Sil"
        '
        'btn_sil
        '
        Me.btn_sil.BackColor = System.Drawing.Color.Transparent
        Me.btn_sil.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_sil.FlatAppearance.BorderSize = 0
        Me.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sil.Font = New System.Drawing.Font("Comic Sans MS", 10.2!)
        Me.btn_sil.Image = CType(resources.GetObject("btn_sil.Image"), System.Drawing.Image)
        Me.btn_sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_sil.Location = New System.Drawing.Point(92, 12)
        Me.btn_sil.Name = "btn_sil"
        Me.btn_sil.Size = New System.Drawing.Size(69, 40)
        Me.btn_sil.TabIndex = 84
        Me.btn_sil.Text = "Sil"
        Me.btn_sil.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_sil.UseVisualStyleBackColor = False
        '
        'btn_bilgi
        '
        Me.btn_bilgi.BackColor = System.Drawing.Color.Transparent
        Me.btn_bilgi.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_bilgi.FlatAppearance.BorderSize = 0
        Me.btn_bilgi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_bilgi.Font = New System.Drawing.Font("Comic Sans MS", 10.2!)
        Me.btn_bilgi.Image = CType(resources.GetObject("btn_bilgi.Image"), System.Drawing.Image)
        Me.btn_bilgi.Location = New System.Drawing.Point(167, 12)
        Me.btn_bilgi.Name = "btn_bilgi"
        Me.btn_bilgi.Size = New System.Drawing.Size(37, 40)
        Me.btn_bilgi.TabIndex = 85
        Me.btn_bilgi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_bilgi.UseVisualStyleBackColor = False
        '
        'lbl_Bilgilendirme
        '
        Me.lbl_Bilgilendirme.AutoSize = True
        Me.lbl_Bilgilendirme.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Bilgilendirme.Location = New System.Drawing.Point(210, 12)
        Me.lbl_Bilgilendirme.Name = "lbl_Bilgilendirme"
        Me.lbl_Bilgilendirme.Size = New System.Drawing.Size(305, 68)
        Me.lbl_Bilgilendirme.TabIndex = 86
        Me.lbl_Bilgilendirme.Text = "Sol taraftaki sil butonu ile hem uygulamadan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "hemde hemde outlook,hotmail vs. sit" & _
    "elerden de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "mail silebilirsiniz." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lbl_Bilgilendirme.Visible = False
        '
        'frm_mailGelen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 513)
        Me.Controls.Add(Me.lbl_Bilgilendirme)
        Me.Controls.Add(Me.btn_bilgi)
        Me.Controls.Add(Me.btn_sil)
        Me.Controls.Add(Me.dgv_mail)
        Me.Controls.Add(Me.btn_yeni)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_mailGelen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_mailGelen"
        CType(Me.dgv_mail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_gelenler.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_yeni As System.Windows.Forms.Button
    Friend WithEvents dgv_mail As System.Windows.Forms.DataGridView
    Friend WithEvents cmn_mailBoxID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmn_gonderen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmb_konu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmb_icerik As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmb_Tarih As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cms_gelenler As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GoruntuleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_sil As System.Windows.Forms.Button
    Friend WithEvents btn_bilgi As System.Windows.Forms.Button
    Friend WithEvents lbl_Bilgilendirme As System.Windows.Forms.Label
End Class
