using System;

namespace Alakazam
{
    class Program
    {
		static void Main(string[] args)
		{
			int a = 0;
			string b = "alaka";
			string c = "zam";
			while (a != 100)
			{
				a = ++a;
				Console.WriteLine(a);
				if (a % 3 == 0 && a % 4 == 0)
				{
					Console.WriteLine(b + c);
				}
				else if (a % 3 == 0)
				{
					Console.WriteLine(b);
				}
				else if (a % 4 == 0)
				{
					Console.WriteLine(c);
				}
				
			}
		}
    }
}
