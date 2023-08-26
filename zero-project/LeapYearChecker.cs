using System;
namespace zero_project
{
	public class LeapYearChecker
	{
		public static void Main()
		{
			Console.WriteLine("Enter year: ");
			int year = Convert.ToInt32(Console.ReadLine());

			bool f;

			if (year % 400 == 0) f = true;
			else
			{
				if (year % 100 == 0) f = false;
				else
				{
					if (year % 4 == 0) f = true;
					else f = false;
				}
			}

			switch (f)
			{
				case true:
					Console.WriteLine($"{year} is leap");
					break;
				case false:
					Console.WriteLine($"{year} isn`t leap");
					break;
			}
		}
	}
}

