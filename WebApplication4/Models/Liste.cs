using System;
using System.Data.Entity;

namespace WebApplication4.Models
{
    public class Liste
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Anzahl { get; set; }
    }

    public class ListeDBContext : DbContext
    {
        public DbSet<Liste> liste { get; set; }
    }
}