using System;

namespace Proxy
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var p = new Person();
			var rp = new ResponsiblePerson(p);
			p.Age = 10;

			Console.WriteLine(rp.Drive ());
			Console.WriteLine(rp.Drink ());
			Console.WriteLine(rp.DrinkAndDrive ());

			rp.Age = 20;

			Console.WriteLine(rp.Drive ());
			Console.WriteLine(rp.Drink ());
			Console.WriteLine(rp.DrinkAndDrive ());
		}
	}
}
