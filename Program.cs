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
			Console.Write($"What's in the bag? ");
			//Bag.RemoveTiles(Console.ReadLine());
			Console.WriteLine($"{Environment.NewLine}{dash}");

			Bag.RemoveTiles("AEERTYOXMCNB_S");		// Standard input 1
			//Bag.RemoveTiles("PQAREIOURSTHGWIOAE_");	// Challenge input 1
			//Bag.RemoveTiles("LQTOONOEFFJZT");			// Challenge input 2
			//Bag.RemoveTiles("AXHDRUIOR_XHJZUQEE");	// Challenge input 3

			Bag.SortBag();

			Console.Write($"{Environment.NewLine}{dash}{dash}{dash}{Environment.NewLine}Press any key to exit...");
			Console.ReadKey();
		}
	}
}
