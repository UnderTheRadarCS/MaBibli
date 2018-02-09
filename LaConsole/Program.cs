using MyGraphicsComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
	class Program
	{
		static void Main(string[] args)
		{
			MyCircle Cercle1 = new MyCircle(10, new MyPoint(5, 10));
			MyCircle Cercle2 = new MyCircle();

			MySquare Carre1 = new MySquare(30,new MyPoint(30,40));
			MySquare Carre2 = new MySquare();

			MyRectangle Rectangle1 = new MyRectangle(10,20,  new MyPoint(30, 40));
			MyRectangle Rectangle2 = new MyRectangle();

			Cercle1.Draw();
			Cercle2.Draw();

			Carre1.Draw();
			Carre2.Draw();

			Rectangle1.Draw();
			Rectangle2.Draw();

			List<MyShape> formes = new List<MyShape>();
			formes.Add(Cercle1);
			formes.Add(Cercle2);
			formes.Add(Rectangle1);
			formes.Add(Rectangle2);
			formes.Add(Carre1);
			formes.Add(Carre2);
			

			Console.WriteLine("\nContenu de la liste : \n");

			foreach (MyShape shape in formes)
			{
				shape.Draw();
			}

			Console.WriteLine("\nContenu de la liste implémentant IPointy: \n");

			foreach (MyShape shape in formes)
			{
				if(shape is IPointy)
					shape.Draw();
			}

			Console.WriteLine("\nContenu de la liste n'implémentant PAS IPointy: \n");

			foreach (MyShape shape in formes)
			{
				if (!(shape is IPointy))
					shape.Draw();
			}

			List<MySquare> carre = new List<MySquare>();
			
			carre.Add(Carre1);
			carre.Add(Carre2);
			carre.Add(new MySquare(15, new MyPoint(10, 10)));
			carre.Add(new MySquare(20, new MyPoint(35, 45)));
			
			carre.Sort();

			Console.WriteLine("\nContenu de la liste de carré triée : \n");

			foreach (MyShape shape in carre)
			{
					shape.Draw();
			}

			MySquareAbscisseComparer pcomp = new MySquareAbscisseComparer();
			carre.Sort(pcomp);

			Console.WriteLine("\nContenu de la liste de carrée triée par ordre croissant des abscisses : \n");

			foreach (MyShape shape in carre)
			{
				shape.Draw();
			}

			Console.WriteLine("\nCarré de la liste dont la longueur vaut 15 : \n");

			(carre.Find(x => x.Longueur == 15)).Draw();

			Console.WriteLine("\nCarré de la liste dont le point (20,20) fait partie : \n");

			foreach (MySquare shape in carre)
			{
				if (shape.IsPointIn(new MyPoint(20, 20)))
					shape.Draw(); 
			}

			formes.Sort();

			Console.WriteLine("\nListe de Formes affichées par Aire : \n");

			foreach (MyShape shape in formes)
			{
					shape.Draw();
			}

			while (1 == 1) ;
		}
	}
}
