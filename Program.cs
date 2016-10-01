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

			Console.WriteLine($"Debug Input:AEERTYOXMCNB_S{Environment.NewLine}{dash}");
			Bag.RemoveTiles("AEERTYOXMCNB_S");

			Console.WriteLine($"{Environment.NewLine}{Environment.NewLine}{dash}{dash}{dash}");

			Bag.SortBag();
			//DebugOutput();


			Console.Write($"{Environment.NewLine}{dash}{dash}{dash}{Environment.NewLine}Press any key to exit...");
			Console.ReadKey();
		}

		static void DebugOutput()
		{
			//Console.WriteLine($"Bag.DisplayContents():{Environment.NewLine}{Bag.DisplayContents(Bag.TileBag)}");
			//Console.WriteLine($"Bag.DisplaySortedContents(Bag.TileBag):{Environment.NewLine}{Bag.DisplaySortedContents(Bag.TileBag)}");
			Console.WriteLine($"Bag.CountTilesInBag(): {Bag.CountTilesInBag()}");
		}
	}
}
