<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnKapat = New System.Windows.Forms.Button()
        Me.ımageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnSinifListesi = New System.Windows.Forms.Button()
        Me.btnOgrenciEkle = New System.Windows.Forms.Button()
        Me.btnOgrenciListesi = New System.Windows.Forms.Button()
        Me.btnDevamsizlik = New System.Windows.Forms.Button()
        Me.btnNotListesi = New System.Windows.Forms.Button()
        Me.btnOgrenciBilgi = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ÖğrenciİşlemleriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.yeniOgrenciMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ogrenciListesiMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.devamsizlikDurumuMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnKapat
        '
        Me.btnKapat.BackColor = System.Drawing.Color.White
        Me.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKapat.Image = CType(resources.GetObject("btnKapat.Image"), System.Drawing.Image)
        Me.btnKapat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKapat.Location = New System.Drawing.Point(648, 31)
        Me.btnKapat.Name = "btnKapat"
        Me.btnKapat.Size = New System.Drawing.Size(100, 25)
        Me.btnKapat.TabIndex = 20
        Me.btnKapat.Text = "Kapat"
        Me.btnKapat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnKapat.UseVisualStyleBackColor = False
        '
        'ımageList1
        '
        Me.ımageList1.ImageStream = CType(resources.GetObject("ımageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ımageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ımageList1.Images.SetKeyName(0, "iconfinder_130-man-student-2_3099383.png")
        Me.ımageList1.Images.SetKeyName(1, "iconfinder_avatar_103310.png")
        Me.ımageList1.Images.SetKeyName(2, "iconfinder_document-03_1622833.png")
        Me.ımageList1.Images.SetKeyName(3, "iconfinder_icon-40-clipboard-list_314879.png")
        Me.ımageList1.Images.SetKeyName(4, "iconfinder_5_2058804.png")
        Me.ımageList1.Images.SetKeyName(5, "iconfinder_Clipboard-Plan_379500.png")
        Me.ımageList1.Images.SetKeyName(6, "iconfinder_mail_reply_6124.png")
        Me.ımageList1.Images.SetKeyName(7, "iconfinder_group_half_add_103578.png")
        Me.ımageList1.Images.SetKeyName(8, "iconfinder_board-math-class-school_2824448.png")
        Me.ımageList1.Images.SetKeyName(9, "iconfinder_bad_smelly_41541.png")
        '
        'btnSinifListesi
        '
        Me.btnSinifListesi.BackColor = System.Drawing.Color.White
        Me.btnSinifListesi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSinifListesi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnSinifListesi.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSinifListesi.ImageIndex = 8
        Me.btnSinifListesi.ImageList = Me.ımageList1
        Me.btnSinifListesi.Location = New System.Drawing.Point(502, 57)
        Me.btnSinifListesi.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSinifListesi.Name = "btnSinifListesi"
        Me.btnSinifListesi.Size = New System.Drawing.Size(246, 186)
        Me.btnSinifListesi.TabIndex = 18
        Me.btnSinifListesi.Text = "Ders Kayıt"
        Me.btnSinifListesi.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSinifListesi.UseVisualStyleBackColor = False
        '
        'btnOgrenciEkle
        '
        Me.btnOgrenciEkle.BackColor = System.Drawing.Color.White
        Me.btnOgrenciEkle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOgrenciEkle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnOgrenciEkle.ImageIndex = 7
        Me.btnOgrenciEkle.ImageList = Me.ımageList1
        Me.btnOgrenciEkle.Location = New System.Drawing.Point(0, 246)
        Me.btnOgrenciEkle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOgrenciEkle.Name = "btnOgrenciEkle"
        Me.btnOgrenciEkle.Size = New System.Drawing.Size(245, 194)
        Me.btnOgrenciEkle.TabIndex = 16
        Me.btnOgrenciEkle.Text = "Öğrenci Ekle"
        Me.btnOgrenciEkle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnOgrenciEkle.UseVisualStyleBackColor = False
        '
        'btnOgrenciListesi
        '
        Me.btnOgrenciListesi.BackColor = System.Drawing.Color.White
        Me.btnOgrenciListesi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOgrenciListesi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnOgrenciListesi.ImageIndex = 3
        Me.btnOgrenciListesi.ImageList = Me.ımageList1
        Me.btnOgrenciListesi.Location = New System.Drawing.Point(249, 246)
        Me.btnOgrenciListesi.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOgrenciListesi.Name = "btnOgrenciListesi"
        Me.btnOgrenciListesi.Size = New System.Drawing.Size(245, 194)
        Me.btnOgrenciListesi.TabIndex = 14
        Me.btnOgrenciListesi.Text = "Öğrenci Listesi"
        Me.btnOgrenciListesi.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnOgrenciListesi.UseVisualStyleBackColor = False
        '
        'btnDevamsizlik
        '
        Me.btnDevamsizlik.BackColor = System.Drawing.Color.White
        Me.btnDevamsizlik.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDevamsizlik.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnDevamsizlik.ImageIndex = 4
        Me.btnDevamsizlik.ImageList = Me.ımageList1
        Me.btnDevamsizlik.Location = New System.Drawing.Point(502, 246)
        Me.btnDevamsizlik.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDevamsizlik.Name = "btnDevamsizlik"
        Me.btnDevamsizlik.Size = New System.Drawing.Size(246, 191)
        Me.btnDevamsizlik.TabIndex = 21
        Me.btnDevamsizlik.Text = "Devamsızlık"
        Me.btnDevamsizlik.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDevamsizlik.UseVisualStyleBackColor = False
        '
        'btnNotListesi
        '
        Me.btnNotListesi.BackColor = System.Drawing.Color.White
        Me.btnNotListesi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNotListesi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnNotListesi.ImageIndex = 2
        Me.btnNotListesi.ImageList = Me.ımageList1
        Me.btnNotListesi.Location = New System.Drawing.Point(249, 57)
        Me.btnNotListesi.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNotListesi.Name = "btnNotListesi"
        Me.btnNotListesi.Size = New System.Drawing.Size(245, 188)
        Me.btnNotListesi.TabIndex = 22
        Me.btnNotListesi.Text = "Not Listesi"
        Me.btnNotListesi.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNotListesi.UseVisualStyleBackColor = False
        '
        'btnOgrenciBilgi
        '
        Me.btnOgrenciBilgi.BackColor = System.Drawing.Color.White
        Me.btnOgrenciBilgi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOgrenciBilgi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnOgrenciBilgi.ImageIndex = 0
        Me.btnOgrenciBilgi.ImageList = Me.ımageList1
        Me.btnOgrenciBilgi.Location = New System.Drawing.Point(0, 57)
        Me.btnOgrenciBilgi.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOgrenciBilgi.Name = "btnOgrenciBilgi"
        Me.btnOgrenciBilgi.Size = New System.Drawing.Size(245, 189)
        Me.btnOgrenciBilgi.TabIndex = 23
        Me.btnOgrenciBilgi.Text = "Öğrenci Bilgileri"
        Me.btnOgrenciBilgi.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnOgrenciBilgi.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÖğrenciİşlemleriToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(748, 28)
        Me.MenuStrip1.TabIndex = 24
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ÖğrenciİşlemleriToolStripMenuItem
        '
        Me.ÖğrenciİşlemleriToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.yeniOgrenciMenuItem, Me.ogrenciListesiMenuItem, Me.devamsizlikDurumuMenuItem})
        Me.ÖğrenciİşlemleriToolStripMenuItem.Name = "ÖğrenciİşlemleriToolStripMenuItem"
        Me.ÖğrenciİşlemleriToolStripMenuItem.Size = New System.Drawing.Size(133, 24)
        Me.ÖğrenciİşlemleriToolStripMenuItem.Text = "Öğrenci İşlemleri"
        '
        'yeniOgrenciMenuItem
        '
        Me.yeniOgrenciMenuItem.Name = "yeniOgrenciMenuItem"
        Me.yeniOgrenciMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.yeniOgrenciMenuItem.Text = "Yeni Öğrenci Ekle"
        '
        'ogrenciListesiMenuItem
        '
        Me.ogrenciListesiMenuItem.Name = "ogrenciListesiMenuItem"
        Me.ogrenciListesiMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.ogrenciListesiMenuItem.Text = "Öğrenci Listesi"
        '
        'devamsizlikDurumuMenuItem
        '
        Me.devamsizlikDurumuMenuItem.Name = "devamsizlikDurumuMenuItem"
        Me.devamsizlikDurumuMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.devamsizlikDurumuMenuItem.Text = "Devamsızlık Durumları"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 441)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(748, 25)
        Me.ToolStrip1.TabIndex = 25
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(113, 22)
        Me.ToolStripLabel1.Text = "ToolStripLabel1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(113, 22)
        Me.ToolStripLabel2.Text = "ToolStripLabel2"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(748, 466)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btnOgrenciBilgi)
        Me.Controls.Add(Me.btnNotListesi)
        Me.Controls.Add(Me.btnDevamsizlik)
        Me.Controls.Add(Me.btnKapat)
        Me.Controls.Add(Me.btnSinifListesi)
        Me.Controls.Add(Me.btnOgrenciEkle)
        Me.Controls.Add(Me.btnOgrenciListesi)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Öğrenci Takip Programı"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnKapat As Button
    Friend WithEvents btnSinifListesi As Button
    Friend WithEvents btnOgrenciEkle As Button
    Friend WithEvents btnOgrenciListesi As Button
    Friend WithEvents btnDevamsizlik As Button
    Friend WithEvents btnNotListesi As Button
    Friend WithEvents btnOgrenciBilgi As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ÖğrenciİşlemleriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents yeniOgrenciMenuItem As ToolStripMenuItem
    Friend WithEvents ogrenciListesiMenuItem As ToolStripMenuItem
    Friend WithEvents devamsizlikDurumuMenuItem As ToolStripMenuItem
    Friend WithEvents ımageList1 As ImageList
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents Timer1 As Timer
End Class
