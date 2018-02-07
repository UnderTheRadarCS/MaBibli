using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBibli
{
	abstract public class MyShape
	{

		public MyPoint accroche
		{
			get; set;
		}

		public MyShape()
		{
			accroche = new MyPoint();
		}

		public abstract void Draw();
	}

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

	public class MySquare : MyShape , IlsPointIn
	{
		public int longueur
			{ get; set; }
		
		public MySquare()
		{
			longueur = 10;
		}

		public MySquare(int x)
		{
			longueur = x;
		}

		public MySquare(int x, MyPoint acc)
		{
			longueur = x;
			accroche.x = acc.x;
			accroche.y = acc.y;
		}

		public override string ToString()
		{
			return "MySquare :\n    accroche = " + accroche.ToString() + "\n    longueur = " + longueur + "\n";
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

	public class MyCircle : MyShape , IlsPointIn
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
			return "MyCircle :\n    accroche = " + accroche.ToString() + "\n    Rayon = " + Rayon + "\n";
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
	}

	public class MyRectangle : MyShape , IlsPointIn
	{
		public int longueur
		{ get; set; }

		public int largeur
		{ get; set; }

		public MyRectangle()
		{
			largeur = 5 ;
			longueur = 10 ;
		}

		public MyRectangle(int x, int y)
		{
			longueur = x;
			largeur = y;
		}

		public MyRectangle(int x, int y, MyPoint acc)
		{
			longueur = x;
			largeur = y;
			accroche.x = acc.x;
			accroche.y = acc.y;
		}

		public override string ToString()
		{
			return "MyRectangle :\n    accroche = " + accroche.ToString() + "\n    longueur = " + longueur + "\n    largeur = " + largeur + "\n";
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
	}
}
