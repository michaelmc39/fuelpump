Public Class frmFinishTransaction
    Private txtFuelType As Object
    Public Property FuelType As String
    Public Property lblFuelAmount As Object


    Private Sub lblCheckout_Click(sender As Object, e As EventArgs) Handles lblCheckout.Click

    End Sub

    ' In CheckoutForm.vb

    Public Sub SetLabelValue(ByVal value As String)

        lblCheckout.Text = CostValue
    End Sub


    Private Sub frmFinishTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCheckout.Text = CostValue
        Label3.Text = FuelAmount
    End Sub

    Private Sub btnCompleteTransaction_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        System.IO.File.WriteAllText("fuelPrice.txt", lblCheckout.Text)
        System.IO.File.WriteAllText("fuelAmount.txt", Label3.Text)
        MessageBox.Show("Payment Complete!")
        frmfPumpFuel.Show()
        Me.Close()
    End Sub
End Class