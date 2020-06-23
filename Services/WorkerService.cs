using Kyrsach_K3S2_V1.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Kyrsach_K3S2_V1.Services
{
    public class WorkerService : ServiceBase
    {       
        public List<Worker> GetWorker(List<Worker> workers)
        {
            using (var connection = new SqlConnection(ConnectionString))
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
                                workers.Add(new Worker() { IdW = id, Fio = name });
                            }
                        }
                    }
                }
            }
            return workers;
        }
    }
}
