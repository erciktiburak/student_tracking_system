Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripLabel1.Text = Now.ToShortDateString()
        ToolStripLabel2.Text = Now.ToLongTimeString()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripLabel2.Text = Now.ToLongTimeString()
    End Sub

    Private Sub btnKapat_Click(sender As Object, e As EventArgs) Handles btnKapat.Click
        If MsgBox("Program kapatılacaktır! Onaylıyor Musunuz?", vbYesNo, "İPTAL") = MsgBoxResult.No Then
            Return
        End If
        Me.Close()

    End Sub

    Private Sub yeniOgrenciMenuItem_Click(sender As Object, e As EventArgs) Handles yeniOgrenciMenuItem.Click
        Form11.Show()
    End Sub

    Private Sub btnOgrenciEkle_Click(sender As Object, e As EventArgs) Handles btnOgrenciEkle.Click
        Form11.Show()
    End Sub

    Private Sub btnOgrenciBilgi_Click(sender As Object, e As EventArgs) Handles btnOgrenciBilgi.Click
        Form2.Show()
    End Sub

    Private Sub btnDevamsizlik_Click(sender As Object, e As EventArgs) Handles btnDevamsizlik.Click
        Form10.Show()
    End Sub

    Private Sub btnOgrenciListesi_Click(sender As Object, e As EventArgs) Handles btnOgrenciListesi.Click
        Form3.Show()
    End Sub

    Private Sub btnSinifListesi_Click(sender As Object, e As EventArgs) Handles btnSinifListesi.Click
        Form4.Show()
    End Sub

    Private Sub ogrenciListesiMenuItem_Click(sender As Object, e As EventArgs) Handles ogrenciListesiMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub devamsizlikDurumuMenuItem_Click(sender As Object, e As EventArgs) Handles devamsizlikDurumuMenuItem.Click
        Form10.Show()
    End Sub

    Private Sub btnNotListesi_Click(sender As Object, e As EventArgs) Handles btnNotListesi.Click
        Form12.Show()
    End Sub
End Class
