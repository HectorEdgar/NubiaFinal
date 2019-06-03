using ProyectoNubiaV0._1.Controladores;
using ProyectoNubiaV0._1.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoNubiaV0._1
{
    public partial class Loggin : Form
    {
        private ControlLoggin controlLogin;
        public Loggin()
        {
            InitializeComponent();
            controlLogin = new ControlLoggin();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            controlLogin.validarUsuario(textBox1.Text,textBox2.Text);
            if (controlLogin.usuario!=null)
            {
                this.Visible = false;
                MenuPrincipal menuPrincipal = new MenuPrincipal();
                menuPrincipal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar==13)
            {
                button1.PerformClick();
            }        
        }
    }
}
