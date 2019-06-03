using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoNubiaV0._1.Modelos;
using System.Windows.Forms;

namespace ProyectoNubiaV0._1.Controladores
{
    class ControlHoras
    {

        public Hora hora { get; set; }
        public ControlHoras()
        {

        }

        public int agregarHora(string horaInicio, string horaFin)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    hora = new Hora();
                    hora.HoraInicio = DateTime.Parse(horaInicio);
                    hora.HoraFin = DateTime.Parse(horaFin);

                    entity.Horas.Add(hora);
                    return entity.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    hora = null;
                    return -1;
                }
            }
        }

        public List<Hora> obtenerHoras()
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    return entity.Horas.Select(p => p).ToList();
                }
                catch (Exception)
                {

                    return null;
                }
            }
        }

        public List<Hora> obtenerHoras(string horaInicio, string horaFin)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    return entity.Horas.Where(p => p.HoraInicio.Date.CompareTo(DateTime.Parse(horaInicio)) >= 0
                    && p.HoraFin.Date.CompareTo(DateTime.Parse(horaFin)) <= 0).ToList();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public Hora buscarHora(string horaInicio, string horaFin)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    hora = entity.Horas.Where(p => p.HoraInicio.Date.CompareTo(DateTime.Parse(horaInicio)) == 0
                    && p.HoraFin.Date.CompareTo(DateTime.Parse(horaFin)) == 0).First();
                    return hora;
                }
                catch (Exception)
                {
                    hora = null;
                    return hora;
                }
            }
        }
        public Hora buscarHora(int id)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    hora = entity.Horas.Where(p => p.IdHora == id).First();
                    return hora;
                }
                catch (Exception)
                {
                    hora = null;
                    return hora;
                }
            }
        }


        public int actualizarHora(int id, string horaInicio, string horaFin)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    hora = entity.Horas.Where(p => p.IdHora == id).First();
                    hora.HoraInicio = DateTime.Parse(horaInicio);
                    hora.HoraFin = DateTime.Parse(horaFin);

                    return entity.SaveChanges();

                }
                catch (Exception)
                {

                    return -1;
                }
            }

        }
        public int eliminarHora(int id)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    hora = entity.Horas.Where(p => p.IdHora == id).First();
                    entity.Horas.Remove(hora);

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
