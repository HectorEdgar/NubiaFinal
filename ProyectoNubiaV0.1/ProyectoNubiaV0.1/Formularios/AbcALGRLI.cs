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
    public partial class AbcALGRLI : Form
    {
        private ControlLicenciatura control;
        private ControlGrupo controlGrupo;
        private ControlAlumno controlAlumno;
        public AbcALGRLI()
        {
            InitializeComponent();
            control = new ControlLicenciatura();
            controlGrupo = new ControlGrupo();
            controlAlumno = new ControlAlumno();
            gridAlumno();
            gridGrupo();
            gridLicenciatura();
            bloquearLic();
            bloquearGrup();
            bloquearAlum();     
        }

        public void gridAlumno() {
            dataGridView3.DataSource = controlAlumno.obtenerAlumnos();
           
        }
        public void gridGrupo()
        {
            dataGridView2.DataSource = controlGrupo.obtenerGrupos();

        }
        public void gridLicenciatura()
        {
            dataGridView1.DataSource = control.obtenerLicenciaturas();

        }

        public void bloquearLic() {
           
            pnlBusquedaLicen.Enabled = false;
           
            button2.Enabled = false;
            button4.Enabled = false;
        }

        public void desbloquearLic()
        {
           
            pnlBusquedaLicen.Enabled = true;
           
            button2.Enabled = true;
            button4.Enabled = true;
        }

        public void desbloquearGrup() {

            pnlBusquedaGrupo.Enabled = true;

            BtnEditar.Enabled = true;
            btnElinar.Enabled = true;
        }

        public void bloquearGrup()
        {

            pnlBusquedaGrupo.Enabled = false;

            BtnEditar.Enabled = false;
            btnElinar.Enabled = false;
        }

        public void bloquearAlum()
        {

            pnlBussquedaAlumno.Enabled = false;

            btnEdiA.Enabled = false;
            btnElimAlum.Enabled = false;
        }
        public void desbloquearAlum()
        {

            pnlBussquedaAlumno.Enabled = true;

            btnEdiA.Enabled = true;
            btnElimAlum.Enabled = true;
        }


        public void limpiarLic() {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
        }

        public void limpiarAlum()
        {
            txtApellido.ResetText();
            txtApellidos.ResetText();
            txtMat.ResetText();
            txtMatricula.ResetText();
            txtNombreAlumno.ResetText();
            txtEdad.ResetText();
            txtEdadAl.ResetText();
            txtGrupoCod.ResetText();

            txtBuquedaAl.ResetText();
            txtNom.ResetText();
            txtGrupo.ResetText();
        }

        public void limpiarGrupo()
        {
            txtNombreGrupo.ResetText();
            txtCodLicenciatura.ResetText();
            txtSemestre.ResetText();
            txtNombreBusqueda.ResetText();

            txtId.ResetText();
            txtNombre.ResetText();
            txtCodigo.ResetText();
            txtSem.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (control.agregarLicenciatura(textBox2.Text) > 0)
            {
                MessageBox.Show("Se agrego correctamente");
                gridLicenciatura();
                limpiarLic();


            }
            else
            {
                MessageBox.Show("Ocurrio un error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            control.obtenerLicenciaturas(textBox4.Text);
            desbloquearLic();

            textBox3.Text = control.licenciatura.Nombre;
            textBox1.Text = control.licenciatura.IdLicenciatura + "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (control.actualizarLicenciatura(textBox3.Text) > 0)
            {
                MessageBox.Show("Se actualizo");
            }
            else
            {
                MessageBox.Show("No actualizo");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (control.eliminarLicenciatura(Convert.ToInt16(textBox1.Text)) > 0)
            {
                MessageBox.Show("Se elimino");
            }
            else
            {
                MessageBox.Show("no elimino");
            }
        }

        private void btnAgregarGrupo_Click(object sender, EventArgs e)
        {
            if (controlGrupo.agregarGrupo(txtNombreGrupo.Text, Convert.ToInt32(txtCodLicenciatura.Text), txtSemestre.Text) > 0)
            {
                MessageBox.Show("Se agrego correctamente el grupo");
                limpiarGrupo();
                gridGrupo();
            }
            else
            {
                MessageBox.Show("Ocurrio un error");
            }
        }

        private void btnBuscarGrupo_Click(object sender, EventArgs e)
        {
            controlGrupo.obtenerGrupos(txtNombreBusqueda.Text);
            desbloquearGrup();
            txtId.Text = controlGrupo.grupo.idGrupo + "";

            txtNombre.Text = controlGrupo.grupo.Nombre;
            txtCodigo.Text = controlGrupo.grupo.IdLicenciatura + "";
            txtSem.Text = controlGrupo.grupo.semestre;

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (controlGrupo.actualizarGrupo(txtNombre.Text, Convert.ToInt32(txtCodigo.Text), txtSem.Text) > 0)
            {
                MessageBox.Show("Se actualizo el grupo");
            }
            else
            {
                MessageBox.Show("No actualizo");
            }
        }

        private void btnElinar_Click(object sender, EventArgs e)
        {
            if (controlGrupo.eliminarGrupo(Convert.ToInt16(txtId.Text)) > 0)
            {
                MessageBox.Show("Se elimino");
            }
            else
            {
                MessageBox.Show("no elimino");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (controlAlumno.agregarAlumnos(txtMatricula.Text, Convert.ToInt32(txtGrupoCod.Text), txtNombreAlumno.Text, txtApellidos.Text, txtEdad.Text) > 0)
            {
                MessageBox.Show("Se agrego correctamente el alumno");
                gridAlumno();
                limpiarAlum();
            }
            else
            {
                MessageBox.Show("Ocurrio un error");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            controlAlumno.obtenerAlumnos(txtBuquedaAl.Text);
            desbloquearGrup();
            txtMat.Text = controlAlumno.alumno.Matricula;
            txtNom.Text = controlAlumno.alumno.Nombre;
            txtApellido.Text = controlAlumno.alumno.Apellidos;
            txtEdadAl.Text = controlAlumno.alumno.Edad;
            txtGrupo.Text = controlAlumno.alumno.idGrupo + "";
        }

        private void btnEdiA_Click(object sender, EventArgs e)
        {
            if (controlAlumno.actualizarAlumnos(txtNom.Text, txtApellido.Text, txtEdad.Text, Convert.ToInt32(txtGrupo.Text)) > 0)
            {
                MessageBox.Show("Se actualizo el alumno");
            }
            else
            {
                MessageBox.Show("No actualizo");
            }
        }

        private void btnElimAlum_Click(object sender, EventArgs e)
        {
            if (controlAlumno.eliminarAlumnos(txtMat.Text) > 0)
            {
                MessageBox.Show("Se elimino el alumno ");
            }
            else
            {
                MessageBox.Show("no elimino");
            }

        }

        private void AbcALGRLI_Load(object sender, EventArgs e)
        {
            
            this.licenciaturaTableAdapter.Fill(this.sistema_GimnasioDataSet3.Licenciatura);
            
            this.grupoTableAdapter.Fill(this.sistema_GimnasioDataSet1.Grupo);
            
            this.alumnoTableAdapter.Fill(this.sistema_GimnasioDataSet.Alumno);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MenuPrincipalAbc menup = new  MenuPrincipalAbc();
            menup.ShowDialog();

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtMat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void txtEdadAl_TextChanged(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void txtGrupo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
