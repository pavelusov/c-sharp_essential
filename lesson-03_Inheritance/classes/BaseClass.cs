using System;
namespace lesson03_Inheritance
{
	public class BaseClass
	{
		public BaseClass()
		{
		}
		public virtual void Method()
		{
			Console.WriteLine("Method Base Class");
		}
		public void NonVirtualMethod()
		{
			Console.WriteLine("BASE CLASS Non Virtual Method");
		}
		public virtual void SealedMethod()
		{
			Console.WriteLine("BASE  CLASS Sealed Method");
		}
	}
}