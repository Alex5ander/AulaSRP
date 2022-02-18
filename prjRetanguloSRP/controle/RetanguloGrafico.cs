using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjRetanguloSRP.controle
{
    class RetanguloGrafico
    {
        public modelo.RetanguloMatematico RM { get; set; }

        public RetanguloGrafico (modelo.RetanguloMatematico RM)
        {
            this.RM = RM;
        }

        public void Desenhar (int x, int y, Graphics g) {
            g.Clear(Color.White);

            Pen caneta = new Pen(Color.Orange, 3);

            g.DrawRectangle(caneta, x, y, (int)this.RM.L1, (int)this.RM.L2);
            g.DrawEllipse(caneta, x, y, (int)this.RM.L1, (int)this.RM.L2);
        }
    }
}
