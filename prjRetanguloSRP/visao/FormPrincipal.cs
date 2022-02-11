using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjRetanguloSRP.visao
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        modelo.RetanguloMatematico ret;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ret = new modelo.RetanguloMatematico(Double.Parse(txtL1.Text), Double.Parse(txtL2.Text));

            lbResposta.Text = "Área: "+ret.Area().ToString()+" Perimetro: "+ret.Perimetro().ToString();
        }
    }
}
