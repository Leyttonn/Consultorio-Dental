using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Datos
{
    public class UserDao : ConexionToSql
    {
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from Usuarios where NombreUsuario=@user and Password=@pass;";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.UsuarioID = reader.GetInt32(0);
                            UserLoginCache.NombreUsuario = reader.GetString(1);
                            UserLoginCache.Email = reader.GetString(3);
                            UserLoginCache.Nombre = reader.GetString(4);
                            UserLoginCache.Apellido = reader.GetString(5);
                            UserLoginCache.Estado = reader.GetBoolean(7);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
        }
    }
    public static class UserLoginCache
    {
        public static int UsuarioID { get; set; }
        public static string NombreUsuario { get; set; }
        public static string Email { get; set; }
        public static string Nombre { get; set; }
        public static string Apellido { get; set; }
        public static bool Estado { get; set; }
    }
}
