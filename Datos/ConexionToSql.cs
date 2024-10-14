using System.Data.SqlClient;
namespace Datos
{
    public class ConexionToSql
    {
        private readonly string connectionString;
        public ConexionToSql()
        {
            connectionString = "Server=ADMINISTRATOR\\WINCC;Database = loginUsuarios; integrated security = true";
            /*connectionString = "Server=nombre de tu servidor = nombre de tu base de datos; integrated security = true";*/
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

    }
}