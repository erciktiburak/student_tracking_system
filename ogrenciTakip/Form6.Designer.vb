<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbDers = New System.Windows.Forms.ComboBox()
        Me.cbOgr = New System.Windows.Forms.ComboBox()
        Me.btnKaydet = New System.Windows.Forms.Button()
        Me.btnKapat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 29.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(87, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(422, 57)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ders Kayıt Ekranı"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(92, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ders Seçiniz"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(92, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Öğrenci Seçiniz"
        '
        'cbDers
        '
        Me.cbDers.FormattingEnabled = True
        Me.cbDers.Location = New System.Drawing.Point(271, 175)
        Me.cbDers.Name = "cbDers"
        Me.cbDers.Size = New System.Drawing.Size(200, 24)
        Me.cbDers.TabIndex = 3
        '
        'cbOgr
        '
        Me.cbOgr.FormattingEnabled = True
        Me.cbOgr.Location = New System.Drawing.Point(271, 215)
        Me.cbOgr.Name = "cbOgr"
        Me.cbOgr.Size = New System.Drawing.Size(200, 24)
        Me.cbOgr.TabIndex = 4
        '
        'btnKaydet
        '
        Me.btnKaydet.BackColor = System.Drawing.Color.White
        Me.btnKaydet.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnKaydet.Location = New System.Drawing.Point(271, 272)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(97, 57)
        Me.btnKaydet.TabIndex = 5
        Me.btnKaydet.Text = "Kaydet"
        Me.btnKaydet.UseVisualStyleBackColor = False
        '
        'btnKapat
        '
        Me.btnKapat.BackColor = System.Drawing.Color.White
        Me.btnKapat.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnKapat.Location = New System.Drawing.Point(374, 272)
        Me.btnKapat.Name = "btnKapat"
        Me.btnKapat.Size = New System.Drawing.Size(97, 57)
        Me.btnKapat.TabIndex = 6
        Me.btnKapat.Text = "Kapat"
        Me.btnKapat.UseVisualStyleBackColor = False
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(614, 355)
        Me.Controls.Add(Me.btnKapat)
        Me.Controls.Add(Me.btnKaydet)
        Me.Controls.Add(Me.cbOgr)
        Me.Controls.Add(Me.cbDers)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form6"
        Me.Text = "Ders Ekle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbDers As ComboBox
    Friend WithEvents cbOgr As ComboBox
    Friend WithEvents btnKaydet As Button
    Friend WithEvents btnKapat As Button
End Class
