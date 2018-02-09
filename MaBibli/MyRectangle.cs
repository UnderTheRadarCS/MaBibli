using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBibli
{

	public class MyRectangle : MyShape, IlsPointIn, IPointy, IComparable<MyRectangle>, IEquatable<MyRectangle>
	{
		public byte Points
		{ get; }

		public int longueur
		{ get; set; }

		public int largeur
		{ get; set; }

		public MyRectangle()
		{
			Points = 4;
			largeur = 5;
			longueur = 10;
		}

		public MyRectangle(int x, int y)
		{
			Points = 4;
			longueur = x;
			largeur = y;
		}

		public MyRectangle(int x, int y, MyPoint acc)
		{
			Points = 4;
			longueur = x;
			largeur = y;
			accroche.x = acc.x;
			accroche.y = acc.y;
		}

		public override string ToString()
		{
			return "MyRectangle :    accroche = " + accroche.ToString() + "    longueur = " + longueur + "    largeur = " + largeur + "\n";
		}

		public override int GetAire()
		{
			return longueur * largeur;
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
				if (point.x > (this.accroche.x + this.longueur) || point.y > (this.accroche.y + this.largeur))
				return false;
			else
				return true;
		}

		public int CompareTo(MyRectangle other)
		{
			return (longueur*largeur).CompareTo((other.longueur * other.largeur));
		}

		public bool Equals(MyRectangle rect)
		{
			if (rect != null && rect is MyRectangle)
				return (longueur.Equals(rect.longueur) && largeur.Equals(rect.largeur));
			else
				return false;
		}

		public override int GetHashCode()
		{
			return ToString().GetHashCode();
		}

	}


	public class MyRectangleAbscisseComparer : IComparer<MyRectangle>
	{
		public int Compare(MyRectangle a, MyRectangle b)
		{
			return a.accroche.x.CompareTo(b.accroche.x);
		}

	}

}
