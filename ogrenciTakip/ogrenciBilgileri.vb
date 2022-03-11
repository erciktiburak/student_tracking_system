Public Class Form11
    Private Sub btnSec_Click(sender As Object, e As EventArgs) Handles btnSec.Click
        ofdFto.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*"
        If ofdFto.ShowDialog() = DialogResult.Cancel Then
            Return
        End If
        txtResim.Text = ofdFto.FileName
        pbFoto.ImageLocation = txtResim.Text
    End Sub

    Private Sub btnTemizle_Click(sender As Object, e As EventArgs) Handles btnTemizle.Click
        For Each c In Me.Controls
            If TypeOf c Is TextBox Then
                c.text = ""
            End If
        Next
    End Sub

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        If txtAdsoyad.Text = "" Or txtKimlik.Text = "" Or txtNo.Text = "" Or txtResim.Text = "" Or txtTarih.Text = "" Then
            MsgBox("Lütfen Tüm Alanları Doldurunuz",
           MsgBoxStyle.Critical, "Hata")
            Return
        End If
        sqlKod("insert into ogrenci (tc,adsoyad,okulno,tarih,resim) values ('" & txtKimlik.Text & "','" & txtAdsoyad.Text & "',
                                                        '" & txtNo.Text & "','" & txtTarih.Text & "','" & txtResim.Text & "')")
        If MsgBox("Öğrenci Eklenecek.Onaylıyor Musunuz?", MsgBoxStyle.YesNo, "İşlem Onayı") = MsgBoxResult.No Then
            Return
        End If
        MsgBox("Öğrenci Eklendi", MsgBoxStyle.Information, "İşlem Tamam")
        btnTemizle.PerformClick()
    End Sub

    Private Sub btnKapat_Click(sender As Object, e As EventArgs) Handles btnKapat.Click
        Me.Close()

    End Sub

    Private Sub txtKimlik_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKimlik.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAdsoyad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAdsoyad.KeyPress
        If Not (Char.IsLetter(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Space) Then
            e.Handled = True
        End If
    End Sub
End Class