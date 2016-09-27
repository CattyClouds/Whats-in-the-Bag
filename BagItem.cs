using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_s_in_the_Bag
{
	/// <summary>
	/// Defines an item in the bag and the amount of that item.
	/// </summary>
	class BagItem
	{
		public static char Tile { get; set; }
		public static int Amount { get; set; }

		static BagItem()
		{
			char tile = '>';
			int amount = 0;

			Tile = tile;
			Amount = amount;
		}
	}
}
