namespace GitCommitDatePicker
{
    partial class RebaseLogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RebaseLogForm));
            this.labelWhatHappened = new System.Windows.Forms.Label();
            this.richTextBoxRebaseLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // labelWhatHappened
            // 
            this.labelWhatHappened.AutoSize = true;
            this.labelWhatHappened.Location = new System.Drawing.Point(12, 9);
            this.labelWhatHappened.Name = "labelWhatHappened";
            this.labelWhatHappened.Size = new System.Drawing.Size(117, 13);
            this.labelWhatHappened.TabIndex = 0;
            this.labelWhatHappened.Text = "Here\'s what happened:";
            // 
            // richTextBoxRebaseLog
            // 
            this.richTextBoxRebaseLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxRebaseLog.Location = new System.Drawing.Point(12, 25);
            this.richTextBoxRebaseLog.Name = "richTextBoxRebaseLog";
            this.richTextBoxRebaseLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxRebaseLog.Size = new System.Drawing.Size(559, 286);
            this.richTextBoxRebaseLog.TabIndex = 1;
            this.richTextBoxRebaseLog.Text = "";
            // 
            // RebaseLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 323);
            this.Controls.Add(this.richTextBoxRebaseLog);
            this.Controls.Add(this.labelWhatHappened);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RebaseLogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rebase Log";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWhatHappened;
        private System.Windows.Forms.RichTextBox richTextBoxRebaseLog;
    }
}