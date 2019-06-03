using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoNubiaV0._1.Modelos;

namespace ProyectoNubiaV0._1.Controladores
{
    class ControlLicenciatura
    {
        public ControlLicenciatura()
        {

        }

        public Licenciatura licenciatura { get; set; }

        public int agregarLicenciatura(String nombre)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    Licenciatura licenciatura = new Licenciatura();
                    licenciatura.Nombre = nombre;
                    entity.Licenciaturas.Add(licenciatura);
                    return entity.SaveChanges();
                }
                catch (Exception)
                {
                    return -1;
                }
            }


        }

        public List<Licenciatura> obtenerLicenciaturas()
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    return entity.Licenciaturas.Select(p=>p).ToList();
                }
                catch (Exception)
                {
                    return null;
                }
            }

                
        }

        public Licenciatura obtenerLicenciaturas(string nombre)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    this.licenciatura = entity.Licenciaturas.Where(p => p.Nombre == nombre).First();
                    return licenciatura;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public int eliminarLicenciatura(int id)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    var licenciatura = entity.Licenciaturas.Where(p => p.IdLicenciatura == id).ToList().First();
                    entity.Licenciaturas.Remove(licenciatura);
                    return entity.SaveChanges();
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }


        public int actualizarLicenciatura(string nombre)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    var licenciatura = entity.Licenciaturas.Where(p => p.IdLicenciatura == this.licenciatura.IdLicenciatura).ToList().First();
                    licenciatura.Nombre = nombre;
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
