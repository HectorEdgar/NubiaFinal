using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoNubiaV0._1.Controladores;

namespace ProyectoNubiaV0._1.Formularios
{
    public partial class AbcGrupoGim : Form
    {
        private ControlGrupoGimnasio controlGrup;
        private ControlGrupoAlumnos controlGrupAlumno;
        public AbcGrupoGim()
        {
            InitializeComponent();
            controlGrupAlumno = new ControlGrupoAlumnos();
            controlGrup = new ControlGrupoGimnasio();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (controlGrup.agregarGrupoGimnasio(textBox3.Text, Convert.ToInt32(textBox1.Text)) > 0)
            {
                MessageBox.Show("Se agrego correctamente");

            }
            else
            {
                MessageBox.Show("Ocurrio un error");
            }
        }

        private void btnBuscarGrupo_Click(object sender, EventArgs e)
        {
            controlGrup.obtenerGrupoGim(txtNombreBusqueda.Text);


            txtId.Text = controlGrup.grupogim.idGimnasio + "";
            txtNombre.Text = controlGrup.grupogim.nombre;
            txtCodigo.Text = controlGrup.grupogim.IdHorario + "";
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

            if (controlGrup.actualizarGrupoGim(txtNombre.Text, Convert.ToInt32(txtCodigo.Text)) > 0)
            {
                MessageBox.Show("Se actualizo");
            }
            else
            {
                MessageBox.Show("No actualizo");
            }
        }

        private void btnElinar_Click(object sender, EventArgs e)
        {
            if (controlGrup.eliminarGrupoGim(Convert.ToInt16(txtId.Text)) > 0)
            {
                MessageBox.Show("Se elimino");
            }
            else
            {
                MessageBox.Show("no elimino");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MenuPrincipalAbc menup = new MenuPrincipalAbc();
            menup.ShowDialog();
        }

        private void AbcGrupoGim_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (controlGrupAlumno.agregarAlGrupoGimnasio(textBox2.Text, Convert.ToInt32(textBox5.Text)) > 0)
            {
                MessageBox.Show("Se agrego correctamente");

            }
            else
            {
                MessageBox.Show("Ocurrio un error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            controlGrupAlumno.obtenerAlGrupoGim(Convert.ToInt32(txtNombreBusqueda.Text));


            textBox6.Text = controlGrupAlumno.grupAlum.idGimnasio + "";
            textBox7.Text = controlGrupAlumno.grupAlum.Matricula;
           // textBox4.Text = controlGrupAlumno.grupAlum. + "";
        }
    }
}
