using System;

namespace lesson06_Staticfieldsconstructor
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            if (Car.FactoryStart) // Срабатывает статический конструктор!
            {
                Console.WriteLine("The construction of cars began!");
            } else {
                Console.WriteLine("The Factory don't work");
            }
            // Factory
            Car toyota = Car.Factory(Manufacturer.Toyota);
            if (Car.FactoryStart) {
                Console.WriteLine("The construction of cars began!");
            }

			// Singletone 

			Singletone instance1 = Singletone.GetInstance();
			Singletone instance2 = Singletone.GetInstance();
            
			Console.WriteLine(instance1.GetHashCode());
			Console.WriteLine(instance2.GetHashCode());

            // Exstension methods
            string text = "Hello";
			ExtensionClass.ExtensionMethod_1(text); // ExtensionMethod_1
            text.ExtensionMethod_2("world");        // ExtensionMethod_2
            // повторить опциональные параметры
        }
    }
}
