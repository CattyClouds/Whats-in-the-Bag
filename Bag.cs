using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace Whats_in_the_Bag
{
	public class Bag
	{
		private Dictionary<char, int> tileBag = new Dictionary<char, int>()
		{
			['A'] = 9,['B'] = 2,['C'] = 2,
			['D'] = 4,['E'] = 12,['F'] = 2,
			['G'] = 3,['H'] = 2,['I'] = 9,
			['J'] = 1,['K'] = 1,['L'] = 4,
			['M'] = 2,['N'] = 6,['O'] = 8,
			['P'] = 2,['Q'] = 1,['R'] = 6,
			['S'] = 4,['T'] = 6,['U'] = 4,
			['V'] = 2,['W'] = 2,['X'] = 1,
			['Y'] = 2,['Z'] = 1,['_'] = 2
		};

		public string RemoveTiles(string tiles)
		{
			foreach (var item in tiles.ToUpper())
			{
				if (tileBag.ContainsKey(item) && tileBag[item] >= 1)
				{
					tileBag[item] = tileBag[item] - 1;
				}
				else if (tileBag.ContainsKey(item) && tileBag[item] <= 0)
				{
					return $"Invalid input. More {item}'s have been taken from the bag than possible."; // Challenge error output
				}
				else return "Error: Tile not found in the bag.";
			}
			return "Removed tiles from the bag.";
		}

		public string FormatContents()
		{
			StringBuilder sb = new StringBuilder();
			var sortedDict = tileBag.OrderByDescending(tile => tile.Value);
			int prevItem = int.MaxValue;

			foreach (var item in sortedDict)
			{
				if (item.Value < prevItem)
				{
					prevItem = item.Value;
					sb.Append($"\n{item.Value}: {item.Key}");
				}
				else if (item.Value == prevItem)
				{
					sb.Append($", {item.Key}");
				}
			}
			return sb.ToString();
		}
	}
}
