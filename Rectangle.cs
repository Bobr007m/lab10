using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    // Производный класс Прямоугольник
    public class Rectangle : GeometricFigure
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle() : base("Прямоугольник") { }

        public override void Init()
        {
            base.Init();
            Console.Write("Введите длину: ");
            Length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ширину: ");
            Width = Convert.ToDouble(Console.ReadLine());
            Area = Length * Width;
        }

        public override void RandomInit()
        {
            base.RandomInit();
            Random rnd = new Random();
            Length = rnd.Next(1, 100);
            Width = rnd.Next(1, 100);
            Area = Length * Width;
        }

        public override string ToString()
        {
            return base.ToString() + $", Длина: {Length}, Ширина: {Width}";
        }
    }
}
