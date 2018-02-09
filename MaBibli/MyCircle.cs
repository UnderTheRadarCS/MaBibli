using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGraphicsComponents
{

	public class MyCircle : MyShape, IlsPointIn, IComparable<MyCircle>, IEquatable<MyCircle>
	{
		private int _rayon;
		
		public int Rayon
		{
			get { return _rayon; }
			set { _rayon = value;}
		}

		public MyCircle()
		{
			Rayon = 10;
		}

		public MyCircle(int rayon)
		{
			Rayon = rayon;
		}

		public MyCircle(int rayon, MyPoint accroche)
		{
			Rayon = rayon;
			Accroche = accroche;
		}

		public override string ToString()
		{
			return "MyCircle :    accroche = " + Accroche + "    Rayon = " + Rayon + "\n";
		}

		public override int GetAire()
		{
			return (int)((double)Rayon * (double)Rayon * Math.PI);
		}


		public override void Draw()
		{
			Console.WriteLine("Methode Draw -> " + this);
		}

		public bool IsPointIn(MyPoint point)
		{
			int iVarx, iVary, Idifference;

			if (point.X > Accroche.X)
				iVarx = point.X - Accroche.X;
			else
				iVarx = Accroche.X - point.X;

			if (point.Y > Accroche.Y)
				iVary = point.Y - Accroche.Y;
			else
				iVary = Accroche.Y - point.Y;

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
			return a.Accroche.X.CompareTo(b.Accroche.X);
		}

	}

}
