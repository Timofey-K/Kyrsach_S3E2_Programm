using System;
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
        public void Pokypka(int idClient, string nameClient, int idWeapon, int idWorker)
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
                        command.Parameters.AddWithValue("@idWeapon", idWeapon);
                        command.Parameters.AddWithValue("@idWorker", idWorker);
                        command.Parameters.AddWithValue("@dateTime", DateTime.Now);
                        command.ExecuteNonQuery();

                        command.CommandText = $@"select Тип, Стоимость from ОружиеКолющее Where КодОружия = {idWeapon}
                                      union select Тип, Стоимость from ОружиеРубящее Where КодОружия = {idWeapon}
                                      union select Тип, Стоимость from ОружиеУдарное Where КодОружия = {idWeapon}
                                      union select Тип, Стоимость from ОружиеПодЗаказ Where КодОружия = {idWeapon}";
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string tip = reader.GetString(0);
                                    int cost = reader.GetInt32(1);

                                    MessageBox.Show($"Клиент {nameClient} купил {tip} за {cost}");
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
    }
}
