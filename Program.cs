using System;
using System.IO;

/*
 * TreeBuilder: A console app that will allow users to design
 * customized directory trees to be applied to a current "root"
 * path. Largely based from code in a Java version from 2018.
 * 
 * Authored by Valenthyne, June 4 2020 - undetermined
 */ 

namespace TreeBuilder
{
	class Program
	{
		// Variables
		String driveLetter = "C:\\";

		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to TreeBuilder!\n");

			bool stay = true;

			while (stay)
			{
				printMenu();
				char sel = Console.ReadKey().KeyChar;
				Console.WriteLine("\n");

				switch (sel)
				{
					case '1': navMenu();
						break;
					case '2': branchMenu();
						break;
					case '3': genMenu();
						break;
					default: stay = false;
						break;
				}
			}

			Console.WriteLine("\n\nThank you for using TreeBuilder!");
			Console.ReadKey();
		}

		// Method to print the menu for user input
		static void printMenu()
		{
			Console.WriteLine("   [1]: Navigation");
			Console.WriteLine("   [2]: Branching");
			Console.WriteLine("   [3]: Generation");
			Console.WriteLine("   [4]: Exit");
			Console.Write("\nSelect : ");
		}

		static void navMenu()
		{

		}

		static void branchMenu()
		{

		}

		static void genMenu()
		{

		}
	}
}
