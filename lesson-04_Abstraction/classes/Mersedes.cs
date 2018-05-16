using System;
namespace lesson04_Abstraction
{
	public class Mersedes : AbstractBaseCar
    {
		public override void Go()
		{
			Console.WriteLine("Go Mersedes car");
		}
		public override void Stop()
		{
			Console.WriteLine("Stop Mersedes car");
		}
	}
}
