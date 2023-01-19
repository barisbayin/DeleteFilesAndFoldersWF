namespace DeleteFilesAndFolders
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnChoosePath = new System.Windows.Forms.Button();
            this.tbxPath = new System.Windows.Forms.TextBox();
            this.chckManuelChoose = new System.Windows.Forms.CheckBox();
            this.lbxContainsFileName = new System.Windows.Forms.ListBox();
            this.lbxContainsFolderName = new System.Windows.Forms.ListBox();
            this.lbxResults = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnGetFiles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbxFolders = new System.Windows.Forms.ListBox();
            this.btnDeleteFilePatern = new System.Windows.Forms.Button();
            this.tbxFilePatern = new System.Windows.Forms.TextBox();
            this.btnAddFilePatern = new System.Windows.Forms.Button();
            this.btnAddFolderPatern = new System.Windows.Forms.Button();
            this.tbxFolderPatern = new System.Windows.Forms.TextBox();
            this.btnDeleteFolderPatern = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChoosePath
            // 
            this.btnChoosePath.Location = new System.Drawing.Point(53, 12);
            this.btnChoosePath.Name = "btnChoosePath";
            this.btnChoosePath.Size = new System.Drawing.Size(139, 38);
            this.btnChoosePath.TabIndex = 0;
            this.btnChoosePath.Text = "Choose Directory";
            this.btnChoosePath.UseVisualStyleBackColor = true;
            this.btnChoosePath.Click += new System.EventHandler(this.btnChoosePath_Click);
            // 
            // tbxPath
            // 
            this.tbxPath.Enabled = false;
            this.tbxPath.Location = new System.Drawing.Point(129, 64);
            this.tbxPath.Name = "tbxPath";
            this.tbxPath.Size = new System.Drawing.Size(640, 20);
            this.tbxPath.TabIndex = 1;
            // 
            // chckManuelChoose
            // 
            this.chckManuelChoose.AutoSize = true;
            this.chckManuelChoose.Location = new System.Drawing.Point(53, 67);
            this.chckManuelChoose.Name = "chckManuelChoose";
            this.chckManuelChoose.Size = new System.Drawing.Size(61, 17);
            this.chckManuelChoose.TabIndex = 2;
            this.chckManuelChoose.Text = "Manuel";
            this.chckManuelChoose.UseVisualStyleBackColor = true;
            this.chckManuelChoose.CheckedChanged += new System.EventHandler(this.chckManuelChoose_CheckedChanged);
            // 
            // lbxContainsFileName
            // 
            this.lbxContainsFileName.FormattingEnabled = true;
            this.lbxContainsFileName.Items.AddRange(new object[] {
            "Blacklist",
            "Discord",
            "Downloads",
            "History",
            "Steam",
            "FileGrabber",
            "Cookies"});
            this.lbxContainsFileName.Location = new System.Drawing.Point(53, 122);
            this.lbxContainsFileName.Name = "lbxContainsFileName";
            this.lbxContainsFileName.Size = new System.Drawing.Size(150, 342);
            this.lbxContainsFileName.TabIndex = 3;
            this.lbxContainsFileName.SelectedIndexChanged += new System.EventHandler(this.lbxContainsFileName_SelectedIndexChanged);
            this.lbxContainsFileName.SelectedValueChanged += new System.EventHandler(this.lbxContainsFileName_SelectedValueChanged);
            // 
            // lbxContainsFolderName
            // 
            this.lbxContainsFolderName.FormattingEnabled = true;
            this.lbxContainsFolderName.Items.AddRange(new object[] {
            "InstalledSoftware",
            "ProcessList",
            "Screenshot",
            "DomainDetects",
            "domain detect",
            "InstalledBrowsers"});
            this.lbxContainsFolderName.Location = new System.Drawing.Point(246, 122);
            this.lbxContainsFolderName.Name = "lbxContainsFolderName";
            this.lbxContainsFolderName.Size = new System.Drawing.Size(150, 342);
            this.lbxContainsFolderName.TabIndex = 4;
            this.lbxContainsFolderName.SelectedIndexChanged += new System.EventHandler(this.lbxContainsFolderName_SelectedIndexChanged);
            this.lbxContainsFolderName.SelectedValueChanged += new System.EventHandler(this.lbxContainsFolderName_SelectedValueChanged);
            // 
            // lbxResults
            // 
            this.lbxResults.FormattingEnabled = true;
            this.lbxResults.Location = new System.Drawing.Point(454, 122);
            this.lbxResults.Name = "lbxResults";
            this.lbxResults.Size = new System.Drawing.Size(315, 251);
            this.lbxResults.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(619, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 38);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete Files";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(237, 12);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(139, 38);
            this.btnClearAll.TabIndex = 8;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnGetFiles
            // 
            this.btnGetFiles.Location = new System.Drawing.Point(429, 12);
            this.btnGetFiles.Name = "btnGetFiles";
            this.btnGetFiles.Size = new System.Drawing.Size(139, 38);
            this.btnGetFiles.TabIndex = 9;
            this.btnGetFiles.Text = "Get Files/Folders";
            this.btnGetFiles.UseVisualStyleBackColor = true;
            this.btnGetFiles.Click += new System.EventHandler(this.btnGetFiles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "File Paterns";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Folder Paterns";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Files";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Folders";
            // 
            // lbxFolders
            // 
            this.lbxFolders.FormattingEnabled = true;
            this.lbxFolders.Location = new System.Drawing.Point(454, 408);
            this.lbxFolders.Name = "lbxFolders";
            this.lbxFolders.Size = new System.Drawing.Size(315, 121);
            this.lbxFolders.TabIndex = 13;
            // 
            // btnDeleteFilePatern
            // 
            this.btnDeleteFilePatern.Location = new System.Drawing.Point(53, 499);
            this.btnDeleteFilePatern.Name = "btnDeleteFilePatern";
            this.btnDeleteFilePatern.Size = new System.Drawing.Size(70, 30);
            this.btnDeleteFilePatern.TabIndex = 15;
            this.btnDeleteFilePatern.Text = "-";
            this.btnDeleteFilePatern.UseVisualStyleBackColor = true;
            this.btnDeleteFilePatern.Click += new System.EventHandler(this.btnDeleteFilePatern_Click);
            // 
            // tbxFilePatern
            // 
            this.tbxFilePatern.Location = new System.Drawing.Point(53, 473);
            this.tbxFilePatern.Name = "tbxFilePatern";
            this.tbxFilePatern.Size = new System.Drawing.Size(150, 20);
            this.tbxFilePatern.TabIndex = 16;
            // 
            // btnAddFilePatern
            // 
            this.btnAddFilePatern.Location = new System.Drawing.Point(133, 499);
            this.btnAddFilePatern.Name = "btnAddFilePatern";
            this.btnAddFilePatern.Size = new System.Drawing.Size(70, 30);
            this.btnAddFilePatern.TabIndex = 17;
            this.btnAddFilePatern.Text = "+";
            this.btnAddFilePatern.UseVisualStyleBackColor = true;
            this.btnAddFilePatern.Click += new System.EventHandler(this.btnAddFilePatern_Click);
            // 
            // btnAddFolderPatern
            // 
            this.btnAddFolderPatern.Location = new System.Drawing.Point(326, 499);
            this.btnAddFolderPatern.Name = "btnAddFolderPatern";
            this.btnAddFolderPatern.Size = new System.Drawing.Size(70, 30);
            this.btnAddFolderPatern.TabIndex = 20;
            this.btnAddFolderPatern.Text = "+";
            this.btnAddFolderPatern.UseVisualStyleBackColor = true;
            this.btnAddFolderPatern.Click += new System.EventHandler(this.btnAddFolderPatern_Click);
            // 
            // tbxFolderPatern
            // 
            this.tbxFolderPatern.Location = new System.Drawing.Point(246, 473);
            this.tbxFolderPatern.Name = "tbxFolderPatern";
            this.tbxFolderPatern.Size = new System.Drawing.Size(150, 20);
            this.tbxFolderPatern.TabIndex = 19;
            // 
            // btnDeleteFolderPatern
            // 
            this.btnDeleteFolderPatern.Location = new System.Drawing.Point(246, 499);
            this.btnDeleteFolderPatern.Name = "btnDeleteFolderPatern";
            this.btnDeleteFolderPatern.Size = new System.Drawing.Size(70, 30);
            this.btnDeleteFolderPatern.TabIndex = 18;
            this.btnDeleteFolderPatern.Text = "-";
            this.btnDeleteFolderPatern.UseVisualStyleBackColor = true;
            this.btnDeleteFolderPatern.Click += new System.EventHandler(this.btnDeleteFolderPatern_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 561);
            this.Controls.Add(this.btnAddFolderPatern);
            this.Controls.Add(this.tbxFolderPatern);
            this.Controls.Add(this.btnDeleteFolderPatern);
            this.Controls.Add(this.btnAddFilePatern);
            this.Controls.Add(this.tbxFilePatern);
            this.Controls.Add(this.btnDeleteFilePatern);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbxFolders);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetFiles);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbxResults);
            this.Controls.Add(this.lbxContainsFolderName);
            this.Controls.Add(this.lbxContainsFileName);
            this.Controls.Add(this.chckManuelChoose);
            this.Controls.Add(this.tbxPath);
            this.Controls.Add(this.btnChoosePath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Delete Files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChoosePath;
        private System.Windows.Forms.TextBox tbxPath;
        private System.Windows.Forms.CheckBox chckManuelChoose;
        private System.Windows.Forms.ListBox lbxContainsFileName;
        private System.Windows.Forms.ListBox lbxContainsFolderName;
        private System.Windows.Forms.ListBox lbxResults;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnGetFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbxFolders;
        private System.Windows.Forms.Button btnDeleteFilePatern;
        private System.Windows.Forms.TextBox tbxFilePatern;
        private System.Windows.Forms.Button btnAddFilePatern;
        private System.Windows.Forms.Button btnAddFolderPatern;
        private System.Windows.Forms.TextBox tbxFolderPatern;
        private System.Windows.Forms.Button btnDeleteFolderPatern;
    }
}

