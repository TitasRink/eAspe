using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAspeDatabase.DbConfigs
{
    public class DbConfiguration: IDbConfiguration
    {
        public string ConnectionString { get; set; }
        public DbContextOptions Options { get; set; }

        public DbConfiguration(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("ConString");
            Options = new DbContextOptionsBuilder().UseSqlServer(ConnectionString).Options;
        }
    }
}
