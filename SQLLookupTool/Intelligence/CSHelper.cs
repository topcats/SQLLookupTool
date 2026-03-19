using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLLookupTool.Intelligence
{
    internal class CSHelper
    {
        /// <summary>
        /// Connection String Builder
        /// </summary>
        /// <param name="connectiontype">Either Oracle or MSSQL</param>
        /// <param name="servername">server name</param>
        /// <param name="databasename">MS SQL database or Oracle Service Name</param>
        /// <param name="security">Integrated security (MSSQL only)</param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>Connection String</returns>
        public static string GetConnectionString(CSTypeList connectiontype, string servername, string databasename, bool security, string username, string password)
        {
            string output = string.Empty;


            if (connectiontype == CSTypeList.Oracle)
            {

                // Build Oracle CS
                string sOracleCS = "(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)";
                sOracleCS += "(Host=" + servername + ")(Port=1521)))";
                sOracleCS += "(CONNECT_DATA=(SERVICE_NAME=" + databasename + ")))";

                output += "Data Source=" + sOracleCS + ";";
                output += "User Id=" + username + ";";
                output += "Password=" + password + ";";
            }
            else
            {
                // Build MS SQL CS
                output += "Data Source=" + servername + ";";
                output += "Initial Catalog=" + databasename + ";";
                if (security)
                    output += "Integrated Security=True;";
                else
                {
                    output += "Integrated Security=False;";
                    output += "User ID=" + username + ";";
                    output += "Password=" + password + ";";
                }

                output += "Encrypt=True;";
                output += "TrustServerCertificate=True;";
                output += "Column Encryption Setting=Enabled;";
                output += "Application Name=\"" + Application.ProductName + "\";";
            }

            // Return Connection String
            return output;
        }
    }
}
