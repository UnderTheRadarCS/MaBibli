using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGraphicsComponents
{

	public class MyRectangle : MyShape, IlsPointIn, IPointy, IComparable<MyRectangle>, IEquatable<MyRectangle>
	{
		
		public int Points()
		{
			return 4;
		}

		private int _longueur;

		public int Longueur
		{
			get {return _longueur; }
			set {_longueur = value; }
		}

		private int _largeur;

		public int Largeur
		{
			get { return _largeur; }
			set { _largeur = value; }
		}

		public MyRectangle()
		{
			Largeur = 5;
			Longueur = 10;
		}

		public MyRectangle(int longueur, int largeur)
		{
			Longueur = longueur;
			Largeur = largeur;
		}

		public MyRectangle(int longueur, int largeur, MyPoint accroche)
		{
			Longueur = longueur;
			Largeur = largeur;
			Accroche = accroche;
		}

		public override string ToString()
		{
			return "MyRectangle :    accroche = " + Accroche + "    longueur = " + Longueur + "    largeur = " + Largeur + "\n";
		}

		public override int GetAire()
		{
			return Longueur * Largeur;
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
				if (point.X > (this.Accroche.X + this.Longueur) || point.Y > (this.Accroche.Y + this.Largeur))
				return false;
			else
				return true;
		}

		public int CompareTo(MyRectangle other)
		{
			return (Longueur*Largeur).CompareTo((other.Longueur * other.Largeur));
		}

		public bool Equals(MyRectangle rect)
		{
			if (rect != null && rect is MyRectangle)
				return (Longueur.Equals(rect.Longueur) && Largeur.Equals(rect.Largeur));
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
			return a.Accroche.X.CompareTo(b.Accroche.X);
		}

	}

}
