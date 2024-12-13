Imports System.Reflection.Emit
Imports Accessibility

Public Class frmfPumpFuel

    Private lblStatus As Object

    Private Sub btnCloseProgram_Click(sender As Object, e As EventArgs) Handles btnCloseProgram.Click
        End
    End Sub

    Private Sub frmfPumpFuel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Update every second
        AddHandler pumpTimer.Tick, AddressOf pumpTimer_Tick_1
        pumpTimer.Interval = PumpSpeed
    End Sub



    Private Sub btnPumpFuel_Click(sender As Object, e As EventArgs) Handles btnPumpFuel.Click
        If RbDiesel.Checked() Then
            pumpTimer.Enabled = True
        ElseIf RbPetrol.Checked() Then
            pumpTimer.Enabled = True
        End If




    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        pumpTimer.Enabled = False
    End Sub

    Private Sub pumpTimer_Tick_1(sender As Object, e As EventArgs) Handles pumpTimer.Tick
        If RbDiesel.Checked Then
            Dim currentLitresDiesel As Double = Val(lblLitres.Text.Replace("L", ""))
            currentLitresDiesel += LitresDiesel
            lblLitres.Text = currentLitresDiesel.ToString("0.0") & "L"

            Dim currentPriceDiesel As Double = lblCost.Text = (Val(lblCost.Text) + 0.7).ToString("#0.#0")
            currentPriceDiesel += DieselPrice

            lblCost.Text = currentPriceDiesel.ToString("0.0")
        ElseIf RbPetrol.Checked Then
            Dim currentLitresPetrol As Double = Val(lblLitres.Text.Replace("L", ""))
            currentLitresPetrol += PetrolPrice

            lblLitres.Text = currentLitresPetrol.ToString("0.0") & "L"

            Dim currentPricePetrol As Double = Val(lblCost.Text.Replace("£", ""))
            currentPricePetrol += PetrolPrice

            lblCost.Text = currentPricePetrol.ToString("0.0")

        End If






    End Sub

    Private Sub lblLitres_Click(sender As Object, e As EventArgs) Handles lblLitres.Click

    End Sub

    Private Sub btnTransaction_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click
        CostValue = lblCost.Text
        Dim frmFinishTransaction As New frmFinishTransaction()
        Me.Hide()
        frmFinishTransaction.Show()
    End Sub
End Class