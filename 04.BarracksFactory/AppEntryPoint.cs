namespace _03BarracksFactory
{
    using Contracts;
    using Core;

    class AppEntryPoint
    {
        static void Main(string[] args)
        {
            IRunnable engine = new Engine();
            engine.Run();
        }
    }
}
