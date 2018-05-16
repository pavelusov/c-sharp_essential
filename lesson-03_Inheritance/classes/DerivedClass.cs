using System;
namespace lesson03_Inheritance
{
	public class DerivedClass : BaseClass
    {
        public DerivedClass()
        {
        }

        // Переопределение метода
        public override void Method()
        {
            // Call base Method
			base.Method(); // decorator
			Console.WriteLine("Method Derived Class");
        }

        // Замещение метода - new important
		public new void NonVirtualMethod()
        {
            Console.WriteLine("DERIVED CLASS Non Virtual Method");
        }

        // sealed запрещает ниже по графу ПЕРЕОПРЕДЕЛЯТЬ ВИРТУАЛЬНЫЙ метод
		sealed public override void SealedMethod()
        {
            Console.WriteLine("BASE  CLASS Sealed Method");
        }
    }
}
