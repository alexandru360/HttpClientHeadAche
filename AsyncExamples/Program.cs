namespace AsyncExamples
{
    using CommonLib;

    class Program
    {
        static void Main(string[] args)
        {
            HttpCommonLib.Main().Wait();
            HttpCommonLib.Main2().Wait();
        }
    }
}
