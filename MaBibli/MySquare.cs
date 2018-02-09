using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBibli
{
	public class MySquare : MyShape, IlsPointIn, IPointy, IComparable<MySquare>, IEquatable<MySquare>
	{
		public int longueur
		{ get; set; }

		public byte Points
		{ get; }

		public MySquare()
		{
			Points = 4;
			longueur = 10;
		}

		public MySquare(int x)
		{
			Points = 4;
			longueur = x;
		}

		public MySquare(int x, MyPoint acc)
		{
			Points = 4;
			longueur = x;
			accroche.x = acc.x;
			accroche.y = acc.y;
		}

		public int CompareTo(MySquare other)
		{
			return longueur.CompareTo(other.longueur);
		}

		public bool Equals(MySquare square)
		{
			if (square != null && square is MySquare)
				return longueur.Equals(square.longueur);
			else
				return false;
		}

		public override int GetHashCode()
		{
			return ToString().GetHashCode();
		}

		public override string ToString()
		{
			return "MySquare :    accroche = " + accroche.ToString() + "    longueur = " + longueur + "\n";
		}

		public override int GetAire()
		{
			return longueur * longueur;
		}

		public override void Draw()
		{
			Console.WriteLine("Methode Draw -> " + this.ToString());
		}

		public bool IsPointIn(MyPoint point)
		{
			if (point.x < this.accroche.x || point.y < this.accroche.y)
				return false;
			else
				if (point.x > (this.accroche.x + this.longueur) || point.y > (this.accroche.y + this.longueur))
				return false;
			else
				return true;
		}
	}

	public class MySquareAbscisseComparer : IComparer<MySquare>
	{
		public int Compare(MySquare a, MySquare b)
		{
			return a.accroche.x.CompareTo(b.accroche.x);
		}

	}


}
