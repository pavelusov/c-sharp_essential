using System;
namespace lesson04_Abstraction
{
	interface IBook
    {
		void Read();
    }
	interface IBookPaper : IBook
	{
		new void Read(); // Если такой же метод - new
		void Open();
		void Close();
	}
	interface IBookElectronic
	{
		void On();
		void Off();
	}

	public class BookPaper : IBookPaper
	{
		public void Read()
		{
			// Read
		}
		public void Open()
		{
			// Open
		}
		public void Close()
		{
			// Close
		}
	}

	public class BookElectronic : IBook, IBookElectronic
	{
		public void Read() // IBook
		{
			// Read
		}
		public void On() // IBookElectronic
		{
			// On
		}
		public void Off() // IBookElectronic
		{
			// Off
		}
	}
}
