<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.txtAra = New System.Windows.Forms.TextBox()
        Me.btnAra = New System.Windows.Forms.Button()
        Me.pbFoto = New System.Windows.Forms.PictureBox()
        Me.btnKaydet = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbAdSoyad = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ımageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnSec = New System.Windows.Forms.Button()
        Me.txtTc = New System.Windows.Forms.TextBox()
        Me.txtAdSoyad = New System.Windows.Forms.TextBox()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.txtDYeri = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTarih = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFoto = New System.Windows.Forms.TextBox()
        Me.ofdResim = New System.Windows.Forms.OpenFileDialog()
        Me.btnKapat = New System.Windows.Forms.Button()
        Me.dgKayitlar = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kayit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnYeni = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.btnTemizle = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgKayitlar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtAra
        '
        Me.txtAra.Location = New System.Drawing.Point(68, 21)
        Me.txtAra.Name = "txtAra"
        Me.txtAra.Size = New System.Drawing.Size(136, 22)
        Me.txtAra.TabIndex = 0
        '
        'btnAra
        '
        Me.btnAra.BackColor = System.Drawing.Color.White
        Me.btnAra.Location = New System.Drawing.Point(210, 20)
        Me.btnAra.Name = "btnAra"
        Me.btnAra.Size = New System.Drawing.Size(129, 23)
        Me.btnAra.TabIndex = 1
        Me.btnAra.Text = "Detaylı Ara"
        Me.btnAra.UseVisualStyleBackColor = False
        '
        'pbFoto
        '
        Me.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbFoto.Location = New System.Drawing.Point(629, 12)
        Me.pbFoto.Name = "pbFoto"
        Me.pbFoto.Size = New System.Drawing.Size(167, 163)
        Me.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFoto.TabIndex = 3
        Me.pbFoto.TabStop = False
        '
        'btnKaydet
        '
        Me.btnKaydet.BackColor = System.Drawing.Color.White
        Me.btnKaydet.Location = New System.Drawing.Point(406, 12)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(68, 41)
        Me.btnKaydet.TabIndex = 5
        Me.btnKaydet.Text = "Kaydet"
        Me.btnKaydet.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(810, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "T.C No "
        '
        'tbAdSoyad
        '
        Me.tbAdSoyad.AutoSize = True
        Me.tbAdSoyad.Location = New System.Drawing.Point(809, 79)
        Me.tbAdSoyad.Name = "tbAdSoyad"
        Me.tbAdSoyad.Size = New System.Drawing.Size(77, 17)
        Me.tbAdSoyad.TabIndex = 8
        Me.tbAdSoyad.Text = "Ad Soyad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(810, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Okul No"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(809, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Okula Kayıt"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Doğum Yeri"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Doğum Tarihi"
        '
        'ımageList1
        '
        Me.ımageList1.ImageStream = CType(resources.GetObject("ımageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ımageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ımageList1.Images.SetKeyName(0, "iconfinder_camera_299066.png")
        Me.ımageList1.Images.SetKeyName(1, "iconfinder_Cancel_1493282 (1).png")
        Me.ımageList1.Images.SetKeyName(2, "iconfinder_plus_1646001.png")
        '
        'btnSec
        '
        Me.btnSec.ImageIndex = 2
        Me.btnSec.ImageList = Me.ımageList1
        Me.btnSec.Location = New System.Drawing.Point(825, 183)
        Me.btnSec.Name = "btnSec"
        Me.btnSec.Size = New System.Drawing.Size(43, 36)
        Me.btnSec.TabIndex = 19
        Me.btnSec.UseVisualStyleBackColor = True
        '
        'txtTc
        '
        Me.txtTc.Enabled = False
        Me.txtTc.Location = New System.Drawing.Point(906, 48)
        Me.txtTc.Name = "txtTc"
        Me.txtTc.Size = New System.Drawing.Size(212, 22)
        Me.txtTc.TabIndex = 21
        '
        'txtAdSoyad
        '
        Me.txtAdSoyad.Enabled = False
        Me.txtAdSoyad.Location = New System.Drawing.Point(906, 76)
        Me.txtAdSoyad.Name = "txtAdSoyad"
        Me.txtAdSoyad.Size = New System.Drawing.Size(212, 22)
        Me.txtAdSoyad.TabIndex = 22
        '
        'txtNo
        '
        Me.txtNo.Enabled = False
        Me.txtNo.Location = New System.Drawing.Point(906, 105)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(212, 22)
        Me.txtNo.TabIndex = 23
        '
        'txtDYeri
        '
        Me.txtDYeri.Location = New System.Drawing.Point(114, 23)
        Me.txtDYeri.Name = "txtDYeri"
        Me.txtDYeri.Size = New System.Drawing.Size(129, 22)
        Me.txtDYeri.TabIndex = 26
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(114, 51)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(129, 22)
        Me.TextBox8.TabIndex = 27
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox13)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(878, 229)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(246, 92)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sınıf/Bölüm"
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(82, 57)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(158, 22)
        Me.TextBox13.TabIndex = 5
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(82, 27)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(158, 22)
        Me.TextBox6.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 57)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 17)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Bölüm"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 17)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Sınıf"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 27)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 17)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Cep Tel"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(259, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 17)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "E-mail"
        '
        'TextBox18
        '
        Me.TextBox18.Location = New System.Drawing.Point(73, 24)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(158, 22)
        Me.TextBox18.TabIndex = 4
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(331, 26)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(158, 22)
        Me.TextBox12.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.TextBox20)
        Me.GroupBox2.Controls.Add(Me.TextBox19)
        Me.GroupBox2.Controls.Add(Me.TextBox12)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.TextBox18)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(629, 348)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(495, 81)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "İletişim Bilgileri"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(259, 54)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(50, 17)
        Me.Label21.TabIndex = 41
        Me.Label21.Text = "Adres"
        '
        'TextBox20
        '
        Me.TextBox20.Location = New System.Drawing.Point(331, 51)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(158, 22)
        Me.TextBox20.TabIndex = 40
        '
        'TextBox19
        '
        Me.TextBox19.Location = New System.Drawing.Point(73, 51)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(158, 22)
        Me.TextBox19.TabIndex = 39
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 51)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(63, 17)
        Me.Label20.TabIndex = 38
        Me.Label20.Text = "Veli Adı"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 17)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Ara"
        '
        'txtTarih
        '
        Me.txtTarih.Enabled = False
        Me.txtTarih.Location = New System.Drawing.Point(906, 133)
        Me.txtTarih.Name = "txtTarih"
        Me.txtTarih.Size = New System.Drawing.Size(212, 22)
        Me.txtTarih.TabIndex = 41
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(635, 195)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 17)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Fotoğraf Seç"
        '
        'txtFoto
        '
        Me.txtFoto.Location = New System.Drawing.Point(742, 190)
        Me.txtFoto.Name = "txtFoto"
        Me.txtFoto.Size = New System.Drawing.Size(77, 22)
        Me.txtFoto.TabIndex = 44
        '
        'ofdResim
        '
        Me.ofdResim.FileName = "OpenFileDialog1"
        '
        'btnKapat
        '
        Me.btnKapat.BackColor = System.Drawing.Color.White
        Me.btnKapat.Location = New System.Drawing.Point(480, 12)
        Me.btnKapat.Name = "btnKapat"
        Me.btnKapat.Size = New System.Drawing.Size(69, 41)
        Me.btnKapat.TabIndex = 54
        Me.btnKapat.Text = "Kapat"
        Me.btnKapat.UseVisualStyleBackColor = False
        '
        'dgKayitlar
        '
        Me.dgKayitlar.AllowUserToAddRows = False
        Me.dgKayitlar.AllowUserToDeleteRows = False
        Me.dgKayitlar.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dgKayitlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgKayitlar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.tc, Me.Column1, Me.Column2, Me.kayit})
        Me.dgKayitlar.Location = New System.Drawing.Point(1, 61)
        Me.dgKayitlar.Name = "dgKayitlar"
        Me.dgKayitlar.ReadOnly = True
        Me.dgKayitlar.RowTemplate.Height = 24
        Me.dgKayitlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgKayitlar.Size = New System.Drawing.Size(622, 402)
        Me.dgKayitlar.TabIndex = 55
        '
        'id
        '
        Me.id.HeaderText = "Ö.ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'tc
        '
        Me.tc.HeaderText = "T.C"
        Me.tc.Name = "tc"
        Me.tc.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Ad Soyad"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 120
        '
        'Column2
        '
        Me.Column2.HeaderText = "Okul No"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'kayit
        '
        Me.kayit.HeaderText = "Kayıt Tarihi"
        Me.kayit.Name = "kayit"
        Me.kayit.ReadOnly = True
        Me.kayit.Width = 140
        '
        'btnYeni
        '
        Me.btnYeni.BackColor = System.Drawing.Color.White
        Me.btnYeni.Location = New System.Drawing.Point(345, 12)
        Me.btnYeni.Name = "btnYeni"
        Me.btnYeni.Size = New System.Drawing.Size(55, 40)
        Me.btnYeni.TabIndex = 56
        Me.btnYeni.Text = "Yeni"
        Me.btnYeni.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(810, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 17)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Öğrenci Id"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(906, 20)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(117, 22)
        Me.txtId.TabIndex = 58
        '
        'btnTemizle
        '
        Me.btnTemizle.BackColor = System.Drawing.Color.White
        Me.btnTemizle.Location = New System.Drawing.Point(1029, 16)
        Me.btnTemizle.Name = "btnTemizle"
        Me.btnTemizle.Size = New System.Drawing.Size(89, 27)
        Me.btnTemizle.TabIndex = 108
        Me.btnTemizle.Text = "Temizle"
        Me.btnTemizle.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox8)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtDYeri)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Location = New System.Drawing.Point(630, 229)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(246, 92)
        Me.GroupBox3.TabIndex = 109
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Genel Bilgi"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1163, 473)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnTemizle)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnYeni)
        Me.Controls.Add(Me.dgKayitlar)
        Me.Controls.Add(Me.btnKapat)
        Me.Controls.Add(Me.txtFoto)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtTarih)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtNo)
        Me.Controls.Add(Me.txtAdSoyad)
        Me.Controls.Add(Me.txtTc)
        Me.Controls.Add(Me.btnSec)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbAdSoyad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnKaydet)
        Me.Controls.Add(Me.pbFoto)
        Me.Controls.Add(Me.btnAra)
        Me.Controls.Add(Me.txtAra)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Öğrenci Ekle"
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgKayitlar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAra As TextBox
    Friend WithEvents btnAra As Button
    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents btnKaydet As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tbAdSoyad As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSec As Button
    Friend WithEvents txtTc As TextBox
    Friend WithEvents txtAdSoyad As TextBox
    Friend WithEvents txtNo As TextBox
    Friend WithEvents txtDYeri As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox20 As TextBox
    Friend WithEvents TextBox19 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents ımageList1 As ImageList
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTarih As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtFoto As TextBox
    Friend WithEvents ofdResim As OpenFileDialog
    Friend WithEvents btnKapat As Button
    Friend WithEvents dgKayitlar As DataGridView
    Friend WithEvents btnYeni As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents btnTemizle As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents tc As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents kayit As DataGridViewTextBoxColumn
End Class
