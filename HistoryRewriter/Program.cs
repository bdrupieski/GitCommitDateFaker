using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace HistoryRewriter
{
    class Program
    {
        static void Main(string[] args)
        {
            var repoPath = @"C:\Users\brian\Desktop\TestRepo";
            var dates = new List<DateTimeOffset>
            {
                new DateTimeOffset(new DateTime(2016, 12, 20, 5, 55, 43)),
                new DateTimeOffset(new DateTime(2016, 12, 21, 6, 55, 43)),
                new DateTimeOffset(new DateTime(2016, 12, 24, 3, 34, 43)),
            };

            RewriteDates(repoPath, dates);
        }

        private static void RewriteDates(string repoDirectoryPath, List<DateTimeOffset> dates)
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

            cmd.StandardInput.WriteLine("SET PATH=%PATH%;" + Directory.GetCurrentDirectory());
            cmd.StandardInput.Flush();
            cmd.StandardInput.WriteLine("SET GIT_SEQUENCE_EDITOR=SequenceEditor.exe");
            cmd.StandardInput.Flush();
            cmd.StandardInput.WriteLine($"git rebase -i HEAD~{dates.Count}");
            cmd.StandardInput.Flush();
            cmd.StandardInput.WriteLine("SET EDITOR=touch");
            cmd.StandardInput.Flush();

            foreach (var date in dates)
            {
                var iso8601Date = date.ToString("o");

                cmd.StandardInput.WriteLine($"SET GIT_COMMITTER_DATE=\"{iso8601Date}\"");
                cmd.StandardInput.Flush();
                cmd.StandardInput.WriteLine($"git commit --amend --date \"{iso8601Date}\"");
                cmd.StandardInput.Flush();
                cmd.StandardInput.WriteLine("git rebase --continue");
                cmd.StandardInput.Flush();
            }

            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
        }
    }
}
