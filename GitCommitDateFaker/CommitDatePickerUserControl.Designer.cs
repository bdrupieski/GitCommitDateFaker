namespace GitCommitDateFaker
{
    partial class CommitDatePickerUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCommitMessage = new System.Windows.Forms.Label();
            this.dateTimePickerCommitDateTime = new System.Windows.Forms.DateTimePicker();
            this.buttonResetDateTime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCommitMessage
            // 
            this.labelCommitMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCommitMessage.AutoEllipsis = true;
            this.labelCommitMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCommitMessage.Location = new System.Drawing.Point(3, 11);
            this.labelCommitMessage.Name = "labelCommitMessage";
            this.labelCommitMessage.Size = new System.Drawing.Size(172, 19);
            this.labelCommitMessage.TabIndex = 0;
            this.labelCommitMessage.Text = "label_COMMIT_MESSAGE";
            // 
            // dateTimePickerCommitDateTime
            // 
            this.dateTimePickerCommitDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerCommitDateTime.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            this.dateTimePickerCommitDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerCommitDateTime.Location = new System.Drawing.Point(181, 10);
            this.dateTimePickerCommitDateTime.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerCommitDateTime.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerCommitDateTime.Name = "dateTimePickerCommitDateTime";
            this.dateTimePickerCommitDateTime.ShowUpDown = true;
            this.dateTimePickerCommitDateTime.Size = new System.Drawing.Size(179, 20);
            this.dateTimePickerCommitDateTime.TabIndex = 1;
            this.dateTimePickerCommitDateTime.ValueChanged += new System.EventHandler(this.dateTimePickerCommitDateTime_ValueChanged);
            // 
            // buttonResetDateTime
            // 
            this.buttonResetDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonResetDateTime.Enabled = false;
            this.buttonResetDateTime.Location = new System.Drawing.Point(366, 9);
            this.buttonResetDateTime.Name = "buttonResetDateTime";
            this.buttonResetDateTime.Size = new System.Drawing.Size(50, 23);
            this.buttonResetDateTime.TabIndex = 2;
            this.buttonResetDateTime.Text = "Reset";
            this.buttonResetDateTime.UseVisualStyleBackColor = true;
            this.buttonResetDateTime.Click += new System.EventHandler(this.buttonResetDateTime_Click);
            // 
            // CommitDatePickerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.buttonResetDateTime);
            this.Controls.Add(this.dateTimePickerCommitDateTime);
            this.Controls.Add(this.labelCommitMessage);
            this.Name = "CommitDatePickerUserControl";
            this.Size = new System.Drawing.Size(419, 42);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonResetDateTime;
        private System.Windows.Forms.Label labelCommitMessage;
        private System.Windows.Forms.DateTimePicker dateTimePickerCommitDateTime;
    }
}
