using System.Windows.Forms;

namespace GitCommitDatePicker
{
    public partial class RebaseLogForm : Form
    {
        public RebaseLogForm()
        {
            InitializeComponent();
        }

        public RebaseLogForm(string logText) : this()
        {
            richTextBoxRebaseLog.Text = logText;
        }
    }
}
