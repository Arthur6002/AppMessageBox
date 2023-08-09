using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntExemplo1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você gostou da aula de c#?", "Segundo Módulo", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                txtSelecao.Text = "Sim";
            else
                txtSelecao.Text = "Não";
        }

        private void bntExemplo2_Click(object sender, EventArgs e)
        {
           DialogResult Resposta = MessageBox.Show("Outro exemplo", "Segundo Modulo", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);

            if (Resposta == DialogResult.Abort)
                txtSelecao.Text = "Abort";
            else if (Resposta == DialogResult.Retry)
                txtSelecao.Text = "Retry";
            else
                txtSelecao.Text = "Ignore";
        }
    }
}
