﻿Public Class FinishTransaction
    Private Sub tbUsername_TextChanged(sender As Object, e As EventArgs) Handles tbUsername.TextChanged

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If tbUsername.Text = "Admin1" And tbPassword.Text = "Pass22" Then
            Adminfrm.Show()
            Me.Hide()
            Me.Dispose()
        Else
            MessageBox.Show("Password Is Incorrect")
        End If
    End Sub
End Class