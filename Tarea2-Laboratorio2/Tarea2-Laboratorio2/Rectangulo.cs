using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_Laboratorio2
{
    class Rectangulo
    {
        public int Id { get; set; }
        public double P1EjeX { get; set; }
        public double P1EjeY { get; set; }
        public double P2EjeX { get; set; }
        public double P2EjeY { get; set; }
        public double P3EjeX { get; set; }
        public double P3EjeY { get; set; }
        public double P4EjeX { get; set; }
        public double P4EjeY { get; set; }

        public double CalcularPerimetro()
        {
            double d1 = (double)(((P2EjeX-P1EjeX)*(P2EjeX - P1EjeX))+((P2EjeY-P1EjeY)*(P2EjeY - P1EjeY)));
            double Rd1 = Math.Sqrt(d1);
            double d2 = (double)(((P3EjeX-P2EjeX)*(P3EjeX - P2EjeX))+((P3EjeY-P2EjeY)*(P3EjeY - P2EjeY)));
            double Rd2 = Math.Sqrt(d2);
            double d3 = (double)(((P4EjeX-P3EjeX)*(P4EjeX - P3EjeX))+((P4EjeY-P3EjeY)*(P4EjeY - P3EjeY)));
            double Rd3 = Math.Sqrt(d3);
            double d4 = (double)(((P1EjeX-P4EjeX)*(P1EjeX - P4EjeX))+((P1EjeY-P4EjeY)*(P1EjeY - P4EjeY)));
            double Rd4 = Math.Sqrt(d4);
            double perimetro = 2*(Rd1+Rd2);
            return perimetro;
        }

        public double CalcularArea()
        {
            double d1 = (double)(((P2EjeX - P1EjeX) * (P2EjeX - P1EjeX)) + ((P2EjeY - P1EjeY) * (P2EjeY - P1EjeY)));
            double Rd1 = Math.Sqrt(d1);
            double d2 = (double)(((P3EjeX - P2EjeX) * (P3EjeX - P2EjeX)) + ((P3EjeY - P2EjeY) * (P3EjeY - P2EjeY)));
            double Rd2 = Math.Sqrt(d2);
            double d3 = (double)(((P4EjeX - P3EjeX) * (P4EjeX - P3EjeX)) + ((P4EjeY - P3EjeY) * (P4EjeY - P3EjeY)));
            double Rd3 = Math.Sqrt(d3);
            double d4 = (double)(((P1EjeX - P4EjeX) * (P1EjeX - P4EjeX)) + ((P1EjeY - P4EjeY) * (P1EjeY - P4EjeY)));
            double Rd4 = Math.Sqrt(d4);
            double area = (Rd1) * (Rd2);
            return area;
        }
    }
}
