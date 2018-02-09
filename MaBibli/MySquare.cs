using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGraphicsComponents
{
	public class MySquare : MyShape, IlsPointIn, IPointy, IComparable<MySquare>, IEquatable<MySquare>
	{
		private int _longueur;
		
		public int Longueur
		{
			get { return _longueur; }
			set { _longueur = value; }
		}

		public int Points()
		{
			return 4;
		}

		public MySquare()
		{
			Longueur = 10;
		}

		public MySquare(int longueur)
		{
			Longueur = longueur;
		}

		public MySquare(int longueur, MyPoint accroche)
		{
			Longueur = longueur;
			Accroche = accroche;
		}

		public int CompareTo(MySquare other)
		{
			return Longueur.CompareTo(other.Longueur);
		}

		public bool Equals(MySquare square)
		{
			if (square != null && square is MySquare)
				return Longueur.Equals(square.Longueur);
			else
				return false;
		}

		public override int GetHashCode()
		{
			return ToString().GetHashCode();
		}

		public override string ToString()
		{
			return "MySquare :    accroche = " + Accroche + "    longueur = " + Longueur + "\n";
		}

		public override int GetAire()
		{
			return Longueur * Longueur;
		}

		public override void Draw()
		{
			Console.WriteLine("Methode Draw -> " + this);
		}

		public bool IsPointIn(MyPoint point)
		{
			if (point.X < this.Accroche.X || point.Y < this.Accroche.Y)
				return false;
			else
				if (point.X > (this.Accroche.X + this.Longueur) || point.Y > (this.Accroche.Y + this.Longueur))
				return false;
			else
				return true;
		}
	}

	public class MySquareAbscisseComparer : IComparer<MySquare>
	{
		public int Compare(MySquare a, MySquare b)
		{
			return a.Accroche.X.CompareTo(b.Accroche.X);
		}

	}


}
