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
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoFinal.Clases
{
    public partial class FormPrincipal : Form
    {
        private Stack<Poligono> pilaPoligonos = new Stack<Poligono>();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnAbrirTriangulo_Click(object sender, EventArgs e)
        {
            FormTriangulo formTriangulo = new FormTriangulo(pilaPoligonos);
            formTriangulo.Show();
        }

        private void btnAbrirRectangulo_Click(object sender, EventArgs e)
        {
            FormRectangulo formRectangulo = new FormRectangulo(pilaPoligonos);
            formRectangulo.Show();
        }

        private void btnAbrirParalelogramo_Click(object sender, EventArgs e)
        {
            FormParalelogramo formParalelogramo = new FormParalelogramo(pilaPoligonos);
            formParalelogramo.Show();
        }

        private void btnMostrarPila_Click(object sender, EventArgs e)
        {
            lblPila.Text = string.Join(Environment.NewLine, pilaPoligonos);
        }
    }
}
