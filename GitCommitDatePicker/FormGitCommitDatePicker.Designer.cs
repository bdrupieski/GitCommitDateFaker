namespace GitCommitDatePicker
{
    partial class FormGitCommitDatePicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGitCommitDatePicker));
            this.textBoxRepoPath = new System.Windows.Forms.TextBox();
            this.buttonPickRepo = new System.Windows.Forms.Button();
            this.labelRepoPath = new System.Windows.Forms.Label();
            this.labelBranch = new System.Windows.Forms.Label();
            this.comboBoxBranches = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelCommits = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRebase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxRepoPath
            // 
            this.textBoxRepoPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRepoPath.Enabled = false;
            this.textBoxRepoPath.Location = new System.Drawing.Point(103, 14);
            this.textBoxRepoPath.Name = "textBoxRepoPath";
            this.textBoxRepoPath.Size = new System.Drawing.Size(300, 20);
            this.textBoxRepoPath.TabIndex = 0;
            // 
            // buttonPickRepo
            // 
            this.buttonPickRepo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPickRepo.Location = new System.Drawing.Point(409, 12);
            this.buttonPickRepo.Name = "buttonPickRepo";
            this.buttonPickRepo.Size = new System.Drawing.Size(115, 23);
            this.buttonPickRepo.TabIndex = 1;
            this.buttonPickRepo.Text = "Choose repository...";
            this.buttonPickRepo.UseVisualStyleBackColor = true;
            this.buttonPickRepo.Click += new System.EventHandler(this.buttonPickRepo_Click);
            // 
            // labelRepoPath
            // 
            this.labelRepoPath.AutoSize = true;
            this.labelRepoPath.Location = new System.Drawing.Point(12, 17);
            this.labelRepoPath.Name = "labelRepoPath";
            this.labelRepoPath.Size = new System.Drawing.Size(85, 13);
            this.labelRepoPath.TabIndex = 2;
            this.labelRepoPath.Text = "Repository Path:";
            // 
            // labelBranch
            // 
            this.labelBranch.AutoSize = true;
            this.labelBranch.Location = new System.Drawing.Point(53, 45);
            this.labelBranch.Name = "labelBranch";
            this.labelBranch.Size = new System.Drawing.Size(44, 13);
            this.labelBranch.TabIndex = 3;
            this.labelBranch.Text = "Branch:";
            // 
            // comboBoxBranches
            // 
            this.comboBoxBranches.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxBranches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBranches.Enabled = false;
            this.comboBoxBranches.FormattingEnabled = true;
            this.comboBoxBranches.Location = new System.Drawing.Point(103, 42);
            this.comboBoxBranches.Name = "comboBoxBranches";
            this.comboBoxBranches.Size = new System.Drawing.Size(300, 21);
            this.comboBoxBranches.TabIndex = 4;
            this.comboBoxBranches.SelectedIndexChanged += new System.EventHandler(this.comboBoxBranches_SelectedIndexChanged);
            // 
            // tableLayoutPanelCommits
            // 
            this.tableLayoutPanelCommits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelCommits.AutoScroll = true;
            this.tableLayoutPanelCommits.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelCommits.ColumnCount = 1;
            this.tableLayoutPanelCommits.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelCommits.Location = new System.Drawing.Point(12, 69);
            this.tableLayoutPanelCommits.Name = "tableLayoutPanelCommits";
            this.tableLayoutPanelCommits.RowCount = 1;
            this.tableLayoutPanelCommits.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelCommits.Size = new System.Drawing.Size(512, 510);
            this.tableLayoutPanelCommits.TabIndex = 5;
            // 
            // buttonRebase
            // 
            this.buttonRebase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRebase.Enabled = false;
            this.buttonRebase.Location = new System.Drawing.Point(409, 40);
            this.buttonRebase.Name = "buttonRebase";
            this.buttonRebase.Size = new System.Drawing.Size(115, 23);
            this.buttonRebase.TabIndex = 6;
            this.buttonRebase.Text = "Rebase";
            this.buttonRebase.UseVisualStyleBackColor = true;
            this.buttonRebase.Click += new System.EventHandler(this.buttonRebase_Click);
            // 
            // FormGitCommitDatePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 591);
            this.Controls.Add(this.buttonRebase);
            this.Controls.Add(this.tableLayoutPanelCommits);
            this.Controls.Add(this.comboBoxBranches);
            this.Controls.Add(this.labelBranch);
            this.Controls.Add(this.labelRepoPath);
            this.Controls.Add(this.buttonPickRepo);
            this.Controls.Add(this.textBoxRepoPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(470, 435);
            this.Name = "FormGitCommitDatePicker";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Git Commit Date Picker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRepoPath;
        private System.Windows.Forms.Button buttonPickRepo;
        private System.Windows.Forms.Label labelRepoPath;
        private System.Windows.Forms.Label labelBranch;
        private System.Windows.Forms.ComboBox comboBoxBranches;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCommits;
        private System.Windows.Forms.Button buttonRebase;
    }
}

