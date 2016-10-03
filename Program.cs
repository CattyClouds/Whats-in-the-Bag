using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_s_in_the_Bag
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WindowHeight = 42; // Debug purposes
			string dash = String.Concat(Enumerable.Repeat("-", 32));

			var bag = new Bag();

			Console.Write($"What's in the bag? ");
			//bag.RemoveTiles(Console.ReadLine());
			Console.WriteLine($"\n{dash}");

			bag.RemoveTiles("AEERTYOXMCNB_S");		// Standard input 1
			//bag.RemoveTiles("PQAREIOURSTHGWIOAE_");	// Challenge input 1
			//bag.RemoveTiles("LQTOONOEFFJZT");			// Challenge input 2
			//bag.RemoveTiles("AXHDRUIOR_XHJZUQEE");	// Challenge input 3

			bag.SortBag();

			Console.Write($"\n{dash}{dash}{dash}\nPress any key to exit...");
			Console.ReadKey();
		}
	}
}
