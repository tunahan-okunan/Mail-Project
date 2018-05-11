<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Silinenler
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Silinenler))
        Me.dgv_mail = New System.Windows.Forms.DataGridView()
        Me.cmn_mailBoxID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmn_Alici = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmb_konu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmb_icerik = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmb_Tarih = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cms_Silinenler = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GörüntüleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgv_mail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_Silinenler.SuspendLayout()
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
        Me.dgv_mail.ContextMenuStrip = Me.cms_Silinenler
        Me.dgv_mail.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgv_mail.Location = New System.Drawing.Point(0, -1)
        Me.dgv_mail.MultiSelect = False
        Me.dgv_mail.Name = "dgv_mail"
        Me.dgv_mail.ReadOnly = True
        Me.dgv_mail.RowHeadersVisible = False
        Me.dgv_mail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgv_mail.RowTemplate.Height = 24
        Me.dgv_mail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_mail.Size = New System.Drawing.Size(652, 514)
        Me.dgv_mail.StandardTab = True
        Me.dgv_mail.TabIndex = 84
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
        Me.cmb_Tarih.HeaderText = "Silinen Tarih"
        Me.cmb_Tarih.Name = "cmb_Tarih"
        Me.cmb_Tarih.ReadOnly = True
        '
        'cms_Silinenler
        '
        Me.cms_Silinenler.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cms_Silinenler.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GörüntüleToolStripMenuItem, Me.SilToolStripMenuItem})
        Me.cms_Silinenler.Name = "cms_Silinenler"
        Me.cms_Silinenler.Size = New System.Drawing.Size(150, 56)
        '
        'GörüntüleToolStripMenuItem
        '
        Me.GörüntüleToolStripMenuItem.Name = "GörüntüleToolStripMenuItem"
        Me.GörüntüleToolStripMenuItem.Size = New System.Drawing.Size(149, 26)
        Me.GörüntüleToolStripMenuItem.Text = "Görüntüle"
        '
        'SilToolStripMenuItem
        '
        Me.SilToolStripMenuItem.Name = "SilToolStripMenuItem"
        Me.SilToolStripMenuItem.Size = New System.Drawing.Size(149, 26)
        Me.SilToolStripMenuItem.Text = "Sil"
        '
        'frm_Silinenler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(652, 513)
        Me.Controls.Add(Me.dgv_mail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Silinenler"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Silinenler"
        CType(Me.dgv_mail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_Silinenler.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv_mail As System.Windows.Forms.DataGridView
    Friend WithEvents cmn_mailBoxID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmn_Alici As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmb_konu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmb_icerik As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmb_Tarih As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cms_Silinenler As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GörüntüleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
