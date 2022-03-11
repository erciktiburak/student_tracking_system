Public Class Form5
    Private Sub txtAra_TextChanged(sender As Object, e As EventArgs) Handles txtAra.TextChanged
        Dim dt As DataTable = dtGetir("select * from ogrenciler where adsoyad like '" & txtAra.Text & "%' or tel like '" & txtAra.Text & "%' or adres like '" & txtAra.Text & "%' order by adsoyad")
        dgOgrenci.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            dgOgrenci.Rows.Add(dt.Rows(i)("ogrNo").ToString(), dt.Rows(i)("adsoyad").ToString(),                               dt.Rows(i)("tel").ToString(),                               dt.Rows(i)("adres").ToString())        Next
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = dtGetir("select * from ogrenciler order by adsoyad")
        For i = 0 To dt.Rows.Count - 1
            dgOgrenci.Rows.Add(dt.Rows(i)("ogrNo").ToString(), dt.Rows(i)("adsoyad").ToString(),                               dt.Rows(i)("tel").ToString(),                               dt.Rows(i)("adres").ToString())        Next
    End Sub

    Private Sub dgMusteri_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dgOgrenci.KeyPress
        Form10.txtOgrNo.Text = dgOgrenci.CurrentRow.Cells(0).Value.ToString()
        Form10.txtAdSoyad.Text = dgOgrenci.CurrentRow.Cells(1).Value.ToString()
        Form10.txtTel.Text = dgOgrenci.CurrentRow.Cells(2).Value.ToString()
        Form10.txtAdres.Text = dgOgrenci.CurrentRow.Cells(3).Value.ToString()
        Me.Close()
    End Sub

    Private Sub btnYeni_Click(sender As Object, e As EventArgs) Handles btnYeni.Click
        Form11.Show()
    End Sub
End Class