using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FOso : Form
    {
        public FOso()
        {
            InitializeComponent();
        }

        private void txtNombre_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void btmSaludo_Click(object sender, EventArgs e)
        {
           /* string texto = txtNombre.Text;
            string texto1 = txtApellido.Text;
            lblSalidaNombre.Text = "HOLA " + texto+" "+texto1;*/
          /* if (txtApellido.Text == "legajoveliz")
            {
                MessageBox.Show("Login aceptado");

            }else
            {
                MessageBox.Show("Password incorrecta, intente otra vez!");
            }*/
          if (rBtnArt.Checked == true)
            {
                MessageBox.Show("PONETE A ESTUDIAAAAAAAAR!!! ");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cBNombreTrabajo.Items.Add("Jumbo Nordelta");
            cBNombreTrabajo.Items.Add("Jumbo Unicenter");
            cBNombreTrabajo.Items.Add("El chino");
            cBNombreTrabajo.Items.Add("Carrefour");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("GRACIAS POR USAR LA APP"); 
        }

        private void txtNombre_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void txtNombre_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HOLIS"); 
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtApellido_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
