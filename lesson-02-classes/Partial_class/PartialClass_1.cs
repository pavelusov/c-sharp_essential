using System;
namespace lesson02classes
{
	partial class PartialClass
    {
		public void MethodFromPart1()
		{
			Console.WriteLine("1 part");
		}
		partial void PartialMethod();
    }
}
