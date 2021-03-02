using System;
using System.IO;

namespace Singleton
{
    public sealed class FileWorkerSingleton
    {

        private static readonly Lazy<FileWorkerSingleton> instance = new Lazy<FileWorkerSingleton>(() => new FileWorkerSingleton());

        public string FilePath { get; }
        public string Text { get; private set; }

        public static FileWorkerSingleton Instance
        {
            get
            {
                return instance.Value;
            }
        }

        private FileWorkerSingleton()
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
