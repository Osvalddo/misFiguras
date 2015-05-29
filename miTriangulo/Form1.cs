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
        Triangulo a;

        public frmTriangulo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLado1.Text) || string.IsNullOrEmpty(txtLado2.Text) || string.IsNullOrEmpty(txtLado3.Text))
            {
                ErrorProvider.Equals(txtLado1, "Error");
                MessageBox.Show("Completa los campos con datos numéricos", "Error");
            }
            else
            {

                a = new Triangulo();
                a.pLado1 = Convert.ToDouble(txtLado1.Text);
                a.pLado2 = Convert.ToDouble(txtLado2.Text);
                a.pLado3 = Convert.ToDouble(txtLado3.Text);
                a.pTipo = a.tipoTriangulo();

                // lblcalcularSuperf.Text = Convert.ToString(a.calcularSuperficie());

                //if ((a.pLado1 == a.pLado2) & (a.pLado2 == a.pLado3))
                //{ 
                //    lblcalcularSuperf.Text = Convert.ToString(a.calcularSuperficie());
                //    lblcalcularPerim.Text = Convert.ToString(a.calcularPerimEquilatero());
                //    a.pTipo = "Equilatero";

                //}

                //if ((a.pLado1 != a.pLado2) & (a.pLado3 != a.pLado2)) 
                //{
                //    lblcalcularSuperf.Text = Convert.ToString(a.calcularSuperficie());
                //    lblcalcularPerim.Text = Convert.ToString(a.calcularPerimEscaleno());
                //    a.pTipo = "Escaleno";
                //}

                ////triangulo isosceles
                //if (a.pLado1 == a.pLado2 || a.pLado2 == a.pLado3) 
                //{
                //    lblcalcularSuperf.Text = Convert.ToString(a.calcularSuperficie());
                //    lblcalcularPerim.Text = Convert.ToString(a.calcularPerimIsosceles());
                //    a.pTipo = "Isosceles";
                //}

                lblcalcularSuperf.Text = Convert.ToString(a.calcularSuperficie());
                lblcalcularPerim.Text = Convert.ToString(a.calcularPerim());


                MessageBox.Show(a.toString());
            }
        }

        private void txtLado1_Leave(object sender, EventArgs e)
        {
            // mi idea es validar el texto que escribo en este campo. Deben ser solo números mayores a cero. Sino emitir alerta.
            //if (!string.IsNullOrWhiteSpace(txtLado1.Text) || !string.IsNullOrEmpty(txtLado1.Text))
            //{
            //    MessageBox.Show("El lado 1 no puede estar vacio");
            //}
        }

       

        private void txtLado1_Validating(object sender, CancelEventArgs e)
        {
        //   rim() == "" ) {
        //    ErrorProvider if(txtLado1.Text.T
        //        errorProvider.SetError(txtLado1, "Name is required");
        //    e.Cancel = true;
        //    return;
        //                                    }    
        //    // Name is Valid
        //    errorProvider.SetError(txtLado1, "");
        }

        private void txtLado1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void txtLado2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void txtLado3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }


    }
}
