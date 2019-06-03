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

namespace ProyectoNubiaV0._1
{
    public partial class AbcHorarioHorasGimnasio : Form
    {
        private ControlGeneralHorarios control;
        public AbcHorarioHorasGimnasio()
        {
            InitializeComponent();
            this.control = new ControlGeneralHorarios();
            setCustomFormatDateTimePicker();
            obtenerInformacionHorarioGrupoGimnasio();

        }



        public void obtenerInformacionHorarioGrupoGimnasio()
        {
            dataGridView4.Rows.Clear();
            this.control.controlHorarioGimnasio.obtenerHorariosGimnasio();

            for (int i = 0; i < this.control.controlHorarioGimnasio.horariosGimnasio.Count; i++)
            {
                String dias = "";
                this.control.buscarGrupoGimnasioHorario(this.control.controlHorarioGimnasio.horariosGimnasio[i].nombre);

                for (int j = 0; j < control.controlHorarioGimnasio_Horas.horarioGimnasio_Horas.Count; j++)
                {
                    dias += " " + control.controlHorarioGimnasio_Horas.horarioGimnasio_Horas[j].Dia;
                }

                dataGridView4.Rows.Add(
                    this.control.controlHorarioGimnasio.horarioGimnasio.IdHorario,
                    this.control.controlHorarioGimnasio.horarioGimnasio.nombre,
                    this.control.controlHoras.hora.HoraInicio.ToShortTimeString(),
                    this.control.controlHoras.hora.HoraFin.ToShortTimeString(),
                    dias
                    );
            }



        }
        public void setCustomFormatDateTimePicker()
        {
            dtpInicio.Format = DateTimePickerFormat.Custom;
            dtpInicio.CustomFormat = "HH:mm:ss";
            dtpFin.Format = DateTimePickerFormat.Custom;
            dtpFin.CustomFormat = "HH:mm:ss";
            dtpEditarHoraInicio.Format = DateTimePickerFormat.Custom;
            dtpEditarHoraInicio.CustomFormat = "HH:mm:ss";
            dtpEditarHoraFin.Format = DateTimePickerFormat.Custom;
            dtpEditarHoraFin.CustomFormat = "HH:mm:ss";
        }
        private void btnAgregarHorarioGimnasio_Click(object sender, EventArgs e)
        {
            if (!txtNombre.Text.Equals(""))
            {
                if (clbDias.CheckedItems.Count > 0)
                {
                    if (this.control.agregarGrupoGimnasioHorario(txtNombre.Text, dtpInicio.Value.ToLongTimeString(), dtpFin.Value.ToLongTimeString(), clbDias.CheckedItems.OfType<String>().ToList()) > 2)
                    {
                        limpiarPanelAgregar();
                        obtenerInformacionHorarioGrupoGimnasio();
                        MessageBox.Show("Agregado");

                    }
                    else
                    {
                        MessageBox.Show("No agregado");
                    }
                }
                else
                {
                    MessageBox.Show("Agregue un dia");
                }
            }
            else
            {
                MessageBox.Show("Agregue un nombre");
            }
        }
        public void limpiarPanelAgregar()
        {
            txtNombre.ResetText();
            dtpFin.ResetText();
            dtpInicio.ResetText();
            for (int i = 0; i < clbDias.Items.Count; i++)
            {
                clbDias.SetItemChecked(i, false);
            }
        }


        public void limpiarPanelEditar()
        {
            txtEditarId.Text = "";
            txtEditarNombre.Text = "";
            dtpEditarHoraInicio.ResetText();
            dtpEditarHoraFin.ResetText();
            for (int i = 0; i < clbEditarDias.Items.Count; i++)
            {
                clbEditarDias.SetItemChecked(i, false);
            }
        }

        public void activarControlesEditar()
        {
            panel7.Enabled = true;
            panel8.Enabled = true;
            panel9.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }
        public void desactivarControlesEditar()
        {
            panel7.Enabled = false;
            panel8.Enabled = false;
            panel9.Enabled = false;
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {

            limpiarPanelEditar();
            if (control.buscarGrupoGimnasioHorario(txtEditarBuscar.Text))
            {
                activarControlesEditar();
                txtEditarId.Text = this.control.controlHorarioGimnasio.horarioGimnasio.IdHorario + "";
                txtEditarNombre.Text = this.control.controlHorarioGimnasio.horarioGimnasio.nombre + "";
                dtpEditarHoraInicio.Value = this.control.controlHoras.hora.HoraInicio;
                dtpEditarHoraFin.Value = this.control.controlHoras.hora.HoraFin;

                foreach (var dia in this.control.controlHorarioGimnasio_Horas.horarioGimnasio_Horas)
                {
                    for (int i = 0; i < clbEditarDias.Items.Count; i++)
                    {
                        if (dia.Dia == clbEditarDias.Items[i].ToString())
                        {
                            clbEditarDias.SetItemChecked(i, true);
                        }
                    }
                }
            }
            else
            {
                desactivarControlesEditar();
                MessageBox.Show("No se encontro el horario");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (control.eliminarGrupoGimnasioHorario())
            {
                obtenerInformacionHorarioGrupoGimnasio();
                limpiarPanelEditar();
                desactivarControlesEditar();
                MessageBox.Show("Se elimino correctamente");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!txtEditarNombre.Text.Equals(""))
            {
                if (clbEditarDias.CheckedItems.Count > 0)
                {
                    if (control.actualizarGrupoGimnasioHorario(txtEditarNombre.Text, dtpEditarHoraInicio.Text, dtpEditarHoraFin.Text, clbEditarDias.CheckedItems.OfType<String>().ToList()))
                    {
                        obtenerInformacionHorarioGrupoGimnasio();
                        limpiarPanelEditar();
                        desactivarControlesEditar();
                        MessageBox.Show("Se actualizo correctamente");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar");
                    }
                }
                else
                {
                    MessageBox.Show("Agregue un dia");
                }

            }
            else
            {
                MessageBox.Show("Agregue un nombre");
            }

        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            obtenerInformacionHorarioGrupoGimnasio();
        }

        private void AbcHorarioHorasGimnasio_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason.Equals(CloseReason.UserClosing))
            {
                Application.Exit();
            }
        }

        private void btnRegresarMenuPrincipalAbc_Click(object sender, EventArgs e)
        {
            Application.OpenForms["MenuPrincipalAbc"].Visible = true;
            this.Dispose();
        }

        private void AbcHorarioHorasGimnasio_Load(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
