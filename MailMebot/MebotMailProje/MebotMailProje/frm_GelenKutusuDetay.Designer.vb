<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_GelenKutusuDetay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_GelenKutusuDetay))
        Me.dgv_dosyalar = New System.Windows.Forms.DataGridView()
        Me.cmn_dosyaUzanti = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmn_dosyaAdi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTMİndir = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.İndirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_tarih = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_konu = New System.Windows.Forms.TextBox()
        Me.rtxt_icerik = New System.Windows.Forms.RichTextBox()
        Me.lbl_gonderen = New System.Windows.Forms.Label()
        Me.btn_yanitla = New System.Windows.Forms.Button()
        CType(Me.dgv_dosyalar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CTMİndir.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_dosyalar
        '
        Me.dgv_dosyalar.AllowUserToAddRows = False
        Me.dgv_dosyalar.AllowUserToResizeColumns = False
        Me.dgv_dosyalar.AllowUserToResizeRows = False
        Me.dgv_dosyalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_dosyalar.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgv_dosyalar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_dosyalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_dosyalar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cmn_dosyaUzanti, Me.cmn_dosyaAdi})
        Me.dgv_dosyalar.ContextMenuStrip = Me.CTMİndir
        Me.dgv_dosyalar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv_dosyalar.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgv_dosyalar.Location = New System.Drawing.Point(0, 288)
        Me.dgv_dosyalar.MultiSelect = False
        Me.dgv_dosyalar.Name = "dgv_dosyalar"
        Me.dgv_dosyalar.RowHeadersVisible = False
        Me.dgv_dosyalar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgv_dosyalar.RowTemplate.Height = 100
        Me.dgv_dosyalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_dosyalar.Size = New System.Drawing.Size(652, 225)
        Me.dgv_dosyalar.StandardTab = True
        Me.dgv_dosyalar.TabIndex = 89
        '
        'cmn_dosyaUzanti
        '
        Me.cmn_dosyaUzanti.DataPropertyName = "dosyaUzantisi"
        Me.cmn_dosyaUzanti.HeaderText = "DosyaUzantısı"
        Me.cmn_dosyaUzanti.Name = "cmn_dosyaUzanti"
        '
        'cmn_dosyaAdi
        '
        Me.cmn_dosyaAdi.DataPropertyName = "dosyaAdi"
        Me.cmn_dosyaAdi.HeaderText = "DosyaAdı"
        Me.cmn_dosyaAdi.Name = "cmn_dosyaAdi"
        '
        'CTMİndir
        '
        Me.CTMİndir.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CTMİndir.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.İndirToolStripMenuItem})
        Me.CTMİndir.Name = "CTMİndir"
        Me.CTMİndir.Size = New System.Drawing.Size(115, 30)
        '
        'İndirToolStripMenuItem
        '
        Me.İndirToolStripMenuItem.Name = "İndirToolStripMenuItem"
        Me.İndirToolStripMenuItem.Size = New System.Drawing.Size(114, 26)
        Me.İndirToolStripMenuItem.Text = "İndir"
        '
        'lbl_tarih
        '
        Me.lbl_tarih.AutoSize = True
        Me.lbl_tarih.Font = New System.Drawing.Font("Minion Pro", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tarih.Location = New System.Drawing.Point(497, 3)
        Me.lbl_tarih.Name = "lbl_tarih"
        Me.lbl_tarih.Size = New System.Drawing.Size(52, 26)
        Me.lbl_tarih.TabIndex = 88
        Me.lbl_tarih.Text = "Tarih"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rod", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Konu"
        '
        'txt_konu
        '
        Me.txt_konu.Font = New System.Drawing.Font("Rod", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_konu.Location = New System.Drawing.Point(66, 44)
        Me.txt_konu.Name = "txt_konu"
        Me.txt_konu.ReadOnly = True
        Me.txt_konu.Size = New System.Drawing.Size(483, 34)
        Me.txt_konu.TabIndex = 86
        '
        'rtxt_icerik
        '
        Me.rtxt_icerik.Font = New System.Drawing.Font("Rod", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxt_icerik.Location = New System.Drawing.Point(0, 84)
        Me.rtxt_icerik.Name = "rtxt_icerik"
        Me.rtxt_icerik.ReadOnly = True
        Me.rtxt_icerik.Size = New System.Drawing.Size(653, 201)
        Me.rtxt_icerik.TabIndex = 85
        Me.rtxt_icerik.Text = ""
        '
        'lbl_gonderen
        '
        Me.lbl_gonderen.AutoSize = True
        Me.lbl_gonderen.Font = New System.Drawing.Font("Minion Pro", 12.2!)
        Me.lbl_gonderen.Location = New System.Drawing.Point(11, 9)
        Me.lbl_gonderen.Name = "lbl_gonderen"
        Me.lbl_gonderen.Size = New System.Drawing.Size(97, 28)
        Me.lbl_gonderen.TabIndex = 84
        Me.lbl_gonderen.Text = "Gönderen"
        '
        'btn_yanitla
        '
        Me.btn_yanitla.BackColor = System.Drawing.Color.Transparent
        Me.btn_yanitla.Image = CType(resources.GetObject("btn_yanitla.Image"), System.Drawing.Image)
        Me.btn_yanitla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_yanitla.Location = New System.Drawing.Point(558, 44)
        Me.btn_yanitla.Name = "btn_yanitla"
        Me.btn_yanitla.Size = New System.Drawing.Size(88, 35)
        Me.btn_yanitla.TabIndex = 90
        Me.btn_yanitla.Text = "Yanıtla"
        Me.btn_yanitla.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_yanitla.UseVisualStyleBackColor = False
        '
        'frm_GelenKutusuDetay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(652, 513)
        Me.Controls.Add(Me.btn_yanitla)
        Me.Controls.Add(Me.dgv_dosyalar)
        Me.Controls.Add(Me.lbl_tarih)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_konu)
        Me.Controls.Add(Me.rtxt_icerik)
        Me.Controls.Add(Me.lbl_gonderen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_GelenKutusuDetay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_GelenKutusuDetay"
        CType(Me.dgv_dosyalar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CTMİndir.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_dosyalar As System.Windows.Forms.DataGridView
    Friend WithEvents cmn_dosyaUzanti As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmn_dosyaAdi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_tarih As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_konu As System.Windows.Forms.TextBox
    Friend WithEvents rtxt_icerik As System.Windows.Forms.RichTextBox
    Friend WithEvents lbl_gonderen As System.Windows.Forms.Label
    Friend WithEvents CTMİndir As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents İndirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_yanitla As System.Windows.Forms.Button
End Class
