using Kyrsach_K3S2_V1.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Kyrsach_K3S2_V1.Services
{
    class PodZakazService
    {
        private static string connectionString = ConfigurationManager
                   .ConnectionStrings["МагазинСредневековогоОружия"]
                   .ConnectionString;

        public void GetPodZakaz(List<Weapon> weapon)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = $@"Select КодОружия, Тип,  Качество, ТребуетсяРазрешение, Стоимость, Описание 
                                           From ОружиеПодЗаказ";
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string Тип = reader.GetString(1);
                                string Качество = reader.GetString(2);
                                bool Разрешение = reader.GetBoolean(3);
                                int Стоимость = reader.GetInt32(4);
                                string Описание = reader.GetString(5);

                                weapon.Add(new Weapon() { id = id, Тип = Тип, Качество = Качество, Разрешение = Разрешение, Стоимость = Стоимость, Описание = Описание });
                            }
                        }
                    }
                }
            }
        }

        public void GetPodZakaz(List<Weapon> weapon, string quality)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = $@"Select КодОружия, Тип,  Качество, ТребуетсяРазрешение, Стоимость, Описание 
                                           From ОружиеПодЗаказ Where Качество = @Качество";
                    command.Parameters.AddWithValue("@Качество", quality);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string Тип = reader.GetString(1);
                                string Качество = reader.GetString(2);
                                bool Разрешение = reader.GetBoolean(3);
                                int Стоимость = reader.GetInt32(4);
                                string Описание = reader.GetString(5);

                                weapon.Add(new Weapon() { id = id, Тип = Тип, Качество = Качество, Разрешение = Разрешение, Стоимость = Стоимость, Описание = Описание });
                            }
                        }
                    }
                }
            }
        }
    }
}
