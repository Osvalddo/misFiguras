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
    public partial class frmRectang2 : Form
    {
        public frmRectang2()
        {
            InitializeComponent();
        }

        private void Rectangulo2_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Rectangulo a;
            a = new Rectangulo();
            a.pLadoA = Convert.ToDouble(txtLadoA.Text);
            a.pLadoB = Convert.ToDouble(txtLadoB.Text);

            lblcalcularSuperfR.Text = Convert.ToString(a.calcularSuperficieR());
            lblcalcularPerim.Text = Convert.ToString(a.calcularPerimetroR());
        }

        private void txtLadoB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void txtLadoA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
    }
}
