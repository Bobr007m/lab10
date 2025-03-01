using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    // Производный класс Параллелепипед
    public class Parallelepiped : GeometricFigure
    {
        public double Height { get; set; }

        public Parallelepiped() : base("Параллелепипед") { }

        public override void Init()
        {
            base.Init();
            Console.Write("Введите высоту: ");
            Height = Convert.ToDouble(Console.ReadLine());
            Area = Height * 100; // Пример расчета площади
        }

        public override void RandomInit()
        {
            base.RandomInit();
            Random rnd = new Random();
            Height = rnd.Next(1, 100);
            Area = Height * 100; // Пример расчета площади
        }

        public override string ToString()
        {
            return base.ToString() + $", Высота: {Height}";
        }
    }
}
