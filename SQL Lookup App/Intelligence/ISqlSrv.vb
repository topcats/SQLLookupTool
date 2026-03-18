Namespace Intelligence

    Public Interface ISqlSrv
        Inherits IDisposable

        ''' <summary>
        ''' Fired for a Result Line
        ''' </summary>
        ''' <param name="message">Result line</param>
        Event ResultMessage(message As String)

        ''' <summary>
        ''' Fired for an Error message
        ''' </summary>
        ''' <param name="category">Error category</param>
        ''' <param name="message">Error Mssage</param>
        Event ErrorMessage(ByVal category As String, ByVal message As String)


        ''' <summary>
        ''' Execute SQL Statement
        ''' </summary>
        ''' <remarks>results will go to events</remarks>
        ''' <param name="sql">SQL to execute</param>
        Sub ExecuteStatement(ByVal sql As String)


    End Interface
End Namespace
