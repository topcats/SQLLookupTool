using SQLLookupTool.Interfaces;
using System;
using System.Data;
using System.Data.SqlClient;
using static SQLLookupTool.Intelligence.MessageDelegates;


namespace SQLLookupTool.Intelligence
{

    /// <summary>
    /// MS SQL Server Connection
    /// </summary>
    internal class MsSqlServer : ISqlSrv
    {

        /// <summary>
        /// Connection String
        /// </summary>
        private readonly string CS;

        /// <summary>
        /// Connection Object
        /// </summary>
        private SqlConnection Conn = default;

        /// <inheritdoc />
        public event ResultMessageEventHandler ResultMessage;

        /// <inheritdoc />
        public event ErrorMessageEventHandler ErrorMessage;



        public MsSqlServer(string ConnectionString)
        {
            this.CS = ConnectionString;
        }

        public void Dispose()
        {
            this.Conn?.Close();
            this.Conn = null;
        }



        private void Connect()
        {

            // Connect to Server
            try
            {
                this.Conn = new SqlConnection(this.CS);
                this.Conn.Open();
            }
            catch (Exception ex)
            {
                ErrorMessage?.Invoke("ERROR-CONN", ex.Message);
                this.Conn = null;
            }
        }



        /// <inheritdoc />
        public void ExecuteStatement(string sql)
        {
            if (this.Conn == null || this.Conn.State != ConnectionState.Open)
                Connect();
            if (this.Conn == null)
                return;


            SqlDataReader oReader = default;
            SqlCommand oCmd = default;

            // Run Command
            try
            {
                oCmd = new SqlCommand(sql, this.Conn);

                oReader = oCmd.ExecuteReader();
                ShowResults(ref oReader);
            }
            catch (Exception ex)
            {
                ErrorMessage?.Invoke("ERROR-CMD", ex.Message);
            }

            finally
            {
                oReader?.Close();
                oCmd?.Dispose();
                oReader = null;
                oCmd = null;
            }
        }



        private void ShowResults(ref SqlDataReader oReader)
        {
            string SLine = string.Empty;
            try
            {
                using (oReader)
                {
                    // List Headers
                    for (int iCount = 0; iCount <= oReader.FieldCount - 1; iCount++)
                        SLine += oReader.GetName(iCount).ToUpper() + "\t";
                    ResultMessage?.Invoke(SLine);

                    // Get Rows and fields
                    while (oReader.Read())
                    {
                        SLine = string.Empty;
                        for (int iCount = 0; iCount <= oReader.FieldCount - 1; iCount++)
                            SLine += oReader.GetValue(iCount).ToString() + "\t";
                        ResultMessage?.Invoke(SLine);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorMessage?.Invoke("ERROR:", ex.Message);
            }
            ResultMessage?.Invoke(string.Empty);
        }
    }
}
