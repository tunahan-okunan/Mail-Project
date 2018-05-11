<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_kayitOl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_kayitOl))
        Me.txt_sifre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_kullaniciAd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Ad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_soyad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtp_dogumTarihi = New System.Windows.Forms.DateTimePicker()
        Me.lbl_random = New System.Windows.Forms.Label()
        Me.txt_random = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_kayitOl = New System.Windows.Forms.Button()
        Me.btn_Random = New System.Windows.Forms.Button()
        Me.lbl_kayıtOl = New System.Windows.Forms.Label()
        Me.pnl_giris = New System.Windows.Forms.Panel()
        Me.mebot_simge = New System.Windows.Forms.Panel()
        Me.btn_simgeDurumu = New System.Windows.Forms.Button()
        Me.btn_kapat = New System.Windows.Forms.Button()
        Me.lbl_aciklama = New System.Windows.Forms.Label()
        Me.pnl_giris.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_sifre
        '
        Me.txt_sifre.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sifre.Location = New System.Drawing.Point(293, 154)
        Me.txt_sifre.MaxLength = 50
        Me.txt_sifre.Name = "txt_sifre"
        Me.txt_sifre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_sifre.Size = New System.Drawing.Size(280, 31)
        Me.txt_sifre.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(144, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 28)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Şifre"
        '
        'txt_kullaniciAd
        '
        Me.txt_kullaniciAd.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_kullaniciAd.Location = New System.Drawing.Point(293, 117)
        Me.txt_kullaniciAd.MaxLength = 50
        Me.txt_kullaniciAd.Name = "txt_kullaniciAd"
        Me.txt_kullaniciAd.Size = New System.Drawing.Size(280, 31)
        Me.txt_kullaniciAd.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(144, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 28)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Kullanıcı Adı"
        '
        'txt_Ad
        '
        Me.txt_Ad.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_Ad.Location = New System.Drawing.Point(293, 191)
        Me.txt_Ad.MaxLength = 50
        Me.txt_Ad.Name = "txt_Ad"
        Me.txt_Ad.Size = New System.Drawing.Size(280, 31)
        Me.txt_Ad.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(144, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 28)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Ad"
        '
        'txt_soyad
        '
        Me.txt_soyad.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_soyad.Location = New System.Drawing.Point(293, 228)
        Me.txt_soyad.MaxLength = 50
        Me.txt_soyad.Name = "txt_soyad"
        Me.txt_soyad.Size = New System.Drawing.Size(280, 31)
        Me.txt_soyad.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(144, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 28)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Soyad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.Location = New System.Drawing.Point(144, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 28)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Doğum Tarihi"
        '
        'dtp_dogumTarihi
        '
        Me.dtp_dogumTarihi.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.dtp_dogumTarihi.Location = New System.Drawing.Point(293, 265)
        Me.dtp_dogumTarihi.Name = "dtp_dogumTarihi"
        Me.dtp_dogumTarihi.Size = New System.Drawing.Size(280, 26)
        Me.dtp_dogumTarihi.TabIndex = 14
        '
        'lbl_random
        '
        Me.lbl_random.AutoSize = True
        Me.lbl_random.Font = New System.Drawing.Font("Monotype Corsiva", 19.8!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Strikeout), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_random.Location = New System.Drawing.Point(137, 306)
        Me.lbl_random.Name = "lbl_random"
        Me.lbl_random.Size = New System.Drawing.Size(114, 40)
        Me.lbl_random.TabIndex = 15
        Me.lbl_random.Text = "Random"
        '
        'txt_random
        '
        Me.txt_random.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_random.Location = New System.Drawing.Point(293, 362)
        Me.txt_random.MaxLength = 4
        Me.txt_random.Name = "txt_random"
        Me.txt_random.Size = New System.Drawing.Size(280, 31)
        Me.txt_random.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.Location = New System.Drawing.Point(146, 365)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 24)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Robot musun?"
        '
        'btn_kayitOl
        '
        Me.btn_kayitOl.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_kayitOl.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_kayitOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_kayitOl.Font = New System.Drawing.Font("Comic Sans MS", 10.2!)
        Me.btn_kayitOl.Location = New System.Drawing.Point(293, 409)
        Me.btn_kayitOl.Name = "btn_kayitOl"
        Me.btn_kayitOl.Size = New System.Drawing.Size(120, 40)
        Me.btn_kayitOl.TabIndex = 18
        Me.btn_kayitOl.Text = "Kayıt Ol"
        Me.btn_kayitOl.UseVisualStyleBackColor = False
        '
        'btn_Random
        '
        Me.btn_Random.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_Random.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_Random.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Random.Font = New System.Drawing.Font("Comic Sans MS", 10.2!)
        Me.btn_Random.Location = New System.Drawing.Point(293, 309)
        Me.btn_Random.Name = "btn_Random"
        Me.btn_Random.Size = New System.Drawing.Size(120, 40)
        Me.btn_Random.TabIndex = 19
        Me.btn_Random.Text = "Yeni"
        Me.btn_Random.UseVisualStyleBackColor = False
        '
        'lbl_kayıtOl
        '
        Me.lbl_kayıtOl.AutoSize = True
        Me.lbl_kayıtOl.BackColor = System.Drawing.Color.Transparent
        Me.lbl_kayıtOl.Font = New System.Drawing.Font("Comic Sans MS", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_kayıtOl.ForeColor = System.Drawing.Color.Transparent
        Me.lbl_kayıtOl.Location = New System.Drawing.Point(103, 5)
        Me.lbl_kayıtOl.Name = "lbl_kayıtOl"
        Me.lbl_kayıtOl.Size = New System.Drawing.Size(165, 53)
        Me.lbl_kayıtOl.TabIndex = 9
        Me.lbl_kayıtOl.Text = "Kayıt Ol"
        '
        'pnl_giris
        '
        Me.pnl_giris.BackColor = System.Drawing.Color.Silver
        Me.pnl_giris.BackgroundImage = CType(resources.GetObject("pnl_giris.BackgroundImage"), System.Drawing.Image)
        Me.pnl_giris.Controls.Add(Me.mebot_simge)
        Me.pnl_giris.Controls.Add(Me.btn_simgeDurumu)
        Me.pnl_giris.Controls.Add(Me.lbl_kayıtOl)
        Me.pnl_giris.Controls.Add(Me.btn_kapat)
        Me.pnl_giris.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_giris.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pnl_giris.Location = New System.Drawing.Point(0, 0)
        Me.pnl_giris.Name = "pnl_giris"
        Me.pnl_giris.Size = New System.Drawing.Size(717, 64)
        Me.pnl_giris.TabIndex = 20
        '
        'mebot_simge
        '
        Me.mebot_simge.BackColor = System.Drawing.Color.Transparent
        Me.mebot_simge.BackgroundImage = CType(resources.GetObject("mebot_simge.BackgroundImage"), System.Drawing.Image)
        Me.mebot_simge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.mebot_simge.Location = New System.Drawing.Point(3, 8)
        Me.mebot_simge.Name = "mebot_simge"
        Me.mebot_simge.Size = New System.Drawing.Size(64, 53)
        Me.mebot_simge.TabIndex = 9
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
        Me.btn_simgeDurumu.TabIndex = 11
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
        Me.btn_kapat.UseCompatibleTextRendering = True
        Me.btn_kapat.UseVisualStyleBackColor = False
        '
        'lbl_aciklama
        '
        Me.lbl_aciklama.AutoSize = True
        Me.lbl_aciklama.Font = New System.Drawing.Font("Comic Sans MS", 9.3!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_aciklama.Location = New System.Drawing.Point(12, 516)
        Me.lbl_aciklama.Name = "lbl_aciklama"
        Me.lbl_aciklama.Size = New System.Drawing.Size(684, 23)
        Me.lbl_aciklama.TabIndex = 21
        Me.lbl_aciklama.Text = "Eğer Gmail ile giriş yapıyorsanız az güvenli uygulamaların hesabınıza erişmesine " & _
    "izin veriniz."
        '
        'frm_kayitOl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(717, 564)
        Me.Controls.Add(Me.lbl_aciklama)
        Me.Controls.Add(Me.pnl_giris)
        Me.Controls.Add(Me.btn_Random)
        Me.Controls.Add(Me.btn_kayitOl)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_random)
        Me.Controls.Add(Me.lbl_random)
        Me.Controls.Add(Me.dtp_dogumTarihi)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_soyad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_Ad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_sifre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_kullaniciAd)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_kayitOl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_kayitOl"
        Me.pnl_giris.ResumeLayout(False)
        Me.pnl_giris.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_sifre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_kullaniciAd As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_Ad As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_soyad As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtp_dogumTarihi As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_random As System.Windows.Forms.Label
    Friend WithEvents txt_random As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_kayitOl As System.Windows.Forms.Button
    Friend WithEvents btn_Random As System.Windows.Forms.Button
    Friend WithEvents lbl_kayıtOl As System.Windows.Forms.Label
    Friend WithEvents pnl_giris As System.Windows.Forms.Panel
    Friend WithEvents mebot_simge As System.Windows.Forms.Panel
    Friend WithEvents btn_simgeDurumu As System.Windows.Forms.Button
    Friend WithEvents btn_kapat As System.Windows.Forms.Button
    Friend WithEvents lbl_aciklama As System.Windows.Forms.Label
End Class
