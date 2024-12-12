Public Class frmSplash


    Private Sub frmPumpFuel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timSplash.Start()
    End Sub

    Private Sub timSplash_Tick(sender As Object, e As EventArgs) Handles timSplash.Tick
        timSplash.Stop()
        timSplash.Dispose()
        frmfPumpFuel.Show()
        Me.Visible = False
    End Sub
End Class
