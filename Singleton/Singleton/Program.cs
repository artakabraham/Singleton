using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var text1 = new FileWorker();
            var text2 = new FileWorker();

            text1.WriteText("Loerm Ipsum");
            text2.WriteText("Hello World");

            text1.Save();
            text2.Save();
        }
    }
}
