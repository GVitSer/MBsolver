using System;
using Solver;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBsolver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус круга");
            var r = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите стороны треугольника");
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());            

            var areaCircle = AllSolver.AreaCircle(r);
            Console.WriteLine("Площадь круга = {0}", areaCircle);
            Console.WriteLine();
            var areaTriangle = AllSolver.AreaTriangle(a, b, c);
            Console.WriteLine("Площадь треугольника = {0}", areaTriangle);
            Console.ReadLine();
        }
    }
}
