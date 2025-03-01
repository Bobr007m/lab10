using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    // Производный класс Окружность
    public class Circle : GeometricFigure
    {
        public double Radius { get; set; }

        public Circle() : base("Окружность") { }

        public override void Init()
        {
            base.Init();
            Console.Write("Введите радиус: ");
            Radius = Convert.ToDouble(Console.ReadLine());
            Area = Math.PI * Radius * Radius;
        }

        public override void RandomInit()
        {
            base.RandomInit();
            Random rnd = new Random();
            Radius = rnd.Next(1, 100);
            Area = Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return base.ToString() + $", Радиус: {Radius}";
        }
    }
}
