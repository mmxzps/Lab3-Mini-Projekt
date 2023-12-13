using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using Lab3_Mini_Projekt.Model;

namespace Lab3_Mini_Projekt.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<InterestWebLink> InterestWebLinks { get; set;}

        public ApplicationContext(DbContextOptions<ApplicationContext> options) :base(options) { }
    }
}
