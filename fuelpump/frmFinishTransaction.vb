Public Class frmFinishTransaction

    Private Sub lblCheckout_Click(sender As Object, e As EventArgs) Handles lblCheckout.Click

    End Sub

    ' In CheckoutForm.vb

    Public Sub SetLabelValue(ByVal value As String)

        lblCheckout.Text = CostValue
    End Sub


    Private Sub frmFinishTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCheckout.Text = CostValue
    End Sub
End Class