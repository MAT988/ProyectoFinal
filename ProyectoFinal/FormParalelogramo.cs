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
    public partial class FormParalelogramo : Form
    {
        private Stack<Poligono> pilaPoligonos;

        public FormParalelogramo(Stack<Poligono> pila)
        {
            InitializeComponent();
            pilaPoligonos = pila;
        }

        private void btnCrearParalelogramo_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtBase.Text, out double baseParalelogramo) &&
                double.TryParse(txtAltura.Text, out double alturaParalelogramo))
            {
                Paralelogramo paralelogramo = new Paralelogramo(baseParalelogramo, alturaParalelogramo);
                pilaPoligonos.Push(paralelogramo);
                lblMensaje.Text = "Paralelogramo añadido a la pila.";
            }
            else
            {
                lblMensaje.Text = "Por favor, ingrese valores válidos.";
            }
        }
    }
}

