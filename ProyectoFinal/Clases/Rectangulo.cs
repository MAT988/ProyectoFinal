using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Clases
{
    public class Rectangulo : FiguraGeometrica, Poligono
    {
        private double baseRectangulo;
        private double altura;

        public Rectangulo(double baseRectangulo, double altura) : base("Rectángulo")
        {
            this.baseRectangulo = baseRectangulo;
            this.altura = altura;
        }

        public double Area(double valor1, double valor2)
        {
            return valor1 * valor2;
        }

        public override string ToString()
        {
            return $"{Nombre}: Área = {Area(baseRectangulo, altura)}";
        }
    }

}
