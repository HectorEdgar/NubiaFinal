using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoNubiaV0._1.Modelos;

namespace ProyectoNubiaV0._1.Controladores
{
    class ControlGrupoAlumnos
    {
        public Alumnos_GrupoGimnasio grupAlum { get; set; }

        public int agregarAlGrupoGimnasio(String matricula, int id)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    Alumnos_GrupoGimnasio grupAlum = new Alumnos_GrupoGimnasio();
                    grupAlum.Matricula = matricula;
                    grupAlum.idGimnasio = id;
                    entity.Alumnos_GrupoGimnasio.Add(grupAlum);
                    return entity.SaveChanges();
                }
                catch (Exception)
                {
                    return -1;
                }
            }


        }

        public Alumnos_GrupoGimnasio obtenerAlGrupoGim(int nombre)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    this.grupAlum = entity.Alumnos_GrupoGimnasio.Where(p => p.idGimnasio == nombre).First();
                    return grupAlum;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }


        public int eliminarGrupoGim(String id)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    var grupoa = entity.Alumnos_GrupoGimnasio.Where(p => p.Matricula == id).ToList().First();
                    entity.Alumnos_GrupoGimnasio.Remove(grupoa);
                    return entity.SaveChanges();
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }

        public int actualizarGrupoGim(String nombre)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    var grupoA = entity.Alumnos_GrupoGimnasio.Where(p => p.Matricula == this.grupAlum.Matricula).ToList().First();
                    grupoA.Matricula = nombre;
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
