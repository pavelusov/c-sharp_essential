using System;

namespace lesson03_Inheritance
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			DerivedClass instance = new DerivedClass();
			instance.Method();
			instance.NonVirtualMethod();

			Console.WriteLine();
			Console.WriteLine("Upcast");
            // Upcast
			BaseClass instanceBase = instance;
			instanceBase.Method();
			instanceBase.NonVirtualMethod();

			Console.WriteLine();
			Console.WriteLine("Downcast");
            // Downcast
			DerivedClass instanceDerived = (DerivedClass)instanceBase;
			instanceDerived.Method();
			instanceDerived.NonVirtualMethod();

			// Cast with AS  (Safe Cast)
			BaseClass a = null;
			DerivedClass b = new DerivedClass();
			if (b is BaseClass) {
				a = (BaseClass)b;
			} else {
				a = null;
			}

			// or
			Console.WriteLine("--- AS ---");

            // Safe Upcast
			a = b as BaseClass; // return BaseClass if true
			a.Method();
        }
    }
}
