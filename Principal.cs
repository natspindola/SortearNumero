using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortearNumero
{
    public partial class frmSorteio : Form
    {
        public frmSorteio()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            Sorteio();
        }
        private void Sorteio()
        {
            Random sorteio = new Random();

            int sorteado;
            int[] verificar = new int[70];

            string resultado = "";
            for(int i=0; i<6; i++)
            {
                inicio:
                sorteado = sorteio.Next(0, 61);

                for(int x=0; x<6; x++)
                {
                    if(verificar[x] == sorteado)
                    {
                        goto inicio;
                    }
                }

                resultado = resultado + " - " + sorteado;
                lblResultado.Text = resultado;
                verificar[i] = sorteado;
            }
        }
    }
}
