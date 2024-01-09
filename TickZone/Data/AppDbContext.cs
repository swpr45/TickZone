using Microsoft.EntityFrameworkCore;
using TickZone.Models;

namespace TickZone.Data
{
    public class AppDbContext:DbContext 
        //to inherit from dbcontext we need to add entity framework package
    {
        /* What is DbContext?
           • Translator between your model classes and the database
        i.e. this class is official translator between model class and sql code
         */
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });

            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am =>am.Actor_Movies).HasForeignKey(am => am.MovieId);
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(am => am.Actor_Movies).HasForeignKey(am => am.ActorId);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Actor> Actors { get; set; } 
        public DbSet<Actor_Movie> Actor_Movies { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Cinema> Cinema { get; set; }

    }
}
