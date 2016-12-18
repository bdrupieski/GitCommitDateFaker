using System;
using System.Drawing;
using System.Windows.Forms;
using LibGit2Sharp;

namespace GitCommitDatePicker
{
    public partial class CommitDatePickerUserControl : UserControl
    {
        private readonly DateTimeOffset _originalCommitDateTimeOffset;

        public CommitDatePickerUserControl()
        {
            InitializeComponent();
        }

        public CommitDatePickerUserControl(Commit commit) : this()
        {
            _originalCommitDateTimeOffset = commit.Committer.When;
            dateTimePickerCommitDateTime.Value = _originalCommitDateTimeOffset.DateTime;
            labelCommitMessage.Text = commit.Message;
        }

        public DateTime SelectedDateTime => dateTimePickerCommitDateTime.Value;
        public bool IsDateModified() => _originalCommitDateTimeOffset.DateTime != dateTimePickerCommitDateTime.Value;

        public void RegisterEventDateChanged(EventHandler eventHandler)
        {
            dateTimePickerCommitDateTime.ValueChanged += eventHandler;
        }

        private void dateTimePickerCommitDateTime_ValueChanged(object sender, EventArgs e)
        {
            if (IsDateModified())
            {
                buttonResetDateTime.Enabled = true;
                BackColor = Color.LightGoldenrodYellow;
            }
            else
            {
                buttonResetDateTime.Enabled = false;
                BackColor = SystemColors.Control;
            }
        }

        private void buttonResetDateTime_Click(object sender, EventArgs e)
        {
            dateTimePickerCommitDateTime.Value = _originalCommitDateTimeOffset.DateTime;
        }
    }
}
