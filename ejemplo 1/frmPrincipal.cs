using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo_1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.ShowDialog();
        }

        private void tsbPerfil_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            Form1 ventana = new Form1();
            ventana.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hola princeso");
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Chau traquac");
        }
    }
}
