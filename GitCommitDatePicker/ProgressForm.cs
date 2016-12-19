using System.Windows.Forms;

namespace GitCommitDatePicker
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
