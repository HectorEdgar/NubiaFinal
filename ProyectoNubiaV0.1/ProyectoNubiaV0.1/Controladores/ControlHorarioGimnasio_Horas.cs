using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoNubiaV0._1.Modelos;
using System.Windows.Forms;

namespace ProyectoNubiaV0._1.Controladores
{
    class ControlHorarioGimnasio_Horas
    {
        public HorarioGimnasio_Horas horarioGimnasio_Hora { get; set; }
        public List<HorarioGimnasio_Horas> horarioGimnasio_Horas { get; set; }

        public ControlHorarioGimnasio_Horas()
        {

        }

        public int agregarHorarioGimnasio_Horas(int idHorarioGimnasio, int idHora, string dia)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    horarioGimnasio_Hora = new HorarioGimnasio_Horas();
                    horarioGimnasio_Hora.IdHorario = idHorarioGimnasio;
                    horarioGimnasio_Hora.IdHora = idHora;
                    horarioGimnasio_Hora.Dia = dia;

                    entity.HorarioGimnasio_Horas.Add(horarioGimnasio_Hora);
                    return entity.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return -1;
                }
            }
        }

        public List<HorarioGimnasio_Horas> obtenerHorarioGimnasio_Horas()
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    horarioGimnasio_Horas= entity.HorarioGimnasio_Horas.Select(p => p).ToList();
                    return horarioGimnasio_Horas;
                }
                catch (Exception)
                {

                    return null;
                }
            }

        }

        public List<HorarioGimnasio_Horas> obtenerHorarioGimnasio_Horas(int idHorarioGimnasio, int idHora)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    horarioGimnasio_Horas= entity.HorarioGimnasio_Horas.Where(p => p.IdHorario == idHorarioGimnasio && p.IdHora == idHora).ToList();
                    return horarioGimnasio_Horas;
                }
                catch (Exception)
                {

                    return null;
                }
            }

        }
        public List<HorarioGimnasio_Horas> obtenerHorarioGimnasio_Horas(int idHorarioGimnasio)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    horarioGimnasio_Horas = entity.HorarioGimnasio_Horas.Where(p => p.IdHorario == idHorarioGimnasio).ToList();
                    return horarioGimnasio_Horas;
                }
                catch (Exception)
                {

                    return null;
                }
            }

        }
        public List<HorarioGimnasio_Horas> obtenerHorarioGimnasio_Horas(string dia)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    return entity.HorarioGimnasio_Horas.Where(p => p.Dia == dia).ToList();
                }
                catch (Exception)
                {

                    return null;
                }
            }

        }

        public int actualizarHorarioGimnasio(int idHorarioGimnasio, int idHora, string dia)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    horarioGimnasio_Hora = entity.HorarioGimnasio_Horas.Where(p => p.IdHorario == idHorarioGimnasio && p.IdHora == idHora).First();
                    horarioGimnasio_Hora.Dia = dia;
                    return entity.SaveChanges();
                }
                catch (Exception)
                {

                    return -1;
                }
            }
        }

        public int eliminarHorarioGimnasio(int idHorarioGimnasio, int idHora, string dia)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    horarioGimnasio_Hora = entity.HorarioGimnasio_Horas.
                        Where(
                        p => p.IdHorario == idHorarioGimnasio &&
                        p.IdHora == idHora &&
                        p.Dia == dia).First();
                        
                    entity.HorarioGimnasio_Horas.Remove(horarioGimnasio_Hora);
                    return entity.SaveChanges();
                }
                catch (Exception)
                {

                    return -1;
                }
            }
        }

        public int eliminarHorarioGimnasio(int idHorarioGimnasio, int idHora)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    horarioGimnasio_Horas = entity.HorarioGimnasio_Horas.
                        Where(
                        p => p.IdHorario == idHorarioGimnasio &&
                        p.IdHora == idHora).ToList();

                    foreach (var hora in horarioGimnasio_Horas)
                    {
                        entity.HorarioGimnasio_Horas.Remove(hora);
                    }

                    
                    return entity.SaveChanges();
                }
                catch (Exception)
                {

                    return -1;
                }
            }
        }


    }
}
