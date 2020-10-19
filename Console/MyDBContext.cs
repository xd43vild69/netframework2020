using BLL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    public class MyDBContext : DbContext
    {
        public DbSet<Person> Person { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<PersonHouse> PersonHouse { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=dbNetFramework;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonHouse>()
                .HasKey(s => new { s.PersonId, s.HouseId });
        }
    }

}
