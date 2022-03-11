Public Class Form2
    Private Sub btnAra_Click(sender As Object, e As EventArgs) Handles btnAra.Click
        Form3.Show()
    End Sub

    Private Sub btnYeni_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub btnSec_Click(sender As Object, e As EventArgs) Handles btnSec.Click
        ofdResim.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*"
        If ofdResim.ShowDialog() = DialogResult.Cancel Then
            Return
        End If
        txtFoto.Text = ofdResim.FileName
        pbFoto.ImageLocation = txtFoto.Text
    End Sub

    Private Sub btnKapat_Click(sender As Object, e As EventArgs) Handles btnKapat.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = dtGetir("select * from ogrenciGirisi order by adsoyad")
        For i = 0 To dt.Rows.Count - 1
            dgKayitlar.Rows.Add(dt.Rows(i)("ogrId").ToString(), dt.Rows(i)("tc").ToString(),
                             dt.Rows(i)("adsoyad").ToString(), dt.Rows(i)("okulNo").ToString(), dt.Rows(i)("kayTarih").ToString(),
                             dt.Rows(i)("resim").ToString())
        Next
    End Sub

    Private Sub btnYeni_Click_1(sender As Object, e As EventArgs) Handles btnYeni.Click
        Form11.Show()
    End Sub

    Private Sub dgKayitlar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgKayitlar.CellClick
        txtId.Text = dgKayitlar.CurrentRow.Cells(0).Value.ToString()
        txtTc.Text = dgKayitlar.CurrentRow.Cells(1).Value.ToString()
        txtAdSoyad.Text = dgKayitlar.CurrentRow.Cells(2).Value.ToString()
        txtNo.Text = dgKayitlar.CurrentRow.Cells(3).Value.ToString()
        txtTarih.Text = dgKayitlar.CurrentRow.Cells(4).Value.ToString()
        pbFoto.ImageLocation = dgKayitlar.CurrentRow.Cells(5).Value.ToString()
    End Sub

    Private Sub btnTemizle_Click(sender As Object, e As EventArgs) Handles btnTemizle.Click
        For Each c In Me.Controls
            If TypeOf c Is TextBox Then
                c.text = ""
            End If
        Next
    End Sub

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        '        sqlCalistir("insert into kayitlar
        '(baslik,aciklama,kayGun,kayAy,kayYil,ucret,musteriNo) values ('" & txtBaslik.Text &
        '"','" & txtAciklama.Text & "'," & gun & "," & ay & "," & yil & "," & ucret & "," &
        'musteriNo & ")")
        '        If txtOdeme.Text <> "" Then
        '            Dim odenen As Double = Convert.ToDouble(txtOdeme.Text)
        '            vt.sqlCalistir("insert into odemeler (odemeGun,odemeAy,odemeYil,odenen,musteriNo)
        'values (" & gun & "," & ay & "," & yil & "," & odenen & "," & musteriNo & ")")
        '        End If

        '        MsgBox("İş Kaydı Yapılmıştır", MsgBoxStyle.Information, "İşlem Tamam")
        '        btnTemizle.PerformClick()
    End Sub
End Class