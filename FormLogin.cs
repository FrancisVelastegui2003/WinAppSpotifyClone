using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppSpotifyClone
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Nombre de usuario y contraseña ingresados:

            string username = textBox1.Text;
            string password = textBox2.Text;

            // Verificar las credenciales
            if (username == "francis" && password == "Francis2003")
            {
                // Si las credenciales son correctas, se ejecuta 
                this.Hide();
                FormMain formMain = new FormMain();
                formMain.ShowDialog();
            }
            else
            {
                // Si las credenciales son incorrectas, mostrar un mensaje de error
                MessageBox.Show("Credenciales incorrectas. Por favor, inténtelo de nuevo.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
