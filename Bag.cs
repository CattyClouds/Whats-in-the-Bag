using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace What_s_in_the_Bag
{
	class Bag
	{
		// Properties
		public static string Tiles { get; set; }
		public static int TotalTileCount { get; set; }
		public static Dictionary<char, int> TileBag { get; set; }
		public static int[] TileAmounts { get; set; }

		static Bag()
		{
			var bag = new Dictionary<char, int>();
			TileBag = bag;

			string tiles = "ABCDEFGHIJKLMNOPQRSTUVWXYZ_";
			Tiles = tiles;

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
			TileAmounts = tileAmounts;

			AddTilesToBag();
		}

		static void AddTilesToBag()
		{
			for (int i = 0; i < Tiles.Length; i++)
			{
				TileBag.Add(Tiles[i], TileAmounts[i]);
			}
		}

		public static void RemoveTiles(string tiles)
		{
			foreach (var item in tiles.ToUpper())
			{
				if (TileBag.ContainsKey(item) && TileBag[item] >= 1)
				{
					TileBag[item] = TileBag[item] - 1;
				}
				else if (TileBag.ContainsKey(item) && TileBag[item] <= 0)
				{
					Console.WriteLine($"Invalid input. More {item}'s have been taken from the bag than possible."); // Challenge error output
				}
				else Console.WriteLine("Error: Tile not found in bag.");
			}
		}

		public static void SortBag()
		{
			StringBuilder sb = new StringBuilder();
			var sortedDict = new SortedDictionary<char, int>(TileBag).OrderByDescending(tile => tile.Value);
			int prevItem = int.MaxValue;

			foreach (var item in sortedDict)
			{
				if (item.Value < prevItem)
				{
					sb.Append($"{item.Value.ToString()}: {item.Key}");
					prevItem = item.Value;
					Console.Write($"{Environment.NewLine}{sb}");
				}
				else if (item.Value == prevItem)
				{
					sb.Append($", {item.Key}");
					Console.Write($"{sb}");
					prevItem = item.Value;
				}
				else if (item.Value > prevItem)
				{
					Console.WriteLine(">Entered SortBag() elseif"); // Placeholder
				}
				else Console.WriteLine($">Entered SortBag() else");
				sb.Clear();
			}
		}

		public static string DisplayContents(Dictionary<char, int> input)
		{
			string concatInput = string.Join("\n", input);
			return concatInput;
		}

		public static string DisplaySortedContents(Dictionary<char, int> input)
		{
			StringBuilder sb = new StringBuilder();
			var sortedDict = new SortedDictionary<char, int>(TileBag).OrderByDescending(kvp => kvp.Value);

			string concatInput = string.Join("\n", sortedDict);
			return concatInput;
		}

		public static int CountTilesInBag()
		{
			int total = 0;
			total = TileBag.Values.Sum();

			return total;
		}
	}
}
