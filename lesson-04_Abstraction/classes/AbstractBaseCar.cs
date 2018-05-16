using System;
namespace lesson04_Abstraction
{
	abstract public class AbstractBaseCar
    {
		
        // Обычный метод
        public void AggressiveStop()
		{
			Console.WriteLine("Aggressive Stop");
		}

        // Виртуальный метод
		public virtual void WhatIs()
		{
			Console.WriteLine("This is a Car");
		}

        // Абстрактный метод - обязательно должны реализовать в производном классе
		public abstract void Go();
        public abstract void Stop();
	}
}
