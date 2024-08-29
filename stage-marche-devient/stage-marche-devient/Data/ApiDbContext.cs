using Microsoft.EntityFrameworkCore;
using stage_marche_devient.Models;

namespace stage_marche_devient.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext()
        {
        }
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
        }

        public virtual DbSet<ReserverModel> Reserver { get; set; }
        public virtual DbSet<Randonnee> Randonnee { get; set; }
        public virtual DbSet<Publication> Publication { get; set; }
        public virtual DbSet<Theme> Theme { get; set; }
    }
}