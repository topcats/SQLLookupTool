Imports System.Windows.Forms

Public Class FormConnectionDesign

    Private Sub OK_Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OK_Button.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub SetForm()
        ' Set Database Type
        If optDatabaseTypeMSSQL.Checked Then
            Me.lblDatabaseName.Text = "Database Name"
            Me.lblSecurity.Enabled = True
            Me.chkSecurity.Enabled = True

        ElseIf optDatabaseTypeOracle.Checked Then
            Me.lblDatabaseName.Text = "Service Name"
            Me.lblSecurity.Enabled = False
            Me.chkSecurity.Enabled = False

        End If

        ' Set Secruity Type
        If Me.chkSecurity.Enabled AndAlso Me.chkSecurity.Checked Then
            Me.lblUsername.Enabled = False
            Me.txtUsername.Enabled = False
            Me.lblPassword.Enabled = False
            Me.txtPassword.Enabled = False
        Else
            Me.lblUsername.Enabled = True
            Me.txtUsername.Enabled = True
            Me.lblPassword.Enabled = True
            Me.txtPassword.Enabled = True
        End If
    End Sub



    Public Property DatabaseType As String
        Get
            If optDatabaseTypeOracle.Checked Then
                Return "ORACLE"
            Else
                Return "MSSQL"
                End If
        End Get
        Set(value As String)
            optDatabaseTypeMSSQL.Checked = False
            optDatabaseTypeOracle.Checked = False
            If value = "ORACLE" Then
                optDatabaseTypeOracle.Checked = True
            Else
                optDatabaseTypeMSSQL.Checked = True
            End If

            Call SetForm()
        End Set
    End Property

    Public Property ServerName As String
        Get
            Return Me.txtServerName.Text
        End Get
        Set(value As String)
            Me.txtServerName.Text = value
        End Set
    End Property

    Public Property DatabaseName As String
        Get
            Return Me.txtDatabaseName.Text
        End Get
        Set(value As String)
            Me.txtDatabaseName.Text = value
        End Set
    End Property

    Public Property Security As Boolean
        Get
            Return Me.chkSecurity.Checked
        End Get
        Set(value As Boolean)
            Me.chkSecurity.Checked = value
            Call SetForm()
        End Set
    End Property

    Public Property UserName As String
        Get
            Return Me.txtUsername.Text
        End Get
        Set(value As String)
            Me.txtUsername.Text = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return Me.txtPassword.Text
        End Get
        Set(value As String)
            Me.txtPassword.Text = value
        End Set
    End Property




    Private Sub OptDatabaseType_CheckedChanged(sender As Object, e As EventArgs) Handles optDatabaseTypeMSSQL.CheckedChanged, optDatabaseTypeOracle.CheckedChanged
        Call SetForm()
    End Sub

    Private Sub ChkSecurity_CheckedChanged(sender As Object, e As EventArgs) Handles chkSecurity.CheckedChanged
        Call SetForm()
    End Sub

    Private Sub FormConnectionDesign_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Call SetForm()
    End Sub
End Class
