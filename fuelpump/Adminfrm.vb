Public Class Adminfrm
    Private Sub Adminfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.IO.File.Exists("fuelAmount.txt") Then
            lblFuelAmount.Text = System.IO.File.ReadAllText("fuelAmount.txt")
            lblTotalCost.Text = System.IO.File.ReadAllText("fuelPrice.txt")
        End If
    End Sub

End Class