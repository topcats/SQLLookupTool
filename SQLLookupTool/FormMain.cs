using SQLLookupTool.Intelligence;
using SQLLookupTool.Properties;
using System;
using System.Windows.Forms;

namespace SQLLookupTool
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();


            // Load Saved Settings
            this.txtConnection.Text = Settings.Default.ConnectionString;
            this.txtCommand.Text = Settings.Default.CommandText;

            // Set Tab Stops
            this.txtResults.SelectionTabs = new int[] { 300, 600, 800, 1000, 1175, 1350, 1525, 1700, 1875, 2050, 2225, 2400, 2575, 2750, 2925, 3100 };

        }

        private void CmdConnectionLoad_Click(object sender, EventArgs e)
        {
            // Init box with last used
            var oConnection = new FormConnectionDesign();

            // Show Form
            DialogResult result = oConnection.ShowDialog(owner: this);
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(oConnection.ServerName))
            {
                // If good save and create string
                string CS_Database = oConnection.DatabaseName;
                string CS_Server = oConnection.ServerName;
                bool CS_Secrurity = oConnection.Security;
                string CS_Username = oConnection.UserName;
                string CS_Password = oConnection.Password;
                CSTypeList CS_Type = oConnection.DatabaseType;

                // Create CS
                this.txtConnection.Text = CSHelper.GetConnectionString(CS_Type, CS_Server, CS_Database, CS_Secrurity, CS_Username, CS_Password);
            }
        }


        private void CmdExecute_Click(object sender, EventArgs e)
        {
            // Lock form and save settings
            LockForm(true);
            Settings.Default.ConnectionString = this.txtConnection.Text;
            Settings.Default.CommandText = this.txtCommand.Text;
            Settings.Default.Save();


            if (this.txtConnection.Text.StartsWith("Data Source=("))
            {
                // Oracle
                using (OracleServer oDB = new OracleServer(this.txtConnection.Text))
                {
                    oDB.ErrorMessage += (category, message) => LogError(category, message);
                    oDB.ResultMessage += message => LogResult(message);

                    oDB.ExecuteStatement(this.txtCommand.Text);
                }
            }
            else
                // MS SQL
                using (MsSqlServer oDB = new MsSqlServer(this.txtConnection.Text))
                {
                    oDB.ErrorMessage += (category, message) => LogError(category, message);
                    oDB.ResultMessage += message => LogResult(message);

                    oDB.ExecuteStatement(this.txtCommand.Text);
                }

            LockForm(false);
        }



        private void CmdClearResults_Click(object sender, EventArgs e)
        {
            this.txtResults.Text = String.Empty;
        }



        private void LockForm(bool lockit)
        {
            this.txtConnection.Enabled = !lockit;
            this.txtCommand.Enabled = !lockit;

            this.cmdConnectionLoad.Enabled = !lockit;
            this.cmdExecute.Enabled = !lockit;
            this.cmdClearResults.Enabled = !lockit;

            this.Cursor = lockit ? Cursors.WaitCursor : Cursors.Default;

            this.Refresh();
        }


        private delegate void LogErrorDelegate(string category, string message);
        private void LogError(string category, string message)
        {
            if (this.txtResults.InvokeRequired)
            {
                var d = new LogErrorDelegate(LogError);
                this.txtResults.Invoke(d);
            }
            else
                this.txtResults.Text += category + "\t" + message + Environment.NewLine;
            Application.DoEvents();
        }


        private delegate void LogResultDelegate(string message);
        private void LogResult(string message)
        {
            if (this.txtResults.InvokeRequired)
            {
                var d = new LogResultDelegate(LogResult);
                this.txtResults.Invoke(d);
            }
            else
                this.txtResults.Text += message + Environment.NewLine;
            Application.DoEvents();
        }
    }
}
