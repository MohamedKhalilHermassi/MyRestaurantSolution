using ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
//DBCONTEXT
namespace Infrastructure
{
    public class ExamenContext:DbContext
    {
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employe> Employes { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Serveur> Serveurs { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (@"Data Source=(localdb)\mssqllocaldb;
                   Initial Catalog=RestaurantDB;
                   Integrated Security=true;
                   MultipleActiveResultSets=true");
            //Activer LazyLoading
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Employe>().HasDiscriminator<int>("TypeEmploye")
                                           .HasValue<Employe>(0)
                                          .HasValue<Serveur>(2)
                                           .HasValue<Chef>(1);

            modelBuilder.Entity<Reservation>()
                .HasKey(r => new { r.RestaurantFk, r.ClientFk, r.Date });


            base.OnModelCreating(modelBuilder);
        }

    }
  
}
