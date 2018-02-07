using MaBibli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			MyCircle carre = new MyCircle(10, new MyPoint(5, 10));
			Console.WriteLine("\n\n" + carre.IsPointIn(new MyPoint(15, 20)));
			while (1 == 1) ;
		}
	}
}
