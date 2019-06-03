using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoNubiaV0._1.Formularios
{
    public partial class MenuPrincipalAbc : Form
    {
        public MenuPrincipalAbc()
        {
            InitializeComponent();
        }

        private void AbcHorario_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AbcHorarioHorasGimnasio abcHorarioGimnasio = new AbcHorarioHorasGimnasio();
            abcHorarioGimnasio.ShowDialog();
        }

        private void btnRegresarMenuPrincipal_Click(object sender, EventArgs e)
        {
            Application.OpenForms["MenuPrincipal"].Visible = true;
            this.Dispose();
        }

        private void MenuPrincipalAbc_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason.Equals(CloseReason.UserClosing))
            {
                Application.Exit();
            }
        }

        private void btnAbcAlumnos_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AbcALGRLI abcALGRLI = new AbcALGRLI();
            abcALGRLI.ShowDialog();

        }

        private void ABCGruposGimnasio_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AbcGrupoGim abcGrupoGim = new AbcGrupoGim();
            abcGrupoGim.ShowDialog();
        }
    }
}
