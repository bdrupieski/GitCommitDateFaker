using System.Windows.Forms;

namespace GitCommitDateFaker
{
    public partial class ProgressForm : Form
    {
        public ProgressForm()
        {
            InitializeComponent();
        }

        public void ShowProgress(int percent)
        {
            labelPercent.Text = percent + @"%";
        }
    }
}
