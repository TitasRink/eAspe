using eAspe.Models;
using eAspeDatabase.DbConfigs;
using eAspeDatabase.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAspeDatabase.SqlDbContext
{
    public class AspeContext: DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemProperties> ItemProperties { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }

        public AspeContext(IDbConfiguration options) : base(options.Options)
        {

        }
    }
}
