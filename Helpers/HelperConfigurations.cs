using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Helpers
{
    public class HelperConfigurations
    {
        public static string GetConnectionString()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .AddJsonFile("config.json",true,true);
            IConfigurationRoot config = builder.Build();
            string connectionString = config["SqlHospital"];
            return connectionString;
        }
    }
}
