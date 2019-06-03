using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoNubiaV0._1.Formularios;


namespace ProyectoNubiaV0._1
{
    public partial class MenuPrincipal : Form
    {

        public MenuPrincipal()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MenuPrincipalAbc menuPrincipalAbc = new MenuPrincipalAbc();
            menuPrincipalAbc.ShowDialog();
            
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (e.CloseReason.Equals(CloseReason.UserClosing))
            {
                Application.Exit();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Loggin"].Visible = true;
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            TomaAsistencia tomaAsistencia = new TomaAsistencia();
            tomaAsistencia.ShowDialog();
        }
    }
}
