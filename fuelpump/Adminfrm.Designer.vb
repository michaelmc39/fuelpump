<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Adminfrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblFuelAmount = New Label()
        lblTotalCost = New Label()
        SuspendLayout()
        ' 
        ' lblFuelAmount
        ' 
        lblFuelAmount.AutoSize = True
        lblFuelAmount.Location = New Point(294, 61)
        lblFuelAmount.Name = "lblFuelAmount"
        lblFuelAmount.Size = New Size(41, 15)
        lblFuelAmount.TabIndex = 1
        lblFuelAmount.Text = "Label2"
        ' 
        ' lblTotalCost
        ' 
        lblTotalCost.AutoSize = True
        lblTotalCost.Location = New Point(294, 158)
        lblTotalCost.Name = "lblTotalCost"
        lblTotalCost.Size = New Size(41, 15)
        lblTotalCost.TabIndex = 2
        lblTotalCost.Text = "Label3"
        ' 
        ' Adminfrm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblTotalCost)
        Controls.Add(lblFuelAmount)
        Name = "Adminfrm"
        Text = "Adminfrm"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblFuelAmount As Label
    Friend WithEvents lblTotalCost As Label
End Class
