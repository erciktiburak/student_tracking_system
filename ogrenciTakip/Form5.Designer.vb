<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.txtAra = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnYeni = New System.Windows.Forms.Button()
        Me.dgOgrenci = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgOgrenci, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAra
        '
        Me.txtAra.Location = New System.Drawing.Point(133, 20)
        Me.txtAra.Name = "txtAra"
        Me.txtAra.Size = New System.Drawing.Size(353, 22)
        Me.txtAra.TabIndex = 32
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 17)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Müşteri Arama"
        '
        'btnYeni
        '
        Me.btnYeni.BackColor = System.Drawing.Color.White
        Me.btnYeni.Location = New System.Drawing.Point(526, 9)
        Me.btnYeni.Name = "btnYeni"
        Me.btnYeni.Size = New System.Drawing.Size(139, 54)
        Me.btnYeni.TabIndex = 30
        Me.btnYeni.Text = "Yeni Müşteri"
        Me.btnYeni.UseVisualStyleBackColor = False
        '
        'dgOgrenci
        '
        Me.dgOgrenci.AllowUserToAddRows = False
        Me.dgOgrenci.AllowUserToDeleteRows = False
        Me.dgOgrenci.BackgroundColor = System.Drawing.Color.White
        Me.dgOgrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgOgrenci.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgOgrenci.Location = New System.Drawing.Point(12, 69)
        Me.dgOgrenci.Name = "dgOgrenci"
        Me.dgOgrenci.ReadOnly = True
        Me.dgOgrenci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgOgrenci.Size = New System.Drawing.Size(697, 431)
        Me.dgOgrenci.TabIndex = 29
        '
        'Column1
        '
        Me.Column1.HeaderText = "M.No"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "AdSoyad"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Tel"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Adres"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(715, 505)
        Me.Controls.Add(Me.txtAra)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnYeni)
        Me.Controls.Add(Me.dgOgrenci)
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form5"
        CType(Me.dgOgrenci, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAra As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnYeni As Button
    Friend WithEvents dgOgrenci As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
