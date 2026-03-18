Imports System.Data.SqlClient

Namespace Intelligence

    ''' <summary>
    ''' MS SQL Server Connection
    ''' </summary>
    Public Class MsSqlSrv
        Implements ISqlSrv

        ''' <summary>
        ''' Connection String 
        ''' </summary>
        Private ReadOnly CS As String

        ''' <summary>
        ''' Connection Object
        ''' </summary>
        Private Conn As SqlConnection = Nothing

        '''<inheritdoc />
        Public Event ResultMessage(ByVal message As String) Implements ISqlSrv.ResultMessage

        '''<inheritdoc />
        Public Event ErrorMessage(ByVal category As String, ByVal message As String) Implements ISqlSrv.ErrorMessage

        Public Sub New(ByVal ConnectionString As String)
            Me.CS = ConnectionString
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose

            If Not IsNothing(Me.Conn) Then Me.Conn.Close()
            Me.Conn = Nothing
        End Sub

        Private Sub Connect()

            'Connect to Server
            Try
                Me.Conn = New SqlConnection(Me.CS)
                Me.Conn.Open()

            Catch ex As Exception
                RaiseEvent ErrorMessage("ERROR-CONN", ex.Message)
                Me.Conn = Nothing
            End Try
        End Sub


        '''<inheritdoc />
        Public Sub ExecuteStatement(ByVal sql As String) Implements ISqlSrv.ExecuteStatement

            If Me.Conn Is Nothing OrElse Me.Conn.State <> ConnectionState.Open Then
                Call Connect()
            End If
            If Me.Conn Is Nothing Then Exit Sub


            Dim oReader As SqlDataReader = Nothing
            Dim oCmd As SqlCommand = Nothing

            'Run Command
            Try

                oCmd = New SqlCommand(sql, Me.Conn)

                oReader = oCmd.ExecuteReader
                ShowResults(oReader)

            Catch ex As Exception
                RaiseEvent ErrorMessage("ERROR-CMD", ex.Message)

            Finally
                If Not IsNothing(oReader) Then oReader.Close()
                If Not IsNothing(oCmd) Then oCmd.Dispose()
                oReader = Nothing
                oCmd = Nothing

            End Try

        End Sub



        Private Sub ShowResults(ByRef oReader As SqlDataReader)
            Dim SLine As String = String.Empty
            Try
                Using oReader
                    ' List Headers
                    For iCount As Integer = 0 To oReader.FieldCount - 1
                        SLine &= oReader.GetName(iCount).ToUpper & vbTab
                    Next
                    RaiseEvent ResultMessage(SLine)

                    ' Get Rows and fields
                    While oReader.Read
                        SLine = String.Empty
                        For iCount As Integer = 0 To oReader.FieldCount - 1
                            SLine &= oReader.GetValue(iCount).ToString & vbTab
                        Next
                        RaiseEvent ResultMessage(SLine)
                    End While
                End Using

            Catch ex As Exception
                RaiseEvent ErrorMessage("ERROR:", ex.Message)

            End Try
            RaiseEvent ResultMessage(String.Empty)

        End Sub

    End Class

End Namespace
