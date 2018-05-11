<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_gonderilenMaillerPlatformu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_gonderilenMaillerPlatformu))
        Me.dgv_mail = New System.Windows.Forms.DataGridView()
        Me.cmn_mailBoxID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmn_Alici = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmb_konu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmb_icerik = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmb_Tarih = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cms_gonderilenler = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GoruntuleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pb_ara = New System.Windows.Forms.PictureBox()
        Me.txt_ara = New System.Windows.Forms.TextBox()
        Me.rb_tumu = New System.Windows.Forms.RadioButton()
        Me.rb_son7Gun = New System.Windows.Forms.RadioButton()
        Me.rb__buYil = New System.Windows.Forms.RadioButton()
        Me.rb_BuAy = New System.Windows.Forms.RadioButton()
        Me.rb_aralik = New System.Windows.Forms.RadioButton()
        Me.dtp_Baslangic = New System.Windows.Forms.DateTimePicker()
        Me.dtp_bitis = New System.Windows.Forms.DateTimePicker()
        Me.btn_aralik_ara = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgv_mail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_gonderilenler.SuspendLayout()
        CType(Me.pb_ara, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.dgv_mail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cmn_mailBoxID, Me.cmn_Alici, Me.cmb_konu, Me.cmb_icerik, Me.cmb_Tarih})
        Me.dgv_mail.ContextMenuStrip = Me.cms_gonderilenler
        Me.dgv_mail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv_mail.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgv_mail.Location = New System.Drawing.Point(0, 105)
        Me.dgv_mail.MultiSelect = False
        Me.dgv_mail.Name = "dgv_mail"
        Me.dgv_mail.ReadOnly = True
        Me.dgv_mail.RowHeadersVisible = False
        Me.dgv_mail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgv_mail.RowTemplate.Height = 24
        Me.dgv_mail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_mail.Size = New System.Drawing.Size(652, 408)
        Me.dgv_mail.StandardTab = True
        Me.dgv_mail.TabIndex = 82
        '
        'cmn_mailBoxID
        '
        Me.cmn_mailBoxID.DataPropertyName = "mailbox_ID"
        Me.cmn_mailBoxID.HeaderText = "MailBoxID"
        Me.cmn_mailBoxID.Name = "cmn_mailBoxID"
        Me.cmn_mailBoxID.ReadOnly = True
        Me.cmn_mailBoxID.Visible = False
        '
        'cmn_Alici
        '
        Me.cmn_Alici.DataPropertyName = "alici"
        Me.cmn_Alici.HeaderText = "Alıcı"
        Me.cmn_Alici.Name = "cmn_Alici"
        Me.cmn_Alici.ReadOnly = True
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
        'cms_gonderilenler
        '
        Me.cms_gonderilenler.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cms_gonderilenler.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoruntuleToolStripMenuItem, Me.SilToolStripMenuItem})
        Me.cms_gonderilenler.Name = "cms_gonderilenler"
        Me.cms_gonderilenler.Size = New System.Drawing.Size(150, 56)
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
        'pb_ara
        '
        Me.pb_ara.BackColor = System.Drawing.SystemColors.Window
        Me.pb_ara.BackgroundImage = CType(resources.GetObject("pb_ara.BackgroundImage"), System.Drawing.Image)
        Me.pb_ara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_ara.Location = New System.Drawing.Point(623, 1)
        Me.pb_ara.Name = "pb_ara"
        Me.pb_ara.Size = New System.Drawing.Size(29, 30)
        Me.pb_ara.TabIndex = 85
        Me.pb_ara.TabStop = False
        '
        'txt_ara
        '
        Me.txt_ara.Dock = System.Windows.Forms.DockStyle.Top
        Me.txt_ara.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara.Location = New System.Drawing.Point(0, 0)
        Me.txt_ara.Name = "txt_ara"
        Me.txt_ara.Size = New System.Drawing.Size(652, 31)
        Me.txt_ara.TabIndex = 84
        '
        'rb_tumu
        '
        Me.rb_tumu.AutoSize = True
        Me.rb_tumu.Checked = True
        Me.rb_tumu.Location = New System.Drawing.Point(7, 22)
        Me.rb_tumu.Name = "rb_tumu"
        Me.rb_tumu.Size = New System.Drawing.Size(65, 21)
        Me.rb_tumu.TabIndex = 0
        Me.rb_tumu.TabStop = True
        Me.rb_tumu.Text = "Tümü"
        Me.rb_tumu.UseVisualStyleBackColor = True
        '
        'rb_son7Gun
        '
        Me.rb_son7Gun.AutoSize = True
        Me.rb_son7Gun.Location = New System.Drawing.Point(74, 22)
        Me.rb_son7Gun.Name = "rb_son7Gun"
        Me.rb_son7Gun.Size = New System.Drawing.Size(97, 21)
        Me.rb_son7Gun.TabIndex = 1
        Me.rb_son7Gun.Text = "Son 7 Gün"
        Me.rb_son7Gun.UseVisualStyleBackColor = True
        '
        'rb__buYil
        '
        Me.rb__buYil.AutoSize = True
        Me.rb__buYil.Location = New System.Drawing.Point(243, 24)
        Me.rb__buYil.Name = "rb__buYil"
        Me.rb__buYil.Size = New System.Drawing.Size(65, 21)
        Me.rb__buYil.TabIndex = 3
        Me.rb__buYil.Text = "Bu Yıl"
        Me.rb__buYil.UseVisualStyleBackColor = True
        '
        'rb_BuAy
        '
        Me.rb_BuAy.AutoSize = True
        Me.rb_BuAy.Location = New System.Drawing.Point(172, 22)
        Me.rb_BuAy.Name = "rb_BuAy"
        Me.rb_BuAy.Size = New System.Drawing.Size(66, 21)
        Me.rb_BuAy.TabIndex = 2
        Me.rb_BuAy.Text = "Bu Ay"
        Me.rb_BuAy.UseVisualStyleBackColor = True
        '
        'rb_aralik
        '
        Me.rb_aralik.AutoSize = True
        Me.rb_aralik.Location = New System.Drawing.Point(311, 24)
        Me.rb_aralik.Name = "rb_aralik"
        Me.rb_aralik.Size = New System.Drawing.Size(92, 21)
        Me.rb_aralik.TabIndex = 4
        Me.rb_aralik.Text = "Aralık Seç"
        Me.rb_aralik.UseVisualStyleBackColor = True
        '
        'dtp_Baslangic
        '
        Me.dtp_Baslangic.Enabled = False
        Me.dtp_Baslangic.Location = New System.Drawing.Point(409, 12)
        Me.dtp_Baslangic.Name = "dtp_Baslangic"
        Me.dtp_Baslangic.Size = New System.Drawing.Size(203, 22)
        Me.dtp_Baslangic.TabIndex = 5
        '
        'dtp_bitis
        '
        Me.dtp_bitis.Enabled = False
        Me.dtp_bitis.Location = New System.Drawing.Point(409, 40)
        Me.dtp_bitis.Name = "dtp_bitis"
        Me.dtp_bitis.Size = New System.Drawing.Size(203, 22)
        Me.dtp_bitis.TabIndex = 6
        '
        'btn_aralik_ara
        '
        Me.btn_aralik_ara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_aralik_ara.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aralik_ara.Image = CType(resources.GetObject("btn_aralik_ara.Image"), System.Drawing.Image)
        Me.btn_aralik_ara.Location = New System.Drawing.Point(618, 22)
        Me.btn_aralik_ara.Name = "btn_aralik_ara"
        Me.btn_aralik_ara.Size = New System.Drawing.Size(32, 32)
        Me.btn_aralik_ara.TabIndex = 7
        Me.btn_aralik_ara.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_aralik_ara)
        Me.GroupBox1.Controls.Add(Me.dtp_bitis)
        Me.GroupBox1.Controls.Add(Me.dtp_Baslangic)
        Me.GroupBox1.Controls.Add(Me.rb_aralik)
        Me.GroupBox1.Controls.Add(Me.rb_BuAy)
        Me.GroupBox1.Controls.Add(Me.rb__buYil)
        Me.GroupBox1.Controls.Add(Me.rb_son7Gun)
        Me.GroupBox1.Controls.Add(Me.rb_tumu)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(648, 70)
        Me.GroupBox1.TabIndex = 86
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tarih Filtre"
        '
        'frm_gonderilenMaillerPlatformu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(652, 513)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pb_ara)
        Me.Controls.Add(Me.txt_ara)
        Me.Controls.Add(Me.dgv_mail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_gonderilenMaillerPlatformu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_gonderilenMaillerPlatformu"
        CType(Me.dgv_mail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_gonderilenler.ResumeLayout(False)
        CType(Me.pb_ara, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_mail As System.Windows.Forms.DataGridView
    Friend WithEvents pb_ara As System.Windows.Forms.PictureBox
    Friend WithEvents txt_ara As System.Windows.Forms.TextBox
    Friend WithEvents cms_gonderilenler As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmn_mailBoxID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmn_Alici As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmb_konu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmb_icerik As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmb_Tarih As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GoruntuleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rb_tumu As System.Windows.Forms.RadioButton
    Friend WithEvents rb_son7Gun As System.Windows.Forms.RadioButton
    Friend WithEvents rb__buYil As System.Windows.Forms.RadioButton
    Friend WithEvents rb_BuAy As System.Windows.Forms.RadioButton
    Friend WithEvents rb_aralik As System.Windows.Forms.RadioButton
    Friend WithEvents dtp_Baslangic As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_bitis As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_aralik_ara As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
