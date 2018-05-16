using System;
namespace lesson06_Staticfieldsconstructor
{
    static class ExtensionClass
    {
        static public void ExtensionMethod_1(this string value1)
        {
            System.Console.WriteLine($"ExtensionMethod speak: {value1}");
        }
        static public void ExtensionMethod_2(this string value1, string value2)
        {
            System.Console.WriteLine($"ExtensionMethod speak: {value1} and {value2}");
        }
    }
}
