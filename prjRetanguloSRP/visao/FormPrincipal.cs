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
        controle.RetanguloGrafico RG;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ret = new modelo.RetanguloMatematico(Double.Parse(txtL1.Text), Double.Parse(txtL2.Text));

            lbResposta.Text = "Área: "+ret.Area().ToString()+" Perimetro: "+ret.Perimetro().ToString();
        }

        private void btnPlotar_Click(object sender, EventArgs e)
        {
            if (ret == null)
            {
                btnCalcular_Click(sender, e);
            }

            RG = new controle.RetanguloGrafico(ret);
            RG.Desenhar(10, 10, tela.CreateGraphics());
        }

        private void tela_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void tela_MouseMove(object sender, MouseEventArgs e)
        {
            if (RG != null)
            {
                int x = (int) (e.X - ret.L1 / 2);
                int y = (int) (e.Y - ret.L2 / 2);
                RG.Desenhar(x, y, tela.CreateGraphics());
            }
        }
    }
}
