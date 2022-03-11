Public Class Form12
    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = dtGetir("select * from ogrNot order by adsoyad")
        For i = 0 To dt.Rows.Count - 1
            dgKayitlar.Rows.Add(dt.Rows(i)("kayId").ToString(), dt.Rows(i)("ogrNo").ToString(), dt.Rows(i)("adsoyad").ToString(),
                                dt.Rows(i)("ders").ToString(),
                                dt.Rows(i)("vize").ToString(), dt.Rows(i)("final").ToString())
        Next
    End Sub
    Private Sub btnEkle_Click(sender As Object, e As EventArgs) Handles btnEkle.Click
        Dim kayId As Integer = Convert.ToInt32(txtId.Text)
        sqlCalistir("insert into ogrNot (ogrNo,adsoyad,ders,vize,final) values ('" & txtOgrNo.Text & "'
,'" & txtAdsoyad.Text & "'," & txtDers.Text & ",'" & txtVize.Text & "'," & txtFinal.Text & ")")
        If MsgBox("Personel Çıkış Bilgileri Kaydedilecek.Onaylıyor Musunuz?", MsgBoxStyle.YesNo, "İşlem Onayı") = MsgBoxResult.No Then
            Return
        End If
        MsgBox("Personel Çıkış Bilgileri Kaydedildi.", MsgBoxStyle.Information, "İşlem Tamam")
        btnTemizle.PerformClick()
    End Sub

    Private Sub dgKayitlar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgKayitlar.CellClick
        txtId.Text = dgKayitlar.CurrentRow.Cells(0).Value.ToString()
        txtOgrNo.Text = dgKayitlar.CurrentRow.Cells(1).Value.ToString()
        txtAdsoyad.Text = dgKayitlar.CurrentRow.Cells(2).Value.ToString()
        txtDers.Text = dgKayitlar.CurrentRow.Cells(2).Value.ToString()
        txtVize.Text = dgKayitlar.CurrentRow.Cells(3).Value.ToString()
        txtFinal.Text = dgKayitlar.CurrentRow.Cells(4).Value.ToString()
    End Sub

    Private Sub btnGuncelle_Click(sender As Object, e As EventArgs) Handles btnGuncelle.Click
        If txtId.Text = "" Then
            MsgBox("Bir Kayıt Seçiniz!", vbCritical, "Hata")
        End If
        Return
        Dim kayitId As Integer = Convert.ToInt32(txtId.Text)
        dgKayitlar.Rows(kayitId).Cells(0).Value = txtOgrNo.Text
        dgKayitlar.Rows(kayitId).Cells(1).Value = txtAdsoyad.Text
        dgKayitlar.Rows(kayitId).Cells(1).Value = txtDers.Text
        dgKayitlar.Rows(kayitId).Cells(2).Value = txtVize.Text
        dgKayitlar.Rows(kayitId).Cells(3).Value = txtFinal.Text

    End Sub

    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        Dim kayId As Integer = Convert.ToInt32(txtId.Text)
        sqlCalistir("delete from ogrNot where kayId=" & kayId)
        If MsgBox("Öğrenci Bilgisi Silinecek.Onaylıyor Musunuz?", MsgBoxStyle.YesNo, "İşlem Onayı") = MsgBoxResult.No Then
            Return
        End If
        MsgBox("Öğrenci Bilgisi Silinmiştir", MsgBoxStyle.Information, "İşlem Tamam")
        btnTemizle.PerformClick()
    End Sub

    Private Sub btnTemizli_Click(sender As Object, e As EventArgs) Handles btnTemizle.Click
        For Each c In Me.Controls
            If TypeOf c Is TextBox Then
                c.text = ""
            End If
        Next
    End Sub

    Private Sub txtAra_TextChanged(sender As Object, e As EventArgs) Handles txtAra.TextChanged
        dgKayitlar.Rows.Clear()
        Dim dt As DataTable = dtGetir("select * from ogrNot where adsoyad like '%" & txtAra.Text & "%' order by adsoyad")
        For i = 0 To dt.Rows.Count - 1
            dgKayitlar.Rows.Add(dt.Rows(i)("kayId").ToString(), dt.Rows(i)("ogrNo").ToString(),
                                dt.Rows(i)("adsoyad").ToString(), dt.Rows(i)("ders").ToString(), dt.Rows(i)("vize").ToString(), dt.Rows(i)("final").ToString())
        Next
    End Sub

    Private Sub btnKapat_Click(sender As Object, e As EventArgs) Handles btnKapat.Click
        Me.Close()
    End Sub
End Class