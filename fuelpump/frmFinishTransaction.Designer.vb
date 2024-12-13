<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinishTransaction
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
        lblCheckout = New Label()
        Label1 = New Label()
        btnFinish = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' lblCheckout
        ' 
        lblCheckout.AutoSize = True
        lblCheckout.Location = New Point(176, 76)
        lblCheckout.Name = "lblCheckout"
        lblCheckout.Size = New Size(41, 15)
        lblCheckout.TabIndex = 0
        lblCheckout.Text = "Label1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(109, 76)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 15)
        Label1.TabIndex = 1
        Label1.Text = "Total Cost: £"
        ' 
        ' btnFinish
        ' 
        btnFinish.Location = New Point(126, 237)
        btnFinish.Name = "btnFinish"
        btnFinish.Size = New Size(142, 23)
        btnFinish.TabIndex = 2
        btnFinish.Text = "Complete Transaction"
        btnFinish.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(109, 124)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 15)
        Label2.TabIndex = 3
        Label2.Text = "Total Amount:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(201, 126)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 4
        Label3.Text = "Label3"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(239, 126)
        Label4.Name = "Label4"
        Label4.Size = New Size(13, 15)
        Label4.TabIndex = 5
        Label4.Text = "L"
        ' 
        ' frmFinishTransaction
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnFinish)
        Controls.Add(Label1)
        Controls.Add(lblCheckout)
        Name = "frmFinishTransaction"
        Text = "frmFinishTransaction"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCheckout As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnFinish As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
