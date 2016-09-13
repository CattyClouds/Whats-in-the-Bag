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
			//Console.WriteLine($"What's in the bag?{Environment.NewLine}{dash}");
			Console.WriteLine($"DEBUG Input count:{Environment.NewLine}{dash}");
			Input("AEERTYOXMCNB_S"); // Sample input
			//Input(Console.ReadLine());

			Console.WriteLine($"{Environment.NewLine}{Environment.NewLine}{dash}{dash}{dash}");

			// Debug outputs
			string theCount = string.Join(",", TileAmounts.ToArray());
			Console.WriteLine($"Amount of each tile: {theCount}");
			Console.WriteLine($"Total tiles in bag: {TotalTileCount()}");
			Console.WriteLine($"Tiles in bag: {BagOutput(BagItems)}");

			// End of program
			Console.Write($"{dash}{dash}{dash}{Environment.NewLine}Press any key to exit...");
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

			//Counting the input chars and displaying them
			int count = 0;
			bool repeat = false;
			string outOfBagItem = null;

			foreach (var item in tilesOutOfBag)
			{
				outOfBagItem = item.ToString();

				count = 0;

				for (int i = 0; i < tilesOutOfBag.Count(); i++)
				{
					if (outOfBagItem == tilesOutOfBag[i].ToString())
					{
						count++;
					}
				}
				if (count == 1)
				{
					Console.WriteLine($"CHAR: {outOfBagItem} {count}");
				}
				else if (count >= 2 & !repeat)
				{
					Console.WriteLine($"CHAR: {outOfBagItem} {count}");
					repeat = true;
				}
			}

			// Set properties
			TileAmounts = tileAmounts; 
			BagItems = bag;

			return bag;
		}

		static int TotalTileCount()
		{
			int count = 0;
			for (int i = 0; i < TileAmounts.Length; i++)
			{
				count += TileAmounts[i];
			}
			return count; // Should be 100 by default
		}

		static string BagOutput(List<string> bagInput)
		{
			//char[] theOutput = bagInput.ToArray();
			string concatInput = string.Join("", bagInput.ToArray()); ;
			return concatInput;
		}
	}
}
