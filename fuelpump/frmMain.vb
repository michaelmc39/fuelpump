Public Class frmMain
    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        frmAdminLogin.Show()
        Me.Hide()
        Me.Dispose()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        frmfPumpFuel.Show()
        Me.Hide()
        Me.Dispose()
    End Sub
End Class