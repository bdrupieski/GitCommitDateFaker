using System;
using System.Collections.Generic;
using System.IO;

namespace SequenceEditor
{
    /// <summary>
    /// Replaces every instance of "pick " with "edit " 
    /// in the text file whose path is passed as the 
    /// first command line argument.
    /// 
    /// This is meant to be used as git's GIT_SEQUENCE_EDITOR
    /// so that each commit in an interactive rebase can be 
    /// programmatically set to "edit". Otherwise, it'll open
    /// vim (or whatever is the default editor).
    /// 
    /// This wouldn't be necessary if I could pass a 
    /// sed script to GIT_SEQUENCE_EDITOR in Windows.
    /// </summary>
    public static class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("At least one argument required.");
                return;
            }

            var path = args[0];
            var lines = File.ReadAllLines(path);
            var newLines = new List<string>();
            foreach (var line in lines)
            {
                string newLine;
                if (line.StartsWith("pick "))
                {
                    newLine = "edit " + line.Substring(5);
                }
                else
                {
                    newLine = line;
                }
                newLines.Add(newLine);
            }
            File.WriteAllLines(path, newLines);
        }
    }
}
