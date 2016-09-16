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
		public static List<string> TileBag { get; set; }
		public static string Tiles { get; set; }
		
		static Bag()
		{
			List<string> bag = new List<string>(); // Bag is empty
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
		}

		static string Input2(string tileInput)
		{
			return tileInput;
		}

		static void AddTile()
		{
			for (int i = 0; i < Tiles.Length; i++) // Go through every tile
			{
				for (int x = 0; x < TileAmounts[i]; x++) // Add the amount of tiles for each tile according to TileAmounts
				{
					TileBag.Add(Tiles[i].ToString());
				}
			}
		}

		static void RemoveTile()
		{
			//TileBag.Remove("");
		}

		// TODO: Currently not displaying contents.
		public static string DisplayContents()
		{
			List<string> bagInput = TileBag;
			string concatInput = string.Join(",", bagInput.ToArray()); ;
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

			return TileBag;
		}
	}
}
