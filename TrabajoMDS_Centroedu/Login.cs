using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoMDS_Centroedu
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //Acción del Botón acceder
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            

        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            //vaciamos los cuadros de textos
            textUsuario.Text = "";
            textPass.Text = "";
            // se muestre nuevamente el formulario de login
            this.Show();
        }

        //Click boton Minimizar
        private void btnMin_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        //Click boton Maximizar
        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        //click boton cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAcceder_Click_1(object sender, EventArgs e)
        {
            string usuario = textUsuario.Text;
            string password = textPass.Text;
            int Id_tipo = 2;
            Control ctrl = new Control();
            string respuesta = ctrl.ctrlAcceso(usuario, password);
            if (respuesta.Length > 0)
            {
                MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {


                Inicio fa1 = new Inicio(Id_tipo);
                fa1.StartPosition = FormStartPosition.CenterScreen;
                fa1.WindowState = FormWindowState.Maximized;
                fa1.Show();
                fa1.FormClosing += frm_closing;


            }
        }
    }
}
