<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Giris
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Giris))
        Me.pnl_giris = New System.Windows.Forms.Panel()
        Me.mebot_SimgeGiris = New System.Windows.Forms.Panel()
        Me.mebot_Yazi = New System.Windows.Forms.Panel()
        Me.btn_simgeDurumu = New System.Windows.Forms.Button()
        Me.btn_kapat = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_kullaniciAd = New System.Windows.Forms.TextBox()
        Me.txt_sifre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cb_beniHatirla = New System.Windows.Forms.CheckBox()
        Me.btn_giris = New System.Windows.Forms.Button()
        Me.llbl_hesapOlustur = New System.Windows.Forms.LinkLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pnl_giris.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_giris
        '
        Me.pnl_giris.BackColor = System.Drawing.Color.Silver
        Me.pnl_giris.BackgroundImage = CType(resources.GetObject("pnl_giris.BackgroundImage"), System.Drawing.Image)
        Me.pnl_giris.Controls.Add(Me.mebot_SimgeGiris)
        Me.pnl_giris.Controls.Add(Me.mebot_Yazi)
        Me.pnl_giris.Controls.Add(Me.btn_simgeDurumu)
        Me.pnl_giris.Controls.Add(Me.btn_kapat)
        Me.pnl_giris.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_giris.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pnl_giris.Location = New System.Drawing.Point(0, 0)
        Me.pnl_giris.Name = "pnl_giris"
        Me.pnl_giris.Size = New System.Drawing.Size(717, 64)
        Me.pnl_giris.TabIndex = 0
        '
        'mebot_SimgeGiris
        '
        Me.mebot_SimgeGiris.BackColor = System.Drawing.Color.Transparent
        Me.mebot_SimgeGiris.BackgroundImage = CType(resources.GetObject("mebot_SimgeGiris.BackgroundImage"), System.Drawing.Image)
        Me.mebot_SimgeGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.mebot_SimgeGiris.Location = New System.Drawing.Point(3, 3)
        Me.mebot_SimgeGiris.Name = "mebot_SimgeGiris"
        Me.mebot_SimgeGiris.Size = New System.Drawing.Size(64, 53)
        Me.mebot_SimgeGiris.TabIndex = 0
        '
        'mebot_Yazi
        '
        Me.mebot_Yazi.BackColor = System.Drawing.Color.Transparent
        Me.mebot_Yazi.BackgroundImage = CType(resources.GetObject("mebot_Yazi.BackgroundImage"), System.Drawing.Image)
        Me.mebot_Yazi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mebot_Yazi.Location = New System.Drawing.Point(73, 3)
        Me.mebot_Yazi.Name = "mebot_Yazi"
        Me.mebot_Yazi.Size = New System.Drawing.Size(256, 61)
        Me.mebot_Yazi.TabIndex = 0
        '
        'btn_simgeDurumu
        '
        Me.btn_simgeDurumu.BackColor = System.Drawing.Color.Transparent
        Me.btn_simgeDurumu.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_simgeDurumu.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_simgeDurumu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simgeDurumu.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_simgeDurumu.ForeColor = System.Drawing.Color.Black
        Me.btn_simgeDurumu.Location = New System.Drawing.Point(617, 0)
        Me.btn_simgeDurumu.Name = "btn_simgeDurumu"
        Me.btn_simgeDurumu.Size = New System.Drawing.Size(50, 64)
        Me.btn_simgeDurumu.TabIndex = 3
        Me.btn_simgeDurumu.TabStop = False
        Me.btn_simgeDurumu.Text = "_"
        Me.btn_simgeDurumu.UseCompatibleTextRendering = True
        Me.btn_simgeDurumu.UseVisualStyleBackColor = False
        '
        'btn_kapat
        '
        Me.btn_kapat.BackColor = System.Drawing.Color.Transparent
        Me.btn_kapat.BackgroundImage = CType(resources.GetObject("btn_kapat.BackgroundImage"), System.Drawing.Image)
        Me.btn_kapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_kapat.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_kapat.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_kapat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_kapat.ForeColor = System.Drawing.Color.Black
        Me.btn_kapat.Location = New System.Drawing.Point(667, 0)
        Me.btn_kapat.Name = "btn_kapat"
        Me.btn_kapat.Size = New System.Drawing.Size(50, 64)
        Me.btn_kapat.TabIndex = 0
        Me.btn_kapat.TabStop = False
        Me.btn_kapat.UseCompatibleTextRendering = True
        Me.btn_kapat.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(174, 193)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kullanıcı Adı"
        '
        'txt_kullaniciAd
        '
        Me.txt_kullaniciAd.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_kullaniciAd.Location = New System.Drawing.Point(315, 193)
        Me.txt_kullaniciAd.MaxLength = 50
        Me.txt_kullaniciAd.Name = "txt_kullaniciAd"
        Me.txt_kullaniciAd.Size = New System.Drawing.Size(239, 31)
        Me.txt_kullaniciAd.TabIndex = 2
        '
        'txt_sifre
        '
        Me.txt_sifre.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sifre.Location = New System.Drawing.Point(315, 240)
        Me.txt_sifre.MaxLength = 50
        Me.txt_sifre.Name = "txt_sifre"
        Me.txt_sifre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_sifre.Size = New System.Drawing.Size(239, 31)
        Me.txt_sifre.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(174, 240)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Şifre"
        '
        'cb_beniHatirla
        '
        Me.cb_beniHatirla.AutoSize = True
        Me.cb_beniHatirla.BackColor = System.Drawing.Color.Transparent
        Me.cb_beniHatirla.Font = New System.Drawing.Font("Comic Sans MS", 10.2!)
        Me.cb_beniHatirla.Location = New System.Drawing.Point(315, 286)
        Me.cb_beniHatirla.Name = "cb_beniHatirla"
        Me.cb_beniHatirla.Size = New System.Drawing.Size(123, 28)
        Me.cb_beniHatirla.TabIndex = 4
        Me.cb_beniHatirla.TabStop = False
        Me.cb_beniHatirla.Text = "Beni hatırla"
        Me.cb_beniHatirla.UseVisualStyleBackColor = False
        '
        'btn_giris
        '
        Me.btn_giris.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_giris.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btn_giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_giris.Font = New System.Drawing.Font("Comic Sans MS", 10.2!)
        Me.btn_giris.Location = New System.Drawing.Point(315, 320)
        Me.btn_giris.Name = "btn_giris"
        Me.btn_giris.Size = New System.Drawing.Size(120, 40)
        Me.btn_giris.TabIndex = 5
        Me.btn_giris.Text = "Giriş"
        Me.btn_giris.UseVisualStyleBackColor = False
        '
        'llbl_hesapOlustur
        '
        Me.llbl_hesapOlustur.ActiveLinkColor = System.Drawing.Color.Blue
        Me.llbl_hesapOlustur.AutoSize = True
        Me.llbl_hesapOlustur.BackColor = System.Drawing.Color.Transparent
        Me.llbl_hesapOlustur.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.llbl_hesapOlustur.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.llbl_hesapOlustur.LinkColor = System.Drawing.SystemColors.HotTrack
        Me.llbl_hesapOlustur.Location = New System.Drawing.Point(580, 476)
        Me.llbl_hesapOlustur.Name = "llbl_hesapOlustur"
        Me.llbl_hesapOlustur.Size = New System.Drawing.Size(125, 24)
        Me.llbl_hesapOlustur.TabIndex = 7
        Me.llbl_hesapOlustur.TabStop = True
        Me.llbl_hesapOlustur.Text = "Hesap Oluştur"
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.Location = New System.Drawing.Point(0, 512)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(717, 52)
        Me.Panel3.TabIndex = 9
        '
        'frm_Giris
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(717, 564)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.llbl_hesapOlustur)
        Me.Controls.Add(Me.btn_giris)
        Me.Controls.Add(Me.cb_beniHatirla)
        Me.Controls.Add(Me.txt_sifre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_kullaniciAd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnl_giris)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Giris"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Giriş Ekranı"
        Me.pnl_giris.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnl_giris As System.Windows.Forms.Panel
    Friend WithEvents btn_kapat As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_kullaniciAd As System.Windows.Forms.TextBox
    Friend WithEvents txt_sifre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cb_beniHatirla As System.Windows.Forms.CheckBox
    Friend WithEvents btn_giris As System.Windows.Forms.Button
    Friend WithEvents llbl_hesapOlustur As System.Windows.Forms.LinkLabel
    Friend WithEvents btn_simgeDurumu As System.Windows.Forms.Button
    Friend WithEvents mebot_Yazi As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents mebot_SimgeGiris As System.Windows.Forms.Panel

End Class
