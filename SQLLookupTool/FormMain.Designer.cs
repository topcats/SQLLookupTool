namespace SQLLookupTool
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.txtConnection = new System.Windows.Forms.TextBox();
            this.lblConnection = new System.Windows.Forms.Label();
            this.lblCommand = new System.Windows.Forms.Label();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.txtResults = new System.Windows.Forms.RichTextBox();
            this.cmdConnectionLoad = new System.Windows.Forms.Button();
            this.cmdExecute = new System.Windows.Forms.Button();
            this.cmdClearResults = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = System.Drawing.Color.Transparent;
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.txtConnection, 1, 0);
            this.tlpMain.Controls.Add(this.lblConnection, 0, 0);
            this.tlpMain.Controls.Add(this.lblCommand, 0, 2);
            this.tlpMain.Controls.Add(this.txtCommand, 1, 2);
            this.tlpMain.Controls.Add(this.txtResults, 1, 4);
            this.tlpMain.Controls.Add(this.cmdConnectionLoad, 0, 1);
            this.tlpMain.Controls.Add(this.cmdExecute, 0, 3);
            this.tlpMain.Controls.Add(this.cmdClearResults, 0, 5);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(4);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 6;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.Size = new System.Drawing.Size(826, 443);
            this.tlpMain.TabIndex = 1;
            // 
            // txtConnection
            // 
            this.txtConnection.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConnection.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConnection.Location = new System.Drawing.Point(144, 4);
            this.txtConnection.Margin = new System.Windows.Forms.Padding(4);
            this.txtConnection.Multiline = true;
            this.txtConnection.Name = "txtConnection";
            this.tlpMain.SetRowSpan(this.txtConnection, 2);
            this.txtConnection.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConnection.Size = new System.Drawing.Size(678, 46);
            this.txtConnection.TabIndex = 2;
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblConnection.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnection.ForeColor = System.Drawing.Color.White;
            this.lblConnection.Location = new System.Drawing.Point(4, 0);
            this.lblConnection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(132, 20);
            this.lblConnection.TabIndex = 0;
            this.lblConnection.Text = "Connection";
            // 
            // lblCommand
            // 
            this.lblCommand.AutoSize = true;
            this.lblCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCommand.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommand.ForeColor = System.Drawing.Color.White;
            this.lblCommand.Location = new System.Drawing.Point(4, 54);
            this.lblCommand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(132, 140);
            this.lblCommand.TabIndex = 3;
            this.lblCommand.Text = "SQL Command";
            // 
            // txtCommand
            // 
            this.txtCommand.AcceptsReturn = true;
            this.txtCommand.AcceptsTab = true;
            this.txtCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCommand.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommand.Location = new System.Drawing.Point(144, 58);
            this.txtCommand.Margin = new System.Windows.Forms.Padding(4);
            this.txtCommand.Multiline = true;
            this.txtCommand.Name = "txtCommand";
            this.tlpMain.SetRowSpan(this.txtCommand, 2);
            this.txtCommand.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCommand.Size = new System.Drawing.Size(678, 172);
            this.txtCommand.TabIndex = 4;
            this.txtCommand.WordWrap = false;
            // 
            // txtResults
            // 
            this.txtResults.AcceptsTab = true;
            this.txtResults.BackColor = System.Drawing.SystemColors.Window;
            this.txtResults.DetectUrls = false;
            this.txtResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResults.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResults.HideSelection = false;
            this.txtResults.Location = new System.Drawing.Point(144, 238);
            this.txtResults.Margin = new System.Windows.Forms.Padding(4);
            this.txtResults.Name = "txtResults";
            this.tlpMain.SetRowSpan(this.txtResults, 2);
            this.txtResults.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.txtResults.ShowSelectionMargin = true;
            this.txtResults.Size = new System.Drawing.Size(678, 201);
            this.txtResults.TabIndex = 6;
            this.txtResults.Text = "";
            this.txtResults.WordWrap = false;
            // 
            // cmdConnectionLoad
            // 
            this.cmdConnectionLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdConnectionLoad.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConnectionLoad.Location = new System.Drawing.Point(36, 24);
            this.cmdConnectionLoad.Margin = new System.Windows.Forms.Padding(4);
            this.cmdConnectionLoad.Name = "cmdConnectionLoad";
            this.cmdConnectionLoad.Size = new System.Drawing.Size(100, 26);
            this.cmdConnectionLoad.TabIndex = 1;
            this.cmdConnectionLoad.Text = "Build";
            this.cmdConnectionLoad.UseVisualStyleBackColor = true;
            this.cmdConnectionLoad.Click += new System.EventHandler(this.CmdConnectionLoad_Click);
            // 
            // cmdExecute
            // 
            this.cmdExecute.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmdExecute.Location = new System.Drawing.Point(4, 198);
            this.cmdExecute.Margin = new System.Windows.Forms.Padding(4);
            this.cmdExecute.Name = "cmdExecute";
            this.cmdExecute.Size = new System.Drawing.Size(132, 32);
            this.cmdExecute.TabIndex = 5;
            this.cmdExecute.Text = "Execute";
            this.cmdExecute.UseVisualStyleBackColor = true;
            this.cmdExecute.Click += new System.EventHandler(this.CmdExecute_Click);
            // 
            // cmdClearResults
            // 
            this.cmdClearResults.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmdClearResults.Location = new System.Drawing.Point(4, 407);
            this.cmdClearResults.Margin = new System.Windows.Forms.Padding(4);
            this.cmdClearResults.Name = "cmdClearResults";
            this.cmdClearResults.Size = new System.Drawing.Size(132, 32);
            this.cmdClearResults.TabIndex = 7;
            this.cmdClearResults.Text = "Clear Results";
            this.cmdClearResults.UseVisualStyleBackColor = true;
            this.cmdClearResults.Click += new System.EventHandler(this.CmdClearResults_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SQLLookupTool.Properties.Resources.Bullet;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(826, 443);
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "SQL Lookup Tool";
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TableLayoutPanel tlpMain;
        internal System.Windows.Forms.TextBox txtConnection;
        internal System.Windows.Forms.Label lblConnection;
        internal System.Windows.Forms.Label lblCommand;
        internal System.Windows.Forms.TextBox txtCommand;
        internal System.Windows.Forms.RichTextBox txtResults;
        internal System.Windows.Forms.Button cmdConnectionLoad;
        internal System.Windows.Forms.Button cmdExecute;
        internal System.Windows.Forms.Button cmdClearResults;
    }
}