Namespace Intelligence
    Public Class CSHelper

        Public Shared Function GetCS(CS_Type As String, CS_Server As String, CS_Database As String, CS_Secrurity As Boolean, CS_Username As String, CS_Password As String) As String
            Dim CSReturn As String = String.Empty


            If CS_Type = "ORACLE" Then
                ' Build Oracle CS
                Dim sOracleCS As String = ""

                sOracleCS = "(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)"
                sOracleCS &= "(Host=" & CS_Server & ")(Port=1521)))"
                sOracleCS &= "(CONNECT_DATA=(SERVICE_NAME=" & CS_Database & ")))"

                CSReturn &= "Data Source=" & sOracleCS & ";"
                CSReturn &= "User Id=" & CS_Username & ";"
                CSReturn &= "Password=" & CS_Password & ";"
            Else
                ' Build MS SQL CS
                CSReturn &= "Data Source=" & CS_Server & ";"
                CSReturn &= "Initial Catalog=" & CS_Database & ";"
                If CS_Secrurity Then
                    CSReturn &= "Integrated Security=True;"

                Else
                    CSReturn &= "Integrated Security=False;"
                    CSReturn &= "User ID=" & CS_Username & ";"
                    CSReturn &= "Password=" & CS_Password & ";"
                End If

                CSReturn &= "Encrypt=True;"
                CSReturn &= "TrustServerCertificate=True;"
                CSReturn &= "Column Encryption Setting=Enabled;"
                CSReturn &= "Application Name=""" & My.Application.Info.Title & """;"
            End If

            ' Return Connection String
            Return CSReturn
        End Function


    End Class
End Namespace
