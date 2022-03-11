<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form13
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form13))
        Me.lbYazi = New System.Windows.Forms.Label()
        Me.lbUyeOl = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCikis = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnGiris = New System.Windows.Forms.Button()
        Me.txtParola = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbYazi
        '
        Me.lbYazi.AutoSize = True
        Me.lbYazi.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbYazi.Location = New System.Drawing.Point(322, 92)
        Me.lbYazi.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbYazi.Name = "lbYazi"
        Me.lbYazi.Size = New System.Drawing.Size(129, 39)
        Me.lbYazi.TabIndex = 28
        Me.lbYazi.Text = "Sign in"
        '
        'lbUyeOl
        '
        Me.lbUyeOl.AutoSize = True
        Me.lbUyeOl.BackColor = System.Drawing.Color.White
        Me.lbUyeOl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbUyeOl.LinkColor = System.Drawing.Color.Black
        Me.lbUyeOl.Location = New System.Drawing.Point(9, 335)
        Me.lbUyeOl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbUyeOl.Name = "lbUyeOl"
        Me.lbUyeOl.Size = New System.Drawing.Size(82, 24)
        Me.lbUyeOl.TabIndex = 27
        Me.lbUyeOl.TabStop = True
        Me.lbUyeOl.Text = "Sign up"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Orange
        Me.Label3.Location = New System.Drawing.Point(56, 34)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(373, 36)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Hello There! Welcome ☺"
        '
        'btnCikis
        '
        Me.btnCikis.BackColor = System.Drawing.SystemColors.Window
        Me.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCikis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCikis.ImageIndex = 0
        Me.btnCikis.Location = New System.Drawing.Point(392, 239)
        Me.btnCikis.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCikis.Name = "btnCikis"
        Me.btnCikis.Size = New System.Drawing.Size(74, 38)
        Me.btnCikis.TabIndex = 25
        Me.btnCikis.Text = "cancel"
        Me.btnCikis.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 92)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(172, 167)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'btnGiris
        '
        Me.btnGiris.BackColor = System.Drawing.SystemColors.Window
        Me.btnGiris.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGiris.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnGiris.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGiris.ImageIndex = 1
        Me.btnGiris.Location = New System.Drawing.Point(315, 239)
        Me.btnGiris.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnGiris.Name = "btnGiris"
        Me.btnGiris.Size = New System.Drawing.Size(65, 38)
        Me.btnGiris.TabIndex = 23
        Me.btnGiris.Text = "login"
        Me.btnGiris.UseVisualStyleBackColor = False
        '
        'txtParola
        '
        Me.txtParola.Location = New System.Drawing.Point(329, 174)
        Me.txtParola.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtParola.Name = "txtParola"
        Me.txtParola.PasswordChar = Global.Microsoft.VisualBasic.ChrW(36)
        Me.txtParola.Size = New System.Drawing.Size(137, 20)
        Me.txtParola.TabIndex = 22
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(329, 141)
        Me.txtId.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(137, 20)
        Me.txtId.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(212, 172)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Password :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(212, 141)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Username:"
        '
        'Form13
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(486, 366)
        Me.Controls.Add(Me.lbYazi)
        Me.Controls.Add(Me.lbUyeOl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCikis)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnGiris)
        Me.Controls.Add(Me.txtParola)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form13"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Üye Girişi"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbYazi As Label
    Friend WithEvents lbUyeOl As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCikis As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnGiris As Button
    Friend WithEvents txtParola As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
