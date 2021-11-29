using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BancoABC
{
    class controlbd
    {

        public string ctrlLogin(string usuario, string password)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";
            Usuarios datosUsuario = null;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                datosUsuario = Modelo.PorUsuario(usuario);

                if (datosUsuario == null)
                {
                    respuesta = "El usuario no existe";
                }
                else
                {
                    if (datosUsuario.Password != (password))
                    {
                        respuesta = "El usuario y/o contraseña no coinciden";
                    }
                    else
                    {
                        Session.idusuarios = datosUsuario.Idusuarios;
                        Session.usuario = usuario;
                        Session.nombre = datosUsuario.Nombre;
                        Session.saldo = datosUsuario.Saldo;
                        Session.ncuenta = datosUsuario.Ncuenta;
                    }
                }
            }
            return respuesta;
        }



    }
}
