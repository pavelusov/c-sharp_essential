using System;
namespace lesson06_Staticfieldsconstructor
{
	enum Manufacturer
	{
		Toyota,
		Mersedes
	}
	interface ICar {
		void Go();
		void Stop();
	}
    abstract class Car : ICar
    {
		public static bool FactoryStart = false;
		static Car()
        {
			FactoryStart = true;
        }
		public static Car Factory(Manufacturer manufacturer)
		{
			switch (manufacturer)
			{	
				case Manufacturer.Toyota:
					return new Toyota();
				case Manufacturer.Mersedes:
					return new Mersedes();
				default: // Very bad
                    return new Lada(); 
							
			}
		}
        public abstract void Go();
        public abstract void Stop();
    }

	class Toyota : Car
	{
		public override void Go()
		{

		}
		public override void Stop()
		{

		}
	}
    class Mersedes : Car
    {
        public override void Go()
        {

        }
        public override void Stop()
        {

        }
    }
    class Lada : Car
    {
        public override void Go()
        {

        }
        public override void Stop()
        {

        }
    }
}
