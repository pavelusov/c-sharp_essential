using System;
namespace lesson04_Abstraction
{
	interface IExample_1
    {
		void Method();
    }
	interface IExample_2
    {
        void Method();
    }

	public class Example : IExample_1, IExample_2
	{
		// Явное указание имени интерфейса
		void IExample_1.Method() // By default private
		{
		    // Implementations interface the IExample_1
			Console.WriteLine("Implementations interface the IExample_1");
		}
		
        // Явное указание имени интерфейса
        void IExample_2.Method() // By default private
        {
            // Implementations interface the IExample_2
            Console.WriteLine("Implementations interface the IExample_2");
        }
		
		// Объединение реализации одноименных абстрактных членов
		public void Method()
		{
			// Implementation interfaces the IExample_1 and  the IExample_2
			Console.WriteLine("Implementations interface the IExample_1 and  the IExample_2");
		}
	}
}
