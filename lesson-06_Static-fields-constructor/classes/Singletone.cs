using System;
namespace lesson06_Staticfieldsconstructor
{
    class Singletone
    {
		private static Singletone instance = null;
		// Constructor protected
		protected Singletone()
        {
        }
		public static Singletone GetInstance()
		{
			//return instance == null ? new Singletone() : instance; 
			if (instance == null)
			{
				instance = new Singletone();
			}
			return instance;
		}
    }
}
