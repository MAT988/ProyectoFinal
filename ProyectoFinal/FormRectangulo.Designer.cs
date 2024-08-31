using ProyectoFinal.Clases;
using System.Collections.Generic;
using System.Windows.Forms;
using System;

using System;
using System.Windows.Forms;

namespace ProyectoFinal.Clases
{
    partial class FormRectangulo
    {
        private void InitializeComponent()
        {
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.btnCrearRectangulo = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
           
            this.txtBase.Location = new System.Drawing.Point(12, 12);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 20);
            this.txtBase.TabIndex = 0;
          
            this.txtAltura.Location = new System.Drawing.Point(12, 38);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 1;
           
            this.btnCrearRectangulo.Location = new System.Drawing.Point(12, 64);
            this.btnCrearRectangulo.Name = "btnCrearRectangulo";
            this.btnCrearRectangulo.Size = new System.Drawing.Size(75, 23);
            this.btnCrearRectangulo.TabIndex = 2;
            this.btnCrearRectangulo.Text = "Crear";
            this.btnCrearRectangulo.UseVisualStyleBackColor = true;
            this.btnCrearRectangulo.Click += new System.EventHandler(this.btnCrearRectangulo_Click);
         
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(12, 90);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje.TabIndex = 3;
           
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Base";
          
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Altura";
            
            this.ClientSize = new System.Drawing.Size(200, 150);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnCrearRectangulo);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtBase);
            this.Name = "FormRectangulo";
            this.Text = "Rectángulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Button btnCrearRectangulo;
        private System.Windows.Forms.Label lblMensaje;
        private Label label1;
        private Label label2;
    }
}

