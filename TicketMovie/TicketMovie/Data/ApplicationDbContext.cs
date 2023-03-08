using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketMovie.Models;

namespace TicketMovie.Data
{
    public class ApplicationDbContext:DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(x => new
            {
                x.ActorId,
                x.MovieId
            });
            modelBuilder.Entity<Actor_Movie>().HasOne(x => x.Movie).WithMany(y => y.Actor_Movies).HasForeignKey(m =>
                m.MovieId);
            modelBuilder.Entity<Actor_Movie>().HasOne(x => x.Actor).WithMany(y => y.Actor_Movies).HasForeignKey(m =>
                m.ActorId);
        }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor_Movie> Actor_Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }
    }
}
