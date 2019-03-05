using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_Laboratorio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido Usuario");
            Console.WriteLine("==================");
            Console.WriteLine("");
            Console.WriteLine("Programa para hayar el Perimetro y Area de un rectangulo en un Plano Cartesiano.");
            // Crear Rectangulo
            Rectangulo rectangulo = new Rectangulo();

            Console.WriteLine("Ingrese Punto 1 en el Eje X:");
            double p1X = Convert.ToDouble(Console.ReadLine());
            rectangulo.P1EjeX = p1X;
            Console.WriteLine("Ingrese Punto 1 en el Eje Y:");
            double p1Y = Convert.ToDouble(Console.ReadLine());
            rectangulo.P1EjeY = p1Y;
            Console.WriteLine("Ingrese Punto 2 en el Eje X:");
            double p2X = Convert.ToDouble(Console.ReadLine());
            rectangulo.P2EjeX = p2X;
            Console.WriteLine("Ingrese Punto 2 en el Eje Y:");
            double p2Y = Convert.ToDouble(Console.ReadLine());
            rectangulo.P2EjeY = p1Y;
            Console.WriteLine("Ingrese Punto 3 en el Eje X:");
            double p3X = Convert.ToDouble(Console.ReadLine());
            rectangulo.P3EjeX = p3X;
            Console.WriteLine("Ingrese Punto 3 en el Eje Y:");
            double p3Y = Convert.ToDouble(Console.ReadLine());
            rectangulo.P3EjeY = p3Y;
            Console.WriteLine("Ingrese Punto 4 en el Eje X:");
            double p4X = Convert.ToDouble(Console.ReadLine());
            rectangulo.P4EjeX = p4X;
            Console.WriteLine("Ingrese Punto 4 en el Eje Y:");
            double p4Y = Convert.ToDouble(Console.ReadLine());
            rectangulo.P4EjeY = p4Y;

            double Perimetro;
            double Area;

            Perimetro = rectangulo.CalcularPerimetro();
            Area = rectangulo.CalcularArea();

            Console.WriteLine(string.Concat("El Perimetro de el Rectangulo es: [", Perimetro.ToString(), "]"));
            Console.WriteLine("===");
            Console.WriteLine(string.Concat("El Area de el Rectangulo es: [", Area.ToString(), "]"));
            Console.WriteLine("===");
            Console.WriteLine("Gracias por Usar el Programa");

            Console.Read();
        }
    }
}
