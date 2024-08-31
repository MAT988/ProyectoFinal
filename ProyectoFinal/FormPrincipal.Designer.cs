namespace ProyectoFinal.Clases
{
    partial class FormPrincipal
    {
        private void InitializeComponent()
        {
            this.btnAbrirTriangulo = new System.Windows.Forms.Button();
            this.btnAbrirRectangulo = new System.Windows.Forms.Button();
            this.btnAbrirParalelogramo = new System.Windows.Forms.Button();
            this.btnMostrarPila = new System.Windows.Forms.Button();
            this.lblPila = new System.Windows.Forms.Label();
            this.SuspendLayout();
         
            this.btnAbrirTriangulo.Location = new System.Drawing.Point(12, 12);
            this.btnAbrirTriangulo.Name = "btnAbrirTriangulo";
            this.btnAbrirTriangulo.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirTriangulo.TabIndex = 0;
            this.btnAbrirTriangulo.Text = "Triángulo";
            this.btnAbrirTriangulo.UseVisualStyleBackColor = true;
            this.btnAbrirTriangulo.Click += new System.EventHandler(this.btnAbrirTriangulo_Click);
           
            this.btnAbrirRectangulo.Location = new System.Drawing.Point(12, 41);
            this.btnAbrirRectangulo.Name = "btnAbrirRectangulo";
            this.btnAbrirRectangulo.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirRectangulo.TabIndex = 1;
            this.btnAbrirRectangulo.Text = "Rectángulo";
            this.btnAbrirRectangulo.UseVisualStyleBackColor = true;
            this.btnAbrirRectangulo.Click += new System.EventHandler(this.btnAbrirRectangulo_Click);
          
            this.btnAbrirParalelogramo.Location = new System.Drawing.Point(12, 70);
            this.btnAbrirParalelogramo.Name = "btnAbrirParalelogramo";
            this.btnAbrirParalelogramo.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirParalelogramo.TabIndex = 2;
            this.btnAbrirParalelogramo.Text = "Paralelogramo";
            this.btnAbrirParalelogramo.UseVisualStyleBackColor = true;
            this.btnAbrirParalelogramo.Click += new System.EventHandler(this.btnAbrirParalelogramo_Click);
          
            this.btnMostrarPila.Location = new System.Drawing.Point(12, 99);
            this.btnMostrarPila.Name = "btnMostrarPila";
            this.btnMostrarPila.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarPila.TabIndex = 3;
            this.btnMostrarPila.Text = "Mostrar Pila";
            this.btnMostrarPila.UseVisualStyleBackColor = true;
            this.btnMostrarPila.Click += new System.EventHandler(this.btnMostrarPila_Click);
          
            this.lblPila.AutoSize = true;
            this.lblPila.Location = new System.Drawing.Point(93, 17);
            this.lblPila.Name = "lblPila";
            this.lblPila.Size = new System.Drawing.Size(0, 13);
            this.lblPila.TabIndex = 4;
          
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblPila);
            this.Controls.Add(this.btnMostrarPila);
            this.Controls.Add(this.btnAbrirParalelogramo);
            this.Controls.Add(this.btnAbrirRectangulo);
            this.Controls.Add(this.btnAbrirTriangulo);
            this.Name = "FormPrincipal";
            this.Text = "Formulario Principal";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnAbrirTriangulo;
        private System.Windows.Forms.Button btnAbrirRectangulo;
        private System.Windows.Forms.Button btnAbrirParalelogramo;
        private System.Windows.Forms.Button btnMostrarPila;
        private System.Windows.Forms.Label lblPila;
    }
}