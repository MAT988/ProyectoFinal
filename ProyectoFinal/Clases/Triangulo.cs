using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Clases
{
    public class Triangulo : FiguraGeometrica, Poligono
    {
        private double baseTriangulo;
        private double altura;

        public Triangulo(double baseTriangulo, double altura) : base("Triángulo")
        {
            this.baseTriangulo = baseTriangulo;
            this.altura = altura;
        }

        public double Area(double valor1, double valor2)
        {
            return 0.5 * valor1 * valor2;
        }

        public override string ToString()
        {
            return $"{Nombre}: Área = {Area(baseTriangulo, altura)}";
        }
    }

}
