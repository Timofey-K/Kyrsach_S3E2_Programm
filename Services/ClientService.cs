using Kyrsach_K3S2_V1.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Kyrsach_K3S2_V1.Services
{
    public class ClientService : ServiceBase
    {
        public List<Client> GetClient(List<Client> clients)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"Select КодКлиента, ФИОКлиента From Клиент";
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string name = reader.GetString(1);
                                clients.Add(new Client() { Id = id, Fio = name });
                            }
                        }
                    }
                }
                return clients;
            }
        }
        public void Insert(string fio, string number)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {

                    command.CommandText = $@"insert into Клиент(ФИОКлиента, Телефон) values(@fio, @number)";
                    command.Parameters.AddWithValue("@fio", fio);
                    command.Parameters.AddWithValue("@number", number);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void Delete(string number)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = $@"delite from Клиент where Телефон =  @numder)";
                    command.Parameters.AddWithValue("@numder", number);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void Update(string name, string number)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = $@"update Клиент set ФИОКлиента = @name where Телефон = @numder)";
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@numder", number);
                    command.ExecuteNonQuery();

                }
            }
        }

    }
}
