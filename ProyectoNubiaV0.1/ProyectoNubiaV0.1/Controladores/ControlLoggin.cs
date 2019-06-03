using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoNubiaV0._1.Modelos;


namespace ProyectoNubiaV0._1.Controladores
{
    class ControlLoggin
    {
        public Usuario usuario { get; set; }
        public ControlLoggin()
        {

        }

        public void validarUsuario(string usuario, string contraseña)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                try
                {
                    this.usuario = entity.Usuarios.Where(p => p.nombreUsuario == usuario && p.Contraseña == contraseña).Select(p => p).First();
                }
                catch (Exception)
                {
                    this.usuario = null;
                }
            }
        }
    }
}
