using System;

namespace Transaction_Script
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine (HolidayService.BookHolidayFor(1, DateTime.Now, DateTime.Today));
		}
	}
}
