﻿using System.IO;

namespace Singleton
{
    public class FileWorkerSibgleton
    {
        public string FilePath { get; }
        public string Text { get; private set; }

        private FileWorkerSibgleton()
        {
            FilePath = "test.txt";
            ReadtextFromFile();
        }

        private void ReadtextFromFile()
        {
            if (!File.Exists(FilePath))
            {
                Text = "";
            }
            else
            {
                using var reader = new StreamReader(FilePath);
                Text = reader.ReadToEnd();
            }
        }

        public void WriteText(string text)
        {
            Text += text;
        }

        public void Save()
        {
            using var writer = new StreamWriter(FilePath, false);
            writer.WriteLine(Text);
        }
    }
}