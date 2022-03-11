Public Class Form13
    Private Sub lbUyeOl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbUyeOl.LinkClicked
        Form14.Show()
        Me.Close()
    End Sub

    Private Sub btnGiris_Click(sender As Object, e As EventArgs) Handles btnGiris.Click
        If txtId.Text = "" Or txtParola.Text = "" Then
            MsgBox("You did not enter a username or password!", MsgBoxStyle.Critical, "Error!")
            Return
        End If
        sorgu("select * from kullanici where kadi='" & txtId.Text & "' and password='" & txtParola.Text & "'")
        Close()
    End Sub

    Private Sub btnCikis_Click(sender As Object, e As EventArgs) Handles btnCikis.Click
        If MsgBox("Entry Will Be Canceled! Do you confirm?", vbYesNo, "Cancel") = MsgBoxResult.No Then
            Return
        End If
        Me.Close()

    End Sub

    Private Sub lbYazi_Click(sender As Object, e As EventArgs) Handles lbYazi.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class