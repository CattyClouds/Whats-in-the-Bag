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
		//public static SortedDictionary<char, int> SortedTileBag { get; set; }
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

		public static void RemoveTile(char tile, int amount)
		{
			int keyValue = 0;
			TileBag.TryGetValue(tile, out  keyValue);

			if (TileBag.ContainsKey(tile) && keyValue > amount)
			{
				TileBag[tile] = keyValue - amount;
			}
			else
			{
				TileBag.Remove(tile);
				Console.WriteLine($"REMOVED: {tile}");
			}
		}

		public static void RemoveTiles(string tiles)
		{
			foreach (var item in tiles)
			{
				if (Bag.TileBag.ContainsKey(item))
				{
					TileBag[item] = TileBag[item] - 1;
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
				//Console.WriteLine($"{sb}");
				//Console.WriteLine();
				//sb.Append(item.Value.ToString() + ": ");
				//if (prevItem > item.Value)
				if (item.Value < prevItem)
				{
					//sb.Append(item.Value.ToString() + ": ");
					sb.Append($"{item.Value.ToString()}: {item.Key}");
					prevItem = item.Value;
					Console.Write($"{Environment.NewLine}{sb}"); // needs a write because this make a new line if it starts on a multiple of # of tile
					//sb.Clear();
				}
				else if (item.Value == prevItem)
				{
					sb.Append($", {item.Key}");
					Console.Write($"{sb}");
					prevItem = item.Value;
				}
				else if (item.Value > prevItem)
				{
					Console.WriteLine(">Entered SortBag() elseif");
				}
				else Console.WriteLine($">Entered SortBag() else");
				//Console.WriteLine($"{sb}");
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
