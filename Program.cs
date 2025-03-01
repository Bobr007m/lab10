using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    // Базовый класс
    public class GeometricFigure
    {
        public string Name { get; set; }
        public double Area { get; protected set; }

        public GeometricFigure() { }

        public GeometricFigure(string name)
        {
            Name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Фигура: {Name}, Площадь: {Area}");
        }

        public virtual void Init()
        {
            Console.Write("Введите название фигуры: ");
            Name = Console.ReadLine();
        }

        public virtual void RandomInit()
        {
            Random rnd = new Random();
            Name = "Фигура_" + rnd.Next(1, 100);
            Area = rnd.Next(1, 100);
        }

        public override bool Equals(object obj)
        {
            if (obj is GeometricFigure figure)
            {
                return Name == figure.Name && Area == figure.Area;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Фигура: {Name}, Площадь: {Area}";
        }
        public static void ShowAllSquares(GeometricFigure[] figures)
        {
            foreach (var figure in figures)
            {
                if (figure is Rectangle rect && rect.Length == rect.Width)
                {
                    Console.WriteLine(rect);
                }
            }
        }

        public static void ShowFiguresWithAreaGreaterThan(GeometricFigure[] figures, double minArea)
        {
            foreach (var figure in figures)
            {
                if (figure.Area >= minArea)
                {
                    Console.WriteLine(figure);
                }
            }
        }

        public static void ShowFiguresWithRadius(GeometricFigure[] figures, double radius)
        {
            foreach (var figure in figures)
            {
                if (figure is Circle circle && circle.Radius == radius)
                {
                    Console.WriteLine(circle);
                }
            }
        }
    }
    }
