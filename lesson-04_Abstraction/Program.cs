using System;

namespace lesson04_Abstraction
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Example example = new Example();

            example.Method(); // Implementations interface the ISample_1 and  the ISample_2
            
            IExample_1 example_1 = example as IExample_1;
			example_1.Method(); // Implementations interface the IExample_1

            IExample_2 example_2 = example as IExample_2;
			example_2.Method(); // Implementations interface the IExample_2
        }
    }
}
