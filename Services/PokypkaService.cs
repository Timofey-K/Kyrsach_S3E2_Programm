using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kyrsach_K3S2_V1.Services
{
    public class PokypkaService
    {

        private static string connectionString = ConfigurationManager
                              .ConnectionStrings["МагазинСредневековогоОружия"]
                              .ConnectionString;
        public void Pokypka(int idClient, string nameClient, int idWorker, string nameWorker, List<int> kods)
        {
            string korzina;
            korzina = $"{nameClient} купил \n";
            int summCost = 0;
            DateTime dateTime = DateTime.Now;
            foreach (int kod in kods)
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        try
                        {
                            command.CommandText = $@"EXEC opPokupka @idClient, @idWeapon, @idWorker, @dateTime";
                            command.Parameters.AddWithValue("@idClient", idClient);
                            command.Parameters.AddWithValue("@idWeapon", kod);
                            command.Parameters.AddWithValue("@idWorker", idWorker);
                            command.Parameters.AddWithValue("@dateTime", dateTime);
                            command.ExecuteNonQuery();
                            command.CommandText = $@"select Тип, Стоимость from ОружиеКолющее Where КодОружия = {kod}
                                      union select Тип, Стоимость from ОружиеРубящее Where КодОружия = {kod}
                                      union select Тип, Стоимость from ОружиеУдарное Where КодОружия = {kod}
                                      union select Тип, Стоимость from ОружиеПодЗаказ Where КодОружия = {kod}";
                            using (var reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        string tip = reader.GetString(0);
                                        int cost = reader.GetInt32(1);

                                        korzina += $"{tip} за {cost} \n";
                                        summCost += cost;
                                    }
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Ошибка выполнения операции");
                        }
                    }
                }
            }
            korzina += $"Общая стоимость покупки = {summCost} \n";
            korzina += $"Покупку оформил {nameWorker} \n";
            korzina += $"Дата операции {dateTime}";
            MessageBox.Show(korzina);
        }
    }
}
