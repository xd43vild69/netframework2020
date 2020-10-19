using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Console.IO
{
    public class IOMemorize
    {
        
        private const string PATH = @"C:\Users\D13\Desktop\Memorize\";
        private const string IN_FILE_NAME  = PATH + "input.txt";
        private StreamWriter SW { get; set; }
        private Stack<string> ParentStack { get; set; } = new Stack<string>();
        private string OutputFile { get; set; }
        private int LevelPrevious { get; set; }

        public void ExecuteFormat()
        {
            RenameOutputFile();
            SW = new StreamWriter(OutputFile);
            StreamReader sr = new StreamReader(IN_FILE_NAME);

            while (!sr.EndOfStream)
            {
                WriteForFile(sr.ReadLine());
            }

            sr.ReadToEnd();
            SW.Close();
        }

        private void WriteForFile(string line)
        {
            int level = GetDepth(line);

            if (level == 0)
            {
                SetResetLevel(line);
            }
            else if (level == LevelPrevious)
            {
                SetSameLevel(line);
            }
            else if (level < LevelPrevious)
            {
                RemoveParents(level);
                SetDowngradeLevel(line);
            }
            else if (level > LevelPrevious)
            {
                SetUpgradeLevel(line);
            }
            LevelPrevious = level;
        }

        private void SetResetLevel(string line)
        {
            ParentStack = new Stack<string>();
            WriteChild(line);
            ParentStack.Push(line);
        }

        private void SetUpgradeLevel(string line)
        {
            WriteChild(line);
            ParentStack.Push(line);
        }

        private void SetSameLevel(string line)
        {
            ParentStack.Pop();
            WriteChild(line);
            ParentStack.Push(line);
        }

        /// <summary>
        /// Controls the downgrade with multiple Pop() and insert a new parent to the tree.
        /// </summary>
        /// <param name="line"></param>
        private void SetDowngradeLevel(string line)
        {
            WriteChild(line);
            ParentStack.Push(line);
        }

        private void SetLevelPrevious(int level)
        {
            if (level == 0)
            {
                LevelPrevious = 0;
            }
            else if (level > LevelPrevious || level < LevelPrevious)
            {
                LevelPrevious = level;
            }
        }

        private int GetDepth(string line)
        {
            for (int i = line.Length - 1; i >= 0; i--)
            {
                if (line[i] == '\t')
                {
                    int position = i + 1;
                    return position;
                }
            }
            return 0;
        }

        private void RemoveParents(int level)
        {
            while (ParentStack.Count > level)
            {
                ParentStack.Pop();
            }
        }

        private string GetParent()
        {
            string parent = string.Empty;
            foreach (var s in ParentStack.Reverse())
            {
                parent = parent + " " + s;
            }
            return parent;
        }

        private void WriteChild(string childLine)
        {
            WriteChildParentChild(childLine);
            //WriteParentChildQuestion(childLine);
        }

        private void WriteChildParentChild(string childLine)
        {
            string parent = GetParent();

            SW.WriteLine(parent + ": " + childLine + ".");
            SW.WriteLine("   ");
        }

        private void WriteParentChildQuestion(string childLine)
        {
            string parent = GetParent();

            SW.WriteLine("Parent:" + parent + "; Child:" + childLine + ".");
            SW.WriteLine("Parent:" + parent + "; Child:" + childLine + ".");

            SW.WriteLine("   ");
        }

        private void RenameOutputFile()
        {
            var randomNumber = new Random().Next();
            OutputFile = PATH + $"output_{randomNumber}.txt";
        }

    }
}
