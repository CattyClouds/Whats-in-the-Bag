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
		public static int[] TileAmounts { get; set; }
		public static string Tiles { get; set; }
		public static List<string> TileBag { get; set; }

		static Bag()
		{
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

			List<string> bag = new List<string>(); // Bag is empty
			TileBag = bag;
			AddTilesToBag();
		}

		static void AddTilesToBag()
		{
			for (int i = 0; i < Tiles.Length; i++) // Go through every tile according to the rules of the game
			{
				for (int x = 0; x < TileAmounts[i]; x++) // Add the amount of tiles for each tile according to TileAmounts
				{
					TileBag.Add(Tiles[i].ToString());
				}
			}
		}

		//// Add tiles back into the bag. Probably won't implement.
		//static void AddTile(string tile)
		//{
		//	foreach(var item in tile)
		//	{
		//		TileBag.Add(item.ToString());
		//		//TODO: Increment TileAmounts with the added tile
		//	}
		//}

		// TODO: Make it work with more than 1 char
		// 1-count tile input
		// 2-remove in tilebag
		// 3-subtract from array/list
		public static void RemoveTile(string tile)
		{
			foreach (var item in tile)
			{
				if (TileBag.Contains(tile))
				{
					TileBag.Remove(tile);
				}
			}
		}

		public static string DisplayContents()
		{
			string concatInput = string.Join("", TileBag);
			return concatInput;
		}

		// TODO: Make stringbuilder and set it to a property.
		public static int CountBagContents()
		{
			List<int> countBagTileAmounts = new List<int>();
			int count = 0;
			for (int i = 0; i < TileBag.Count; i++) // Go through entire bag
			{
				if (i == 0 || TileBag[i - 1] == TileBag[i]) // Checking previous tile equals current one in index
				{
					count++;
					//countBagTileAmounts.Add(count);
					if (i == (TileBag.Count - 1))
					{
						countBagTileAmounts.Add(count);
						Console.WriteLine($"CHAR: {TileBag[i]} {count}");
					}
				}
				else
				{
					countBagTileAmounts.Add(count);
					Console.WriteLine($"CHAR: {TileBag[i - 1]} {count}");
					count = 1;
				}
			}
			return -1; // Temporary debug return. Gonna use it properly later for output separation
		}

		// Debug: Shows amount of tiles in input
		public static List<string> Input(string tilesOutOfBag)
		{
			int count = 0;
			bool repeat = false;
			string outOfBagItem = null;
			int[] outOfBagTileAmounts = new int[tilesOutOfBag.Count()];

			foreach (var item in tilesOutOfBag)
			{
				outOfBagItem = item.ToString();
				count = 0;

				for (int i = 0; i < tilesOutOfBag.Count(); i++)
				{
					if (outOfBagItem == tilesOutOfBag[i].ToString())
					{
						RemoveTile(outOfBagItem);
						count++;
						outOfBagTileAmounts[i] = count;
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
			string strta = string.Join(",", outOfBagTileAmounts);
			Console.WriteLine(strta);

			return TileBag;
		}

		public static int TotalTileCount()
		{
			int count = 0;
			for (int i = 0; i < TileAmounts.Length; i++)
			{
				count += TileAmounts[i];
			}
			return count; // Should be 100 by default
		}
	}
}
