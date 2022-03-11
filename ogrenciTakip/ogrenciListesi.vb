Public Class Form3
    Private Sub btnTemizle_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnKapat_Click(sender As Object, e As EventArgs) Handles btnKapat.Click
        Me.Close()
    End Sub

    Private Sub txtAra_TextChanged(sender As Object, e As EventArgs) Handles txtAra.TextChanged
        dgKayitlar.Rows.Clear()
        Dim dt As DataTable = dtGetir("select * from ogrenci where adsoyad like '%" & txtAra.Text & "%' order by adsoyad")
        For i = 0 To dt.Rows.Count - 1
            dgKayitlar.Rows.Add(dt.Rows(i)("ogrId").ToString(), dt.Rows(i)("tc").ToString(), dt.Rows(i)("adsoyad").ToString(),
                                dt.Rows(i)("okulNo").ToString(), dt.Rows(i)("tarih").ToString(), dt.Rows(i)("resim").ToString())
        Next
    End Sub

    Private Sub btnDuzenle_Click(sender As Object, e As EventArgs) Handles btnDuzenle.Click
        Dim id As Integer = Convert.ToInt32(txtId.Text)

        sqlCalis("update ogrenci set tc=@tc,adsoyad=@adsoyad,okulNo=@okulNo,tarih=@tarih,resim=@resim where ogrId=" & id)
        If MsgBox("Öğrenci Düzenlenecek.Onaylıyor Musunuz?", MsgBoxStyle.YesNo, "İşlem Onayı") = MsgBoxResult.No Then
            Return
        End If
        MsgBox("Öğrenci Düzenlendi", MsgBoxStyle.Information, "İşlem Tamam")
    End Sub

    Private Sub btnSec_Click(sender As Object, e As EventArgs) Handles btnSec.Click
        ofdResim.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*"
        ofdResim.ShowDialog()
        txtFoto.Text = ofdResim.FileName
        pbFoto.ImageLocation = txtFoto.Text
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = dtGetir("select * from ogrenci order by adsoyad")
        For i = 0 To dt.Rows.Count - 1
            dgKayitlar.Rows.Add(dt.Rows(i)("ogrId").ToString(),
                                dt.Rows(i)("tc").ToString(), dt.Rows(i)("adsoyad").ToString(),
                                dt.Rows(i)("okulNo").ToString(), dt.Rows(i)("tarih").ToString(),
                                dt.Rows(i)("resim").ToString())
        Next
    End Sub

    Private Sub dgKayitlar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgKayitlar.CellClick
        txtId.Text = dgKayitlar.CurrentRow.Cells(0).Value.ToString()
        txtTc.Text = dgKayitlar.CurrentRow.Cells(1).Value.ToString()
        txtAdSoyad.Text = dgKayitlar.CurrentRow.Cells(2).Value.ToString()
        txtNo.Text = dgKayitlar.CurrentRow.Cells(3).Value.ToString()
        txtTarih.Text = dgKayitlar.CurrentRow.Cells(4).Value.ToString()
        pbFoto.ImageLocation = dgKayitlar.CurrentRow.Cells(5).Value.ToString()
    End Sub

End Class