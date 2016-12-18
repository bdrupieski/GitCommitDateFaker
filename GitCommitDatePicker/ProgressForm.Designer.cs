namespace GitCommitDatePicker
{
    partial class ProgressForm
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
            this.labelHoldOn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelHoldOn
            // 
            this.labelHoldOn.AutoSize = true;
            this.labelHoldOn.Location = new System.Drawing.Point(35, 11);
            this.labelHoldOn.Name = "labelHoldOn";
            this.labelHoldOn.Size = new System.Drawing.Size(53, 13);
            this.labelHoldOn.TabIndex = 0;
            this.labelHoldOn.Text = "Hold on...";
            this.labelHoldOn.UseWaitCursor = true;
            // 
            // ProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 37);
            this.ControlBox = false;
            this.Controls.Add(this.labelHoldOn);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(136, 53);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(136, 53);
            this.Name = "ProgressForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHoldOn;
    }
}