using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoNubiaV0._1.Controladores;
using System.Windows.Forms;

namespace ProyectoNubiaV0._1.Controladores
{
    class ControlGeneralHorarios
    {
        public ControlHorarioGimnasio controlHorarioGimnasio { get; }
        public ControlHoras controlHoras { get; }
        public ControlHorarioGimnasio_Horas controlHorarioGimnasio_Horas { get; }

        public ControlGeneralHorarios()
        {
            this.controlHorarioGimnasio = new ControlHorarioGimnasio();
            this.controlHoras = new ControlHoras();
            this.controlHorarioGimnasio_Horas = new ControlHorarioGimnasio_Horas();


        }

        public int agregarGrupoGimnasioHorario(string nombre, string horaInicio, string horaFin, List<string> dias)
        {
            int filasAfectadas = 0;

            if (this.controlHorarioGimnasio.agregarHorarioGimnasio(nombre) == -1)
            {
                MessageBox.Show("Error al agregar HorarioGimnasio");
                return -1;
            }
            if (this.controlHoras.agregarHora(horaInicio, horaFin) == -1)
            {
                MessageBox.Show("Error al agregar Horas");

                this.controlHorarioGimnasio.eliminarHorarioGimnasio(this.controlHorarioGimnasio.horarioGimnasio.IdHorario);
                return -1;
            }


            for (int i = 0; i < dias.Count; i++)
            {
                if (this.controlHorarioGimnasio_Horas.agregarHorarioGimnasio_Horas(this.controlHorarioGimnasio.horarioGimnasio.IdHorario, this.controlHoras.hora.IdHora, dias[i]) == -1)
                {
                    MessageBox.Show("Error al agregar dias");

                    this.controlHorarioGimnasio.eliminarHorarioGimnasio(this.controlHorarioGimnasio.horarioGimnasio.IdHorario);
                    this.controlHoras.eliminarHora(this.controlHoras.hora.IdHora);
                    return -1;
                }
                filasAfectadas++;

            }



            return filasAfectadas + 2;
        }

        public bool eliminarGrupoGimnasioHorario()
        {
            if (this.controlHorarioGimnasio_Horas.eliminarHorarioGimnasio(this.controlHorarioGimnasio.horarioGimnasio.IdHorario, this.controlHoras.hora.IdHora) != -1)
            {
                if (this.controlHoras.eliminarHora(this.controlHoras.hora.IdHora) != -1)
                {
                    if (this.controlHorarioGimnasio.eliminarHorarioGimnasio(this.controlHorarioGimnasio.horarioGimnasio.IdHorario) != -1)
                    {
                        return true;

                    }
                    else { }
                }
                else { }
            }
            else { }

            return false;
        }

        public bool actualizarGrupoGimnasioHorario(String nombre, string horaInicio, string horaFin, List<string> dias)
        {
            if (this.controlHorarioGimnasio.actualizarHorarioGimnasio(this.controlHorarioGimnasio.horarioGimnasio.IdHorario, nombre) != -1)
            {
                if (this.controlHoras.actualizarHora(this.controlHoras.hora.IdHora, horaInicio, horaFin) != -1)
                {
                    if (this.controlHorarioGimnasio_Horas.eliminarHorarioGimnasio(this.controlHorarioGimnasio.horarioGimnasio.IdHorario, this.controlHoras.hora.IdHora) != -1)
                    {
                        for (int i = 0; i < dias.Count; i++)
                        {
                            if (this.controlHorarioGimnasio_Horas.agregarHorarioGimnasio_Horas(this.controlHorarioGimnasio.horarioGimnasio.IdHorario, this.controlHoras.hora.IdHora, dias[i]) == -1)
                            {
                                MessageBox.Show("Error al agregar dias");

                            }
                        }
                        return true;
                    }
                    else { }
                }
                else { }
            }
            else { }
            return false;
        }

        public bool buscarGrupoGimnasioHorario(String nombre)
        {
            if (this.controlHorarioGimnasio.BuscarHorarioGimnasio(nombre) != null)
            {
                if (this.controlHorarioGimnasio_Horas.obtenerHorarioGimnasio_Horas(this.controlHorarioGimnasio.horarioGimnasio.IdHorario) != null)
                {
                    if (this.controlHoras.buscarHora(this.controlHorarioGimnasio_Horas.horarioGimnasio_Horas[0].IdHora) != null)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


    }
}
