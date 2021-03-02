namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton1 = FileWorkerSingleton.Instance;
            var singleton2 = FileWorkerSingleton.Instance;

            singleton1.WriteText("Loerm Ipsum");
            singleton2.WriteText("Hello World");

            singleton1.Save();
            singleton2.Save();
        }
    }
}
