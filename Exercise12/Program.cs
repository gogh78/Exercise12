using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Разработать статический класс для работы с окружностью. Класс должен содержать 3 метода:
            //•	метод, определяющий длину окружности по заданному радиусу;
            //•	метод, определяющий площадь круга по заданному радиусу;
            //•	метод, проверяющий принадлежность точки с координатами(x, y) кругу с радиусом r и координатами центра x0, y0.
           
            Console.WriteLine("Введите значение радиуса окружности");
            int radius = Convert.ToInt32(Console.ReadLine());
            double length = Circle.Length(radius);
            double square = Circle.Square(radius);
            Console.WriteLine("Длина окружности = {0:0.000}", length);
            Console.WriteLine("Площадь круга = {0:0.000}", square);
            Console.WriteLine("Введите координаты х и y для определения принадлежности точки области окружности с координатами центра 0,0");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            string coordinate = Circle.Coordinate(radius, x, y);
            Console.WriteLine("{0}", coordinate);
            Console.ReadKey();
        }
        
    }
    public static class Circle
    {
        //•	метод, определяющий длину окружности по заданному радиусу;
        public static double Length(int radius)
        {
            return Math.Abs(2*Math.PI *radius);
        }
        //•	метод, определяющий площадь круга по заданному радиусу;
        public static double Square(int radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        //•	метод, проверяющий принадлежность точки с координатами(x, y) кругу с радиусом r и координатами центра x0, y0.
        public static string Coordinate(int radius, int x, int y)
        {
            double positionxy = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            if (positionxy <= Math.Abs(radius))
            {
                return "Точка принадлежит кругу";
            }
            else
            {
                return "Точка не принадлежит кругу";
            }
        }
    }
}
