Public Class Form6
    Private Sub btnKapat_Click(sender As Object, e As EventArgs) Handles btnKapat.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbDers.DisplayMember = "dersadi"
        cbDers.ValueMember = "dersId"
        cbDers.DataSource = dtGetir("select * from ders")

        cbOgr.DisplayMember = "adsoyad"
        cbOgr.ValueMember = "ogrId"
        cbOgr.DataSource = dtGetir("select * from ogrenci")
    End Sub

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        Dim ogrId = cbOgr.SelectedValue
        Dim dersId As Integer = Convert.ToInt32(cbDers.SelectedValue())

        Dim adsoyad As String = cbOgr.Text
        Dim ders As String = cbDers.Text


        If kayitSayisi("select * from kayit where ogrId=" & ogrId & " and dersId=" & dersId) > 0 Then
            MsgBox(cbDers.Text & " dersine zaten kayıtlıdır!", MsgBoxStyle.Critical, "Hata")

            Return
        End If
        sqlCalistir("insert into kayit (ogrId,dersId) values (" & ogrId & "," & dersId & ")")
        MsgBox("Ders Kaydı Eklendi", MsgBoxStyle.Information, "İşlem Tamam")

    End Sub

End Class