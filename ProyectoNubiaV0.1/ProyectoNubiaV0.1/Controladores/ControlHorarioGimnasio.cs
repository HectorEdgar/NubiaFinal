using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoNubiaV0._1.Modelos;
using System.Windows.Forms;

namespace ProyectoNubiaV0._1
{
    class ControlHorarioGimnasio
    {
        public HorarioGimnasio horarioGimnasio { get; set; }
        public List<HorarioGimnasio> horariosGimnasio { get; set; }
        public ControlHorarioGimnasio()
        {

        }

        public int agregarHorarioGimnasio(String nombre)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    horarioGimnasio = new HorarioGimnasio();
                    horarioGimnasio.nombre = nombre;
                    entity.HorarioGimnasios.Add(horarioGimnasio);
                    return entity.SaveChanges();

                }
                catch (Exception)
                {
                    horarioGimnasio = null;
                    return -1;
                }
            }
        }

        public List<HorarioGimnasio> obtenerHorariosGimnasio()
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    horariosGimnasio = entity.HorarioGimnasios.Select(p => p).ToList();
                    return horariosGimnasio;
                }
                catch (Exception)
                {

                    return null;
                }
            }

        }

        public List<HorarioGimnasio> obtenerHorariosGimnasio(String nombre)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    return entity.HorarioGimnasios.Where(p=>p.nombre.Contains(nombre)).ToList();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
        public HorarioGimnasio BuscarHorarioGimnasio(String nombre)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    horarioGimnasio = entity.HorarioGimnasios.Where(p => p.nombre == nombre).ToList().First();
                    return horarioGimnasio;
                }
                catch (Exception)
                {
                    horarioGimnasio = null;
                    return horarioGimnasio;
                }
            }
        }
        public int actualizarHorarioGimnasio(int id,String nombre)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    horarioGimnasio = entity.HorarioGimnasios.Where(p => p.IdHorario==id).First();
                    horarioGimnasio.nombre = nombre;
                    return entity.SaveChanges();
                }
                catch (Exception)
                {
                    return -1;
                }
            }
                
        }

        public int eliminarHorarioGimnasio(int id)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    horarioGimnasio = entity.HorarioGimnasios.Where(p => p.IdHorario == id).First();
                    entity.HorarioGimnasios.Remove(horarioGimnasio);
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
