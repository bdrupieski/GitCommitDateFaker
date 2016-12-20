using System.Windows.Forms;

namespace GitCommitDateFaker
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
