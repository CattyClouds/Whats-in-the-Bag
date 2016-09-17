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

		// Add tiles back into the bag
		static void AddTile(string tile)
		{
			foreach(var item in tile)
			{
				TileBag.Add(item.ToString());
				//TODO: Increment TileAmounts with the added tile
			}
		}

		static void RemoveTile(string tile) // TODO: Make it work with more than 1 char
		{
			foreach (var item in tile)
			{
				if(TileBag.Contains(tile))
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

		public static int TotalTileCount()
		{
			int count = 0;
			for (int i = 0; i < TileAmounts.Length; i++)
			{
				count += TileAmounts[i];
			}
			return count; // Should be 100 by default
		}

		public static List<string> Input(string tilesOutOfBag)
		{
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

			return TileBag;
		}
	}
}
