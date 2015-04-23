using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace misFiguras
{
    public partial class frmTriangulo : Form
    {
        public frmTriangulo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Triangulo a;
            a = new Triangulo();
            a.pLado1 = Convert.ToDouble(txtLado1.Text);
            a.pLado2 = Convert.ToDouble(txtLado2.Text);
            a.pLado3 = Convert.ToDouble(txtLado3.Text);

           // lblcalcularSuperf.Text = Convert.ToString(a.calcularSuperficie());

            if (a.pLado1 == a.pLado2 && a.pLado2 == a.pLado3)
            { 
                lblcalcularSuperf.Text = Convert.ToString(a.calcularSuperficie());
                lblcalcularPerim.Text = Convert.ToString(a.calcularPerimEquilatero());
                a.pTipo = "Equilatero";
            
            }

            if (a.pLado1 != a.pLado2 && a.pLado3 != a.pLado2) 
            {
                lblcalcularSuperf.Text = Convert.ToString(a.calcularSuperficie());
                lblcalcularPerim.Text = Convert.ToString(a.calcularPerimEscaleno());
                a.pTipo = "Escaleno";
            }

            //triangulo isosceles
            if (a.pLado1 == a.pLado2 || a.pLado2 == a.pLado3) 
            {
                lblcalcularSuperf.Text = Convert.ToString(a.calcularSuperficie());
                lblcalcularPerim.Text = Convert.ToString(a.calcularPerimIsosceles());
                a.pTipo = "Isosceles";
            }

            MessageBox.Show(a.toString());
            
        }

        private void txtLado1_Leave(object sender, EventArgs e)
        {
            // mi idea es validar el texto que escribo en este campo. Deben ser solo números mayores a cero. Sino emitir alerta.
            //if (!string.IsNullOrWhiteSpace(txtLado1.Text) || !string.IsNullOrEmpty(txtLado1.Text))
            //{
            //    MessageBox.Show("El lado 1 no puede estar vacio");
            //}
        }

        private void txtLado1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
