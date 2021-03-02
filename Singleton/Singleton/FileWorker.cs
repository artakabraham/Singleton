using System.IO;

namespace Singleton
{
    public class FileWorker
    {
        public string FilePath { get; }
        public string Text { get; private set; }

        public FileWorker()
        {
            FilePath = "test.txt";
            ReadtextFromFile();
        }

        public void WriteText(string text)
        {
            Text = text;
        }

        public void Save()
        {
            using var writer = new StreamWriter(FilePath, false);
            writer.WriteLine(Text);
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
    }
}
