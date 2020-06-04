using System;
using System.IO;
using System.Runtime.CompilerServices;

/*
 * TreeBuilder: A console app that will allow users to design
 * customized directory trees to be applied to a current "root"
 * path. Largely based from code in a Java version from 2018.
 * 
 * Authored by Valenthyne, June 4 2020 - undetermined
 */

namespace TreeBuilder
{
	static class Path
	{
		public static String path;
	}

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to TreeBuilder!\n");

			bool stay = true;

			// Set the default path to C drive
			Path.path = "C:\\";

			while (stay)
			{
				MainMenu();
				char sel = Console.ReadKey().KeyChar;
				Console.WriteLine("\n");

				switch (sel)
				{
					case '1': NavMenu();
						break;
					case '2': BranchMenu();
						break;
					case '3': GenMenu();
						break;
					default: stay = false;
						break;
				}
			}

			Console.WriteLine("Thank you for using TreeBuilder!");
			Console.ReadKey();
		}

		// Method to print the menu for user input
		static void MainMenu()
		{
			Console.WriteLine("\n       Main Menu\n");
			Console.WriteLine("   [1]: Navigation");
			Console.WriteLine("   [2]: Branching");
			Console.WriteLine("   [3]: Generation");
			Console.WriteLine("   [4]: Exit");
			Console.Write("\nSelect : ");
		}

		static void NavMenu()
		{
			bool stay = true;

			while (stay)
			{
				Console.WriteLine("\n       Navigation Menu\n");
				Console.WriteLine("Current Path: " + Path.path + "\n");
				Console.WriteLine("   [1]: Change Directory");
				Console.WriteLine("   [2]: Previous Directory");
				Console.WriteLine("   [3]: Drive Selection");
				Console.WriteLine("   [4]: Print Contents");
				Console.WriteLine("   [5]: Return");
				Console.Write("\nSelect : ");

				char sel = Console.ReadKey().KeyChar;
				Console.WriteLine("\n");

				switch (sel)
				{
					case '1':
						Console.Write("Enter destination: ");
						String dest = Console.ReadLine();
						String dir = Path.path + dest;
						
						if (Directory.Exists(dir))
						{
							Path.path = dir + "\\";
							Console.WriteLine("New path: " + Path.path);
						}
						else
						{ 
						Console.WriteLine("Directory '" + dir + "' does not exist.");
						}
						break;
					case '2':
						break;
					case '3':
						break;
					case '4':
						break;
					default:
						stay = false;
						break;
				}
			}
		}

		static void BranchMenu()
		{
			bool stay = true;

			while (stay)
			{
				Console.WriteLine("\n       Branch Menu\n");
				Console.WriteLine("   [1]: Design Branch");
				Console.WriteLine("   [2]: View Branch");
				Console.WriteLine("   [3]: Clear Branch");
				Console.WriteLine("   [4]: Return");
				Console.Write("\nSelect : ");

				char sel = Console.ReadKey().KeyChar;
				Console.WriteLine("\n");

				switch (sel)
				{
					case '1':
						break;
					case '2':
						break;
					case '3':
						break;
					default:
						stay = false;
						break;
				}
			}
		}

		static void GenMenu()
		{
			bool stay = true;

			while (stay)
			{
				Console.WriteLine("\n       Generate Menu\n");
				Console.WriteLine("   [1]: Create Directories");
				Console.WriteLine("   [2]: Generate Branch");
				Console.WriteLine("   [3]: Unload Branch");
				Console.WriteLine("   [4]: Return");
				Console.Write("\nSelect : ");

				char sel = Console.ReadKey().KeyChar;
				Console.WriteLine("\n");

				switch (sel)
				{
					case '1':
						break;
					case '2':
						break;
					case '3':
						break;
					default:
						stay = false;
						break;
				}
			}
		}
	}
}
