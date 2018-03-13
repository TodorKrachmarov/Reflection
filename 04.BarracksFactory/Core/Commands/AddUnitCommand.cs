namespace _03BarracksFactory.Core.Commands
{
    using Contracts;

    public class AddUnitCommand : Command
    {
        public AddUnitCommand(string[] data, IRepository repository, IUnitFactory unitFactory) 
            : base(data, repository, unitFactory) { }

        public override string Execute()
        {
            string unitType = base.Data[1];
            IUnit unitToAdd = base.UnitFactory.CreateUnit(unitType);
            base.Repository.AddUnit(unitToAdd);
            string output = unitType + " added!";
            return output;
        }
    }
}
