using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrsach_K3S2_V1.Services
{
    public class ServiceBase
    {
        protected static string ConnectionString = ConfigurationManager
                         .ConnectionStrings["МагазинСредневековогоОружия"]
                         .ConnectionString;
    }
}
