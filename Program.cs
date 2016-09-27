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
			Console.WindowHeight = 42; // Debug purposes
			string dash = String.Concat(Enumerable.Repeat("-", 32));
			//Console.WriteLine($"What's in the bag?{Environment.NewLine}{dash}");
			//Bag.Input(Console.ReadLine());

			Console.WriteLine($"Debug Input:{Environment.NewLine}{dash}");
			//Bag.Input("AEERTYOXMCNB_S"); // Sample input
			//Bag.RemoveTile("AEERTYOXMCNB_S");

			Console.WriteLine($"{Environment.NewLine}{Environment.NewLine}{dash}{dash}{dash}");

			//Bag.CountBagContents();
			Bag.RemoveTile('F');
			DebugOutput();

			Console.Write($"{dash}{dash}{dash}{Environment.NewLine}Press any key to exit...");
			Console.ReadKey();
		}

		static void DebugOutput()
		{
			//Console.WriteLine($"Bag: {Bag.CountBagContents()}");
			//Console.WriteLine($"Bag.TileAmounts: {string.Join(",", Bag.TileAmounts.ToArray())}");
			//Console.WriteLine($"Bag.TotalTileCount(): {Bag.TotalTileCount()}");
			Console.WriteLine($"Bag.DisplayContents():{Environment.NewLine}{Bag.DisplayContents(Bag.TileBag)}");

			//var stringList = Bag.CountBagTileAmounts.Select(x => x.ToString()).ToList();
			//Console.WriteLine($"Tiles amounts: {Bag.DisplayContents(stringList)}");
			//Console.WriteLine($"Tiles amounts: {Bag.DisplayContents(Bag.CountBagTileAmounts)}");
		}
	}
}
