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

        private void bntMessageBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aula de C#", "Segundo Módulo");
        }
    }
}
