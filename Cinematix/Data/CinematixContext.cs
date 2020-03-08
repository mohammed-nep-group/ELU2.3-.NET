using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cinematix.Models;

namespace Cinematix.Data
{
    public class CinematixContext : DbContext
    {
        public CinematixContext (DbContextOptions<CinematixContext> options)
            : base(options)
        {
        }

        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieVenue> MovieVenues { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Venue> Venues { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cinema>().ToTable("Cinema");
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<Movie>().ToTable("Movie");
            modelBuilder.Entity<MovieVenue>().ToTable("MovieVenue");
            modelBuilder.Entity<Reservation>().ToTable("Reservation");
            modelBuilder.Entity<Venue>().ToTable("Venue");
        }
    }
}
