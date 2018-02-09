using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBibli
{

	public class MyCircle : MyShape, IlsPointIn, IComparable<MyCircle>, IEquatable<MyCircle>
	{
		public int Rayon
		{ get; set; }

		public MyCircle()
		{
			Rayon = 10;
		}

		public MyCircle(int x)
		{
			Rayon = x;
		}

		public MyCircle(int x, MyPoint acc)
		{
			Rayon = x;
			accroche.x = acc.x;
			accroche.y = acc.y;
		}

		public override string ToString()
		{
			return "MyCircle :    accroche = " + accroche.ToString() + "    Rayon = " + Rayon + "\n";
		}

		public override int GetAire()
		{
			return (int)((double)Rayon * (double)Rayon * Math.PI);
		}


		public override void Draw()
		{
			Console.WriteLine("Methode Draw -> " + this.ToString());
		}

		public bool IsPointIn(MyPoint point)
		{
			int iVarx, iVary, Idifference;

			if (point.x > accroche.x)
				iVarx = point.x - accroche.x;
			else
				iVarx = accroche.x - point.x;

			if (point.y > accroche.y)
				iVary = point.y - accroche.y;
			else
				iVary = accroche.y - point.y;

			Idifference = (int)Math.Sqrt((double)((iVarx * iVarx) + (iVary * iVary)));  // Go 3e secondaire

			if (Idifference > Rayon)
				return false;
			else
				return true;
		}


		public int CompareTo(MyCircle other)
		{
			return Rayon.CompareTo(other.Rayon);
		}

		public bool Equals(MyCircle cercle)
		{
			if (cercle != null && cercle is MyCircle)
				return (Rayon.Equals(cercle.Rayon));
			else
				return false;
		}

		public override int GetHashCode()
		{
			return ToString().GetHashCode();
		}
	}

	public class MyCircleAbscisseComparer : IComparer<MyCircle>
	{
		public int Compare(MyCircle a, MyCircle b)
		{
			return a.accroche.x.CompareTo(b.accroche.x);
		}

	}

}
