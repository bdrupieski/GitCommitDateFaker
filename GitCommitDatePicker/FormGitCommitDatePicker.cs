using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using LibGit2Sharp;
using MoreLinq;

namespace GitCommitDatePicker
{
    public partial class FormGitCommitDatePicker : Form
    {
        private List<CommitDatePickerUserControl> _datePickers;

        public FormGitCommitDatePicker()
        {
            InitializeComponent();
        }

        private void buttonPickRepo_Click(object sender, EventArgs e)
        {
            var folderBrowser = new FolderBrowserDialog
            {
                ShowNewFolderButton = false,
                Description = @"Select a folder containing a git repository",
            };

            var result = folderBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                var repoPath = folderBrowser.SelectedPath;

                var isValidGitRepository = Repository.IsValid(repoPath);

                if (!isValidGitRepository)
                {
                    MessageBox.Show($@"{repoPath} is not a valid git repository.", @"Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var repo = new Repository(repoPath);
                    var branchNames = repo.Branches.Select(x => x.CanonicalName).ToList();
                    textBoxRepoPath.Text = repoPath;
                    
                    comboBoxBranches.Items.Clear();
                    foreach (var branchName in branchNames)
                    {
                        comboBoxBranches.Items.Add(branchName);
                    }

                    if (branchNames.Any())
                    {
                        comboBoxBranches.Enabled = true;
                        comboBoxBranches.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show($@"Couldn't find any branches for {repoPath}.", @"Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void comboBoxBranches_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBranches.SelectedIndex < 0 || string.IsNullOrEmpty(textBoxRepoPath.Text))
            {
                return;
            }
            
            BuildDatePickerList();
        }

        private void buttonRebase_Click(object sender, EventArgs e)
        {
            var lastModifiedPicker = _datePickers.Last(x => x.IsDateModified());
            var pickersUntilLastModified = _datePickers.TakeUntil(x => x == lastModifiedPicker);
            var dates = pickersUntilLastModified.Select(x => new DateTimeOffset(x.SelectedDateTime)).Reverse().ToList();

            var progressForm = new ProgressForm();
            var worker = new BackgroundWorker();
            worker.DoWork += (o, args) =>
            {
                args.Result = RewriteDates(textBoxRepoPath.Text, dates);
            };
            worker.RunWorkerCompleted += (o, args) =>
            {
                progressForm.Close();
                var logForm = new RebaseLogForm((string)args.Result);
                logForm.ShowDialog();
                BuildDatePickerList();
            };
            worker.RunWorkerAsync();
            progressForm.ShowDialog();
        }

        private Repository GetCurrentRepository() => new Repository(textBoxRepoPath.Text);
        private Branch GetCurrentBranch() => GetCurrentRepository().Branches[(string)comboBoxBranches.SelectedItem];

        private void BuildDatePickerList()
        {
            var branch = GetCurrentBranch();
            var commits = branch.Commits.Take(100).ToList();

            _datePickers = new List<CommitDatePickerUserControl>();
            tableLayoutPanelCommits.Controls.Clear();
            foreach (var commit in commits)
            {
                var commitDatePicker = new CommitDatePickerUserControl(commit)
                {
                    Dock = DockStyle.Top
                };
                commitDatePicker.RegisterEventDateChanged(DateChanged);
                _datePickers.Add(commitDatePicker);
                tableLayoutPanelCommits.Controls.Add(commitDatePicker);
            }
        }

        private void DateChanged(object sender, EventArgs e)
        {
            buttonRebase.Enabled = _datePickers.Any(x => x.IsDateModified());
        }

        private static string RewriteDates(string repoDirectoryPath, List<DateTimeOffset> dates)
        {
            Process cmd = new Process
            {
                StartInfo =
                {
                    FileName = "cmd.exe",
                    WorkingDirectory = repoDirectoryPath,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    UseShellExecute = false,
                }
            };
            cmd.Start();

            var commands = GenerateCommands(dates);

            foreach (var command in commands)
            {
                cmd.StandardInput.WriteLine(command);
                cmd.StandardInput.Flush();
            }

            cmd.StandardInput.Close();
            cmd.WaitForExit();
            return cmd.StandardOutput.ReadToEnd();
        }

        private static List<string> GenerateCommands(List<DateTimeOffset> dates)
        {
            var commands = new List<string>
            {
                "SET PATH=%PATH%;" + Directory.GetCurrentDirectory(),
                "SET GIT_SEQUENCE_EDITOR=SequenceEditor.exe",
                $"git rebase -i HEAD~{dates.Count}",
                "SET EDITOR=touch"
            };

            foreach (var date in dates)
            {
                var iso8601Date = date.ToString("o");

                commands.Add($"SET GIT_COMMITTER_DATE=\"{iso8601Date}\"");
                commands.Add($"git commit --amend --date \"{iso8601Date}\"");
                commands.Add("git rebase --continue");
            }

            return commands;
        }
    }
}
