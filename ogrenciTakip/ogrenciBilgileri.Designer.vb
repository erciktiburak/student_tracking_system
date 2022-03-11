<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form11
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
        Me.btnTemizle = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSec = New System.Windows.Forms.Button()
        Me.txtResim = New System.Windows.Forms.TextBox()
        Me.pbFoto = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnKapat = New System.Windows.Forms.Button()
        Me.btnKaydet = New System.Windows.Forms.Button()
        Me.txtKimlik = New System.Windows.Forms.TextBox()
        Me.txtAdsoyad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ofdFto = New System.Windows.Forms.OpenFileDialog()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.txtTarih = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTemizle
        '
        Me.btnTemizle.BackColor = System.Drawing.Color.White
        Me.btnTemizle.Location = New System.Drawing.Point(116, 230)
        Me.btnTemizle.Name = "btnTemizle"
        Me.btnTemizle.Size = New System.Drawing.Size(87, 27)
        Me.btnTemizle.TabIndex = 69
        Me.btnTemizle.Text = "Temizle"
        Me.btnTemizle.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 195)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 17)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Resim Ekle"
        '
        'btnSec
        '
        Me.btnSec.BackColor = System.Drawing.Color.White
        Me.btnSec.Location = New System.Drawing.Point(338, 184)
        Me.btnSec.Name = "btnSec"
        Me.btnSec.Size = New System.Drawing.Size(80, 33)
        Me.btnSec.TabIndex = 67
        Me.btnSec.Text = "Seç"
        Me.btnSec.UseVisualStyleBackColor = False
        '
        'txtResim
        '
        Me.txtResim.Location = New System.Drawing.Point(117, 189)
        Me.txtResim.Name = "txtResim"
        Me.txtResim.Size = New System.Drawing.Size(219, 22)
        Me.txtResim.TabIndex = 66
        '
        'pbFoto
        '
        Me.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbFoto.Location = New System.Drawing.Point(424, 89)
        Me.pbFoto.Name = "pbFoto"
        Me.pbFoto.Size = New System.Drawing.Size(174, 122)
        Me.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFoto.TabIndex = 65
        Me.pbFoto.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 136)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Telefon"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(160, 17)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 31)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Öğrenci Ekleme"
        '
        'btnKapat
        '
        Me.btnKapat.BackColor = System.Drawing.Color.White
        Me.btnKapat.Location = New System.Drawing.Point(318, 229)
        Me.btnKapat.Margin = New System.Windows.Forms.Padding(4)
        Me.btnKapat.Name = "btnKapat"
        Me.btnKapat.Size = New System.Drawing.Size(100, 28)
        Me.btnKapat.TabIndex = 61
        Me.btnKapat.Text = "Kapat"
        Me.btnKapat.UseVisualStyleBackColor = False
        '
        'btnKaydet
        '
        Me.btnKaydet.BackColor = System.Drawing.Color.White
        Me.btnKaydet.Location = New System.Drawing.Point(210, 229)
        Me.btnKaydet.Margin = New System.Windows.Forms.Padding(4)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(100, 28)
        Me.btnKaydet.TabIndex = 60
        Me.btnKaydet.Text = "Kaydet"
        Me.btnKaydet.UseVisualStyleBackColor = False
        '
        'txtKimlik
        '
        Me.txtKimlik.Location = New System.Drawing.Point(117, 63)
        Me.txtKimlik.Margin = New System.Windows.Forms.Padding(4)
        Me.txtKimlik.MaxLength = 11
        Me.txtKimlik.Name = "txtKimlik"
        Me.txtKimlik.Size = New System.Drawing.Size(296, 22)
        Me.txtKimlik.TabIndex = 59
        '
        'txtAdsoyad
        '
        Me.txtAdsoyad.Location = New System.Drawing.Point(117, 98)
        Me.txtAdsoyad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAdsoyad.MaxLength = 250
        Me.txtAdsoyad.Name = "txtAdsoyad"
        Me.txtAdsoyad.Size = New System.Drawing.Size(296, 22)
        Me.txtAdsoyad.TabIndex = 58
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 67)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 17)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "TC Kimlik No"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 104)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 17)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Adı Soyadı"
        '
        'ofdFto
        '
        Me.ofdFto.FileName = "OpenFileDialog1"
        '
        'txtNo
        '
        Me.txtNo.Location = New System.Drawing.Point(116, 131)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(296, 22)
        Me.txtNo.TabIndex = 72
        '
        'txtTarih
        '
        Me.txtTarih.Location = New System.Drawing.Point(116, 161)
        Me.txtTarih.Name = "txtTarih"
        Me.txtTarih.Size = New System.Drawing.Size(296, 22)
        Me.txtTarih.TabIndex = 74
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Email"
        '
        'Form11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(608, 296)
        Me.Controls.Add(Me.txtTarih)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNo)
        Me.Controls.Add(Me.btnTemizle)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnSec)
        Me.Controls.Add(Me.txtResim)
        Me.Controls.Add(Me.pbFoto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnKapat)
        Me.Controls.Add(Me.btnKaydet)
        Me.Controls.Add(Me.txtKimlik)
        Me.Controls.Add(Me.txtAdsoyad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Name = "Form11"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Öğrenci Ekleme"
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTemizle As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSec As Button
    Friend WithEvents txtResim As TextBox
    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnKapat As Button
    Friend WithEvents btnKaydet As Button
    Friend WithEvents txtKimlik As TextBox
    Friend WithEvents txtAdsoyad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ofdFto As OpenFileDialog
    Friend WithEvents txtNo As TextBox
    Friend WithEvents txtTarih As TextBox
    Friend WithEvents Label1 As Label
End Class
