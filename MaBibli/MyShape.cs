using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGraphicsComponents
{
	abstract public class MyShape : IComparable<MyShape>
	{

		private MyPoint _accroche;

		public MyPoint Accroche
		{
			get { return _accroche; }
			set { _accroche = value; }
		}

		public MyShape()
		{
			Accroche = new MyPoint();
		}

		public int CompareTo(MyShape other)
		{
			return GetAire().CompareTo(other.GetAire());
		}

		public abstract int GetAire();

		public abstract void Draw();
	}


	
}
