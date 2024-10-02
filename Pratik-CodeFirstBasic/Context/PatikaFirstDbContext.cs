using Microsoft.EntityFrameworkCore;
using Pratik_CodeFirstBasic.Entities;

namespace Pratik_CodeFirstBasic.Context
{
    public class PatikaFirstDbContext:DbContext
    {
        public PatikaFirstDbContext(DbContextOptions<PatikaFirstDbContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<MovieEntity> Movies => Set<MovieEntity>();
        public DbSet<GameEntity> Games => Set<GameEntity>();


    }


   
}
