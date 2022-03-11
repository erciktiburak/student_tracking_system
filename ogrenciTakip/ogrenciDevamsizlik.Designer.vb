<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Me.txtDevamsizlik = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnKaydet = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtTarih = New System.Windows.Forms.DateTimePicker()
        Me.lbGelinmeyen = New System.Windows.Forms.Label()
        Me.lbToplam = New System.Windows.Forms.Label()
        Me.lbKalan = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnKayitGetir = New System.Windows.Forms.Button()
        Me.dgGirilenler = New System.Windows.Forms.DataGridView()
        Me.dgKayitlar = New System.Windows.Forms.DataGridView()
        Me.btnGozat = New System.Windows.Forms.Button()
        Me.btnTemizle = New System.Windows.Forms.Button()
        Me.txtAdres = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtAdSoyad = New System.Windows.Forms.TextBox()
        Me.txtOgrNo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.dgGirilenler, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgKayitlar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDevamsizlik
        '
        Me.txtDevamsizlik.Location = New System.Drawing.Point(600, 688)
        Me.txtDevamsizlik.Name = "txtDevamsizlik"
        Me.txtDevamsizlik.Size = New System.Drawing.Size(103, 22)
        Me.txtDevamsizlik.TabIndex = 71
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label12.Location = New System.Drawing.Point(388, 685)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(206, 29)
        Me.Label12.TabIndex = 70
        Me.Label12.Text = "Devamsızlık Gir"
        '
        'btnKaydet
        '
        Me.btnKaydet.BackColor = System.Drawing.Color.White
        Me.btnKaydet.Location = New System.Drawing.Point(709, 684)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(105, 30)
        Me.btnKaydet.TabIndex = 69
        Me.btnKaydet.Text = "Kaydet"
        Me.btnKaydet.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(410, 642)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 29)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Tarih"
        '
        'dtTarih
        '
        Me.dtTarih.Location = New System.Drawing.Point(560, 642)
        Me.dtTarih.Name = "dtTarih"
        Me.dtTarih.Size = New System.Drawing.Size(250, 22)
        Me.dtTarih.TabIndex = 67
        '
        'lbGelinmeyen
        '
        Me.lbGelinmeyen.AutoSize = True
        Me.lbGelinmeyen.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbGelinmeyen.Location = New System.Drawing.Point(640, 566)
        Me.lbGelinmeyen.Name = "lbGelinmeyen"
        Me.lbGelinmeyen.Size = New System.Drawing.Size(47, 39)
        Me.lbGelinmeyen.TabIndex = 66
        Me.lbGelinmeyen.Text = "0 "
        '
        'lbToplam
        '
        Me.lbToplam.AutoSize = True
        Me.lbToplam.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbToplam.Location = New System.Drawing.Point(311, 566)
        Me.lbToplam.Name = "lbToplam"
        Me.lbToplam.Size = New System.Drawing.Size(47, 39)
        Me.lbToplam.TabIndex = 65
        Me.lbToplam.Text = "0 "
        '
        'lbKalan
        '
        Me.lbKalan.AutoSize = True
        Me.lbKalan.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbKalan.Location = New System.Drawing.Point(195, 632)
        Me.lbKalan.Name = "lbKalan"
        Me.lbKalan.Size = New System.Drawing.Size(37, 39)
        Me.lbKalan.TabIndex = 64
        Me.lbKalan.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.Location = New System.Drawing.Point(44, 625)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 39)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Kalan :"
        '
        'btnKayitGetir
        '
        Me.btnKayitGetir.BackColor = System.Drawing.Color.White
        Me.btnKayitGetir.Location = New System.Drawing.Point(302, 104)
        Me.btnKayitGetir.Name = "btnKayitGetir"
        Me.btnKayitGetir.Size = New System.Drawing.Size(129, 42)
        Me.btnKayitGetir.TabIndex = 62
        Me.btnKayitGetir.Text = "Kayıt Getir"
        Me.btnKayitGetir.UseVisualStyleBackColor = False
        '
        'dgGirilenler
        '
        Me.dgGirilenler.AllowUserToAddRows = False
        Me.dgGirilenler.AllowUserToDeleteRows = False
        Me.dgGirilenler.BackgroundColor = System.Drawing.Color.White
        Me.dgGirilenler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgGirilenler.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4})
        Me.dgGirilenler.Location = New System.Drawing.Point(518, 162)
        Me.dgGirilenler.Name = "dgGirilenler"
        Me.dgGirilenler.ReadOnly = True
        Me.dgGirilenler.RowTemplate.Height = 24
        Me.dgGirilenler.Size = New System.Drawing.Size(425, 382)
        Me.dgGirilenler.TabIndex = 61
        '
        'dgKayitlar
        '
        Me.dgKayitlar.AllowUserToAddRows = False
        Me.dgKayitlar.AllowUserToDeleteRows = False
        Me.dgKayitlar.BackgroundColor = System.Drawing.Color.White
        Me.dgKayitlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgKayitlar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgKayitlar.Location = New System.Drawing.Point(12, 162)
        Me.dgKayitlar.Name = "dgKayitlar"
        Me.dgKayitlar.ReadOnly = True
        Me.dgKayitlar.RowTemplate.Height = 24
        Me.dgKayitlar.Size = New System.Drawing.Size(500, 382)
        Me.dgKayitlar.TabIndex = 60
        '
        'btnGozat
        '
        Me.btnGozat.BackColor = System.Drawing.Color.White
        Me.btnGozat.Location = New System.Drawing.Point(278, 13)
        Me.btnGozat.Name = "btnGozat"
        Me.btnGozat.Size = New System.Drawing.Size(73, 32)
        Me.btnGozat.TabIndex = 59
        Me.btnGozat.Text = "Gözat"
        Me.btnGozat.UseVisualStyleBackColor = False
        '
        'btnTemizle
        '
        Me.btnTemizle.BackColor = System.Drawing.Color.White
        Me.btnTemizle.Location = New System.Drawing.Point(357, 13)
        Me.btnTemizle.Name = "btnTemizle"
        Me.btnTemizle.Size = New System.Drawing.Size(74, 33)
        Me.btnTemizle.TabIndex = 58
        Me.btnTemizle.Text = "Temizle"
        Me.btnTemizle.UseVisualStyleBackColor = False
        '
        'txtAdres
        '
        Me.txtAdres.Enabled = False
        Me.txtAdres.Location = New System.Drawing.Point(563, 47)
        Me.txtAdres.Multiline = True
        Me.txtAdres.Name = "txtAdres"
        Me.txtAdres.Size = New System.Drawing.Size(250, 74)
        Me.txtAdres.TabIndex = 57
        '
        'txtTel
        '
        Me.txtTel.Enabled = False
        Me.txtTel.Location = New System.Drawing.Point(563, 10)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(250, 22)
        Me.txtTel.TabIndex = 56
        '
        'txtAdSoyad
        '
        Me.txtAdSoyad.Enabled = False
        Me.txtAdSoyad.Location = New System.Drawing.Point(213, 58)
        Me.txtAdSoyad.Name = "txtAdSoyad"
        Me.txtAdSoyad.Size = New System.Drawing.Size(218, 22)
        Me.txtAdSoyad.TabIndex = 55
        '
        'txtOgrNo
        '
        Me.txtOgrNo.Enabled = False
        Me.txtOgrNo.Location = New System.Drawing.Point(213, 18)
        Me.txtOgrNo.Multiline = True
        Me.txtOgrNo.Name = "txtOgrNo"
        Me.txtOgrNo.Size = New System.Drawing.Size(60, 25)
        Me.txtOgrNo.TabIndex = 54
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(457, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 17)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Adres"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(457, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 17)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Tel"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(121, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 17)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Adı Soyadı"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(121, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Öğrenci No"
        '
        'Column1
        '
        Me.Column1.HeaderText = "KN"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "Tarih"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Etkinlikler"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Kalan Devamsızlık"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 160
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "TNo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tarih"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Toplam Devamsızlık"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 160
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 566)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(280, 39)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Toplam Devam :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label8.Location = New System.Drawing.Point(423, 566)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(221, 39)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "Devamsızlık:"
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(947, 773)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDevamsizlik)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnKaydet)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtTarih)
        Me.Controls.Add(Me.lbGelinmeyen)
        Me.Controls.Add(Me.lbToplam)
        Me.Controls.Add(Me.lbKalan)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnKayitGetir)
        Me.Controls.Add(Me.dgGirilenler)
        Me.Controls.Add(Me.dgKayitlar)
        Me.Controls.Add(Me.btnGozat)
        Me.Controls.Add(Me.btnTemizle)
        Me.Controls.Add(Me.txtAdres)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtAdSoyad)
        Me.Controls.Add(Me.txtOgrNo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form10"
        Me.Text = "Devamsızlık"
        CType(Me.dgGirilenler, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgKayitlar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDevamsizlik As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnKaydet As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dtTarih As DateTimePicker
    Friend WithEvents lbGelinmeyen As Label
    Friend WithEvents lbToplam As Label
    Friend WithEvents lbKalan As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnKayitGetir As Button
    Friend WithEvents dgGirilenler As DataGridView
    Friend WithEvents dgKayitlar As DataGridView
    Friend WithEvents btnGozat As Button
    Friend WithEvents btnTemizle As Button
    Friend WithEvents txtAdres As TextBox
    Friend WithEvents txtTel As TextBox
    Friend WithEvents txtAdSoyad As TextBox
    Friend WithEvents txtOgrNo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
End Class
