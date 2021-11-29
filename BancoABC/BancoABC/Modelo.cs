using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoABC
{
    class Modelo
    {


        public static int Registro(Usuarios usuario)
        {
            MySqlConnection conexion = ConexionSQL.Conectar();
            conexion.Open();

            string sql = "INSERT INTO usuarios (usuario, password, nombre, id_tipo) VALUES(@usuario, @password, @nombre, @id_tipo)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario.Usuario);
            comando.Parameters.AddWithValue("@password", usuario.Password);
            comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
            comando.Parameters.AddWithValue("@id_tipo", 1);

            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }

        public static bool ExisteUsuario(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = ConexionSQL.Conectar();
            conexion.Open();

            string sql = "SELECT idusuarios FROM usuarios WHERE usuario LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Usuarios PorUsuario(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = ConexionSQL.Conectar();
            conexion.Open();

            string sql = "SELECT idusuarios, password, nombre, saldo, ncuenta FROM usuarios WHERE usuario LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);

            reader = comando.ExecuteReader();

            Usuarios usr = null;

            while (reader.Read())
            {
                usr = new Usuarios();
                usr.Idusuarios = int.Parse(reader["idusuarios"].ToString());
                usr.Password = reader["password"].ToString();
                usr.Nombre = reader["nombre"].ToString();
                usr.Saldo = reader["saldo"].ToString();
                usr.Ncuenta = reader["ncuenta"].ToString();
            }
            return usr;
        }




    }
}
