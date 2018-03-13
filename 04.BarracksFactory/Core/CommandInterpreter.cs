namespace _03BarracksFactory.Core
{
    using Contracts;
    using Data;
    using Factories;
    using System.Collections.Generic;
    using Commands;

    public class CommandInterpreter
    {
        private IRepository repository;
        private IUnitFactory unitFactory;
        private Dictionary<string, Command> implimendCommand;

        public CommandInterpreter()
        {
            this.repository = new UnitRepository();
            this.unitFactory = new UnitFactory();
            this.implimendCommand = new Dictionary<string, Command>();
        }

        public string InterpredCommand(string[] data, string commandName)
        {
            this.implimendCommand.Add("add", new AddUnitCommand(data, this.repository, this.unitFactory));
            this.implimendCommand.Add("report", new ReportCommand(data, this.repository, this.unitFactory));
            this.implimendCommand.Add("fight", new ExitCommand(data, this.repository, this.unitFactory));
            this.implimendCommand.Add("retire", new RetireUnitCommand(data, this.repository, this.unitFactory));

            Command command = this.implimendCommand[commandName];

            this.implimendCommand.Clear();

            return command.Execute();
        }
    }
}
