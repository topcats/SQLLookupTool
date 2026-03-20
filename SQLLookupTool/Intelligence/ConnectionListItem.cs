namespace SQLLookupTool.Intelligence
{
    /// <summary>
    /// Connection List Item
    /// </summary>
    public class ConnectionListItem
    {
        /// <summary>
        /// Connection Type (MSSQL or Oracle)
        /// </summary>
        public CSTypeList ConnectionType { get; set; }

        /// <summary>
        /// Server Name
        /// </summary>
        public string ServerName { get; set; }

        /// <summary>
        /// Database Name (MS SQL Database or Oracle Service Name)
        /// </summary>
        public string DatabaseName { get; set; }

        /// <summary>
        /// Integrated Security (MSSQL only)
        /// </summary>
        public bool Security { get; set; }

        /// <summary>
        /// DB Username
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// DB Password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Get Title
        /// </summary>
        public override string ToString()
        {
            return $"{this.ConnectionTypeName}: {this.ServerName} - {this.DatabaseName} ({this.Username})";
        }

        /// <summary>
        /// Gets the name of the current database connection type.
        /// </summary>
        /// <remarks>Returns a string representing the type of database connection, such as "ORACLE" or
        /// "MSSQL". If the connection type is not recognized, returns "UNKNOWN".</remarks>
        public string ConnectionTypeName
        {
            get
            {
                switch (this.ConnectionType)
                {
                    case CSTypeList.Oracle:
                        return "ORACLE";
                    case CSTypeList.MSSQL:
                        return "MSSQL";
                    default:
                        return "UNKNOWN";
                }
            }
        }
    }
}
