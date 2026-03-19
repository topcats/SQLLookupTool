namespace SQLLookupTool
{
    partial class FormConnectionDesign
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TLPMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblDatabaseType = new System.Windows.Forms.Label();
            this.lblServerName = new System.Windows.Forms.Label();
            this.lblDatabaseName = new System.Windows.Forms.Label();
            this.optDatabaseTypeMSSQL = new System.Windows.Forms.RadioButton();
            this.optDatabaseTypeOracle = new System.Windows.Forms.RadioButton();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.lblSecurity = new System.Windows.Forms.Label();
            this.chkSecurity = new System.Windows.Forms.CheckBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.comboBoxPrevious = new System.Windows.Forms.ComboBox();
            this.TLPButtons = new System.Windows.Forms.TableLayoutPanel();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.TLPMain.SuspendLayout();
            this.TLPButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLPMain
            // 
            this.TLPMain.BackColor = System.Drawing.Color.Transparent;
            this.TLPMain.ColumnCount = 3;
            this.TLPMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.TLPMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPMain.Controls.Add(this.lblDatabaseType, 0, 1);
            this.TLPMain.Controls.Add(this.lblServerName, 0, 2);
            this.TLPMain.Controls.Add(this.lblDatabaseName, 0, 3);
            this.TLPMain.Controls.Add(this.optDatabaseTypeMSSQL, 1, 1);
            this.TLPMain.Controls.Add(this.optDatabaseTypeOracle, 2, 1);
            this.TLPMain.Controls.Add(this.txtServerName, 1, 2);
            this.TLPMain.Controls.Add(this.txtDatabaseName, 1, 3);
            this.TLPMain.Controls.Add(this.lblSecurity, 0, 4);
            this.TLPMain.Controls.Add(this.chkSecurity, 1, 4);
            this.TLPMain.Controls.Add(this.txtUsername, 1, 5);
            this.TLPMain.Controls.Add(this.txtPassword, 1, 6);
            this.TLPMain.Controls.Add(this.lblUsername, 0, 5);
            this.TLPMain.Controls.Add(this.lblPassword, 0, 6);
            this.TLPMain.Controls.Add(this.comboBoxPrevious, 0, 0);
            this.TLPMain.Location = new System.Drawing.Point(13, 13);
            this.TLPMain.Margin = new System.Windows.Forms.Padding(4);
            this.TLPMain.Name = "TLPMain";
            this.TLPMain.RowCount = 8;
            this.TLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPMain.Size = new System.Drawing.Size(451, 226);
            this.TLPMain.TabIndex = 1;
            // 
            // lblDatabaseType
            // 
            this.lblDatabaseType.AutoSize = true;
            this.lblDatabaseType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDatabaseType.ForeColor = System.Drawing.Color.White;
            this.lblDatabaseType.Location = new System.Drawing.Point(4, 40);
            this.lblDatabaseType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatabaseType.Name = "lblDatabaseType";
            this.lblDatabaseType.Size = new System.Drawing.Size(132, 30);
            this.lblDatabaseType.TabIndex = 1;
            this.lblDatabaseType.Text = "Database Type";
            this.lblDatabaseType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblServerName.ForeColor = System.Drawing.Color.White;
            this.lblServerName.Location = new System.Drawing.Point(4, 70);
            this.lblServerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(132, 30);
            this.lblServerName.TabIndex = 4;
            this.lblServerName.Text = "Server Name";
            this.lblServerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDatabaseName
            // 
            this.lblDatabaseName.AutoSize = true;
            this.lblDatabaseName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDatabaseName.ForeColor = System.Drawing.Color.White;
            this.lblDatabaseName.Location = new System.Drawing.Point(3, 100);
            this.lblDatabaseName.Name = "lblDatabaseName";
            this.lblDatabaseName.Size = new System.Drawing.Size(134, 30);
            this.lblDatabaseName.TabIndex = 6;
            this.lblDatabaseName.Text = "Database Name";
            this.lblDatabaseName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // optDatabaseTypeMSSQL
            // 
            this.optDatabaseTypeMSSQL.AutoSize = true;
            this.optDatabaseTypeMSSQL.Checked = true;
            this.optDatabaseTypeMSSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optDatabaseTypeMSSQL.ForeColor = System.Drawing.Color.White;
            this.optDatabaseTypeMSSQL.Location = new System.Drawing.Point(143, 43);
            this.optDatabaseTypeMSSQL.Name = "optDatabaseTypeMSSQL";
            this.optDatabaseTypeMSSQL.Size = new System.Drawing.Size(149, 24);
            this.optDatabaseTypeMSSQL.TabIndex = 2;
            this.optDatabaseTypeMSSQL.TabStop = true;
            this.optDatabaseTypeMSSQL.Text = "MS SQL";
            this.optDatabaseTypeMSSQL.UseVisualStyleBackColor = true;
            this.optDatabaseTypeMSSQL.CheckedChanged += new System.EventHandler(this.optDatabaseTypeMSSQL_CheckedChanged);
            // 
            // optDatabaseTypeOracle
            // 
            this.optDatabaseTypeOracle.AutoSize = true;
            this.optDatabaseTypeOracle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optDatabaseTypeOracle.ForeColor = System.Drawing.Color.White;
            this.optDatabaseTypeOracle.Location = new System.Drawing.Point(298, 43);
            this.optDatabaseTypeOracle.Name = "optDatabaseTypeOracle";
            this.optDatabaseTypeOracle.Size = new System.Drawing.Size(150, 24);
            this.optDatabaseTypeOracle.TabIndex = 3;
            this.optDatabaseTypeOracle.Text = "Oracle";
            this.optDatabaseTypeOracle.UseVisualStyleBackColor = true;
            // 
            // txtServerName
            // 
            this.TLPMain.SetColumnSpan(this.txtServerName, 2);
            this.txtServerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtServerName.Location = new System.Drawing.Point(143, 73);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(305, 27);
            this.txtServerName.TabIndex = 5;
            // 
            // txtDatabaseName
            // 
            this.TLPMain.SetColumnSpan(this.txtDatabaseName, 2);
            this.txtDatabaseName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDatabaseName.Location = new System.Drawing.Point(143, 103);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(305, 27);
            this.txtDatabaseName.TabIndex = 7;
            // 
            // lblSecurity
            // 
            this.lblSecurity.AutoSize = true;
            this.lblSecurity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSecurity.ForeColor = System.Drawing.Color.White;
            this.lblSecurity.Location = new System.Drawing.Point(3, 130);
            this.lblSecurity.Name = "lblSecurity";
            this.lblSecurity.Size = new System.Drawing.Size(134, 30);
            this.lblSecurity.TabIndex = 8;
            this.lblSecurity.Text = "Integrated Security";
            this.lblSecurity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkSecurity
            // 
            this.chkSecurity.AutoSize = true;
            this.chkSecurity.Checked = true;
            this.chkSecurity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSecurity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkSecurity.ForeColor = System.Drawing.Color.White;
            this.chkSecurity.Location = new System.Drawing.Point(143, 133);
            this.chkSecurity.Name = "chkSecurity";
            this.chkSecurity.Size = new System.Drawing.Size(149, 24);
            this.chkSecurity.TabIndex = 9;
            this.chkSecurity.Text = "Use";
            this.chkSecurity.UseVisualStyleBackColor = true;
            this.chkSecurity.CheckedChanged += new System.EventHandler(this.chkSecurity_CheckedChanged);
            // 
            // txtUsername
            // 
            this.TLPMain.SetColumnSpan(this.txtUsername, 2);
            this.txtUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsername.Location = new System.Drawing.Point(143, 163);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(305, 27);
            this.txtUsername.TabIndex = 11;
            // 
            // txtPassword
            // 
            this.TLPMain.SetColumnSpan(this.txtPassword, 2);
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Location = new System.Drawing.Point(143, 193);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(305, 27);
            this.txtPassword.TabIndex = 13;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(3, 160);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(134, 30);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(3, 190);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(134, 30);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxPrevious
            // 
            this.TLPMain.SetColumnSpan(this.comboBoxPrevious, 3);
            this.comboBoxPrevious.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxPrevious.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrevious.FormattingEnabled = true;
            this.comboBoxPrevious.Location = new System.Drawing.Point(3, 3);
            this.comboBoxPrevious.Name = "comboBoxPrevious";
            this.comboBoxPrevious.Size = new System.Drawing.Size(445, 27);
            this.comboBoxPrevious.TabIndex = 0;
            this.comboBoxPrevious.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPrevious_SelectedIndexChanged);
            this.comboBoxPrevious.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ComboBoxPrevious_KeyUp);
            // 
            // TLPButtons
            // 
            this.TLPButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TLPButtons.BackColor = System.Drawing.Color.Transparent;
            this.TLPButtons.ColumnCount = 2;
            this.TLPButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPButtons.Controls.Add(this.OK_Button, 0, 0);
            this.TLPButtons.Controls.Add(this.Cancel_Button, 1, 0);
            this.TLPButtons.Location = new System.Drawing.Point(266, 240);
            this.TLPButtons.Margin = new System.Windows.Forms.Padding(4);
            this.TLPButtons.Name = "TLPButtons";
            this.TLPButtons.RowCount = 1;
            this.TLPButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPButtons.Size = new System.Drawing.Size(195, 40);
            this.TLPButtons.TabIndex = 2;
            // 
            // OK_Button
            // 
            this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OK_Button.Location = new System.Drawing.Point(4, 4);
            this.OK_Button.Margin = new System.Windows.Forms.Padding(4);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(89, 32);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "OK";
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(101, 4);
            this.Cancel_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(89, 32);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // FormConnectionDesign
            // 
            this.AcceptButton = this.OK_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SQLLookupTool.Properties.Resources.Songbird;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.Cancel_Button;
            this.ClientSize = new System.Drawing.Size(477, 296);
            this.Controls.Add(this.TLPMain);
            this.Controls.Add(this.TLPButtons);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConnectionDesign";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connection String Designer";
            this.Shown += new System.EventHandler(this.FormConnectionDesign_Shown);
            this.TLPMain.ResumeLayout(false);
            this.TLPMain.PerformLayout();
            this.TLPButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TableLayoutPanel TLPMain;
        internal System.Windows.Forms.Label lblDatabaseType;
        internal System.Windows.Forms.Label lblServerName;
        internal System.Windows.Forms.Label lblDatabaseName;
        internal System.Windows.Forms.RadioButton optDatabaseTypeMSSQL;
        internal System.Windows.Forms.RadioButton optDatabaseTypeOracle;
        internal System.Windows.Forms.TextBox txtServerName;
        internal System.Windows.Forms.TextBox txtDatabaseName;
        internal System.Windows.Forms.Label lblSecurity;
        internal System.Windows.Forms.CheckBox chkSecurity;
        internal System.Windows.Forms.TextBox txtUsername;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.Label lblUsername;
        internal System.Windows.Forms.Label lblPassword;
        internal System.Windows.Forms.TableLayoutPanel TLPButtons;
        internal System.Windows.Forms.Button OK_Button;
        internal System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.ComboBox comboBoxPrevious;
    }
}