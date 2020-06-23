using Kyrsach_K3S2_V1.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Kyrsach_K3S2_V1.Services
{
    class WeaponService : ServiceBase
    {
        public List<Weapon> GetListWeapon(List<Weapon> weapon, string from)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = $@"Select КодОружия, Тип,  Качество, ТребуетсяРазрешение, Стоимость, Описание 
                                           From {from}";
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string type = reader.GetString(1);
                                string quality = reader.GetString(2);
                                bool permission = reader.GetBoolean(3);
                                int cost = reader.GetInt32(4);
                                string description = reader.GetString(5);

                                weapon.Add(new Weapon() { Id = id, Type = type, Quality = quality, Permission = permission, Cost = cost, Description = description });
                            }
                        }
                    }
                }
            }
            return (weapon);
        }

        public List<Weapon> GetListWeapon(List<Weapon> weapon, string quality, string from)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {

                    command.CommandText = $@"Select КодОружия, Тип,  Качество, ТребуетсяРазрешение, Стоимость, Описание 
                                           From {from} Where Качество = @quality";
                    command.Parameters.AddWithValue("@quality", quality);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string type = reader.GetString(1);
                                string quality2 = reader.GetString(2);
                                bool permission = reader.GetBoolean(3);
                                int cost = reader.GetInt32(4);
                                string description = reader.GetString(5);

                                weapon.Add(new Weapon() { Id = id, Type = type, Quality = quality2, Permission = permission, Cost = cost, Description = description });
                            }
                        }
                    }
                }
            }
            return (weapon);
        }
    }
}
