<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConnectionDesign
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
        Me.TLPButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.TLPMain = New System.Windows.Forms.TableLayoutPanel()
        Me.lblDatabaseType = New System.Windows.Forms.Label()
        Me.lblServerName = New System.Windows.Forms.Label()
        Me.lblDatabaseName = New System.Windows.Forms.Label()
        Me.optDatabaseTypeMSSQL = New System.Windows.Forms.RadioButton()
        Me.optDatabaseTypeOracle = New System.Windows.Forms.RadioButton()
        Me.txtServerName = New System.Windows.Forms.TextBox()
        Me.txtDatabaseName = New System.Windows.Forms.TextBox()
        Me.lblSecurity = New System.Windows.Forms.Label()
        Me.chkSecurity = New System.Windows.Forms.CheckBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.TLPButtons.SuspendLayout()
        Me.TLPMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'TLPButtons
        '
        Me.TLPButtons.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TLPButtons.ColumnCount = 2
        Me.TLPButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPButtons.Controls.Add(Me.OK_Button, 0, 0)
        Me.TLPButtons.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TLPButtons.Location = New System.Drawing.Point(266, 198)
        Me.TLPButtons.Margin = New System.Windows.Forms.Padding(4)
        Me.TLPButtons.Name = "TLPButtons"
        Me.TLPButtons.RowCount = 1
        Me.TLPButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPButtons.Size = New System.Drawing.Size(195, 40)
        Me.TLPButtons.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(4, 4)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(89, 32)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(101, 4)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(89, 32)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'TLPMain
        '
        Me.TLPMain.ColumnCount = 3
        Me.TLPMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TLPMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPMain.Controls.Add(Me.lblDatabaseType, 0, 0)
        Me.TLPMain.Controls.Add(Me.lblServerName, 0, 1)
        Me.TLPMain.Controls.Add(Me.lblDatabaseName, 0, 2)
        Me.TLPMain.Controls.Add(Me.optDatabaseTypeMSSQL, 1, 0)
        Me.TLPMain.Controls.Add(Me.optDatabaseTypeOracle, 2, 0)
        Me.TLPMain.Controls.Add(Me.txtServerName, 1, 1)
        Me.TLPMain.Controls.Add(Me.txtDatabaseName, 1, 2)
        Me.TLPMain.Controls.Add(Me.lblSecurity, 0, 3)
        Me.TLPMain.Controls.Add(Me.chkSecurity, 1, 3)
        Me.TLPMain.Controls.Add(Me.txtUsername, 1, 4)
        Me.TLPMain.Controls.Add(Me.txtPassword, 1, 5)
        Me.TLPMain.Controls.Add(Me.lblUsername, 0, 4)
        Me.TLPMain.Controls.Add(Me.lblPassword, 0, 5)
        Me.TLPMain.Location = New System.Drawing.Point(13, 13)
        Me.TLPMain.Margin = New System.Windows.Forms.Padding(4)
        Me.TLPMain.Name = "TLPMain"
        Me.TLPMain.RowCount = 7
        Me.TLPMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TLPMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TLPMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TLPMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TLPMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TLPMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TLPMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPMain.Size = New System.Drawing.Size(451, 185)
        Me.TLPMain.TabIndex = 0
        '
        'lblDatabaseType
        '
        Me.lblDatabaseType.AutoSize = True
        Me.lblDatabaseType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDatabaseType.Location = New System.Drawing.Point(4, 0)
        Me.lblDatabaseType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDatabaseType.Name = "lblDatabaseType"
        Me.lblDatabaseType.Size = New System.Drawing.Size(132, 30)
        Me.lblDatabaseType.TabIndex = 1
        Me.lblDatabaseType.Text = "Database Type"
        Me.lblDatabaseType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblServerName
        '
        Me.lblServerName.AutoSize = True
        Me.lblServerName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblServerName.Location = New System.Drawing.Point(4, 30)
        Me.lblServerName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblServerName.Name = "lblServerName"
        Me.lblServerName.Size = New System.Drawing.Size(132, 30)
        Me.lblServerName.TabIndex = 4
        Me.lblServerName.Text = "Server Name"
        Me.lblServerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDatabaseName
        '
        Me.lblDatabaseName.AutoSize = True
        Me.lblDatabaseName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDatabaseName.Location = New System.Drawing.Point(3, 60)
        Me.lblDatabaseName.Name = "lblDatabaseName"
        Me.lblDatabaseName.Size = New System.Drawing.Size(134, 30)
        Me.lblDatabaseName.TabIndex = 6
        Me.lblDatabaseName.Text = "Database Name"
        Me.lblDatabaseName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'optDatabaseTypeMSSQL
        '
        Me.optDatabaseTypeMSSQL.AutoSize = True
        Me.optDatabaseTypeMSSQL.Checked = True
        Me.optDatabaseTypeMSSQL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.optDatabaseTypeMSSQL.Location = New System.Drawing.Point(143, 3)
        Me.optDatabaseTypeMSSQL.Name = "optDatabaseTypeMSSQL"
        Me.optDatabaseTypeMSSQL.Size = New System.Drawing.Size(149, 24)
        Me.optDatabaseTypeMSSQL.TabIndex = 2
        Me.optDatabaseTypeMSSQL.TabStop = True
        Me.optDatabaseTypeMSSQL.Text = "MS SQL"
        Me.optDatabaseTypeMSSQL.UseVisualStyleBackColor = True
        '
        'optDatabaseTypeOracle
        '
        Me.optDatabaseTypeOracle.AutoSize = True
        Me.optDatabaseTypeOracle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.optDatabaseTypeOracle.Location = New System.Drawing.Point(298, 3)
        Me.optDatabaseTypeOracle.Name = "optDatabaseTypeOracle"
        Me.optDatabaseTypeOracle.Size = New System.Drawing.Size(150, 24)
        Me.optDatabaseTypeOracle.TabIndex = 3
        Me.optDatabaseTypeOracle.Text = "Oracle"
        Me.optDatabaseTypeOracle.UseVisualStyleBackColor = True
        '
        'txtServerName
        '
        Me.TLPMain.SetColumnSpan(Me.txtServerName, 2)
        Me.txtServerName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtServerName.Location = New System.Drawing.Point(143, 33)
        Me.txtServerName.Name = "txtServerName"
        Me.txtServerName.Size = New System.Drawing.Size(305, 26)
        Me.txtServerName.TabIndex = 5
        '
        'txtDatabaseName
        '
        Me.TLPMain.SetColumnSpan(Me.txtDatabaseName, 2)
        Me.txtDatabaseName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDatabaseName.Location = New System.Drawing.Point(143, 63)
        Me.txtDatabaseName.Name = "txtDatabaseName"
        Me.txtDatabaseName.Size = New System.Drawing.Size(305, 26)
        Me.txtDatabaseName.TabIndex = 7
        '
        'lblSecurity
        '
        Me.lblSecurity.AutoSize = True
        Me.lblSecurity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSecurity.Location = New System.Drawing.Point(3, 90)
        Me.lblSecurity.Name = "lblSecurity"
        Me.lblSecurity.Size = New System.Drawing.Size(134, 30)
        Me.lblSecurity.TabIndex = 8
        Me.lblSecurity.Text = "Integrated Security"
        Me.lblSecurity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkSecurity
        '
        Me.chkSecurity.AutoSize = True
        Me.chkSecurity.Checked = True
        Me.chkSecurity.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSecurity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkSecurity.Location = New System.Drawing.Point(143, 93)
        Me.chkSecurity.Name = "chkSecurity"
        Me.chkSecurity.Size = New System.Drawing.Size(149, 24)
        Me.chkSecurity.TabIndex = 9
        Me.chkSecurity.Text = "Use"
        Me.chkSecurity.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        Me.TLPMain.SetColumnSpan(Me.txtUsername, 2)
        Me.txtUsername.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtUsername.Location = New System.Drawing.Point(143, 123)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(305, 26)
        Me.txtUsername.TabIndex = 11
        '
        'txtPassword
        '
        Me.TLPMain.SetColumnSpan(Me.txtPassword, 2)
        Me.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPassword.Location = New System.Drawing.Point(143, 153)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(305, 26)
        Me.txtPassword.TabIndex = 13
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblUsername.Location = New System.Drawing.Point(3, 120)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(134, 30)
        Me.lblUsername.TabIndex = 10
        Me.lblUsername.Text = "Username"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPassword.Location = New System.Drawing.Point(3, 150)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(134, 30)
        Me.lblPassword.TabIndex = 12
        Me.lblPassword.Text = "Password"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormConnectionDesign
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(477, 254)
        Me.Controls.Add(Me.TLPMain)
        Me.Controls.Add(Me.TLPButtons)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormConnectionDesign"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Connection String Designer"
        Me.TLPButtons.ResumeLayout(False)
        Me.TLPMain.ResumeLayout(False)
        Me.TLPMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TLPButtons As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents TLPMain As TableLayoutPanel
    Friend WithEvents lblDatabaseType As Label
    Friend WithEvents lblServerName As Label
    Friend WithEvents lblDatabaseName As Label
    Friend WithEvents optDatabaseTypeMSSQL As RadioButton
    Friend WithEvents optDatabaseTypeOracle As RadioButton
    Friend WithEvents txtServerName As TextBox
    Friend WithEvents txtDatabaseName As TextBox
    Friend WithEvents lblSecurity As Label
    Friend WithEvents chkSecurity As CheckBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
End Class
