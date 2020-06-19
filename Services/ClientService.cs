using Kyrsach_K3S2_V1.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kyrsach_K3S2_V1.Services
{
    public class ClientService
    {
        private static string connectionString = ConfigurationManager
                    .ConnectionStrings["МагазинСредневековогоОружия"]
                    .ConnectionString;


        public void GetClient(List<Client> clients)
        {
            using (var connection = new SqlConnection(connectionString))
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
                                clients.Add(new Client() { idClient = id, fioClient = name });
                            }
                        }
                    }
                }
            }
        }


        public void Insert(string fio, string number)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    try
                    {
                        command.CommandText = $@"insert into Клиент(ФИОКлиента, Телефон) values(@fio, @number)";
                        command.Parameters.AddWithValue("@fio", fio);
                        command.Parameters.AddWithValue("@number", number);
                        command.ExecuteNonQuery();
                        MessageBox.Show($"Клиент {fio} добавлен");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Клиент с таким номером телефона уже существует");
                    }
                }
            }
        }

        public void Delete(string number)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    try
                    {
                        command.CommandText = $@"delite from Клиент where Телефон =  @numder)";
                        command.Parameters.AddWithValue("@numder", number);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Клиент удалён");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Клиента с таким номером телефона не существует");
                    }
                }
            }
        }

        public void Update(string name, string number)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    try
                    {
                        command.CommandText = $@"update Клиент set ФИОКлиента = @name where Телефон = @numder)";
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@numder", number);
                        command.ExecuteNonQuery();
                        MessageBox.Show("ФИОКлиента изменено");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Клиента с таким номером телефона не существует");
                    }
                }
            }
        }

    }
}
