<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminLogin
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(355, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 15)
        Label1.TabIndex = 4
        Label1.Text = "Admin Login"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(242, 127)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 15)
        Label2.TabIndex = 5
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(242, 214)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 15)
        Label3.TabIndex = 6
        Label3.Text = "Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(595, 88)
        Label4.Name = "Label4"
        Label4.Size = New Size(108, 15)
        Label4.TabIndex = 7
        Label4.Text = "Username: Admin1"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(595, 171)
        Label5.Name = "Label5"
        Label5.Size = New Size(98, 15)
        Label5.TabIndex = 8
        Label5.Text = "Password: Pass22"
        ' 
        ' frmAdminLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnLogin)
        Controls.Add(tbPassword)
        Controls.Add(tbUsername)
        Name = "frmAdminLogin"
        Text = "Admin Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tbUsername As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
