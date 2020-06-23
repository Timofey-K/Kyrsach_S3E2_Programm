using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kyrsach_K3S2_V1.Services
{
    public class PokypkaService : ServiceBase
    {
        public string Pokypka(int idClient, string nameClient, int idWorker, string nameWorker, List<int> kods)
        {
            string resultOp;
            string tip = "";
            resultOp = $"{nameClient} купил \n";
            int summCost = 0;
            DateTime dateTime = DateTime.Now;
            foreach (int kod in kods)
            {
                using (var connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
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
                                    tip = reader.GetString(0);
                                    int cost = reader.GetInt32(1);

                                    resultOp += $"{tip} за {cost} \n";
                                    summCost += cost;
                                }
                            }
                        }

                    }
                }
            }
            resultOp += $"Общая стоимость покупки = {summCost} \n";
            resultOp += $"Покупку оформил {nameWorker} \n";
            resultOp += $"Дата операции {dateTime}";            
            return resultOp;
        }

    }
}
