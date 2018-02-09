using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBibli
{

	public class MyPoint
	{


		public int x
		{ get; set; }
		public int y
		{ get; set; }

		public MyPoint()
		{
			x = 0;
			y = 0;
		}

		public MyPoint(int a, int b)
		{
			x = a;
			y = b;
		}

		public override string ToString()
		{
			return "Point : ( " + x + ", " + y + ")";
		}

	}

}
