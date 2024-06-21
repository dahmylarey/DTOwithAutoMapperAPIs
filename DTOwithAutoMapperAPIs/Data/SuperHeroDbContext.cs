using Microsoft.EntityFrameworkCore;

namespace DTOwithAutoMapperAPIs.Data
{
    public class SuperHeroDbContext : DbContext
    {
        public SuperHeroDbContext(DbContextOptions<SuperHeroDbContext> options) : base(options)
        { }

        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
