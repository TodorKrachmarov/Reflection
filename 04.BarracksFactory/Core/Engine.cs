namespace _03BarracksFactory.Core
{
    using System;
    using Contracts;

    class Engine : IRunnable
    {
        private CommandInterpreter commandInterpreter;

        public Engine()
        {
            this.commandInterpreter = new CommandInterpreter();
        }
        
        public void Run()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    string[] data = input.Split();
                    string commandName = data[0];
                    string result = this.commandInterpreter.InterpredCommand(data, commandName);
                    Console.WriteLine(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        // TODO: refactor for Problem 4
        //private string InterpredCommand(string[] data, string commandName)
        //{
        //    string result = string.Empty;
        //    switch (commandName)
        //    {
        //        case "add":
        //            result = this.AddUnitCommand(data);
        //            break;
        //        case "report":
        //            result = this.ReportCommand(data);
        //            break;
        //        case "fight":
        //            Environment.Exit(0);
        //            break;
        //        default:
        //            throw new InvalidOperationException("Invalid command!");
        //    }
        //    return result;
        //}


        //private string ReportCommand(string[] data)
        //{
        //    string output = this.repository.Statistics;
        //    return output;
        //}


        //private string AddUnitCommand(string[] data)
        //{
        //    string unitType = data[1];
        //    IUnit unitToAdd = this.unitFactory.CreateUnit(unitType);
        //    this.repository.AddUnit(unitToAdd);
        //    string output = unitType + " added!";
        //    return output;
        //}
    }
}
