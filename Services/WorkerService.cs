using Kyrsach_K3S2_V1.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Kyrsach_K3S2_V1.Services
{
    public class WorkerService
    {
        private static string connectionString = ConfigurationManager
                    .ConnectionStrings["МагазинСредневековогоОружия"]
                    .ConnectionString;


        public void GetWorker(List<Worker> workers)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"Select КодСотрудника, ФИОСотрудника From Сотрудник";
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string name = reader.GetString(1);
                                workers.Add(new Worker() { idWorker = id, fioWorker = name });
                            }
                        }
                    }
                }
            }
        }
    }
}
