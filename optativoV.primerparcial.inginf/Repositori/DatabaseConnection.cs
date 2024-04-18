using System;
using Npgsql;

namespace optativoV.primerparcial.inginf.Repositori
{
    public class DatabaseConnection
    {
        private string connectionString;

        public DatabaseConnection(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void TestConnection()
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Ejecutar una consulta simple para verificar la conexión
                    using (var command = new NpgsqlCommand("SELECT 1", connection))
                    {
                        command.ExecuteScalar();
                        Console.WriteLine("La conexión a la base de datos fue exitosa.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al conectar a la base de datos: {ex.Message}");
            }
        }
    }
}
