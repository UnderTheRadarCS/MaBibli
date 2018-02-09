using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBibli
{
	abstract public class MyShape : IComparable<MyShape>
	{

		public MyPoint accroche
		{
			get; set;
		}

		public MyShape()
		{
			accroche = new MyPoint();
		}

		public int CompareTo(MyShape other)
		{
			return GetAire().CompareTo(other.GetAire());
		}

		public abstract int GetAire();

		public abstract void Draw();
	}


	
}
