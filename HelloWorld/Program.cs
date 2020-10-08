using System;

namespace HelloWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Chris big giveaway");
			Console.Write("Choose a door: 1, 2 or 3: ");
			string userValue = Console.ReadLine();

			if (userValue == "1")
			{
				string message = "You won a car!";
				Console.WriteLine(message);
			}
			else if (userValue == "2")
			{
				string message = "You won a boat!";
				Console.WriteLine(message)
			}
			else if (userValue == "3")   
			{
				string message = "You won a scooter";
				Console.WriteLine(message)
			}
			else
			{
				string message = "Please Enter 1, 2 or 3";
				Console.WriteLine(message);
			}
			Console.ReadLine();
		}	123123234
	}
}
