Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtOgrenci = dtGetir("select * from ogrenci")
        For i = 0 To dtOgrenci.Rows.Count - 1
            dgOgrenci.Rows.Add(dtOgrenci.Rows(i)("ogrId").ToString(),
            dtOgrenci.Rows(i)("ogrno").ToString(), dtOgrenci.Rows(i)("adsoyad").ToString(),
            dtOgrenci.Rows(i)("bolum").ToString(), dtOgrenci.Rows(i)("yas").ToString(),
            dtOgrenci.Rows(i)("mail").ToString())
        Next
        Dim dtDers = dtGetir("select * from ders")
        For i = 0 To dtDers.Rows.Count - 1
            dgDers.Rows.Add(dtDers.Rows(i)("dersId").ToString,
            dtDers.Rows(i)("derskodu").ToString, dtDers.Rows(i)("dersadi").ToString,
            dtDers.Rows(i)("kredi").ToString)
        Next
    End Sub
    Private Sub dgOgrenci_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgOgrenci.CellClick
        Dim ogrId As Integer = Convert.ToInt32(dgOgrenci.CurrentRow.Cells(0).Value.ToString())
        Dim dtDers = dtGetir("select * from ders,kayit where
        ders.dersId=kayit.dersId and ogrId=" & ogrId)
        dgOgrDers.Rows.Clear()
        For i = 0 To dtDers.Rows.Count - 1
            dgOgrDers.Rows.Add(dtDers.Rows(i)("kayitId").ToString,
           dtDers.Rows(i)("derskodu").ToString, dtDers.Rows(i)("dersadi").ToString,
           dtDers.Rows(i)("kredi").ToString)
        Next
    End Sub

    Private Sub dgDers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDers.CellClick
        Dim dersId As Integer = Convert.ToUInt32(dgDers.CurrentRow.Cells(0).Value.ToString())
        Dim dtOgrenci = dtGetir("select * from ogrenci,kayit where ogrenci.ogrId=kayit.ogrId and dersId=" & dersId)
        dgDersOgrenci.Rows.Clear()

        For i = 0 To dtOgrenci.Rows.Count - 1
            dgDersOgrenci.Rows.Add(dtOgrenci.Rows(i)("kayitId").ToString(),
            dtOgrenci.Rows(i)("ogrno").ToString(), dtOgrenci.Rows(i)("adsoyad").ToString(),
            dtOgrenci.Rows(i)("bolum").ToString(), dtOgrenci.Rows(i)("yas").ToString(),
            dtOgrenci.Rows(i)("mail").ToString())
        Next
    End Sub

    Private Sub DersKaydınıSilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DersKaydınıSilToolStripMenuItem.Click
        Dim kayId = Convert.ToInt32(dgOgrDers.CurrentRow.Cells(0).Value.ToString())
        Dim ders As String = dgOgrDers.CurrentRow.Cells(2).Value.ToString()

        Dim ogrno As String = dgOgrenci.CurrentRow.Cells(1).Value.ToString()
        Dim adsoyad As String = dgOgrenci.CurrentRow.Cells(2).Value.ToString()

        If MsgBox(ogrno & " nolu " & adsoyad & " isimli öğrencinin " & ders & " dersi silinecektir!
Onaylıyor musunuz?", vbYesNo, "Ders Kayıt Silme Onayı") = MsgBoxResult.No Then
            Return

        End If

        sqlCalistir("delete from kayit where kayitId=" & kayId)
        MsgBox("Ders Kaydı Silindi", MsgBoxStyle.Information, "İşlem Tamam")

        Dim ogrId As Integer = dgOgrenci.CurrentRow.Cells(0).Value
        Dim dtDers As DataTable = dtGetir("select * from kayit,ders where ders.dersId=kayit.dersId and ogrId=" & ogrId)
        dgOgrDers.Rows.Clear()
        For i = 0 To dtDers.Rows.Count - 1
            dgOgrDers.Rows.Add(dtDers.Rows(i)("kayitId").ToString, dtDers.Rows(i)("derskodu").ToString,
                               dtDers.Rows(i)("dersadi").ToString, dtDers.Rows(i)("kredi").ToString)
        Next

    End Sub

    Private Sub btnDersKayit_Click(sender As Object, e As EventArgs) Handles btnDersKayit.Click
        Dim ogrId As Integer = Convert.ToInt32(dgOgrenci.CurrentRow.Cells(0).Value.ToString())
        Dim dersId As Integer = Convert.ToInt32(dgDers.CurrentRow.Cells(0).Value.ToString())

        Dim ogrno As String = dgOgrenci.CurrentRow.Cells(1).Value.ToString()
        Dim adsoyad As String = dgOgrenci.CurrentRow.Cells(2).Value.ToString()
        Dim ders As String = dgDers.CurrentRow.Cells(2).Value.ToString()

        If MsgBox(ogrno & " nolu " & adsoyad & " isimli öğrenciye " & ders & " dersi Eklenecektir! Onaylıyor musunuz?",
                  vbYesNo, "Ders Kayıt Silme Onayı") = MsgBoxResult.No Then
            Return
        End If

        If kayitSayisi("select * from kayit where ogrId=" & ogrId & " and dersId=" & dersId) > 0 Then
            MsgBox(ders & " dersine zaten kayıtlıdır!", MsgBoxStyle.Critical, "Hata")
            Return
        End If
        sqlCalistir("insert into kayit (ogrId,dersId) values (" & ogrId & "," & dersId & ")")
        MsgBox("Ders Kaydı Eklendi", MsgBoxStyle.Information, "İşlem Tamam")

        Dim dtDers As DataTable = dtGetir("select * from kayit,ders where ders.dersId=kayit.dersId and ogrId=" & ogrId)
        dgOgrDers.Rows.Clear()
        For i = 0 To dtDers.Rows.Count - 1
            dgOgrDers.Rows.Add(dtDers.Rows(i)("kayitId").ToString, dtDers.Rows(i)("derskodu").ToString,
                               dtDers.Rows(i)("dersadi").ToString, dtDers.Rows(i)("kredi").ToString)
        Next
    End Sub

    Private Sub btnYeni_Click(sender As Object, e As EventArgs) Handles btnYeni.Click
        Form6.Show()
    End Sub
End Class