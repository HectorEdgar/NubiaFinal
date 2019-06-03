using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoNubiaV0._1.Modelos;

namespace ProyectoNubiaV0._1.Controladores
{
    class ControlGrupoGimnasio
    {
        public ControlGrupoGimnasio()
        {

        }

        public GrupoGimnasio grupogim { get; set; }


        public int agregarGrupoGimnasio(String nombre, int horario)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    GrupoGimnasio grupogim = new GrupoGimnasio();
                    grupogim.nombre = nombre;
                    grupogim.IdHorario = horario;
                    entity.GrupoGimnasios.Add(grupogim);
                    return entity.SaveChanges();
                }
                catch (Exception)
                {
                    return -1;
                }
            }


        }

        public GrupoGimnasio obtenerGrupoGim(String nombre)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    this.grupogim = entity.GrupoGimnasios.Where(p => p.nombre == nombre).First();
                    return grupogim;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }


        public int eliminarGrupoGim(int id)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    var grupogim = entity.GrupoGimnasios.Where(p => p.idGimnasio == id).ToList().First();
                    entity.GrupoGimnasios.Remove(grupogim);
                    return entity.SaveChanges();
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }

        public int actualizarGrupoGim(String nombre, int horario)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    var grupogim = entity.GrupoGimnasios.Where(p => p.idGimnasio == this.grupogim.idGimnasio).ToList().First();
                    grupogim.nombre = nombre;
                    grupogim.IdHorario = horario;
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
