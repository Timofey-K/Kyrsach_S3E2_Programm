using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrsach_K3S2_V1.Models
{
    public class Weapon
    {
        public int id { get; set; }
        public string Тип { get; set; }
        public bool Разрешение { get; set; }
        public string Качество { get; set; }
        public int Стоимость { get; set; }
        public string Описание { get; set; }
    }
}
