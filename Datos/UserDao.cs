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


        /*public void AgregarPaciente(string nombre, string apellido, DateTime fechaNacimiento, string telefono, string email)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO paciente (nombre, apellido, fecha_nacimiento, telefono, email) VALUES (@nombre, @apellido, @fechaNacimiento, @telefono, @correo)";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                    command.Parameters.AddWithValue("@telefono", telefono);
                    command.Parameters.AddWithValue("@correo", email);
                    command.ExecuteNonQuery();
                }
            }
        }*/
        public void AgregarPacienteConHistorial(string nombre, string apellido, DateTime fechaNacimiento, string telefono, string email)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Insertar el paciente y obtener el ID generado
                    string queryPaciente = "INSERT INTO paciente (nombre, apellido, fecha_nacimiento, telefono, email) OUTPUT INSERTED.id_paciente VALUES (@nombre, @apellido, @fechaNacimiento, @telefono, @correo)";
                    int idPaciente;
                    using (var command = new SqlCommand(queryPaciente, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@apellido", apellido);
                        command.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                        command.Parameters.AddWithValue("@telefono", telefono);
                        command.Parameters.AddWithValue("@correo", email);
                        idPaciente = (int)command.ExecuteScalar();
                    }

                    // Crear el historial clínico
                    string queryHistorial = "INSERT INTO historial_clinico (descripcion, paciente_id_paciente) VALUES (@descripcion, @idPaciente)";
                    using (var command = new SqlCommand(queryHistorial, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@descripcion", "Historial creado automáticamente.");
                        command.Parameters.AddWithValue("@idPaciente", idPaciente);
                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }



        public DataTable FiltrarPacientesPorNombre(string nombre)
        {
            DataTable table = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT p.id_paciente, p.nombre, p.apellido, h.descripcion " +
                               "FROM paciente p " +
                               "INNER JOIN historial_clinico h ON p.id_paciente = h.paciente_id_paciente " +
                               "WHERE p.nombre LIKE @nombre";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
                    using (var adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
            }
            return table;
        }







        public void ActualizarPaciente(int id, string nombre, string apellido, DateTime fechaNacimiento, string telefono, string email)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "UPDATE paciente SET nombre = @nombre, apellido = @apellido, fecha_nacimiento = @fechaNacimiento, telefono = @telefono, email = @correo WHERE id_paciente = @id";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                    command.Parameters.AddWithValue("@telefono", telefono);
                    command.Parameters.AddWithValue("@correo", email);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void EliminarPaciente(int id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM paciente WHERE id_paciente = @id";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable ObtenerPacientes()
        {
            DataTable table = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM paciente";

                using (var command = new SqlCommand(query, connection))
                using (var adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(table);
                }
            }
            return table;
        }

        public void AgregarTratamiento(string nombre, string descripcion, decimal costo)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO tratamientos (nombre_tratamiento, descripcion, costo) VALUES (@nombre, @descripcion, @costo)";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    command.Parameters.AddWithValue("@costo", costo);
                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable ObtenerTratamientos()


        {
            DataTable table = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM tratamientos";

                using (var command = new SqlCommand(query, connection))
                using (var adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(table);
                }
            }
            return table;
        }

        public void ActualizarTratamiento(int id, string nombre, string descripcion, decimal costo)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "UPDATE tratamientos SET nombre_tratamiento = @nombre, descripcion = @descripcion, costo = @costo WHERE id_tratamiento = @id";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    command.Parameters.AddWithValue("@costo", costo);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void EliminarTratamiento(int id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM tratamientos WHERE id_tratamiento = @id";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }



        public void AgregarTratamientoAHistorial(int idHistorial, int idTratamiento)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO historial_tratamiento (id_historial, id_tratamiento) VALUES (@idHistorial, @idTratamiento)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idHistorial", idHistorial);
                    command.Parameters.AddWithValue("@idTratamiento", idTratamiento);
                    command.ExecuteNonQuery();
                }
            }
        }


        public DataTable ObtenerTratamientosPorHistorial(int idHistorial)
        {
            DataTable table = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT t.id_tratamiento, t.nombre_tratamiento, t.descripcion, t.costo " +
                               "FROM tratamientos t " +
                               "INNER JOIN historial_tratamiento ht ON t.id_tratamiento = ht.id_tratamiento " +
                               "WHERE ht.id_historial = @idHistorial";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idHistorial", idHistorial);
                    using (var adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
            }
            return table;
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
