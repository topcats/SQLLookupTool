<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.txtConnection = New System.Windows.Forms.TextBox()
        Me.lblConnection = New System.Windows.Forms.Label()
        Me.lblCommand = New System.Windows.Forms.Label()
        Me.txtCommand = New System.Windows.Forms.TextBox()
        Me.txtResults = New System.Windows.Forms.RichTextBox()
        Me.cmdConnectionLoad = New System.Windows.Forms.Button()
        Me.cmdExecute = New System.Windows.Forms.Button()
        Me.cmdClearResults = New System.Windows.Forms.Button()
        Me.tlpMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 2
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Controls.Add(Me.txtConnection, 1, 0)
        Me.tlpMain.Controls.Add(Me.lblConnection, 0, 0)
        Me.tlpMain.Controls.Add(Me.lblCommand, 0, 2)
        Me.tlpMain.Controls.Add(Me.txtCommand, 1, 2)
        Me.tlpMain.Controls.Add(Me.txtResults, 1, 4)
        Me.tlpMain.Controls.Add(Me.cmdConnectionLoad, 0, 1)
        Me.tlpMain.Controls.Add(Me.cmdExecute, 0, 3)
        Me.tlpMain.Controls.Add(Me.cmdClearResults, 0, 5)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 6
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpMain.Size = New System.Drawing.Size(862, 521)
        Me.tlpMain.TabIndex = 0
        '
        'txtConnection
        '
        Me.txtConnection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtConnection.Location = New System.Drawing.Point(123, 3)
        Me.txtConnection.Multiline = True
        Me.txtConnection.Name = "txtConnection"
        Me.tlpMain.SetRowSpan(Me.txtConnection, 2)
        Me.txtConnection.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtConnection.Size = New System.Drawing.Size(736, 44)
        Me.txtConnection.TabIndex = 2
        '
        'lblConnection
        '
        Me.lblConnection.AutoSize = True
        Me.lblConnection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblConnection.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConnection.Location = New System.Drawing.Point(3, 0)
        Me.lblConnection.Name = "lblConnection"
        Me.lblConnection.Size = New System.Drawing.Size(114, 20)
        Me.lblConnection.TabIndex = 0
        Me.lblConnection.Text = "Connection"
        '
        'lblCommand
        '
        Me.lblCommand.AutoSize = True
        Me.lblCommand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCommand.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommand.Location = New System.Drawing.Point(3, 50)
        Me.lblCommand.Name = "lblCommand"
        Me.lblCommand.Size = New System.Drawing.Size(114, 130)
        Me.lblCommand.TabIndex = 3
        Me.lblCommand.Text = "SQL Command"
        '
        'txtCommand
        '
        Me.txtCommand.AcceptsReturn = True
        Me.txtCommand.AcceptsTab = True
        Me.txtCommand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCommand.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCommand.Location = New System.Drawing.Point(123, 53)
        Me.txtCommand.Multiline = True
        Me.txtCommand.Name = "txtCommand"
        Me.tlpMain.SetRowSpan(Me.txtCommand, 2)
        Me.txtCommand.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtCommand.Size = New System.Drawing.Size(736, 160)
        Me.txtCommand.TabIndex = 4
        Me.txtCommand.WordWrap = False
        '
        'txtResults
        '
        Me.txtResults.AcceptsTab = True
        Me.txtResults.DetectUrls = False
        Me.txtResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtResults.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResults.HideSelection = False
        Me.txtResults.Location = New System.Drawing.Point(123, 219)
        Me.txtResults.Name = "txtResults"
        Me.tlpMain.SetRowSpan(Me.txtResults, 2)
        Me.txtResults.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.txtResults.ShowSelectionMargin = True
        Me.txtResults.Size = New System.Drawing.Size(736, 299)
        Me.txtResults.TabIndex = 6
        Me.txtResults.Text = ""
        Me.txtResults.WordWrap = False
        '
        'cmdConnectionLoad
        '
        Me.cmdConnectionLoad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdConnectionLoad.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConnectionLoad.Location = New System.Drawing.Point(42, 23)
        Me.cmdConnectionLoad.Name = "cmdConnectionLoad"
        Me.cmdConnectionLoad.Size = New System.Drawing.Size(75, 23)
        Me.cmdConnectionLoad.TabIndex = 1
        Me.cmdConnectionLoad.Text = "Build"
        Me.cmdConnectionLoad.UseVisualStyleBackColor = True
        '
        'cmdExecute
        '
        Me.cmdExecute.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmdExecute.Location = New System.Drawing.Point(10, 183)
        Me.cmdExecute.Name = "cmdExecute"
        Me.cmdExecute.Size = New System.Drawing.Size(100, 30)
        Me.cmdExecute.TabIndex = 5
        Me.cmdExecute.Text = "Execute"
        Me.cmdExecute.UseVisualStyleBackColor = True
        '
        'cmdClearResults
        '
        Me.cmdClearResults.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmdClearResults.Location = New System.Drawing.Point(10, 488)
        Me.cmdClearResults.Name = "cmdClearResults"
        Me.cmdClearResults.Size = New System.Drawing.Size(100, 30)
        Me.cmdClearResults.TabIndex = 7
        Me.cmdClearResults.Text = "Clear Results"
        Me.cmdClearResults.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 521)
        Me.Controls.Add(Me.tlpMain)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SQL Command Executor"
        Me.tlpMain.ResumeLayout(False)
        Me.tlpMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents txtConnection As TextBox
    Friend WithEvents lblCommand As Label
    Friend WithEvents txtCommand As TextBox
    Friend WithEvents cmdExecute As Button
    Friend WithEvents txtResults As RichTextBox
    Friend WithEvents lblConnection As Label
    Friend WithEvents cmdConnectionLoad As Button
    Friend WithEvents cmdClearResults As Button
End Class
