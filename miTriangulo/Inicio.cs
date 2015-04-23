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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (rbTriángulo.Checked) {
                Form T = new frmTriangulo();
                T.ShowDialog();
                //quiero ocultar el inicio
                }
            if (rbRectángulo.Checked) {
                Form R = new frmRectang2();
                R.ShowDialog();
                }
  
               
        }
    }
}
