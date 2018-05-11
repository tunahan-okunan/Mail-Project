<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_gonderilenMaillerDetay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_gonderilenMaillerDetay))
        Me.lbl_alici = New System.Windows.Forms.Label()
        Me.rtxt_icerik = New System.Windows.Forms.RichTextBox()
        Me.txt_konu = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_tarih = New System.Windows.Forms.Label()
        Me.dgv_dosyalar = New System.Windows.Forms.DataGridView()
        Me.cmn_dosyaUzanti = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmn_dosyaAdi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmn_dosya = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.İndirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgv_dosyalar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmn_dosya.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_alici
        '
        Me.lbl_alici.AutoSize = True
        Me.lbl_alici.Font = New System.Drawing.Font("Minion Pro", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_alici.Location = New System.Drawing.Point(12, 7)
        Me.lbl_alici.Name = "lbl_alici"
        Me.lbl_alici.Size = New System.Drawing.Size(71, 38)
        Me.lbl_alici.TabIndex = 0
        Me.lbl_alici.Text = "Alıcı"
        '
        'rtxt_icerik
        '
        Me.rtxt_icerik.Font = New System.Drawing.Font("Rod", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxt_icerik.Location = New System.Drawing.Point(0, 88)
        Me.rtxt_icerik.Name = "rtxt_icerik"
        Me.rtxt_icerik.ReadOnly = True
        Me.rtxt_icerik.Size = New System.Drawing.Size(653, 201)
        Me.rtxt_icerik.TabIndex = 1
        Me.rtxt_icerik.Text = ""
        '
        'txt_konu
        '
        Me.txt_konu.Font = New System.Drawing.Font("Rod", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_konu.Location = New System.Drawing.Point(66, 48)
        Me.txt_konu.Name = "txt_konu"
        Me.txt_konu.ReadOnly = True
        Me.txt_konu.Size = New System.Drawing.Size(585, 34)
        Me.txt_konu.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rod", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Konu"
        '
        'lbl_tarih
        '
        Me.lbl_tarih.AutoSize = True
        Me.lbl_tarih.Font = New System.Drawing.Font("Minion Pro", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tarih.Location = New System.Drawing.Point(497, 7)
        Me.lbl_tarih.Name = "lbl_tarih"
        Me.lbl_tarih.Size = New System.Drawing.Size(52, 26)
        Me.lbl_tarih.TabIndex = 4
        Me.lbl_tarih.Text = "Tarih"
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
        Me.dgv_dosyalar.ContextMenuStrip = Me.cmn_dosya
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
        Me.dgv_dosyalar.TabIndex = 83
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
        'cmn_dosya
        '
        Me.cmn_dosya.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmn_dosya.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.İndirToolStripMenuItem})
        Me.cmn_dosya.Name = "cmn_dosya"
        Me.cmn_dosya.Size = New System.Drawing.Size(182, 58)
        '
        'İndirToolStripMenuItem
        '
        Me.İndirToolStripMenuItem.Name = "İndirToolStripMenuItem"
        Me.İndirToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.İndirToolStripMenuItem.Text = "İndir"
        '
        'frm_gonderilenMaillerDetay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(652, 513)
        Me.Controls.Add(Me.dgv_dosyalar)
        Me.Controls.Add(Me.lbl_tarih)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_konu)
        Me.Controls.Add(Me.rtxt_icerik)
        Me.Controls.Add(Me.lbl_alici)
        Me.Font = New System.Drawing.Font("Rod", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_gonderilenMaillerDetay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_gonderilenMaillerDetay"
        CType(Me.dgv_dosyalar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmn_dosya.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_alici As System.Windows.Forms.Label
    Friend WithEvents rtxt_icerik As System.Windows.Forms.RichTextBox
    Friend WithEvents txt_konu As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_tarih As System.Windows.Forms.Label
    Friend WithEvents dgv_dosyalar As System.Windows.Forms.DataGridView
    Friend WithEvents cmn_dosya As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents İndirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmn_dosyaUzanti As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmn_dosyaAdi As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
