
Imports SQL_Lookup_App.Intelligence

Public Class FormMain
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Load Saved Settings
        Me.txtConnection.Text = My.Settings.ConnectionString
        Me.txtCommand.Text = My.Settings.CommandText

        ' Set Tab 
        Me.txtResults.SelectionTabs = New Integer() {300, 600, 800, 1000, 1175, 1350, 1525, 1700, 1875, 2050, 2225, 2400, 2575, 2750, 2925, 3100}
    End Sub

    Private Sub FormMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Save input details
        My.Settings.ConnectionString = Me.txtConnection.Text
        My.Settings.CommandText = Me.txtCommand.Text
        My.Settings.Save()
    End Sub


    Private Sub CmdExecute_Click(sender As Object, e As EventArgs) Handles cmdExecute.Click
        LockForm(True)
        My.Settings.ConnectionString = Me.txtConnection.Text
        My.Settings.CommandText = Me.txtCommand.Text
        My.Settings.Save()


        If Me.txtConnection.Text.StartsWith("Data Source=(") Then
            ' Oracle
            Using oDB As New OracleSrv(Me.txtConnection.Text)
                AddHandler oDB.ErrorMessage, Sub(category As String, message As String) LogError(category, message)
                AddHandler oDB.ResultMessage, Sub(message As String) LogResult(message)

                oDB.ExecuteStatement(Me.txtCommand.Text)
            End Using
        Else
            ' MS SQL
            Using oDB As New MsSqlSrv(Me.txtConnection.Text)
                AddHandler oDB.ErrorMessage, Sub(category As String, message As String) LogError(category, message)
                AddHandler oDB.ResultMessage, Sub(message As String) LogResult(message)

                oDB.ExecuteStatement(Me.txtCommand.Text)
            End Using
        End If

        LockForm(False)
    End Sub



    Private Delegate Sub LogErrorDelegate(category As String, message As String)
    Private Sub LogError(category As String, message As String)
        If txtResults.InvokeRequired Then
            Dim d = New LogErrorDelegate(AddressOf LogError)
            txtResults.Invoke(d)
        Else
            Me.txtResults.Text &= category & vbTab & message & Environment.NewLine
        End If
        Application.DoEvents()
    End Sub


    Private Delegate Sub LogResultDelegate(message As String)
    Private Sub LogResult(message As String)
        If txtResults.InvokeRequired Then
            Dim d = New LogResultDelegate(AddressOf LogResult)
            txtResults.Invoke(d)
        Else
            Me.txtResults.Text &= message & Environment.NewLine
        End If
        Application.DoEvents()
    End Sub



    Private Sub LockForm(ByVal lockit As Boolean)

        Me.txtConnection.Enabled = Not lockit
        Me.txtCommand.Enabled = Not lockit

        Me.cmdConnectionLoad.Enabled = Not lockit
        Me.cmdExecute.Enabled = Not lockit
        Me.cmdClearResults.Enabled = Not lockit

        Me.Cursor = If(lockit, Cursors.WaitCursor, Cursors.Default)

        Me.Refresh()
        My.Application.DoEvents()
    End Sub


    Private Sub CmdConnectionLoad_Click(sender As Object, e As EventArgs) Handles cmdConnectionLoad.Click

        ' Init box with last used
        Dim oConnection As New FormConnectionDesign() With {
            .DatabaseName = My.Settings.CS_Database,
            .ServerName = My.Settings.CS_Server,
            .Security = My.Settings.CS_Secrurity,
            .UserName = My.Settings.CS_Username,
            .Password = My.Settings.CS_Password,
            .DatabaseType = My.Settings.CS_Type
        }

        'Show Form
        Dim result = oConnection.ShowDialog(owner:=Me)
        If result = DialogResult.OK Then
            ' If good save and create string
            My.Settings.CS_Database = oConnection.DatabaseName.Trim()
            My.Settings.CS_Server = oConnection.ServerName.Trim()
            My.Settings.CS_Secrurity = oConnection.Security
            My.Settings.CS_Username = oConnection.UserName.Trim()
            My.Settings.CS_Password = oConnection.Password.Trim()
            My.Settings.CS_Type = oConnection.DatabaseType
            My.Settings.Save()

            ' Create CS
            Me.txtConnection.Text = CSHelper.GetCS(My.Settings.CS_Type, My.Settings.CS_Server, My.Settings.CS_Database, My.Settings.CS_Secrurity, My.Settings.CS_Username, My.Settings.CS_Password)
        End If

    End Sub

    Private Sub CmdClearResults_Click(sender As Object, e As EventArgs) Handles cmdClearResults.Click
        Me.txtResults.Text = String.Empty
    End Sub

End Class
