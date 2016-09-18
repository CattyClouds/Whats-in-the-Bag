using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_s_in_the_Bag
{
	class Program
	{
		static void Main(string[] args)
		{
			string dash = String.Concat(Enumerable.Repeat("-", 32));
			//Console.WriteLine($"What's in the bag?{Environment.NewLine}{dash}");
			//Bag.Input(Console.ReadLine());

			Console.WriteLine($"Debug Input:{Environment.NewLine}{dash}");
			//Bag.Input("AEERTYOXMCNB_S"); // Sample input
			//Bag.RemoveTile("AEERTYOXMCNB_S");

			Console.WriteLine($"{Environment.NewLine}{Environment.NewLine}{dash}{dash}{dash}");

			Bag.CountBagContents();
			DebugOutput();

			Console.Write($"{dash}{dash}{dash}{Environment.NewLine}Press any key to exit...");
			Console.ReadKey();
		}

		static void DebugOutput()
		{
			//Console.WriteLine($"Bag: {Bag.CountBagContents()}");
			Console.WriteLine($"Amount of each tile: {string.Join(",", Bag.TileAmounts.ToArray())}");
			Console.WriteLine($"Total tiles in bag: {Bag.TotalTileCount()}");
			Console.WriteLine($"Tiles in bag: {Bag.DisplayContents()}");
		}
	}
}
