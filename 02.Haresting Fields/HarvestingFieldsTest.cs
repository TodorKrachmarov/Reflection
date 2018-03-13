namespace _01HarestingFields
{
    using System;
    using System.Reflection;

    class HarvestingFieldsTest
    {
        static void Main(string[] args)
        {
            Type myType = typeof(HarvestingFields);
            FieldInfo[] allFields = myType.GetFields(BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            string input;
            while ((input = Console.ReadLine()) != "HARVEST")
            {
                switch (input)
                {
                    case "private":
                        foreach (FieldInfo field in allFields)
                        {
                            if (field.IsPrivate)
                            {
                                Console.WriteLine($"{field.Attributes.ToString().ToLower()} {field.FieldType.Name} {field.Name}");
                            }
                        }
                        break;
                    case "protected":
                        foreach (FieldInfo field in allFields)
                        {
                            if (field.IsFamily)
                            {
                                Console.WriteLine($"{input} {field.FieldType.Name} {field.Name}");
                            }
                        }
                        break;
                    case "public":
                        foreach (FieldInfo field in allFields)
                        {
                            if (field.IsPublic)
                            {
                                Console.WriteLine($"{field.Attributes.ToString().ToLower()} {field.FieldType.Name} {field.Name}");
                            }
                        }
                        break;
                    case "all":
                        foreach (FieldInfo field in allFields)
                        {
                            string accMod = field.Attributes.ToString().ToLower() == "family"
                                ? "protected"
                                : field.Attributes.ToString().ToLower();
                            Console.WriteLine($"{accMod} {field.FieldType.Name} {field.Name}");
                        }
                        break;
                }
            }
        }
    }
}
