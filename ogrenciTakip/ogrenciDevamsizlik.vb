Public Class Form10
    Private Sub btnGozat_Click(sender As Object, e As EventArgs) Handles btnGozat.Click
        Form5.Show()
    End Sub

    Private Sub btnTemizle_Click(sender As Object, e As EventArgs) Handles btnTemizle.Click
        For Each c In Me.Controls
            If TypeOf c Is TextBox Then
                c.text = ""
            End If
        Next
    End Sub

    Private Sub btnKayitGetir_Click(sender As Object, e As EventArgs) Handles btnKayitGetir.Click
        If txtOgrNo.Text = "" Then
            MsgBox("Lütfen Bir Müşteri Seçiniz", MsgBoxStyle.Critical, "Hata")
            Return
        End If


        Dim ogrNo As Integer = Convert.ToInt32(txtOgrNo.Text)

        Dim dtKay As DataTable = dtGetir("select * from kayitlar where ogrNo=" & ogrNo)

        dgKayitlar.Rows.Clear()
        For i = 0 To dtKay.Rows.Count - 1
            dgKayitlar.Rows.Add(dtKay.Rows(i)("kayitNo").ToString(),
                                dtKay.Rows(i)("kayGun").ToString() & "." &
                                dtKay.Rows(i)("kayAy").ToString() & "." &
                                dtKay.Rows(i)("kayYil").ToString(),
                                dtKay.Rows(i)("baslik").ToString(),
                                dtKay.Rows(i)("tdevamsizlik").ToString())
        Next

        Dim dtode As DataTable = dtGetir("select * from devamsizliklar where ogrNo=" & ogrNo)

        dgGirilenler.Rows.Clear()
        For i = 0 To dtode.Rows.Count - 1

            dgGirilenler.Rows.Add(dtode.Rows(i)("dNo").ToString(),
                            dtode.Rows(i)("dGun").ToString() & "." &
                            dtode.Rows(i)("dAy").ToString() & "." &
                            dtode.Rows(i)("dYil").ToString(),
                            dtode.Rows(i)("devamsizlik").ToString())
        Next

        Dim devamsizlik As Double = 0
        For i = 0 To dgKayitlar.RowCount - 1
            devamsizlik += Convert.ToDouble(dgKayitlar.Rows(i).Cells(3).Value.ToString())
        Next
        lbToplam.Text = devamsizlik.ToString("0")
        Dim girilmeyen As Double = 0
        For i = 0 To dgGirilenler.RowCount - 1
            girilmeyen += Convert.ToDouble(dgGirilenler.Rows(i).Cells(2).Value.ToString())
        Next
        lbGelinmeyen.Text = girilmeyen.ToString("0")

        Dim kalan As Double = girilmeyen - devamsizlik
        lbKalan.Text = kalan.ToString("0")

        If kalan < 0 Then
            lbKalan.ForeColor = Color.Red
        Else
            lbKalan.ForeColor = Color.Green
        End If
    End Sub

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        If txtDevamsizlik.Text = "" Then
            MsgBox("Devamsızlık giriniz", MsgBoxStyle.Critical, "Hata")
            Return
        End If
        Dim gun As Integer = dtTarih.Value.Day
        Dim ay As Integer = dtTarih.Value.Month
        Dim yil As Integer = dtTarih.Value.Year

        Dim ogrNo As Integer = Convert.ToInt32(txtOgrNo.Text)
        Dim devamsizlik As Double = Convert.ToDouble(txtDevamsizlik.Text)

        vt.sqlCalistir("insert into devamsizliklar (dGun,dAy,dYil,devamsizlik,ogrNo)
        values (" & gun & "," & ay & "," & yil & "," & devamsizlik & "," & ogrNo & ")")
        btnKayitGetir.PerformClick()
    End Sub
End Class