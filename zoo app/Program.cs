using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo_app
{
	public class Animal
	{
		public static void Main()
		{
			string[,] animals =  { { "Cleopatra", "Lion", "Roar" }, { "Paprika", "Tiger", "Snarl" },
										{ "Hercules", "Mouse", "Squeak" } };
			//Lion
			Console.Write(animals[0, 0]);
			Console.Write(" the ");
			Console.Write(animals[0, 1]);
			Console.Write(" makes the sound ");
			Console.WriteLine(animals[0, 2]);

			//Tiger		
			Console.Write(animals[1, 0]);
			Console.Write(" the ");
			Console.Write(animals[1, 1]);
			Console.Write(" makes the sound ");
			Console.WriteLine(animals[1, 2]);

			//Mouse
			Console.Write(animals[2, 0]);
			Console.Write(" the ");
			Console.Write(animals[2, 1]);
			Console.Write(" makes the sound ");
			Console.WriteLine(animals[2, 2]);
		}
	}

}
