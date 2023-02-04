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
    public partial class Form1 : Form
    {
        public Form1()
        {
            //le agrego un comentario
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text;
            DateTime fecha = dtpNacimiento.Value;
            string violencia = ckbViolencia.Checked ? "Amo matar" : "Paz y amor";
            string defensa;
            if (rdbArmaDeFuego.Checked)
                defensa = "ARMA DE FUEGO";
            else if (rdbArmaBlanca.Checked)
                defensa = "ARMA BLANCA";
            else
                defensa = "MANO LIMPIA";
            string Arma = cboArma.SelectedItem.ToString();
            string muertes = nmMuertes.Value.ToString();
            string mensaje = "NOMBRE: " + nombre + ", Nacimiento: " + fecha + ", violencia: " + violencia + ", Estilo de defensa: " + defensa + ", Arma favorita: " + Arma + ", Muertes declaradas: " + muertes;
            MessageBox.Show(mensaje);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboArma.Items.Add("Pistola");
            cboArma.Items.Add("Cuchillo");
            cboArma.Items.Add("Escopeta");
            cboArma.Items.Add("Ametralladora");
            cboArma.Items.Add("Navaja");
            cboArma.Items.Add("Destornillador");
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el botón Izquierdo", "Atención");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el Botón Derecho", "Atención");
            else if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presiono el botón del Medio", "Atención");
        }

        private void lblArma_MouseMove(object sender, MouseEventArgs e)
        {
            lblArma.BackColor = Color.Cyan;
            lblArma.Cursor = Cursors.Hand;
        }

        private void lblArma_MouseLeave(object sender, EventArgs e)
        {
            lblArma.BackColor = System.Drawing.SystemColors.Control;
        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
                txtNombre.BackColor = Color.Red;
            else
                txtNombre.BackColor = System.Drawing.SystemColors.Control;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + textBox1.Text.Length + " Caracteres");
        }
    
    }
}
