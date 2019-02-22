namespace akozak_asql_a3
{
    partial class mainForm
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
            this.tbSourceConn = new System.Windows.Forms.TextBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.tbDestinationConn = new System.Windows.Forms.TextBox();
            this.btnTestConn = new System.Windows.Forms.Button();
            this.lbSource = new System.Windows.Forms.ListBox();
            this.lbDest = new System.Windows.Forms.ListBox();
            this.btnCopyAll = new System.Windows.Forms.Button();
            this.btnCopySelected = new System.Windows.Forms.Button();
            this.lblSourceName = new System.Windows.Forms.Label();
            this.lblDestName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbSourceConn
            // 
            this.tbSourceConn.Location = new System.Drawing.Point(15, 31);
            this.tbSourceConn.Name = "tbSourceConn";
            this.tbSourceConn.Size = new System.Drawing.Size(339, 20);
            this.tbSourceConn.TabIndex = 0;
            this.tbSourceConn.Text = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial " +
    "Catalog=Northwind;Data Source=ALEXDESKTOP\\SQLEXPRESS";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(12, 15);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(131, 13);
            this.lblSource.TabIndex = 1;
            this.lblSource.Text = "Source Connection String:";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(446, 15);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(150, 13);
            this.lblDestination.TabIndex = 3;
            this.lblDestination.Text = "Destination Connection String:";
            // 
            // tbDestinationConn
            // 
            this.tbDestinationConn.Location = new System.Drawing.Point(449, 31);
            this.tbDestinationConn.Name = "tbDestinationConn";
            this.tbDestinationConn.Size = new System.Drawing.Size(339, 20);
            this.tbDestinationConn.TabIndex = 2;
            this.tbDestinationConn.Text = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial " +
    "Catalog=NotNorthwind;Data Source=ALEXDESKTOP\\SQLEXPRESS";
            // 
            // btnTestConn
            // 
            this.btnTestConn.Location = new System.Drawing.Point(360, 15);
            this.btnTestConn.Name = "btnTestConn";
            this.btnTestConn.Size = new System.Drawing.Size(83, 37);
            this.btnTestConn.TabIndex = 4;
            this.btnTestConn.Text = "Test Connection";
            this.btnTestConn.UseVisualStyleBackColor = true;
            this.btnTestConn.Click += new System.EventHandler(this.btnTestConn_Click);
            // 
            // lbSource
            // 
            this.lbSource.FormattingEnabled = true;
            this.lbSource.Location = new System.Drawing.Point(15, 83);
            this.lbSource.Name = "lbSource";
            this.lbSource.Size = new System.Drawing.Size(339, 355);
            this.lbSource.TabIndex = 5;
            // 
            // lbDest
            // 
            this.lbDest.FormattingEnabled = true;
            this.lbDest.Location = new System.Drawing.Point(449, 83);
            this.lbDest.Name = "lbDest";
            this.lbDest.Size = new System.Drawing.Size(339, 355);
            this.lbDest.TabIndex = 6;
            // 
            // btnCopyAll
            // 
            this.btnCopyAll.Location = new System.Drawing.Point(360, 200);
            this.btnCopyAll.Name = "btnCopyAll";
            this.btnCopyAll.Size = new System.Drawing.Size(83, 41);
            this.btnCopyAll.TabIndex = 7;
            this.btnCopyAll.Text = "Copy All";
            this.btnCopyAll.UseVisualStyleBackColor = true;
            this.btnCopyAll.Click += new System.EventHandler(this.btnCopyAll_Click);
            // 
            // btnCopySelected
            // 
            this.btnCopySelected.Location = new System.Drawing.Point(360, 247);
            this.btnCopySelected.Name = "btnCopySelected";
            this.btnCopySelected.Size = new System.Drawing.Size(83, 41);
            this.btnCopySelected.TabIndex = 8;
            this.btnCopySelected.Text = "Copy Selected";
            this.btnCopySelected.UseVisualStyleBackColor = true;
            this.btnCopySelected.Click += new System.EventHandler(this.btnCopySelected_Click);
            // 
            // lblSourceName
            // 
            this.lblSourceName.AutoSize = true;
            this.lblSourceName.Location = new System.Drawing.Point(12, 67);
            this.lblSourceName.Name = "lblSourceName";
            this.lblSourceName.Size = new System.Drawing.Size(93, 13);
            this.lblSourceName.TabIndex = 9;
            this.lblSourceName.Text = "Source Database:";
            // 
            // lblDestName
            // 
            this.lblDestName.AutoSize = true;
            this.lblDestName.Location = new System.Drawing.Point(446, 67);
            this.lblDestName.Name = "lblDestName";
            this.lblDestName.Size = new System.Drawing.Size(112, 13);
            this.lblDestName.TabIndex = 10;
            this.lblDestName.Text = "Destination Database:";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDestName);
            this.Controls.Add(this.lblSourceName);
            this.Controls.Add(this.btnCopySelected);
            this.Controls.Add(this.btnCopyAll);
            this.Controls.Add(this.lbDest);
            this.Controls.Add(this.lbSource);
            this.Controls.Add(this.btnTestConn);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.tbDestinationConn);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.tbSourceConn);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSourceConn;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.TextBox tbDestinationConn;
        private System.Windows.Forms.Button btnTestConn;
        private System.Windows.Forms.ListBox lbSource;
        private System.Windows.Forms.ListBox lbDest;
        private System.Windows.Forms.Button btnCopyAll;
        private System.Windows.Forms.Button btnCopySelected;
        private System.Windows.Forms.Label lblSourceName;
        private System.Windows.Forms.Label lblDestName;
    }
}

