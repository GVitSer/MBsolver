using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solver
{
    public class AllSolver
    {
        //Вычисление площади круга по радиусу.
        public static double AreaCircle(double r)
        {
            double pi = 3.14;
            var arcir = pi * r * r;
            return arcir;
        }

        //Вычисление площади треугольника по трем сторонам
        public static double AreaTriangle(double a, double b, double c)
        {
            if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a))
                return RightTriangle(a, b, c);
            else
            {
                var p = (a + b + c) / 2;
                var s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return s;
            }
        }
        
        //Проверка на то, является ли треугольник прямоугольным.
        public static double RightTriangle(double a, double b, double c)
        {
            Console.WriteLine("Треугольник прямоугольный");
            if (a * a + b * b == c * c)
                return (a * a + b * b) / 2;
            else if (a * a + c * c == b * b)
                return (a * a + c * c) / 2;
            else
                return (c * c + b * b) / 2;
        }
        //Легкость добавления других фигур. Реализацию этого задания я расценил как реализацию принципа
        //Open/Closed Principle в принципах SOLID. Иначе говоря, добавление новых фигур достигается за счёт добавления
        //новых методов в dll, а не изменения кода.

        //Вычисление площади фигуры без знания типа фигуры. Здесь мне непонятно, по каким параметрам определять
        //тип фигуры. Если кривая описывается формулой, то можно применять интеграл для вычисления площади,
        //если многоугольник, то в каждом случае определять количество сторон и взаимную ориентацию этих сторон
        //относительно друг друга.
    }
}
