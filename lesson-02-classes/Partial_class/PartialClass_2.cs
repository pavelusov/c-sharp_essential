using System;
namespace lesson02classes
{
    partial class PartialClass
    {
		public void MethodFromPart2()
        {
            Console.WriteLine("2 part");
        }
		partial void PartialMethod()
		{
			Console.WriteLine("PartialMethod");
		}
		public void UsePartialMethod()
		{
			PartialMethod();
		}
	}
}
