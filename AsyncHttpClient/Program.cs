namespace ConsoleApplication
{
    using CommonLib;

    public class Program
    {
        static void Main(string[] args)
        {
            HttpCommonLib.Main().Wait();
            HttpCommonLib.Main2().Wait();
        }
    }

}