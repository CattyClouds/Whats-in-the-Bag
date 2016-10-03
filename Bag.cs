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
		/// <summary>
		/// TODO: Cleanup property remnants
		/// </summary>

		private Dictionary<char, int> tileBag = new Dictionary<char, int>();

		public Bag()
		{
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

			// Adding tiles to the bag
			for (int i = 0; i < tiles.Length; i++)
			{
				tileBag.Add(tiles[i], tileAmounts[i]);
			}
		}

		public void RemoveTiles(string tiles)
		{
			foreach (var item in tiles.ToUpper())
			{
				if (tileBag.ContainsKey(item) && tileBag[item] >= 1)
				{
					tileBag[item] = tileBag[item] - 1;
				}
				else if (tileBag.ContainsKey(item) && tileBag[item] <= 0)
				{
					Console.WriteLine($"Invalid input. More {item}'s have been taken from the bag than possible."); // Challenge error output
				}
				else Console.WriteLine("Error: Tile not found in bag.");
			}
		}

		public void SortBag()
		{
			var sortedDict = tileBag.OrderByDescending(tile => tile.Value);
			int prevItem = int.MaxValue;

			foreach (var item in sortedDict)
			{
				if (item.Value < prevItem)
				{
					prevItem = item.Value;
					Console.Write($"\n{item.Value}: {item.Key}");
				}
				else if (item.Value == prevItem)
				{
					Console.Write($", {item.Key}");
				}
			}
		}
	}
}
