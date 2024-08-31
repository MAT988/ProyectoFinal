using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Clases
{
    public class Paralelogramo : FiguraGeometrica, Poligono
    {
        private double baseParalelogramo;
        private double altura;

        public Paralelogramo(double baseParalelogramo, double altura) : base("Paralelogramo")
        {
            this.baseParalelogramo = baseParalelogramo;
            this.altura = altura;
        }

        public double Area(double valor1, double valor2)
        {
            return valor1 * valor2;
        }

        public override string ToString()
        {
            return $"{Nombre}: Área = {Area(baseParalelogramo, altura)}";
        }
    }

}
