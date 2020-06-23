using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Kyrsach_K3S2_V1.Services
{
    class OperationService
    {
        public int IdOp { get; set; }
        public int IdW { get; set; }
        public DateTime Date { get; set; }
        public int Cost { get; set; }
        public string TypeOp { get; set; }
    }
    public class LogOperation : ServiceBase
    {
        public string FioC { get; set; }
        public string TypeOp { get; set; }
        public DateTime DateTime { get; set; }
        public int Cost { get; set; }
        public string PhoneC { get; set; }       

        public List<LogOperation> GetLog(List<LogOperation> logOperations)
        {

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = $@"Select ФИОКлиента, ТипОперации, ДатаВремя, Стоимость, Телефон 
                                            From Журнал";
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string fio = reader.GetString(0);
                                string type = reader.GetString(1);
                                DateTime date = reader.GetDateTime(2);
                                int cost = reader.GetInt32(3);
                                string phone = reader.GetString(4);

                                logOperations.Add(new LogOperation() { FioC = fio, TypeOp = type, DateTime = date, Cost = cost, PhoneC = phone });
                            }
                        }
                    }
                }
            }
            return logOperations;
        }
    }
}
