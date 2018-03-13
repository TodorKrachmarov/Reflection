namespace _02BlackBoxInteger
{
    using System;
    using System.Reflection;

    class BlackBoxIntegerTests
    {
        static void Main(string[] args)
        {
            Type myType = typeof(BlackBoxInt);
            ConstructorInfo ctor = myType.GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[0], null);
            BlackBoxInt blackBoxIntInstance = (BlackBoxInt) ctor.Invoke(new object[] { });
            //BlackBoxInt blackBoxIntInstance = (BlackBoxInt) Activator.CreateInstance(myType, true);
            FieldInfo field = myType.GetField("innerValue", BindingFlags.NonPublic | BindingFlags.Instance);
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] tolks = input.Split(new[] {'_'}, StringSplitOptions.RemoveEmptyEntries);
                MethodInfo method = myType.GetMethod(tolks[0], BindingFlags.NonPublic | BindingFlags.Instance);
                method.Invoke(blackBoxIntInstance, new object[] {int.Parse(tolks[1])});
                Console.WriteLine(field.GetValue(blackBoxIntInstance));
            }
        }
    }
}
