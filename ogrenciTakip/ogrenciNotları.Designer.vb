<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form12
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.btnEkle = New System.Windows.Forms.Button()
        Me.dgKayitlar = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnGuncelle = New System.Windows.Forms.Button()
        Me.btnSil = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtOgrNo = New System.Windows.Forms.TextBox()
        Me.txtAdsoyad = New System.Windows.Forms.TextBox()
        Me.txtVize = New System.Windows.Forms.TextBox()
        Me.txtFinal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnKapat = New System.Windows.Forms.Button()
        Me.btnTemizle = New System.Windows.Forms.Button()
        Me.Ara = New System.Windows.Forms.Label()
        Me.txtAra = New System.Windows.Forms.TextBox()
        Me.txtDers = New System.Windows.Forms.TextBox()
        Me.Ders = New System.Windows.Forms.Label()
        CType(Me.dgKayitlar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kayit Id"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(93, 6)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(60, 22)
        Me.txtId.TabIndex = 1
        '
        'btnEkle
        '
        Me.btnEkle.BackColor = System.Drawing.Color.White
        Me.btnEkle.Location = New System.Drawing.Point(677, 31)
        Me.btnEkle.Name = "btnEkle"
        Me.btnEkle.Size = New System.Drawing.Size(106, 40)
        Me.btnEkle.TabIndex = 2
        Me.btnEkle.Text = "Ekle"
        Me.btnEkle.UseVisualStyleBackColor = False
        '
        'dgKayitlar
        '
        Me.dgKayitlar.AllowUserToAddRows = False
        Me.dgKayitlar.AllowUserToDeleteRows = False
        Me.dgKayitlar.BackgroundColor = System.Drawing.Color.White
        Me.dgKayitlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgKayitlar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column2, Me.Column1, Me.Column6, Me.Column4, Me.Column5})
        Me.dgKayitlar.Location = New System.Drawing.Point(10, 129)
        Me.dgKayitlar.Name = "dgKayitlar"
        Me.dgKayitlar.ReadOnly = True
        Me.dgKayitlar.RowTemplate.Height = 24
        Me.dgKayitlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgKayitlar.Size = New System.Drawing.Size(978, 421)
        Me.dgKayitlar.TabIndex = 3
        '
        'Column3
        '
        Me.Column3.HeaderText = "KayNo"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Öğrenci No"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 160
        '
        'Column1
        '
        Me.Column1.HeaderText = "Adı Soyadı"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 160
        '
        'Column6
        '
        Me.Column6.HeaderText = "Ders"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Vize"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Final"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'btnGuncelle
        '
        Me.btnGuncelle.BackColor = System.Drawing.Color.White
        Me.btnGuncelle.Location = New System.Drawing.Point(789, 31)
        Me.btnGuncelle.Name = "btnGuncelle"
        Me.btnGuncelle.Size = New System.Drawing.Size(106, 40)
        Me.btnGuncelle.TabIndex = 4
        Me.btnGuncelle.Text = "Güncelle"
        Me.btnGuncelle.UseVisualStyleBackColor = False
        '
        'btnSil
        '
        Me.btnSil.BackColor = System.Drawing.Color.White
        Me.btnSil.Location = New System.Drawing.Point(677, 79)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.Size = New System.Drawing.Size(106, 40)
        Me.btnSil.TabIndex = 5
        Me.btnSil.Text = "Sil"
        Me.btnSil.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Öğrenci No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(302, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Vize"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Adı Soyadı"
        '
        'txtOgrNo
        '
        Me.txtOgrNo.Location = New System.Drawing.Point(93, 65)
        Me.txtOgrNo.Name = "txtOgrNo"
        Me.txtOgrNo.Size = New System.Drawing.Size(166, 22)
        Me.txtOgrNo.TabIndex = 9
        '
        'txtAdsoyad
        '
        Me.txtAdsoyad.Location = New System.Drawing.Point(93, 37)
        Me.txtAdsoyad.Name = "txtAdsoyad"
        Me.txtAdsoyad.Size = New System.Drawing.Size(166, 22)
        Me.txtAdsoyad.TabIndex = 10
        '
        'txtVize
        '
        Me.txtVize.Location = New System.Drawing.Point(358, 31)
        Me.txtVize.Name = "txtVize"
        Me.txtVize.Size = New System.Drawing.Size(213, 22)
        Me.txtVize.TabIndex = 11
        '
        'txtFinal
        '
        Me.txtFinal.Location = New System.Drawing.Point(358, 60)
        Me.txtFinal.Name = "txtFinal"
        Me.txtFinal.Size = New System.Drawing.Size(213, 22)
        Me.txtFinal.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(302, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Final"
        '
        'btnKapat
        '
        Me.btnKapat.BackColor = System.Drawing.Color.White
        Me.btnKapat.Location = New System.Drawing.Point(792, 77)
        Me.btnKapat.Name = "btnKapat"
        Me.btnKapat.Size = New System.Drawing.Size(106, 40)
        Me.btnKapat.TabIndex = 14
        Me.btnKapat.Text = "Kapat"
        Me.btnKapat.UseVisualStyleBackColor = False
        '
        'btnTemizle
        '
        Me.btnTemizle.BackColor = System.Drawing.Color.White
        Me.btnTemizle.Location = New System.Drawing.Point(159, 6)
        Me.btnTemizle.Name = "btnTemizle"
        Me.btnTemizle.Size = New System.Drawing.Size(100, 25)
        Me.btnTemizle.TabIndex = 15
        Me.btnTemizle.Text = "Temizle"
        Me.btnTemizle.UseVisualStyleBackColor = False
        '
        'Ara
        '
        Me.Ara.AutoSize = True
        Me.Ara.Location = New System.Drawing.Point(269, 98)
        Me.Ara.Name = "Ara"
        Me.Ara.Size = New System.Drawing.Size(30, 17)
        Me.Ara.TabIndex = 16
        Me.Ara.Text = "Ara"
        '
        'txtAra
        '
        Me.txtAra.Location = New System.Drawing.Point(305, 95)
        Me.txtAra.Name = "txtAra"
        Me.txtAra.Size = New System.Drawing.Size(266, 22)
        Me.txtAra.TabIndex = 17
        '
        'txtDers
        '
        Me.txtDers.Location = New System.Drawing.Point(93, 95)
        Me.txtDers.Name = "txtDers"
        Me.txtDers.Size = New System.Drawing.Size(166, 22)
        Me.txtDers.TabIndex = 19
        '
        'Ders
        '
        Me.Ders.AutoSize = True
        Me.Ders.Location = New System.Drawing.Point(12, 100)
        Me.Ders.Name = "Ders"
        Me.Ders.Size = New System.Drawing.Size(38, 17)
        Me.Ders.TabIndex = 18
        Me.Ders.Text = "Ders"
        '
        'Form12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1000, 562)
        Me.Controls.Add(Me.txtDers)
        Me.Controls.Add(Me.Ders)
        Me.Controls.Add(Me.txtAra)
        Me.Controls.Add(Me.Ara)
        Me.Controls.Add(Me.btnTemizle)
        Me.Controls.Add(Me.btnKapat)
        Me.Controls.Add(Me.txtFinal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtVize)
        Me.Controls.Add(Me.txtAdsoyad)
        Me.Controls.Add(Me.txtOgrNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSil)
        Me.Controls.Add(Me.btnGuncelle)
        Me.Controls.Add(Me.dgKayitlar)
        Me.Controls.Add(Me.btnEkle)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form12"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Öğrenci Notları"
        CType(Me.dgKayitlar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents btnEkle As Button
    Friend WithEvents dgKayitlar As DataGridView
    Friend WithEvents btnGuncelle As Button
    Friend WithEvents btnSil As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtOgrNo As TextBox
    Friend WithEvents txtAdsoyad As TextBox
    Friend WithEvents txtVize As TextBox
    Friend WithEvents txtFinal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnKapat As Button
    Friend WithEvents btnTemizle As Button
    Friend WithEvents Ara As Label
    Friend WithEvents txtAra As TextBox
    Friend WithEvents txtDers As TextBox
    Friend WithEvents Ders As Label
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
