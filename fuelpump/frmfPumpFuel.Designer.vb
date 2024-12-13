<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmfPumpFuel
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
        components = New ComponentModel.Container()
        btnCloseProgram = New Button()
        btnPumpFuel = New Button()
        btnStop = New Button()
        pumpTimer = New Timer(components)
        lblLitres = New Label()
        lblCost = New Label()
        lblLitres2 = New Label()
        Label4 = New Label()
        RbPetrol = New RadioButton()
        RbDiesel = New RadioButton()
        btnTransaction = New Button()
        Label1 = New Label()
        btnAdmin = New Button()
        SuspendLayout()
        ' 
        ' btnCloseProgram
        ' 
        btnCloseProgram.Location = New Point(684, 392)
        btnCloseProgram.Name = "btnCloseProgram"
        btnCloseProgram.Size = New Size(75, 23)
        btnCloseProgram.TabIndex = 0
        btnCloseProgram.Text = "Close Program"
        btnCloseProgram.UseVisualStyleBackColor = True
        ' 
        ' btnPumpFuel
        ' 
        btnPumpFuel.Location = New Point(376, 182)
        btnPumpFuel.Name = "btnPumpFuel"
        btnPumpFuel.Size = New Size(100, 100)
        btnPumpFuel.TabIndex = 1
        btnPumpFuel.Text = "Pump Fuel"
        btnPumpFuel.UseVisualStyleBackColor = True
        ' 
        ' btnStop
        ' 
        btnStop.Location = New Point(514, 182)
        btnStop.Name = "btnStop"
        btnStop.Size = New Size(100, 100)
        btnStop.TabIndex = 2
        btnStop.Text = "Stop"
        btnStop.UseVisualStyleBackColor = True
        ' 
        ' pumpTimer
        ' 
        pumpTimer.Interval = 200
        ' 
        ' lblLitres
        ' 
        lblLitres.AutoSize = True
        lblLitres.Location = New Point(514, 82)
        lblLitres.Name = "lblLitres"
        lblLitres.Size = New Size(34, 15)
        lblLitres.TabIndex = 6
        lblLitres.Text = "0.00L"
        ' 
        ' lblCost
        ' 
        lblCost.AutoSize = True
        lblCost.Location = New Point(514, 134)
        lblCost.Name = "lblCost"
        lblCost.Size = New Size(34, 15)
        lblCost.TabIndex = 7
        lblCost.Text = "£0.00"
        ' 
        ' lblLitres2
        ' 
        lblLitres2.AutoSize = True
        lblLitres2.Location = New Point(378, 82)
        lblLitres2.Name = "lblLitres2"
        lblLitres2.Size = New Size(35, 15)
        lblLitres2.TabIndex = 8
        lblLitres2.Text = "Litres"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(376, 134)
        Label4.Name = "Label4"
        Label4.Size = New Size(31, 15)
        Label4.TabIndex = 9
        Label4.Text = "Cost"
        ' 
        ' RbPetrol
        ' 
        RbPetrol.AutoSize = True
        RbPetrol.Location = New Point(251, 82)
        RbPetrol.Name = "RbPetrol"
        RbPetrol.Size = New Size(75, 19)
        RbPetrol.TabIndex = 10
        RbPetrol.TabStop = True
        RbPetrol.Text = "Unleaded"
        RbPetrol.UseVisualStyleBackColor = True
        ' 
        ' RbDiesel
        ' 
        RbDiesel.AutoSize = True
        RbDiesel.Location = New Point(251, 132)
        RbDiesel.Name = "RbDiesel"
        RbDiesel.Size = New Size(56, 19)
        RbDiesel.TabIndex = 11
        RbDiesel.TabStop = True
        RbDiesel.Text = "Diesel"
        RbDiesel.UseVisualStyleBackColor = True
        ' 
        ' btnTransaction
        ' 
        btnTransaction.Location = New Point(524, 392)
        btnTransaction.Name = "btnTransaction"
        btnTransaction.Size = New Size(140, 23)
        btnTransaction.TabIndex = 12
        btnTransaction.Text = "Finish Transaction"
        btnTransaction.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(570, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(208, 15)
        Label1.TabIndex = 13
        Label1.Text = "FUEL COST IS £3.25 PER LITRE OF FUEL"
        ' 
        ' btnAdmin
        ' 
        btnAdmin.Location = New Point(62, 396)
        btnAdmin.Name = "btnAdmin"
        btnAdmin.Size = New Size(75, 23)
        btnAdmin.TabIndex = 14
        btnAdmin.Text = "Admin"
        btnAdmin.UseVisualStyleBackColor = True
        ' 
        ' frmfPumpFuel
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.petrol_station_e1635517091232
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(btnAdmin)
        Controls.Add(Label1)
        Controls.Add(btnTransaction)
        Controls.Add(RbDiesel)
        Controls.Add(RbPetrol)
        Controls.Add(Label4)
        Controls.Add(lblLitres2)
        Controls.Add(lblCost)
        Controls.Add(lblLitres)
        Controls.Add(btnStop)
        Controls.Add(btnPumpFuel)
        Controls.Add(btnCloseProgram)
        Name = "frmfPumpFuel"
        Text = "frmfPumpFuel"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCloseProgram As Button
    Friend WithEvents btnPumpFuel As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents pumpTimer As Timer
    Friend WithEvents lblLitres As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents lblLitres2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RbPetrol As RadioButton
    Friend WithEvents RbDiesel As RadioButton
    Friend WithEvents btnTransaction As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdmin As Button

End Class
