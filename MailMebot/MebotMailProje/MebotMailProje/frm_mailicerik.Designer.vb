<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mailicerik
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_mailicerik))
        Me.pnl_hesap = New System.Windows.Forms.Panel()
        Me.btn_cikis = New System.Windows.Forms.Button()
        Me.pnl_ayarlar = New System.Windows.Forms.Panel()
        Me.btn_tema = New System.Windows.Forms.Button()
        Me.btn_sablon = New System.Windows.Forms.Button()
        Me.btn_hesap = New System.Windows.Forms.Button()
        Me.btn_ayarlar = New System.Windows.Forms.Button()
        Me.btn_silinmisler = New System.Windows.Forms.Button()
        Me.btn_gonderilenler = New System.Windows.Forms.Button()
        Me.btn_taslaklar = New System.Windows.Forms.Button()
        Me.btn_gelenKutusu = New System.Windows.Forms.Button()
        Me.btn_kayitOl = New System.Windows.Forms.Button()
        Me.pnl_mail = New System.Windows.Forms.Panel()
        Me.btn_simgeDurumu = New System.Windows.Forms.Button()
        Me.lbl_gelenMail = New System.Windows.Forms.Label()
        Me.btn_kapat = New System.Windows.Forms.Button()
        Me.pnl_kısaYollar = New System.Windows.Forms.Panel()
        Me.btn_oneDrive = New System.Windows.Forms.Button()
        Me.btn_bing = New System.Windows.Forms.Button()
        Me.btn_msn = New System.Windows.Forms.Button()
        Me.btn_powerpoint = New System.Windows.Forms.Button()
        Me.btn_kisiler = New System.Windows.Forms.Button()
        Me.btn_takvim = New System.Windows.Forms.Button()
        Me.btn_excell = New System.Windows.Forms.Button()
        Me.btn_word = New System.Windows.Forms.Button()
        Me.btn_skype = New System.Windows.Forms.Button()
        Me.lbl_gonderilenMailSayisi = New System.Windows.Forms.Label()
        Me.lbl_taslakSayisi = New System.Windows.Forms.Label()
        Me.lbl_silinenler = New System.Windows.Forms.Label()
        Me.mc_Takvim = New System.Windows.Forms.MonthCalendar()
        Me.lbl_gelenlerinSayisi = New System.Windows.Forms.Label()
        Me.lbl_Kullanici = New System.Windows.Forms.Label()
        Me.lbl_KullaniciHesap = New System.Windows.Forms.Label()
        Me.pnl_hesap.SuspendLayout()
        Me.pnl_ayarlar.SuspendLayout()
        Me.pnl_mail.SuspendLayout()
        Me.pnl_kısaYollar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_hesap
        '
        Me.pnl_hesap.Controls.Add(Me.btn_cikis)
        Me.pnl_hesap.Location = New System.Drawing.Point(900, 245)
        Me.pnl_hesap.Name = "pnl_hesap"
        Me.pnl_hesap.Size = New System.Drawing.Size(118, 53)
        Me.pnl_hesap.TabIndex = 60
        Me.pnl_hesap.Visible = False
        '
        'btn_cikis
        '
        Me.btn_cikis.BackColor = System.Drawing.Color.Transparent
        Me.btn_cikis.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_cikis.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_cikis.FlatAppearance.BorderSize = 0
        Me.btn_cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cikis.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_cikis.Location = New System.Drawing.Point(0, 0)
        Me.btn_cikis.Name = "btn_cikis"
        Me.btn_cikis.Size = New System.Drawing.Size(118, 40)
        Me.btn_cikis.TabIndex = 38
        Me.btn_cikis.Text = "Çıkış"
        Me.btn_cikis.UseVisualStyleBackColor = False
        '
        'pnl_ayarlar
        '
        Me.pnl_ayarlar.Controls.Add(Me.btn_tema)
        Me.pnl_ayarlar.Controls.Add(Me.btn_sablon)
        Me.pnl_ayarlar.Location = New System.Drawing.Point(900, 92)
        Me.pnl_ayarlar.Name = "pnl_ayarlar"
        Me.pnl_ayarlar.Size = New System.Drawing.Size(149, 95)
        Me.pnl_ayarlar.TabIndex = 59
        Me.pnl_ayarlar.Visible = False
        '
        'btn_tema
        '
        Me.btn_tema.BackColor = System.Drawing.Color.Transparent
        Me.btn_tema.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_tema.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_tema.FlatAppearance.BorderSize = 0
        Me.btn_tema.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tema.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_tema.Location = New System.Drawing.Point(0, 40)
        Me.btn_tema.Name = "btn_tema"
        Me.btn_tema.Size = New System.Drawing.Size(149, 40)
        Me.btn_tema.TabIndex = 38
        Me.btn_tema.Text = "Arkaplan Rengi"
        Me.btn_tema.UseVisualStyleBackColor = False
        '
        'btn_sablon
        '
        Me.btn_sablon.BackColor = System.Drawing.Color.Transparent
        Me.btn_sablon.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_sablon.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_sablon.FlatAppearance.BorderSize = 0
        Me.btn_sablon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sablon.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_sablon.Location = New System.Drawing.Point(0, 0)
        Me.btn_sablon.Name = "btn_sablon"
        Me.btn_sablon.Size = New System.Drawing.Size(149, 40)
        Me.btn_sablon.TabIndex = 37
        Me.btn_sablon.Text = "Şablon Değiştir"
        Me.btn_sablon.UseVisualStyleBackColor = False
        '
        'btn_hesap
        '
        Me.btn_hesap.BackColor = System.Drawing.Color.Transparent
        Me.btn_hesap.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_hesap.FlatAppearance.BorderSize = 0
        Me.btn_hesap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_hesap.Font = New System.Drawing.Font("Comic Sans MS", 10.2!)
        Me.btn_hesap.Image = CType(resources.GetObject("btn_hesap.Image"), System.Drawing.Image)
        Me.btn_hesap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_hesap.Location = New System.Drawing.Point(1014, 46)
        Me.btn_hesap.Name = "btn_hesap"
        Me.btn_hesap.Size = New System.Drawing.Size(93, 40)
        Me.btn_hesap.TabIndex = 58
        Me.btn_hesap.Text = "Hesap"
        Me.btn_hesap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_hesap.UseVisualStyleBackColor = False
        '
        'btn_ayarlar
        '
        Me.btn_ayarlar.BackColor = System.Drawing.Color.Transparent
        Me.btn_ayarlar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_ayarlar.FlatAppearance.BorderSize = 0
        Me.btn_ayarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ayarlar.Font = New System.Drawing.Font("Comic Sans MS", 10.2!)
        Me.btn_ayarlar.Image = CType(resources.GetObject("btn_ayarlar.Image"), System.Drawing.Image)
        Me.btn_ayarlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ayarlar.Location = New System.Drawing.Point(900, 46)
        Me.btn_ayarlar.Name = "btn_ayarlar"
        Me.btn_ayarlar.Size = New System.Drawing.Size(108, 40)
        Me.btn_ayarlar.TabIndex = 57
        Me.btn_ayarlar.Text = "Ayarlar"
        Me.btn_ayarlar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ayarlar.UseVisualStyleBackColor = False
        '
        'btn_silinmisler
        '
        Me.btn_silinmisler.BackColor = System.Drawing.Color.Transparent
        Me.btn_silinmisler.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_silinmisler.FlatAppearance.BorderSize = 0
        Me.btn_silinmisler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_silinmisler.Font = New System.Drawing.Font("Comic Sans MS", 10.2!)
        Me.btn_silinmisler.Location = New System.Drawing.Point(6, 267)
        Me.btn_silinmisler.Name = "btn_silinmisler"
        Me.btn_silinmisler.Size = New System.Drawing.Size(209, 40)
        Me.btn_silinmisler.TabIndex = 49
        Me.btn_silinmisler.Text = "Silinenler"
        Me.btn_silinmisler.UseVisualStyleBackColor = False
        '
        'btn_gonderilenler
        '
        Me.btn_gonderilenler.BackColor = System.Drawing.Color.Transparent
        Me.btn_gonderilenler.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_gonderilenler.FlatAppearance.BorderSize = 0
        Me.btn_gonderilenler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_gonderilenler.Font = New System.Drawing.Font("Comic Sans MS", 10.2!)
        Me.btn_gonderilenler.Location = New System.Drawing.Point(6, 221)
        Me.btn_gonderilenler.Name = "btn_gonderilenler"
        Me.btn_gonderilenler.Size = New System.Drawing.Size(209, 40)
        Me.btn_gonderilenler.TabIndex = 48
        Me.btn_gonderilenler.Text = "Gönderilenler"
        Me.btn_gonderilenler.UseVisualStyleBackColor = False
        '
        'btn_taslaklar
        '
        Me.btn_taslaklar.BackColor = System.Drawing.Color.Transparent
        Me.btn_taslaklar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_taslaklar.FlatAppearance.BorderSize = 0
        Me.btn_taslaklar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_taslaklar.Font = New System.Drawing.Font("Comic Sans MS", 10.2!)
        Me.btn_taslaklar.Location = New System.Drawing.Point(6, 175)
        Me.btn_taslaklar.Name = "btn_taslaklar"
        Me.btn_taslaklar.Size = New System.Drawing.Size(209, 40)
        Me.btn_taslaklar.TabIndex = 47
        Me.btn_taslaklar.Text = "Taslaklar"
        Me.btn_taslaklar.UseVisualStyleBackColor = False
        '
        'btn_gelenKutusu
        '
        Me.btn_gelenKutusu.BackColor = System.Drawing.Color.Transparent
        Me.btn_gelenKutusu.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_gelenKutusu.FlatAppearance.BorderSize = 0
        Me.btn_gelenKutusu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_gelenKutusu.Font = New System.Drawing.Font("Comic Sans MS", 10.2!)
        Me.btn_gelenKutusu.Location = New System.Drawing.Point(6, 129)
        Me.btn_gelenKutusu.Name = "btn_gelenKutusu"
        Me.btn_gelenKutusu.Size = New System.Drawing.Size(209, 40)
        Me.btn_gelenKutusu.TabIndex = 45
        Me.btn_gelenKutusu.Text = "Gelen Kutusu"
        Me.btn_gelenKutusu.UseVisualStyleBackColor = False
        '
        'btn_kayitOl
        '
        Me.btn_kayitOl.BackColor = System.Drawing.Color.Transparent
        Me.btn_kayitOl.BackgroundImage = CType(resources.GetObject("btn_kayitOl.BackgroundImage"), System.Drawing.Image)
        Me.btn_kayitOl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_kayitOl.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_kayitOl.FlatAppearance.BorderSize = 0
        Me.btn_kayitOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_kayitOl.Font = New System.Drawing.Font("Comic Sans MS", 10.2!)
        Me.btn_kayitOl.Location = New System.Drawing.Point(17, 46)
        Me.btn_kayitOl.Name = "btn_kayitOl"
        Me.btn_kayitOl.Size = New System.Drawing.Size(40, 40)
        Me.btn_kayitOl.TabIndex = 42
        Me.btn_kayitOl.UseVisualStyleBackColor = False
        '
        'pnl_mail
        '
        Me.pnl_mail.BackColor = System.Drawing.Color.Silver
        Me.pnl_mail.Controls.Add(Me.btn_simgeDurumu)
        Me.pnl_mail.Controls.Add(Me.lbl_gelenMail)
        Me.pnl_mail.Controls.Add(Me.btn_kapat)
        Me.pnl_mail.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_mail.Font = New System.Drawing.Font("Comic Sans MS", 10.2!)
        Me.pnl_mail.Location = New System.Drawing.Point(0, 0)
        Me.pnl_mail.Name = "pnl_mail"
        Me.pnl_mail.Size = New System.Drawing.Size(1119, 33)
        Me.pnl_mail.TabIndex = 41
        '
        'btn_simgeDurumu
        '
        Me.btn_simgeDurumu.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_simgeDurumu.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_simgeDurumu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simgeDurumu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_simgeDurumu.ForeColor = System.Drawing.Color.Black
        Me.btn_simgeDurumu.Location = New System.Drawing.Point(1053, 0)
        Me.btn_simgeDurumu.Name = "btn_simgeDurumu"
        Me.btn_simgeDurumu.Size = New System.Drawing.Size(33, 33)
        Me.btn_simgeDurumu.TabIndex = 10
        Me.btn_simgeDurumu.Text = "_"
        Me.btn_simgeDurumu.UseCompatibleTextRendering = True
        Me.btn_simgeDurumu.UseVisualStyleBackColor = True
        '
        'lbl_gelenMail
        '
        Me.lbl_gelenMail.AutoSize = True
        Me.lbl_gelenMail.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_gelenMail.ForeColor = System.Drawing.Color.Black
        Me.lbl_gelenMail.Location = New System.Drawing.Point(12, 5)
        Me.lbl_gelenMail.Name = "lbl_gelenMail"
        Me.lbl_gelenMail.Size = New System.Drawing.Size(94, 24)
        Me.lbl_gelenMail.TabIndex = 9
        Me.lbl_gelenMail.Text = "Gelen Mail"
        '
        'btn_kapat
        '
        Me.btn_kapat.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_kapat.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_kapat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_kapat.ForeColor = System.Drawing.Color.Black
        Me.btn_kapat.Location = New System.Drawing.Point(1086, 0)
        Me.btn_kapat.Name = "btn_kapat"
        Me.btn_kapat.Size = New System.Drawing.Size(33, 33)
        Me.btn_kapat.TabIndex = 0
        Me.btn_kapat.Text = "x"
        Me.btn_kapat.UseCompatibleTextRendering = True
        Me.btn_kapat.UseVisualStyleBackColor = True
        '
        'pnl_kısaYollar
        '
        Me.pnl_kısaYollar.Controls.Add(Me.btn_oneDrive)
        Me.pnl_kısaYollar.Controls.Add(Me.btn_bing)
        Me.pnl_kısaYollar.Controls.Add(Me.btn_msn)
        Me.pnl_kısaYollar.Controls.Add(Me.btn_powerpoint)
        Me.pnl_kısaYollar.Controls.Add(Me.btn_kisiler)
        Me.pnl_kısaYollar.Controls.Add(Me.btn_takvim)
        Me.pnl_kısaYollar.Controls.Add(Me.btn_excell)
        Me.pnl_kısaYollar.Controls.Add(Me.btn_word)
        Me.pnl_kısaYollar.Controls.Add(Me.btn_skype)
        Me.pnl_kısaYollar.Location = New System.Drawing.Point(337, 172)
        Me.pnl_kısaYollar.Name = "pnl_kısaYollar"
        Me.pnl_kısaYollar.Size = New System.Drawing.Size(338, 286)
        Me.pnl_kısaYollar.TabIndex = 77
        Me.pnl_kısaYollar.Visible = False
        '
        'btn_oneDrive
        '
        Me.btn_oneDrive.BackColor = System.Drawing.Color.Transparent
        Me.btn_oneDrive.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_oneDrive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_oneDrive.Font = New System.Drawing.Font("Comic Sans MS", 10.2!)
        Me.btn_oneDrive.Image = CType(resources.GetObject("btn_oneDrive.Image"), System.Drawing.Image)
        Me.btn_oneDrive.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_oneDrive.Location = New System.Drawing.Point(225, 190)
        Me.btn_oneDrive.Name = "btn_oneDrive"
        Me.btn_oneDrive.Size = New System.Drawing.Size(112, 95)
        Me.btn_oneDrive.TabIndex = 31
        Me.btn_oneDrive.Text = "OneDrive"
        Me.btn_oneDrive.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_oneDrive.UseVisualStyleBackColor = False
        '
        'btn_bing
        '
        Me.btn_bing.BackColor = System.Drawing.Color.Transparent
        Me.btn_bing.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_bing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_bing.Font = New System.Drawing.Font("Comic Sans MS", 10.2!)
        Me.btn_bing.Image = CType(resources.GetObject("btn_bing.Image"), System.Drawing.Image)
        Me.btn_bing.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_bing.Location = New System.Drawing.Point(113, 190)
        Me.btn_bing.Name = "btn_bing"
        Me.btn_bing.Size = New System.Drawing.Size(112, 95)
        Me.btn_bing.TabIndex = 30
        Me.btn_bing.Text = "Bing"
        Me.btn_bing.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_bing.UseVisualStyleBackColor = False
        '
        'btn_msn
        '
        Me.btn_msn.BackColor = System.Drawing.Color.Transparent
        Me.btn_msn.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_msn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_msn.Font = New System.Drawing.Font("Comic Sans MS", 10.2!)
        Me.btn_msn.Image = CType(resources.GetObject("btn_msn.Image"), System.Drawing.Image)
        Me.btn_msn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_msn.Location = New System.Drawing.Point(1, 190)
        Me.btn_msn.Name = "btn_msn"
        Me.btn_msn.Size = New System.Drawing.Size(112, 95)
        Me.btn_msn.TabIndex = 29
        Me.btn_msn.Text = "Twitter"
        Me.btn_msn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_msn.UseVisualStyleBackColor = False
        '
        'btn_powerpoint
        '
        Me.btn_powerpoint.BackColor = System.Drawing.Color.Transparent
        Me.btn_powerpoint.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_powerpoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_powerpoint.Font = New System.Drawing.Font("Comic Sans MS", 10.2!)
        Me.btn_powerpoint.Image = CType(resources.GetObject("btn_powerpoint.Image"), System.Drawing.Image)
        Me.btn_powerpoint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_powerpoint.Location = New System.Drawing.Point(225, 95)
        Me.btn_powerpoint.Name = "btn_powerpoint"
        Me.btn_powerpoint.Size = New System.Drawing.Size(112, 95)
        Me.btn_powerpoint.TabIndex = 28
        Me.btn_powerpoint.Text = "PowerPoint"
        Me.btn_powerpoint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_powerpoint.UseVisualStyleBackColor = False
        '
        'btn_kisiler
        '
        Me.btn_kisiler.BackColor = System.Drawing.Color.Transparent
        Me.btn_kisiler.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_kisiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_kisiler.Font = New System.Drawing.Font("Comic Sans MS", 10.2!)
        Me.btn_kisiler.Image = CType(resources.GetObject("btn_kisiler.Image"), System.Drawing.Image)
        Me.btn_kisiler.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_kisiler.Location = New System.Drawing.Point(113, 95)
        Me.btn_kisiler.Name = "btn_kisiler"
        Me.btn_kisiler.Size = New System.Drawing.Size(112, 95)
        Me.btn_kisiler.TabIndex = 27
        Me.btn_kisiler.Text = "Facebook"
        Me.btn_kisiler.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_kisiler.UseVisualStyleBackColor = False
        '
        'btn_takvim
        '
        Me.btn_takvim.BackColor = System.Drawing.Color.Transparent
        Me.btn_takvim.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_takvim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_takvim.Font = New System.Drawing.Font("Comic Sans MS", 10.2!)
        Me.btn_takvim.Image = CType(resources.GetObject("btn_takvim.Image"), System.Drawing.Image)
        Me.btn_takvim.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_takvim.Location = New System.Drawing.Point(1, 95)
        Me.btn_takvim.Name = "btn_takvim"
        Me.btn_takvim.Size = New System.Drawing.Size(112, 95)
        Me.btn_takvim.TabIndex = 26
        Me.btn_takvim.Text = "Takvim"
        Me.btn_takvim.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_takvim.UseVisualStyleBackColor = False
        '
        'btn_excell
        '
        Me.btn_excell.BackColor = System.Drawing.Color.Transparent
        Me.btn_excell.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_excell.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_excell.Font = New System.Drawing.Font("Comic Sans MS", 10.2!)
        Me.btn_excell.Image = CType(resources.GetObject("btn_excell.Image"), System.Drawing.Image)
        Me.btn_excell.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_excell.Location = New System.Drawing.Point(224, 0)
        Me.btn_excell.Name = "btn_excell"
        Me.btn_excell.Size = New System.Drawing.Size(113, 95)
        Me.btn_excell.TabIndex = 25
        Me.btn_excell.Text = "Excell"
        Me.btn_excell.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_excell.UseVisualStyleBackColor = False
        '
        'btn_word
        '
        Me.btn_word.BackColor = System.Drawing.Color.Transparent
        Me.btn_word.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_word.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_word.Font = New System.Drawing.Font("Comic Sans MS", 10.2!)
        Me.btn_word.Image = CType(resources.GetObject("btn_word.Image"), System.Drawing.Image)
        Me.btn_word.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_word.Location = New System.Drawing.Point(113, 0)
        Me.btn_word.Name = "btn_word"
        Me.btn_word.Size = New System.Drawing.Size(112, 95)
        Me.btn_word.TabIndex = 24
        Me.btn_word.Text = "Word"
        Me.btn_word.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_word.UseVisualStyleBackColor = False
        '
        'btn_skype
        '
        Me.btn_skype.BackColor = System.Drawing.Color.Transparent
        Me.btn_skype.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_skype.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_skype.Font = New System.Drawing.Font("Comic Sans MS", 10.2!)
        Me.btn_skype.Image = CType(resources.GetObject("btn_skype.Image"), System.Drawing.Image)
        Me.btn_skype.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_skype.Location = New System.Drawing.Point(1, 0)
        Me.btn_skype.Name = "btn_skype"
        Me.btn_skype.Size = New System.Drawing.Size(112, 95)
        Me.btn_skype.TabIndex = 23
        Me.btn_skype.Text = "Skype"
        Me.btn_skype.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_skype.UseVisualStyleBackColor = False
        '
        'lbl_gonderilenMailSayisi
        '
        Me.lbl_gonderilenMailSayisi.AutoSize = True
        Me.lbl_gonderilenMailSayisi.BackColor = System.Drawing.Color.Transparent
        Me.lbl_gonderilenMailSayisi.Location = New System.Drawing.Point(24, 235)
        Me.lbl_gonderilenMailSayisi.Name = "lbl_gonderilenMailSayisi"
        Me.lbl_gonderilenMailSayisi.Size = New System.Drawing.Size(0, 17)
        Me.lbl_gonderilenMailSayisi.TabIndex = 79
        '
        'lbl_taslakSayisi
        '
        Me.lbl_taslakSayisi.AutoSize = True
        Me.lbl_taslakSayisi.BackColor = System.Drawing.Color.Transparent
        Me.lbl_taslakSayisi.Location = New System.Drawing.Point(33, 189)
        Me.lbl_taslakSayisi.Name = "lbl_taslakSayisi"
        Me.lbl_taslakSayisi.Size = New System.Drawing.Size(0, 17)
        Me.lbl_taslakSayisi.TabIndex = 81
        '
        'lbl_silinenler
        '
        Me.lbl_silinenler.AutoSize = True
        Me.lbl_silinenler.BackColor = System.Drawing.Color.Transparent
        Me.lbl_silinenler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_silinenler.ForeColor = System.Drawing.Color.Black
        Me.lbl_silinenler.Location = New System.Drawing.Point(33, 281)
        Me.lbl_silinenler.Name = "lbl_silinenler"
        Me.lbl_silinenler.Size = New System.Drawing.Size(0, 17)
        Me.lbl_silinenler.TabIndex = 83
        '
        'mc_Takvim
        '
        Me.mc_Takvim.Location = New System.Drawing.Point(845, 494)
        Me.mc_Takvim.Name = "mc_Takvim"
        Me.mc_Takvim.TabIndex = 85
        Me.mc_Takvim.Visible = False
        '
        'lbl_gelenlerinSayisi
        '
        Me.lbl_gelenlerinSayisi.AutoSize = True
        Me.lbl_gelenlerinSayisi.BackColor = System.Drawing.Color.Transparent
        Me.lbl_gelenlerinSayisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_gelenlerinSayisi.ForeColor = System.Drawing.Color.Black
        Me.lbl_gelenlerinSayisi.Location = New System.Drawing.Point(33, 143)
        Me.lbl_gelenlerinSayisi.Name = "lbl_gelenlerinSayisi"
        Me.lbl_gelenlerinSayisi.Size = New System.Drawing.Size(0, 17)
        Me.lbl_gelenlerinSayisi.TabIndex = 87
        '
        'lbl_Kullanici
        '
        Me.lbl_Kullanici.AutoSize = True
        Me.lbl_Kullanici.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Kullanici.Font = New System.Drawing.Font("Minion Pro", 16.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Kullanici.Location = New System.Drawing.Point(234, 36)
        Me.lbl_Kullanici.Name = "lbl_Kullanici"
        Me.lbl_Kullanici.Size = New System.Drawing.Size(69, 38)
        Me.lbl_Kullanici.TabIndex = 89
        Me.lbl_Kullanici.Text = "User"
        '
        'lbl_KullaniciHesap
        '
        Me.lbl_KullaniciHesap.AutoSize = True
        Me.lbl_KullaniciHesap.BackColor = System.Drawing.Color.Transparent
        Me.lbl_KullaniciHesap.Font = New System.Drawing.Font("Minion Pro", 16.2!)
        Me.lbl_KullaniciHesap.Location = New System.Drawing.Point(234, 74)
        Me.lbl_KullaniciHesap.Name = "lbl_KullaniciHesap"
        Me.lbl_KullaniciHesap.Size = New System.Drawing.Size(121, 38)
        Me.lbl_KullaniciHesap.TabIndex = 91
        Me.lbl_KullaniciHesap.Text = "UserMail"
        '
        'frm_mailicerik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1119, 719)
        Me.Controls.Add(Me.lbl_KullaniciHesap)
        Me.Controls.Add(Me.lbl_Kullanici)
        Me.Controls.Add(Me.mc_Takvim)
        Me.Controls.Add(Me.pnl_kısaYollar)
        Me.Controls.Add(Me.pnl_hesap)
        Me.Controls.Add(Me.pnl_ayarlar)
        Me.Controls.Add(Me.btn_hesap)
        Me.Controls.Add(Me.btn_ayarlar)
        Me.Controls.Add(Me.btn_kayitOl)
        Me.Controls.Add(Me.pnl_mail)
        Me.Controls.Add(Me.lbl_gelenlerinSayisi)
        Me.Controls.Add(Me.btn_gelenKutusu)
        Me.Controls.Add(Me.lbl_silinenler)
        Me.Controls.Add(Me.lbl_taslakSayisi)
        Me.Controls.Add(Me.btn_silinmisler)
        Me.Controls.Add(Me.btn_taslaklar)
        Me.Controls.Add(Me.lbl_gonderilenMailSayisi)
        Me.Controls.Add(Me.btn_gonderilenler)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frm_mailicerik"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_mailicerik"
        Me.pnl_hesap.ResumeLayout(False)
        Me.pnl_ayarlar.ResumeLayout(False)
        Me.pnl_mail.ResumeLayout(False)
        Me.pnl_mail.PerformLayout()
        Me.pnl_kısaYollar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnl_hesap As System.Windows.Forms.Panel
    Friend WithEvents btn_cikis As System.Windows.Forms.Button
    Friend WithEvents pnl_ayarlar As System.Windows.Forms.Panel
    Friend WithEvents btn_tema As System.Windows.Forms.Button
    Friend WithEvents btn_sablon As System.Windows.Forms.Button
    Friend WithEvents btn_hesap As System.Windows.Forms.Button
    Friend WithEvents btn_ayarlar As System.Windows.Forms.Button
    Friend WithEvents btn_silinmisler As System.Windows.Forms.Button
    Friend WithEvents btn_gonderilenler As System.Windows.Forms.Button
    Friend WithEvents btn_taslaklar As System.Windows.Forms.Button
    Friend WithEvents btn_gelenKutusu As System.Windows.Forms.Button
    Friend WithEvents btn_kayitOl As System.Windows.Forms.Button
    Friend WithEvents pnl_mail As System.Windows.Forms.Panel
    Friend WithEvents btn_simgeDurumu As System.Windows.Forms.Button
    Friend WithEvents lbl_gelenMail As System.Windows.Forms.Label
    Friend WithEvents btn_kapat As System.Windows.Forms.Button
    Friend WithEvents pnl_kısaYollar As System.Windows.Forms.Panel
    Friend WithEvents btn_oneDrive As System.Windows.Forms.Button
    Friend WithEvents btn_bing As System.Windows.Forms.Button
    Friend WithEvents btn_msn As System.Windows.Forms.Button
    Friend WithEvents btn_powerpoint As System.Windows.Forms.Button
    Friend WithEvents btn_kisiler As System.Windows.Forms.Button
    Friend WithEvents btn_takvim As System.Windows.Forms.Button
    Friend WithEvents btn_excell As System.Windows.Forms.Button
    Friend WithEvents btn_word As System.Windows.Forms.Button
    Friend WithEvents btn_skype As System.Windows.Forms.Button
    Public WithEvents lbl_gonderilenMailSayisi As System.Windows.Forms.Label
    Public WithEvents lbl_taslakSayisi As System.Windows.Forms.Label
    Public WithEvents lbl_silinenler As System.Windows.Forms.Label
    Friend WithEvents mc_Takvim As System.Windows.Forms.MonthCalendar
    Public WithEvents lbl_gelenlerinSayisi As System.Windows.Forms.Label
    Friend WithEvents lbl_Kullanici As System.Windows.Forms.Label
    Friend WithEvents lbl_KullaniciHesap As System.Windows.Forms.Label
End Class
