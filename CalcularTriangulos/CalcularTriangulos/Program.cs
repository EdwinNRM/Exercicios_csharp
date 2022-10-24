using System;
using System.Globalization;
namespace AreaTriangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();
            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double areaX = x.Area();
            double areaY = y.Area();
            
            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            
            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else if (areaY > areaX)
            {
                Console.WriteLine("Maior área: Y");
            }
            else
            {
                Console.WriteLine("Os triângulos tem a mesma área!");
            }
        }
    }
}