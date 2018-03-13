namespace _03BarracksFactory.Core.Factories
{
    using System;
    using Contracts;
    using _03BarracksFactory.Models.Units;

    public class UnitFactory : IUnitFactory
    {
        private const string UnitTypePath = "_03BarracksFactory.Models.Units.";

        public IUnit CreateUnit(string unitType)
        {
            Type myType = Type.GetType(UnitTypePath + unitType);
            IUnit unit = (Unit) Activator.CreateInstance(myType);
            return unit;
        }
    }
}
