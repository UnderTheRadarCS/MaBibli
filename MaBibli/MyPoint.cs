using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGraphicsComponents
{

	public class MyPoint
	{
		private int _x;

		public int X
		{
			get { return _x; }
			set { _x = value; }
		}

		private int _y;

		public int Y
		{
			get {return _y; }
			set {_y = value; }
		}

		public MyPoint()
		{
			X = 0;
			Y = 0;
		}

		public MyPoint(int x, int y)
		{
			X = x;
			Y = y;
		}

		public override string ToString()
		{
			return "Point : ( " + X + ", " + Y + ")";
		}

	}

}
