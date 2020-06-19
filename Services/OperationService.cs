using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Kyrsach_K3S2_V1.Services
{
    class OperationService
    {
        int idOperation { get; set; }
        int idWorker { get; set; }
        DateTime date { get; set; }
        int cost { get; set; }
        string tipOperation { get; set; }
    }

    public class LogOperation
    {
        public string ФИОКлиента { get; set; }
        public string ТипОперации { get; set; }
        public DateTime ДатаВремя { get; set; }
        public int Стоимость { get; set; }
        public string ТелефонКлиента { get; set; }

        private static string connectionString = ConfigurationManager
                   .ConnectionStrings["МагазинСредневековогоОружия"]
                   .ConnectionString;

        public void GetLog(List<LogOperation> logOperations)
        {

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = $@"Select ФИОКлиента, ТипОперации, ДатаВремя, Стоимость, Телефон 
                                            From Gyrnal";
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string Фио = reader.GetString(0);
                                string Тип = reader.GetString(1);
                                DateTime date = reader.GetDateTime(2);
                                int Стоимость = reader.GetInt32(3);
                                string Телефон = reader.GetString(4);

                                logOperations.Add(new LogOperation() { ФИОКлиента = Фио, ТипОперации = Тип, ДатаВремя = date, Стоимость = Стоимость, ТелефонКлиента = Телефон });
                            }
                        }
                    }
                }
            }
        }
    }
}
