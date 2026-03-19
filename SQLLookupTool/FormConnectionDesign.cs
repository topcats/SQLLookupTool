using SQLLookupTool.Intelligence;
using System;
using System.Windows.Forms;

namespace SQLLookupTool
{
    public partial class FormConnectionDesign : Form
    {

        private ConnectionListManager CLManager = new ConnectionListManager();

        public FormConnectionDesign()
        {
            InitializeComponent();
        }

        private void FormConnectionDesign_Shown(object sender, EventArgs e)
        {

            this.comboBoxPrevious.Items.Clear();
            if (this.CLManager != null && this.CLManager.ConnectionList.Count > 0)
            {
                foreach (var item in this.CLManager.ConnectionList)
                {
                    this.comboBoxPrevious.Items.Add(item);
                }
            }

            this.SetForm();
        }


        private void SetForm()
        {
            // Set Database Type
            if (this.optDatabaseTypeMSSQL.Checked)
            {
                this.lblDatabaseName.Text = "Database Name";
                this.lblSecurity.Enabled = true;
                this.chkSecurity.Enabled = true;
            }
            else if (optDatabaseTypeOracle.Checked)
            {
                this.lblDatabaseName.Text = "Service Name";
                this.lblSecurity.Enabled = false;
                this.chkSecurity.Enabled = false;
            }

            // Set Secruity Type
            if (this.chkSecurity.Enabled && this.chkSecurity.Checked)
            {
                this.lblUsername.Enabled = false;
                this.txtUsername.Enabled = false;
                this.lblPassword.Enabled = false;
                this.txtPassword.Enabled = false;
            }
            else
            {
                this.lblUsername.Enabled = true;
                this.txtUsername.Enabled = true;
                this.lblPassword.Enabled = true;
                this.txtPassword.Enabled = true;
            }
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            // Add to list
            this.CLManager.AddConnection(new ConnectionListItem()
            {
                ConnectionType = this.DatabaseType,
                ServerName = this.ServerName,
                DatabaseName = this.DatabaseName,
                Security = this.Security,
                Username = (this.Security) ? string.Empty : this.UserName,
                Password = (this.Security) ? string.Empty : this.Password
            });
            this.CLManager.Save();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void optDatabaseTypeMSSQL_CheckedChanged(object sender, EventArgs e)
        {
            this.SetForm();
        }

        private void chkSecurity_CheckedChanged(object sender, EventArgs e)
        {
            this.SetForm();
        }


        public CSTypeList DatabaseType
        {
            get
            {
                return (optDatabaseTypeOracle.Checked) ? CSTypeList.Oracle : CSTypeList.MSSQL;
            }
        }

        public string ServerName
        {
            get
            {
                return this.txtServerName.Text.Trim();
            }
        }

        public string DatabaseName
        {
            get
            {
                return this.txtDatabaseName.Text.Trim();
            }
        }

        public bool Security
        {
            get
            {
                return this.chkSecurity.Checked;
            }
        }

        public string UserName
        {
            get
            {
                return this.txtUsername.Text.Trim();
            }
        }

        public string Password
        {
            get
            {
                return this.txtPassword.Text;
            }
        }



        private void ComboBoxPrevious_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ConnectionListItem selectedItem = this.comboBoxPrevious.SelectedItem as ConnectionListItem;
                if (selectedItem != null)
                {
                    // Populate the form fields with the selected item's properties
                    if (selectedItem.ConnectionType == CSTypeList.Oracle)
                    {
                        this.optDatabaseTypeOracle.Checked = true;
                    }
                    else
                    {
                        this.optDatabaseTypeMSSQL.Checked = true;
                    }
                    this.txtServerName.Text = selectedItem.ServerName;
                    this.txtDatabaseName.Text = selectedItem.DatabaseName;
                    this.chkSecurity.Checked = selectedItem.Security;
                    this.txtUsername.Text = selectedItem.Username;
                    this.txtPassword.Text = selectedItem.Password;
                    // Update the form based on the new selections
                    this.SetForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading connection: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ComboBoxPrevious_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                // Remove the selected item
                this.CLManager.RemoveConnection(this.comboBoxPrevious.SelectedItem as ConnectionListItem);
                this.comboBoxPrevious.Items.Remove(this.comboBoxPrevious.SelectedItem);

                // Clear Form
                this.optDatabaseTypeMSSQL.Checked = true;
                this.txtServerName.Text = string.Empty;
                this.txtDatabaseName.Text = string.Empty;
                this.chkSecurity.Checked = true;
                this.txtUsername.Text = string.Empty;
                this.txtPassword.Text = string.Empty;
                this.SetForm();

                // Mark handled
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
