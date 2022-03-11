Imports System.Data.OleDb
Module vt
    Function Baglan()
        Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & Application.StartupPath & "/ogrdata.mdb")
        baglanti.Open()
        Return baglanti
    End Function
    Function dtGetir(sql) As DataTable
        Dim baglanti As OleDbConnection = Baglan()
        Dim cmd As New OleDbCommand
        cmd.Connection = baglanti
        cmd.CommandText = sql
        Dim adp As New OleDbDataAdapter
        adp.SelectCommand = cmd
        Dim dt As New DataTable
        adp.Fill(dt)
        cmd.Connection.Close()
        baglanti.Close()
        adp.Dispose()
        cmd.Dispose()
        Return dt
    End Function
    Function dsGetir(sql) As DataSet
        Dim baglanti As OleDbConnection = Baglan()
        Dim cmd As New OleDbCommand
        cmd.Connection = baglanti
        cmd.CommandText = sql
        Dim ds As New DataSet
        Dim adp As New OleDbDataAdapter
        adp.SelectCommand = cmd
        adp.Fill(ds, "tb")
        cmd.Connection.Close()
        baglanti.Close()
        adp.Dispose()
        cmd.Dispose()
        Return ds
    End Function
    Function sqlCalistir(sql As String) As Boolean
        Dim baglanti As OleDbConnection = Baglan()
        Dim cmd As New OleDbCommand
        cmd.Connection = baglanti
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()
        baglanti.Close()
        cmd.Dispose()
        Return True
    End Function
    Function sqlKod(sql As String) As Boolean
        Dim baglanti As OleDbConnection = Baglan()
        Dim cmd As New OleDbCommand
        cmd.Connection = baglanti
        cmd.CommandText = sql
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@tc", Form11.txtKimlik.Text)
        cmd.Parameters.AddWithValue("@adsoyad", Form11.txtAdsoyad.Text)
        cmd.Parameters.AddWithValue("@okulno", Form11.txtNo.Text)
        cmd.Parameters.AddWithValue("@tarih", Form11.txtTarih.Text)
        cmd.Parameters.AddWithValue("@resim", Form11.txtResim.Text)
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()
        baglanti.Close()
        cmd.Dispose()
        Return True
    End Function

    Function sorgu(sql As String) As Integer
        Dim baglanti As OleDbConnection = Baglan()
        Dim cmd As New OleDbCommand
        Dim dr As OleDbDataReader
        cmd.Connection = baglanti
        cmd.CommandText = sql
        dr = cmd.ExecuteReader()
        If (dr.Read()) Then
            Form1.Show()
            Form13.Hide()
        Else
            MsgBox("Kullanıcı Adı ya da Şifre Yanlış", MsgBoxStyle.Critical, "HATA")
            Form13.txtId.Clear()
            Form13.txtParola.Clear()

        End If
        cmd.Connection.Close()
        baglanti.Close()
        cmd.Dispose()
        Return True
    End Function

    Function sqlCalis(sql As String) As Integer
        Dim baglanti As OleDbConnection = Baglan()
        Dim cmd As New OleDbCommand
        cmd.Connection = baglanti
        cmd.CommandText = sql
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@tc", Form3.txtTc.Text)
        cmd.Parameters.AddWithValue("@adsoyad", Form3.txtAdSoyad.Text)
        cmd.Parameters.AddWithValue("@okulno", Form3.txtNo.Text)
        cmd.Parameters.AddWithValue("@tarih", Form3.txtTarih.Text)
        cmd.Parameters.AddWithValue("@resim", Form3.pbFoto.Text)
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()
        baglanti.Close()
        cmd.Dispose()
        Return True
    End Function
    Function kayitSayisi(sql As String) As Integer
        Dim baglanti As OleDbConnection = Baglan()
        Dim cmd As New OleDbCommand
        cmd.Connection = baglanti
        cmd.CommandText = sql
        Dim dt As New DataTable
        Dim adp As New OleDbDataAdapter
        adp.SelectCommand = cmd
        adp.Fill(dt)
        Return dt.Rows.Count
        cmd.Connection.Close()
        baglanti.Close()
        adp.Dispose()
        cmd.Dispose()
    End Function
End Module

