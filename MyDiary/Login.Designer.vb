<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits Telerik.WinControls.UI.RadForm

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
        Me.VisualStudio2012DarkTheme1 = New Telerik.WinControls.Themes.VisualStudio2012DarkTheme()
        Me.lbl_status = New Telerik.WinControls.UI.RadLabel()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.tb_username = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel11 = New Telerik.WinControls.UI.RadLabel()
        Me.btn_login = New Telerik.WinControls.UI.RadButton()
        Me.tb_password = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel12 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.lbl_status, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.tb_username, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_login, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_password, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_status
        '
        Me.lbl_status.Location = New System.Drawing.Point(5, 162)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(37, 18)
        Me.lbl_status.TabIndex = 2
        Me.lbl_status.Text = "Status"
        Me.lbl_status.ThemeName = "VisualStudio2012Dark"
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.tb_username)
        Me.RadGroupBox1.Controls.Add(Me.lbl_status)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel11)
        Me.RadGroupBox1.Controls.Add(Me.btn_login)
        Me.RadGroupBox1.Controls.Add(Me.tb_password)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel12)
        Me.RadGroupBox1.HeaderText = "RadGroupBox1"
        Me.RadGroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(354, 185)
        Me.RadGroupBox1.TabIndex = 25
        Me.RadGroupBox1.Text = "RadGroupBox1"
        Me.RadGroupBox1.ThemeName = "VisualStudio2012Dark"
        '
        'tb_username
        '
        Me.tb_username.Location = New System.Drawing.Point(144, 50)
        Me.tb_username.MinimumSize = New System.Drawing.Size(0, 24)
        Me.tb_username.Name = "tb_username"
        '
        '
        '
        Me.tb_username.RootElement.MinSize = New System.Drawing.Size(0, 24)
        Me.tb_username.Size = New System.Drawing.Size(164, 24)
        Me.tb_username.TabIndex = 26
        Me.tb_username.ThemeName = "VisualStudio2012Dark"
        '
        'RadLabel11
        '
        Me.RadLabel11.Location = New System.Drawing.Point(46, 54)
        Me.RadLabel11.Name = "RadLabel11"
        Me.RadLabel11.Size = New System.Drawing.Size(92, 18)
        Me.RadLabel11.TabIndex = 25
        Me.RadLabel11.Text = "Student Number:"
        Me.RadLabel11.ThemeName = "VisualStudio2012Dark"
        '
        'btn_login
        '
        Me.btn_login.Location = New System.Drawing.Point(198, 110)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(110, 24)
        Me.btn_login.TabIndex = 29
        Me.btn_login.Text = "Login"
        Me.btn_login.ThemeName = "VisualStudio2012Dark"
        '
        'tb_password
        '
        Me.tb_password.Location = New System.Drawing.Point(144, 80)
        Me.tb_password.MinimumSize = New System.Drawing.Size(0, 24)
        Me.tb_password.Name = "tb_password"
        '
        '
        '
        Me.tb_password.RootElement.MinSize = New System.Drawing.Size(0, 24)
        Me.tb_password.Size = New System.Drawing.Size(164, 24)
        Me.tb_password.TabIndex = 28
        Me.tb_password.ThemeName = "VisualStudio2012Dark"
        '
        'RadLabel12
        '
        Me.RadLabel12.Location = New System.Drawing.Point(82, 84)
        Me.RadLabel12.Name = "RadLabel12"
        Me.RadLabel12.Size = New System.Drawing.Size(56, 18)
        Me.RadLabel12.TabIndex = 27
        Me.RadLabel12.Text = "Password:"
        Me.RadLabel12.ThemeName = "VisualStudio2012Dark"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 209)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.MaximizeBox = False
        Me.Name = "Login"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ThemeName = "VisualStudio2012Dark"
        CType(Me.lbl_status, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.tb_username, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_login, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_password, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VisualStudio2012DarkTheme1 As Telerik.WinControls.Themes.VisualStudio2012DarkTheme
    Friend WithEvents lbl_status As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents tb_username As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel11 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btn_login As Telerik.WinControls.UI.RadButton
    Friend WithEvents tb_password As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel12 As Telerik.WinControls.UI.RadLabel
End Class

