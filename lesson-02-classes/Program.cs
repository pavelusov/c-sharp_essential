using System;

namespace lesson02classes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			PartialClass instance = new PartialClass();
			instance.MethodFromPart1();
			instance.MethodFromPart2();
			instance.UsePartialMethod();
        }
    }
}
