namespace _03BarracksFactory.Core.Commands
{
    using System;
    using Contracts;

    public class ExitCommand : Command
    {
        public ExitCommand(string[] data, IRepository repository, IUnitFactory unitFactory) 
            : base(data, repository, unitFactory) { }

        public override string Execute()
        {
            Environment.Exit(0);
            return "Bye-Bye";
        }
    }
}
