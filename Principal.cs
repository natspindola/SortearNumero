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

            string resultado = "";
            for(int i=0; i<6; i++)
            {
                resultado = resultado + "- " + sorteio.Next(0, 61);
            }
        }
    }
}
