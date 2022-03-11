Public Class Form14


    Private Sub btnUyeOl_Click(sender As Object, e As EventArgs) Handles btnUyeOl.Click
        If txtId.Text = "" Or txtParola.Text = "" Then
            MsgBox("Lütfen Tüm Alanları Doldurunuz",
           MsgBoxStyle.Critical, "Hata")
            Return
        End If
        sqlKod("insert into kullanici (kadi,parola) values ('" & txtId.Text & "','" & txtParola.Text & "')")
        If MsgBox("Kullanıcı Eklenecek.Onaylıyor Musunuz?", MsgBoxStyle.YesNo, "İşlem Onayı") = MsgBoxResult.No Then
            Return
        End If
        MsgBox("Personel Eklendi", MsgBoxStyle.Information, "İşlem Tamam")
        Form13.Show()
        Me.Close()

    End Sub

    Private Sub btnCik_Click(sender As Object, e As EventArgs) Handles btnCik.Click
        Form13.Show()
        Me.Close()
    End Sub
End Class
