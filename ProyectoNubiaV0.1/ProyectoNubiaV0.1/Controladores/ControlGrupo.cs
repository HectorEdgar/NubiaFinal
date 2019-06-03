using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoNubiaV0._1.Modelos;

namespace ProyectoNubiaV0._1.Controladores
{
    class ControlGrupo
    {
        public ControlGrupo()
        {

        }
        public Grupo grupo { get; set; }


        public int agregarGrupo(String nombre, int IdLicenciatura, String semestre)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    Grupo grupo = new Grupo();
                    grupo.Nombre = nombre;
                    grupo.IdLicenciatura = IdLicenciatura;
                    grupo.semestre = semestre;

                    entity.Grupoes.Add(grupo);

                    return entity.SaveChanges();
                }
                catch (Exception)
                {
                    return -1;
                }
            }


        }

        public List<Grupo> obtenerGrupos()
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    return entity.Grupoes.Select(p => p).ToList();
                }
                catch (Exception)
                {
                    return null;
                }
            }


        }

        public Grupo obtenerGrupos(string nombre)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    this.grupo = entity.Grupoes.Where(p => p.Nombre == nombre).First();
                    return grupo;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public int eliminarGrupo(int id)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    var grupo = entity.Grupoes.Where(p => p.idGrupo == id).ToList().First();
                    entity.Grupoes.Remove(grupo);
                    return entity.SaveChanges();
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }


        public int actualizarGrupo(string nombre, int idLicenciatura, string semestre)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    var grupo = entity.Grupoes.Where(p => p.idGrupo == this.grupo.idGrupo).ToList().First();
                    grupo.Nombre = nombre;
                    grupo.IdLicenciatura = idLicenciatura;
                    grupo.semestre = semestre;

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
