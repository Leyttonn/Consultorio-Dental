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
                    command.CommandText = "select * from usuario where nombre_usuario=@user and password=@pass;";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.id_usuario = reader.GetInt32(0);
                            UserLoginCache.nombre_usuario = reader.GetString(1);
                            UserLoginCache.email = reader.GetString(3);
                            UserLoginCache.nombre = reader.GetString(4);
                            UserLoginCache.apellido = reader.GetString(5);
                            UserLoginCache.estado = reader.GetBoolean(7);
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
        public static int id_usuario { get; set; }
        public static string nombre_usuario { get; set; }
        public static string email { get; set; }
        public static string nombre { get; set; }
        public static string apellido { get; set; }
        public static bool estado { get; set; }
    }
}
