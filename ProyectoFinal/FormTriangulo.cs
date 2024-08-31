using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Windows.Forms;

namespace ProyectoFinal.Clases
{
    public partial class FormTriangulo : Form
    {
        private Stack<Poligono> pilaPoligonos;

        public FormTriangulo(Stack<Poligono> pila)
        {
            InitializeComponent();
            pilaPoligonos = pila;
        }

        private void btnCrearTriangulo_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtBase.Text, out double baseTriangulo) &&
                double.TryParse(txtAltura.Text, out double alturaTriangulo))
            {
                Triangulo triangulo = new Triangulo(baseTriangulo, alturaTriangulo);
                pilaPoligonos.Push(triangulo);
                lblMensaje.Text = "Triángulo añadido a la pila.";
            }
            else
            {
                lblMensaje.Text = "Por favor, ingrese valores válidos.";
            }
        }
    }
}
