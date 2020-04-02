using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CourseProjectItr.Models
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public DbSet<Items> Items { get; set; }
        public DbSet<Collections> Collections { get; set; }
        public DbSet<ItemsOfCollections> ItemsOfCollections { get; set; }
        public DbSet<Likes> Likes { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
