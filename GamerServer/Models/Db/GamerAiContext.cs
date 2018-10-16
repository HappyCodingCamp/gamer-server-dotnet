using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;

namespace GamerServer.Models.Db
{
    public class GamerAiContext : DbContext
    {
        public DbSet<Happiness> Happinesses { get; set; } 

        public GamerAiContext(DbContextOptions<GamerAiContext> options) : base(options)
        {
        }
    }
}
