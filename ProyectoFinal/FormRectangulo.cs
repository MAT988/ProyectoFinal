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
    public partial class FormRectangulo : Form
    {
        private Stack<Poligono> pilaPoligonos;

        public FormRectangulo(Stack<Poligono> pila)
        {
            InitializeComponent();
            pilaPoligonos = pila;
        }

        private void btnCrearRectangulo_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtBase.Text, out double baseRectangulo) &&
                double.TryParse(txtAltura.Text, out double alturaRectangulo))
            {
                Rectangulo rectangulo = new Rectangulo(baseRectangulo, alturaRectangulo);
                pilaPoligonos.Push(rectangulo);
                lblMensaje.Text = "Rectángulo añadido a la pila.";
            }
            else
            {
                lblMensaje.Text = "Por favor, ingrese valores válidos.";
            }
        }
    }
}

