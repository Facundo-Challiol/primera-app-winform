using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
                txtApellido.BackColor = Color.Red;
            if (txtNombre.Text == "")
                txtNombre.BackColor = Color.Red;
            if (txtEdad.Text == "")
                txtEdad.BackColor = Color.Red;
            if (txtDireccion.Text == "")
                txtDireccion.BackColor = Color.Red;
            if (txtApellido.Text != "" && txtNombre.Text != "" && txtEdad.Text != "" && txtEdad.Text != "") {
                txtResultado.Text = "Apellido y nombre: " + txtApellido.Text + " " + txtNombre.Text + Environment.NewLine + "Edad: " + txtEdad.Text + Environment.NewLine +  "Direccion: " + txtDireccion.Text;
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            txtApellido.BackColor = System.Drawing.SystemColors.Control;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtNombre.BackColor = System.Drawing.SystemColors.Control;
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            txtEdad.BackColor = System.Drawing.SystemColors.Control;
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            txtDireccion.BackColor = System.Drawing.SystemColors.Control;
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
