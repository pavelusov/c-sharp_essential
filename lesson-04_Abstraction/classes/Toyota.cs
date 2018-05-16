using System;
namespace lesson04_Abstraction
{
	public class Toyota : AbstractBaseCar
    {
		public override void Go()
        {
            Console.WriteLine("Go Toyota car");
        }
        public override void Stop()
        {
            Console.WriteLine("Stop Toyota car");
        }
    }
}
