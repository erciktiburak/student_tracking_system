<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnKapat = New System.Windows.Forms.Button()
        Me.txtBolum = New System.Windows.Forms.TextBox()
        Me.txtSinif = New System.Windows.Forms.TextBox()
        Me.dgKayitlar = New System.Windows.Forms.DataGridView()
        Me.txtTarih = New System.Windows.Forms.TextBox()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.txtAdSoyad = New System.Windows.Forms.TextBox()
        Me.txtTc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbAdSoyad = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFoto = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnSec = New System.Windows.Forms.Button()
        Me.btnDuzenle = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAra = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.ofdResim = New System.Windows.Forms.OpenFileDialog()
        Me.pbFoto = New System.Windows.Forms.PictureBox()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.adsoyad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tarih = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sinif = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bolum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnTemizle = New System.Windows.Forms.Button()
        CType(Me.dgKayitlar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Sınıf :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 17)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Bölüm :"
        '
        'btnKapat
        '
        Me.btnKapat.BackColor = System.Drawing.Color.White
        Me.btnKapat.Location = New System.Drawing.Point(148, 404)
        Me.btnKapat.Name = "btnKapat"
        Me.btnKapat.Size = New System.Drawing.Size(113, 49)
        Me.btnKapat.TabIndex = 10
        Me.btnKapat.Text = "Kapat"
        Me.btnKapat.UseVisualStyleBackColor = False
        '
        'txtBolum
        '
        Me.txtBolum.Location = New System.Drawing.Point(110, 191)
        Me.txtBolum.Name = "txtBolum"
        Me.txtBolum.Size = New System.Drawing.Size(195, 22)
        Me.txtBolum.TabIndex = 15
        '
        'txtSinif
        '
        Me.txtSinif.Location = New System.Drawing.Point(110, 161)
        Me.txtSinif.Name = "txtSinif"
        Me.txtSinif.Size = New System.Drawing.Size(195, 22)
        Me.txtSinif.TabIndex = 14
        '
        'dgKayitlar
        '
        Me.dgKayitlar.AllowUserToAddRows = False
        Me.dgKayitlar.AllowUserToDeleteRows = False
        Me.dgKayitlar.BackgroundColor = System.Drawing.Color.White
        Me.dgKayitlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgKayitlar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.tc, Me.adsoyad, Me.no, Me.tarih, Me.sinif, Me.bolum})
        Me.dgKayitlar.Location = New System.Drawing.Point(309, 51)
        Me.dgKayitlar.Name = "dgKayitlar"
        Me.dgKayitlar.ReadOnly = True
        Me.dgKayitlar.RowTemplate.Height = 24
        Me.dgKayitlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgKayitlar.Size = New System.Drawing.Size(779, 402)
        Me.dgKayitlar.TabIndex = 19
        '
        'txtTarih
        '
        Me.txtTarih.Location = New System.Drawing.Point(110, 128)
        Me.txtTarih.Name = "txtTarih"
        Me.txtTarih.Size = New System.Drawing.Size(195, 22)
        Me.txtTarih.TabIndex = 49
        '
        'txtNo
        '
        Me.txtNo.Location = New System.Drawing.Point(110, 100)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(195, 22)
        Me.txtNo.TabIndex = 48
        '
        'txtAdSoyad
        '
        Me.txtAdSoyad.Location = New System.Drawing.Point(110, 71)
        Me.txtAdSoyad.Name = "txtAdSoyad"
        Me.txtAdSoyad.Size = New System.Drawing.Size(195, 22)
        Me.txtAdSoyad.TabIndex = 47
        '
        'txtTc
        '
        Me.txtTc.Location = New System.Drawing.Point(110, 43)
        Me.txtTc.Name = "txtTc"
        Me.txtTc.Size = New System.Drawing.Size(195, 22)
        Me.txtTc.TabIndex = 46
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 17)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Okula Kayıt"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 17)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Okul No"
        '
        'tbAdSoyad
        '
        Me.tbAdSoyad.AutoSize = True
        Me.tbAdSoyad.Location = New System.Drawing.Point(13, 74)
        Me.tbAdSoyad.Name = "tbAdSoyad"
        Me.tbAdSoyad.Size = New System.Drawing.Size(69, 17)
        Me.tbAdSoyad.TabIndex = 43
        Me.tbAdSoyad.Text = "Ad Soyad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "T.C No "
        '
        'txtFoto
        '
        Me.txtFoto.Location = New System.Drawing.Point(110, 234)
        Me.txtFoto.Name = "txtFoto"
        Me.txtFoto.Size = New System.Drawing.Size(88, 22)
        Me.txtFoto.TabIndex = 52
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 234)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 17)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Fotoğraf Seç"
        '
        'btnSec
        '
        Me.btnSec.BackColor = System.Drawing.Color.White
        Me.btnSec.Location = New System.Drawing.Point(207, 226)
        Me.btnSec.Name = "btnSec"
        Me.btnSec.Size = New System.Drawing.Size(54, 32)
        Me.btnSec.TabIndex = 50
        Me.btnSec.Text = "Seç"
        Me.btnSec.UseVisualStyleBackColor = False
        '
        'btnDuzenle
        '
        Me.btnDuzenle.BackColor = System.Drawing.Color.White
        Me.btnDuzenle.Location = New System.Drawing.Point(29, 404)
        Me.btnDuzenle.Name = "btnDuzenle"
        Me.btnDuzenle.Size = New System.Drawing.Size(113, 49)
        Me.btnDuzenle.TabIndex = 101
        Me.btnDuzenle.Text = "Düzenle"
        Me.btnDuzenle.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(323, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 17)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "Öğrenci Arama"
        '
        'txtAra
        '
        Me.txtAra.Location = New System.Drawing.Point(433, 23)
        Me.txtAra.Name = "txtAra"
        Me.txtAra.Size = New System.Drawing.Size(410, 22)
        Me.txtAra.TabIndex = 103
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 17)
        Me.Label6.TabIndex = 104
        Me.Label6.Text = "Id"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(110, 15)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(105, 22)
        Me.txtId.TabIndex = 105
        '
        'ofdResim
        '
        Me.ofdResim.FileName = "OpenFileDialog1"
        '
        'pbFoto
        '
        Me.pbFoto.Location = New System.Drawing.Point(29, 262)
        Me.pbFoto.Name = "pbFoto"
        Me.pbFoto.Size = New System.Drawing.Size(232, 136)
        Me.pbFoto.TabIndex = 106
        Me.pbFoto.TabStop = False
        '
        'id
        '
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'tc
        '
        Me.tc.HeaderText = "T.C"
        Me.tc.Name = "tc"
        Me.tc.ReadOnly = True
        '
        'adsoyad
        '
        Me.adsoyad.HeaderText = "Ad Soyad"
        Me.adsoyad.Name = "adsoyad"
        Me.adsoyad.ReadOnly = True
        '
        'no
        '
        Me.no.HeaderText = "Okul No"
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        '
        'tarih
        '
        Me.tarih.HeaderText = "Kayıt Tarihi"
        Me.tarih.Name = "tarih"
        Me.tarih.ReadOnly = True
        '
        'sinif
        '
        Me.sinif.HeaderText = "Sınıf"
        Me.sinif.Name = "sinif"
        Me.sinif.ReadOnly = True
        '
        'bolum
        '
        Me.bolum.HeaderText = "Bölüm"
        Me.bolum.Name = "bolum"
        Me.bolum.ReadOnly = True
        '
        'btnTemizle
        '
        Me.btnTemizle.BackColor = System.Drawing.Color.White
        Me.btnTemizle.Location = New System.Drawing.Point(221, 13)
        Me.btnTemizle.Name = "btnTemizle"
        Me.btnTemizle.Size = New System.Drawing.Size(89, 27)
        Me.btnTemizle.TabIndex = 107
        Me.btnTemizle.Text = "Temizle"
        Me.btnTemizle.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1100, 461)
        Me.Controls.Add(Me.btnTemizle)
        Me.Controls.Add(Me.pbFoto)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAra)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnDuzenle)
        Me.Controls.Add(Me.txtFoto)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnSec)
        Me.Controls.Add(Me.txtTarih)
        Me.Controls.Add(Me.txtNo)
        Me.Controls.Add(Me.txtAdSoyad)
        Me.Controls.Add(Me.txtTc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbAdSoyad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgKayitlar)
        Me.Controls.Add(Me.txtBolum)
        Me.Controls.Add(Me.txtSinif)
        Me.Controls.Add(Me.btnKapat)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Öğrenci Listesi"
        CType(Me.dgKayitlar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnKapat As Button
    Friend WithEvents txtBolum As TextBox
    Friend WithEvents txtSinif As TextBox
    Friend WithEvents dgKayitlar As DataGridView
    Friend WithEvents txtTarih As TextBox
    Friend WithEvents txtNo As TextBox
    Friend WithEvents txtAdSoyad As TextBox
    Friend WithEvents txtTc As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbAdSoyad As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFoto As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnSec As Button
    Friend WithEvents btnDuzenle As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAra As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents ofdResim As OpenFileDialog
    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents tc As DataGridViewTextBoxColumn
    Friend WithEvents adsoyad As DataGridViewTextBoxColumn
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents tarih As DataGridViewTextBoxColumn
    Friend WithEvents sinif As DataGridViewTextBoxColumn
    Friend WithEvents bolum As DataGridViewTextBoxColumn
    Friend WithEvents btnTemizle As Button
End Class
