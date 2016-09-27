using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_s_in_the_Bag
{
	class Bag
	{
		// Properties
		public static string Tiles { get; set; }
		public static Dictionary<char, int> TileBag { get; set; }
		public static List<int> CountBagTileAmounts { get; set; }
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
			foreach (var tile in Tiles)
			{
				TileBag.Add(tile, 9);
			}
		}

		public static void RemoveTile(char tile)
		{
			if (TileBag.ContainsKey(tile))
			{
				TileBag.Remove(tile);
			}
			#region Old code
			//foreach (var item in tile)
			//{
			//	if (TileBag.Contains(tile))
			//	{
			//		TileBag.Remove(tile);
			//	}
			//}
			#endregion
		}

		public static string DisplayContents(Dictionary<char, int> input)
		{
			string concatInput = string.Join("\n", input);
			return concatInput;
		}

		// TODO: Make stringbuilder and set it to a property.
		public static int CountBagContents()
		{
			int total = 0;
			return total;
			#region Old code
			//List<int> countBagTileAmounts = new List<int>();

			//int count = 0;
			//for (int i = 0; i < TileBag.Count; i++) // Go through entire bag
			//{
			//	if (i == 0 || TileBag[i - 1] == TileBag[i]) // Checking previous tile equals current one in index
			//	{
			//		count++;
			//		countBagTileAmounts.Add(count);
			//		if (i == (TileBag.Count - 1))
			//		{
			//			countBagTileAmounts.Add(count);
			//			Console.WriteLine($"CHAR: {TileBag[i]}: {count} - {countBagTileAmounts[i]}");
			//		}
			//	}
			//	else
			//	{
			//		countBagTileAmounts.Add(count);
			//		Console.WriteLine($"CHAR: {TileBag[i - 1]}: {count} - {countBagTileAmounts[i]}");
			//		count = 1;
			//	}
			//}
			//CountBagTileAmounts = countBagTileAmounts;
			//return -1; // Temporary debug return. Gonna use it properly later for output separation
			#endregion
		}

		// Debug: Shows amount of tiles in input
		//public static List<string> Input(string tilesOutOfBag)
		//{
		//	int count = 0;
		//	bool repeat = false;
		//	string outOfBagItem = null;
		//	int[] outOfBagTileAmounts = new int[tilesOutOfBag.Count()];

		//	foreach (var item in tilesOutOfBag)
		//	{
		//		outOfBagItem = item.ToString();
		//		count = 0;

		//		for (int i = 0; i < tilesOutOfBag.Count(); i++)
		//		{
		//			if (outOfBagItem == tilesOutOfBag[i].ToString())
		//			{
		//				RemoveTile(outOfBagItem);
		//				count++;
		//				outOfBagTileAmounts[i] = count;
		//			}
		//		}
		//		if (count == 1)
		//		{
		//			Console.WriteLine($"CHAR: {outOfBagItem} {count}");
		//		}
		//		else if (count >= 2 & !repeat)
		//		{
		//			Console.WriteLine($"CHAR: {outOfBagItem} {count}");
		//			repeat = true;
		//		}
		//	}
		//	string strta = string.Join(",", outOfBagTileAmounts);
		//	Console.WriteLine(strta);

		//	return TileBag;
		//}

		public static int TotalTileCount()
		{
			int total = 0;

			foreach (var item in TileBag.Keys)
			{
				total += TileBag.Values.Count;
			}

			return total;
		}
	}
}
