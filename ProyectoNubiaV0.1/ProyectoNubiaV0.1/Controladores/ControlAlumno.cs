using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoNubiaV0._1.Modelos;

namespace ProyectoNubiaV0._1.Controladores
{
    class ControlAlumno
    {
        public ControlAlumno()
        {

        }

        public Alumno alumno { get; set; }
        public List<Alumno> alumnos_todos { get; set; }

        public int agregarAlumnos(String matricula, int grupo, String nombre, String apellidos, String edad)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    Alumno alumno = new Alumno();
                    alumno.Matricula = matricula;
                    alumno.Nombre = nombre;
                    alumno.Apellidos = apellidos;
                    alumno.idGrupo = grupo;
                    alumno.Edad = edad;

                    entity.Alumnoes.Add(alumno);
                    return entity.SaveChanges();
                }
                catch (Exception)
                {
                    return -1;
                }
            }


        }



        public List<Alumno> obtenerAlumnos()
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    alumnos_todos = entity.Alumnoes.Select(p => p).ToList();
                    return alumnos_todos;
                }
                catch (Exception)
                {
                    return null;
                }
            }


        }

        public Alumno obtenerAlumnos(string nombre)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    this.alumno = entity.Alumnoes.Where(p => p.Matricula == nombre).First();
                    return alumno;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public int eliminarAlumnos(String id)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    var alumnos = entity.Alumnoes.Where(p => p.Matricula == id).ToList().First();
                    entity.Alumnoes.Remove(alumnos);
                    return entity.SaveChanges();
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }


        public int actualizarAlumnos(String nombre, String apellidos, String edad, int grupo)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    var alumno = entity.Alumnoes.Where(p => p.Matricula == this.alumno.Matricula).ToList().First();
                    alumno.Nombre = nombre;
                    alumno.Apellidos = apellidos;
                    alumno.Edad = edad;
                    alumno.idGrupo = grupo;
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
