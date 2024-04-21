namespace CustomPostgresExplorer
{
    partial class PostgresExplorer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostgresExplorer));
            this.tblLayout_DatabaseDetails = new System.Windows.Forms.TableLayoutPanel();
            this.lblHostName = new System.Windows.Forms.Label();
            this.txtHostName = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnConnectDatabase = new System.Windows.Forms.Button();
            this.lblDatabaseName = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tblLayout_QueryWindow = new System.Windows.Forms.TableLayoutPanel();
            this.txtQueryEditor = new System.Windows.Forms.TextBox();
            this.tblLayout_ResultsWindow = new System.Windows.Forms.TableLayoutPanel();
            this.lblResults = new System.Windows.Forms.Label();
            this.dgViewResults = new System.Windows.Forms.DataGridView();
            this.lblStatusStrip = new System.Windows.Forms.Label();
            this.tblLayout_Database = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDatabase = new System.Windows.Forms.ComboBox();
            this.btnExecuteQuery = new System.Windows.Forms.Button();
            this.picMandatory = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picBxPassControl = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tblLayout_DatabaseDetails.SuspendLayout();
            this.tblLayout_QueryWindow.SuspendLayout();
            this.tblLayout_ResultsWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewResults)).BeginInit();
            this.tblLayout_Database.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMandatory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxPassControl)).BeginInit();
            this.SuspendLayout();
            // 
            // tblLayout_DatabaseDetails
            // 
            this.tblLayout_DatabaseDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLayout_DatabaseDetails.ColumnCount = 7;
            this.tblLayout_DatabaseDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.027778F));
            this.tblLayout_DatabaseDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.30556F));
            this.tblLayout_DatabaseDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.027778F));
            this.tblLayout_DatabaseDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.30556F));
            this.tblLayout_DatabaseDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.027778F));
            this.tblLayout_DatabaseDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.30556F));
            this.tblLayout_DatabaseDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215F));
            this.tblLayout_DatabaseDetails.Controls.Add(this.lblHostName, 0, 0);
            this.tblLayout_DatabaseDetails.Controls.Add(this.txtHostName, 1, 0);
            this.tblLayout_DatabaseDetails.Controls.Add(this.lblUsername, 2, 0);
            this.tblLayout_DatabaseDetails.Controls.Add(this.txtUserName, 3, 0);
            this.tblLayout_DatabaseDetails.Controls.Add(this.lblPassword, 4, 0);
            this.tblLayout_DatabaseDetails.Controls.Add(this.txtPassword, 5, 0);
            this.tblLayout_DatabaseDetails.Controls.Add(this.btnConnectDatabase, 6, 0);
            this.tblLayout_DatabaseDetails.Location = new System.Drawing.Point(14, 13);
            this.tblLayout_DatabaseDetails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tblLayout_DatabaseDetails.Name = "tblLayout_DatabaseDetails";
            this.tblLayout_DatabaseDetails.RowCount = 1;
            this.tblLayout_DatabaseDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout_DatabaseDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tblLayout_DatabaseDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tblLayout_DatabaseDetails.Size = new System.Drawing.Size(1367, 36);
            this.tblLayout_DatabaseDetails.TabIndex = 0;
            // 
            // lblHostName
            // 
            this.lblHostName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHostName.AutoSize = true;
            this.lblHostName.Location = new System.Drawing.Point(4, 10);
            this.lblHostName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHostName.Name = "lblHostName";
            this.lblHostName.Size = new System.Drawing.Size(95, 15);
            this.lblHostName.TabIndex = 100;
            this.lblHostName.Text = "Host: ";
            // 
            // txtHostName
            // 
            this.txtHostName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHostName.Enabled = false;
            this.txtHostName.Location = new System.Drawing.Point(107, 6);
            this.txtHostName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.Size = new System.Drawing.Size(272, 23);
            this.txtHostName.TabIndex = 1;
            this.txtHostName.Text = "localhost";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(387, 10);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(95, 15);
            this.lblUsername.TabIndex = 101;
            this.lblUsername.Text = "User Name: ";
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.Location = new System.Drawing.Point(490, 6);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(272, 23);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.Text = "postgres";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(770, 10);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(95, 15);
            this.lblPassword.TabIndex = 102;
            this.lblPassword.Text = "Password: ";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(873, 6);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(272, 23);
            this.txtPassword.TabIndex = 3;
            // 
            // btnConnectDatabase
            // 
            this.btnConnectDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnectDatabase.BackColor = System.Drawing.Color.SteelBlue;
            this.btnConnectDatabase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnectDatabase.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnConnectDatabase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnConnectDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnectDatabase.ForeColor = System.Drawing.Color.White;
            this.btnConnectDatabase.Location = new System.Drawing.Point(1153, 3);
            this.btnConnectDatabase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConnectDatabase.Name = "btnConnectDatabase";
            this.btnConnectDatabase.Size = new System.Drawing.Size(210, 30);
            this.btnConnectDatabase.TabIndex = 4;
            this.btnConnectDatabase.Text = "Connect";
            this.btnConnectDatabase.UseVisualStyleBackColor = false;
            this.btnConnectDatabase.Click += new System.EventHandler(this.btnConnectDatabase_Click);
            // 
            // lblDatabaseName
            // 
            this.lblDatabaseName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDatabaseName.AutoSize = true;
            this.lblDatabaseName.Location = new System.Drawing.Point(4, 9);
            this.lblDatabaseName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatabaseName.Name = "lblDatabaseName";
            this.lblDatabaseName.Size = new System.Drawing.Size(183, 15);
            this.lblDatabaseName.TabIndex = 103;
            this.lblDatabaseName.Text = "Database Name: ";
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip.Location = new System.Drawing.Point(0, 644);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip.Size = new System.Drawing.Size(1395, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // tblLayout_QueryWindow
            // 
            this.tblLayout_QueryWindow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLayout_QueryWindow.ColumnCount = 1;
            this.tblLayout_QueryWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout_QueryWindow.Controls.Add(this.txtQueryEditor, 0, 0);
            this.tblLayout_QueryWindow.Location = new System.Drawing.Point(14, 121);
            this.tblLayout_QueryWindow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tblLayout_QueryWindow.Name = "tblLayout_QueryWindow";
            this.tblLayout_QueryWindow.RowCount = 1;
            this.tblLayout_QueryWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout_QueryWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tblLayout_QueryWindow.Size = new System.Drawing.Size(1367, 132);
            this.tblLayout_QueryWindow.TabIndex = 2;
            // 
            // txtQueryEditor
            // 
            this.txtQueryEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQueryEditor.Location = new System.Drawing.Point(4, 4);
            this.txtQueryEditor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtQueryEditor.Multiline = true;
            this.txtQueryEditor.Name = "txtQueryEditor";
            this.txtQueryEditor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQueryEditor.Size = new System.Drawing.Size(1359, 123);
            this.txtQueryEditor.TabIndex = 6;
            // 
            // tblLayout_ResultsWindow
            // 
            this.tblLayout_ResultsWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLayout_ResultsWindow.ColumnCount = 1;
            this.tblLayout_ResultsWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout_ResultsWindow.Controls.Add(this.lblResults, 0, 0);
            this.tblLayout_ResultsWindow.Controls.Add(this.dgViewResults, 0, 1);
            this.tblLayout_ResultsWindow.Location = new System.Drawing.Point(14, 255);
            this.tblLayout_ResultsWindow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tblLayout_ResultsWindow.Name = "tblLayout_ResultsWindow";
            this.tblLayout_ResultsWindow.RowCount = 2;
            this.tblLayout_ResultsWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tblLayout_ResultsWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout_ResultsWindow.Size = new System.Drawing.Size(1367, 385);
            this.tblLayout_ResultsWindow.TabIndex = 3;
            // 
            // lblResults
            // 
            this.lblResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Candara", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(4, 2);
            this.lblResults.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(1359, 18);
            this.lblResults.TabIndex = 105;
            this.lblResults.Text = "Results";
            // 
            // dgViewResults
            // 
            this.dgViewResults.AllowUserToAddRows = false;
            this.dgViewResults.AllowUserToDeleteRows = false;
            this.dgViewResults.AllowUserToOrderColumns = true;
            this.dgViewResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgViewResults.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewResults.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgViewResults.Location = new System.Drawing.Point(4, 25);
            this.dgViewResults.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgViewResults.Name = "dgViewResults";
            this.dgViewResults.Size = new System.Drawing.Size(1359, 357);
            this.dgViewResults.TabIndex = 106;
            // 
            // lblStatusStrip
            // 
            this.lblStatusStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatusStrip.AutoSize = true;
            this.lblStatusStrip.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusStrip.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblStatusStrip.Location = new System.Drawing.Point(14, 647);
            this.lblStatusStrip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusStrip.Name = "lblStatusStrip";
            this.lblStatusStrip.Size = new System.Drawing.Size(171, 15);
            this.lblStatusStrip.TabIndex = 400;
            this.lblStatusStrip.Text = "Welcome to Postgres Explorer";
            this.lblStatusStrip.Click += new System.EventHandler(this.lblStatusStrip_Click);
            // 
            // tblLayout_Database
            // 
            this.tblLayout_Database.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLayout_Database.ColumnCount = 4;
            this.tblLayout_Database.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.07154F));
            this.tblLayout_Database.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.92846F));
            this.tblLayout_Database.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 301F));
            this.tblLayout_Database.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 409F));
            this.tblLayout_Database.Controls.Add(this.label1, 0, 1);
            this.tblLayout_Database.Controls.Add(this.lblDatabaseName, 0, 0);
            this.tblLayout_Database.Controls.Add(this.cmbDatabase, 1, 0);
            this.tblLayout_Database.Controls.Add(this.btnExecuteQuery, 3, 1);
            this.tblLayout_Database.Location = new System.Drawing.Point(14, 50);
            this.tblLayout_Database.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tblLayout_Database.Name = "tblLayout_Database";
            this.tblLayout_Database.RowCount = 2;
            this.tblLayout_Database.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayout_Database.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayout_Database.Size = new System.Drawing.Size(1367, 69);
            this.tblLayout_Database.TabIndex = 401;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 15);
            this.label1.TabIndex = 106;
            this.label1.Text = "Query Editor";
            // 
            // cmbDatabase
            // 
            this.cmbDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDatabase.FormattingEnabled = true;
            this.cmbDatabase.Location = new System.Drawing.Point(195, 6);
            this.cmbDatabase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbDatabase.Name = "cmbDatabase";
            this.cmbDatabase.Size = new System.Drawing.Size(457, 23);
            this.cmbDatabase.TabIndex = 5;
            // 
            // btnExecuteQuery
            // 
            this.btnExecuteQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecuteQuery.BackColor = System.Drawing.Color.Wheat;
            this.btnExecuteQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExecuteQuery.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.btnExecuteQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecuteQuery.ForeColor = System.Drawing.Color.DarkRed;
            this.btnExecuteQuery.Location = new System.Drawing.Point(961, 37);
            this.btnExecuteQuery.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExecuteQuery.Name = "btnExecuteQuery";
            this.btnExecuteQuery.Size = new System.Drawing.Size(402, 28);
            this.btnExecuteQuery.TabIndex = 105;
            this.btnExecuteQuery.Text = "Execute Query";
            this.btnExecuteQuery.UseVisualStyleBackColor = false;
            this.btnExecuteQuery.Click += new System.EventHandler(this.btnExecuteQuery_Click);
            // 
            // picMandatory
            // 
            this.picMandatory.Image = global::CustomPostgresExplorer.Properties.Resources.asterisk;
            this.picMandatory.ImageLocation = "";
            this.picMandatory.Location = new System.Drawing.Point(50, 21);
            this.picMandatory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picMandatory.Name = "picMandatory";
            this.picMandatory.Size = new System.Drawing.Size(12, 11);
            this.picMandatory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMandatory.TabIndex = 402;
            this.picMandatory.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CustomPostgresExplorer.Properties.Resources.asterisk;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(465, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(12, 11);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 403;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CustomPostgresExplorer.Properties.Resources.asterisk;
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(845, 20);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(12, 11);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 404;
            this.pictureBox2.TabStop = false;
            // 
            // picBxPassControl
            // 
            this.picBxPassControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBxPassControl.Image = global::CustomPostgresExplorer.Properties.Resources.eye_show;
            this.picBxPassControl.Location = new System.Drawing.Point(1138, 20);
            this.picBxPassControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picBxPassControl.Name = "picBxPassControl";
            this.picBxPassControl.Size = new System.Drawing.Size(20, 20);
            this.picBxPassControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBxPassControl.TabIndex = 405;
            this.picBxPassControl.TabStop = false;
            this.toolTip.SetToolTip(this.picBxPassControl, "Click to show/hide Password");
            this.picBxPassControl.Click += new System.EventHandler(this.picBxPassControl_Click);
            // 
            // PostgresExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1395, 666);
            this.Controls.Add(this.picBxPassControl);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picMandatory);
            this.Controls.Add(this.tblLayout_Database);
            this.Controls.Add(this.lblStatusStrip);
            this.Controls.Add(this.tblLayout_ResultsWindow);
            this.Controls.Add(this.tblLayout_QueryWindow);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tblLayout_DatabaseDetails);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1154, 705);
            this.Name = "PostgresExplorer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Postgres Explorer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PostgresExplorer_KeyDown);
            this.tblLayout_DatabaseDetails.ResumeLayout(false);
            this.tblLayout_DatabaseDetails.PerformLayout();
            this.tblLayout_QueryWindow.ResumeLayout(false);
            this.tblLayout_QueryWindow.PerformLayout();
            this.tblLayout_ResultsWindow.ResumeLayout(false);
            this.tblLayout_ResultsWindow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewResults)).EndInit();
            this.tblLayout_Database.ResumeLayout(false);
            this.tblLayout_Database.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMandatory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxPassControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayout_DatabaseDetails;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Label lblHostName;
        private System.Windows.Forms.TextBox txtHostName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblDatabaseName;
        private System.Windows.Forms.TableLayoutPanel tblLayout_QueryWindow;
        private System.Windows.Forms.Button btnConnectDatabase;
        private System.Windows.Forms.TextBox txtQueryEditor;
        private System.Windows.Forms.TableLayoutPanel tblLayout_ResultsWindow;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.DataGridView dgViewResults;
        private System.Windows.Forms.Label lblStatusStrip;
        private System.Windows.Forms.TableLayoutPanel tblLayout_Database;
        private System.Windows.Forms.ComboBox cmbDatabase;
        private System.Windows.Forms.Button btnExecuteQuery;
        private System.Windows.Forms.PictureBox picMandatory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picBxPassControl;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label1;
    }
}

