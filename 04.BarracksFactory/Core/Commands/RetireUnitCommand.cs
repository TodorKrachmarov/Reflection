namespace _03BarracksFactory.Core.Commands
{
    using System;
    using Contracts;

    public class RetireUnitCommand : Command
    {
        public RetireUnitCommand(string[] data, IRepository repository, IUnitFactory unitFactory) 
            : base(data, repository, unitFactory) { }

        public override string Execute()
        {
            string result = string.Empty;

            try
            {
                string unitType = base.Data[1];
                base.Repository.RemoveUnit(unitType);
                result = $"{unitType} retired!";
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            
            return result;
        }
    }
}
