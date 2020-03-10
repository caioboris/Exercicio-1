using System;

namespace ConsoleApp5
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] nomes =
			{
				"Fabio Junior",
				"Fiuk",
				"Cleo Pires",
				"Gloria pires"

			};

			foreach(var nome in nomes)
			{
				Console.WriteLine($"O nome é  {nome}");
			}

			Console.ReadLine();
		}
	}
}
