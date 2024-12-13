<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        btnStart = New Button()
        btnAdmin = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnStart
        ' 
        btnStart.Location = New Point(348, 238)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(108, 45)
        btnStart.TabIndex = 0
        btnStart.Text = "Start Pumping Fuel"
        btnStart.UseVisualStyleBackColor = True
        ' 
        ' btnAdmin
        ' 
        btnAdmin.Location = New Point(640, 379)
        btnAdmin.Name = "btnAdmin"
        btnAdmin.Size = New Size(106, 23)
        btnAdmin.TabIndex = 1
        btnAdmin.Text = "Admin Page"
        btnAdmin.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(355, 76)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 30)
        Label1.TabIndex = 2
        Label1.Text = "MCFUELS"
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.BlueViolet
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(btnAdmin)
        Controls.Add(btnStart)
        Name = "frmMain"
        Text = "frmMain"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents btnAdmin As Button
    Friend WithEvents Label1 As Label
End Class
