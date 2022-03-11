<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form14
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form14))
        Me.txtParola = New System.Windows.Forms.TextBox()
        Me.LbParola = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.LbId = New System.Windows.Forms.Label()
        Me.btnUyeOl = New System.Windows.Forms.Button()
        Me.ımageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnCik = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtParola
        '
        Me.txtParola.Location = New System.Drawing.Point(153, 120)
        Me.txtParola.Name = "txtParola"
        Me.txtParola.PasswordChar = Global.Microsoft.VisualBasic.ChrW(36)
        Me.txtParola.Size = New System.Drawing.Size(246, 22)
        Me.txtParola.TabIndex = 24
        '
        'LbParola
        '
        Me.LbParola.AutoSize = True
        Me.LbParola.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LbParola.Location = New System.Drawing.Point(12, 116)
        Me.LbParola.Name = "LbParola"
        Me.LbParola.Size = New System.Drawing.Size(74, 25)
        Me.LbParola.TabIndex = 23
        Me.LbParola.Text = "Parola"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(153, 70)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(246, 22)
        Me.txtId.TabIndex = 22
        '
        'LbId
        '
        Me.LbId.AutoSize = True
        Me.LbId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LbId.Location = New System.Drawing.Point(12, 66)
        Me.LbId.Name = "LbId"
        Me.LbId.Size = New System.Drawing.Size(132, 25)
        Me.LbId.TabIndex = 21
        Me.LbId.Text = "Kullanıcı Adı"
        '
        'btnUyeOl
        '
        Me.btnUyeOl.BackColor = System.Drawing.Color.White
        Me.btnUyeOl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUyeOl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnUyeOl.Location = New System.Drawing.Point(277, 170)
        Me.btnUyeOl.Name = "btnUyeOl"
        Me.btnUyeOl.Size = New System.Drawing.Size(122, 37)
        Me.btnUyeOl.TabIndex = 20
        Me.btnUyeOl.Text = "Üye Ol"
        Me.btnUyeOl.UseVisualStyleBackColor = False
        '
        'ımageList1
        '
        Me.ımageList1.ImageStream = CType(resources.GetObject("ımageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ımageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ımageList1.Images.SetKeyName(0, "iconfinder_Cancel_1493282.png")
        '
        'btnCik
        '
        Me.btnCik.BackColor = System.Drawing.Color.White
        Me.btnCik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCik.ImageIndex = 0
        Me.btnCik.ImageList = Me.ımageList1
        Me.btnCik.Location = New System.Drawing.Point(320, 12)
        Me.btnCik.Name = "btnCik"
        Me.btnCik.Size = New System.Drawing.Size(79, 42)
        Me.btnCik.TabIndex = 26
        Me.btnCik.Text = "Çık"
        Me.btnCik.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCik.UseVisualStyleBackColor = False
        '
        'Form14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(401, 208)
        Me.Controls.Add(Me.btnCik)
        Me.Controls.Add(Me.txtParola)
        Me.Controls.Add(Me.LbParola)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.LbId)
        Me.Controls.Add(Me.btnUyeOl)
        Me.Name = "Form14"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Üye Ol"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtParola As TextBox
    Friend WithEvents LbParola As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents LbId As Label
    Friend WithEvents btnUyeOl As Button
    Friend WithEvents ımageList1 As ImageList
    Friend WithEvents btnCik As Button
End Class
