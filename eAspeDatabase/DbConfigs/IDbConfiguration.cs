using Microsoft.EntityFrameworkCore;

namespace eAspeDatabase.DbConfigs
{
    public interface IDbConfiguration
    {
        string ConnectionString { get; set; }
        DbContextOptions Options { get; set; }
    }
}