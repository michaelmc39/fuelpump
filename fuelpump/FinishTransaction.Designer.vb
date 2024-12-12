<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinishTransaction
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
        tbUsername = New TextBox()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        tbPassword = New TextBox()
        btnLogin = New Button()
        SuspendLayout()
        ' 
        ' tbUsername
        ' 
        tbUsername.Location = New Point(327, 124)
        tbUsername.Name = "tbUsername"
        tbUsername.Size = New Size(129, 23)
        tbUsername.TabIndex = 0
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' tbPassword
        ' 
        tbPassword.Location = New Point(327, 211)
        tbPassword.Name = "tbPassword"
        tbPassword.Size = New Size(129, 23)
        tbPassword.TabIndex = 2
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(355, 309)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(75, 23)
        btnLogin.TabIndex = 3
        btnLogin.Text = "Button1"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' FinishTransaction
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnLogin)
        Controls.Add(tbPassword)
        Controls.Add(tbUsername)
        Name = "FinishTransaction"
        Text = "FinishTransaction"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tbUsername As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents btnLogin As Button
End Class
