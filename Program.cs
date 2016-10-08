using System;
using System.Linq;

namespace Whats_in_the_Bag
{
	class Program
	{
		static void Main(string[] args)
		{
			string dash = String.Concat(Enumerable.Repeat("-", 32));
			var bag = new Bag();

			Console.Write($"What's in the bag? ");
			//bag.RemoveTiles(Console.ReadLine()); // Enter your own input
			Console.WriteLine($"\n{dash}");

			try
			{
				bag.RemoveTiles("AEERTYOXMCNB_S");			// Standard input 1
				//bag.RemoveTiles("PQAREIOURSTHGWIOAE_");	// Challenge input 1
				//bag.RemoveTiles("LQTOONOEFFJZT");			// Challenge input 2
				//bag.RemoveTiles("AXHDRUIOR_XHJZUQEE");	// Challenge input 3
				Console.Write(bag.FormatContents());
			}
			catch (Exception ex)
			{
				Console.Write(ex.Message);
			}

			Console.Write($"\n{dash}{dash}{dash}\nPress any key to exit...");
			Console.ReadKey();
		}
	}
}
