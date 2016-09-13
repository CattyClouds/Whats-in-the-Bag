using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_s_in_the_Bag
{
	class Program
	{
		public static int[] TileAmounts { get; set; }
		public static List<string> BagItems { get; set; }

		static void Main(string[] args)
		{
			string dash = String.Concat(Enumerable.Repeat("-", 32));
			Console.WriteLine($"What's in the bag?{Environment.NewLine}{dash}");

			//Console.Write("Tiles out of the bag: ");
			Input("AEERTYOXMCNB_S"); // Sample input - 1a, 2e, 1r, 1t, 1y, 1o, 1x, 1m, 1n, 1c, 1b, 1_, 1s
									 //Input(Console.ReadLine());

			Console.WriteLine($"{Environment.NewLine}{Environment.NewLine}{dash}DEBUG{dash}{Environment.NewLine}");

			// Debug outputs
			string theCount = string.Join(",", TileAmounts.ToArray());
			Console.WriteLine($"Amount of each tile: {theCount}");
			Console.WriteLine($"Total tiles in bag: {TotalTileCount()}");
			Console.WriteLine($"Tiles in bag: {BagOutput(BagItems)}");

			// End of program
			Console.Write($"{dash}{Environment.NewLine}Press any key to exit...");
			Console.ReadKey();
		}

		static List<string> Input(string tilesOutOfBag)
		{
			List<string> bag = new List<string>(); // Bag is empty

			string tiles = "ABCDEFGHIJKLMNOPQRSTUVWXYZ_";

			int[] tileAmounts = {
				9,2,2,  // A,B,C,
				4,12,2, // D,E,F,
				3,2,9,  // G,H,I,
				1,1,4,  // J,K,L,
				2,6,8,  // M,N,O,
				2,1,6,  // P,Q,R,
				4,6,4,  // S,T,U,
				2,2,1,  // V,W,X,
				2,1,2   // Y,Z,_
				};

			for (int i = 0; i < tiles.Length; i++) // Go through every tile
			{
				for (int x = 0; x < tileAmounts[i]; x++) // Add the amount of tiles for each tile
				{
					bag.Add(tiles[i].ToString());
				}
			}

			//
			// TEST
			//
			int count = 0;
			foreach (var item in tilesOutOfBag)
			{
				
				string repeatChar = item.ToString();
				for (int i = 0; i < tilesOutOfBag.Count(); i++)
				{
					if (repeatChar == tilesOutOfBag[i].ToString())
					{
						count++;
						Console.WriteLine($"REPEATED: {repeatChar} {count}");
					}
				}
			}
			

			// Set properties
			TileAmounts = tileAmounts; 
			BagItems = bag;

			return bag;
		}

		// Debug
		static int TotalTileCount()
		{
			int count = 0;
			for (int i = 0; i < TileAmounts.Length; i++)
			{
				count += TileAmounts[i];
			}
			return count; // Should be 100 by default
		}

		// To an array
		static string BagOutput(List<string> bagInput)
		{
			//char[] theOutput = bagInput.ToArray();
			string concatInput = string.Join("", bagInput.ToArray()); ;
			return concatInput;
		}
	}
}
