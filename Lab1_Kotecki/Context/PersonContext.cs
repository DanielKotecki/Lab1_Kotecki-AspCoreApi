using Lab1_Kotecki.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1_Kotecki.Context
{
    public class PersonContext :DbContext
    {
       // private string _connectionString = "Server=(localdb)\\mssqllocaldb;Database=Lab1;Trusted_Connection=True;";
        private readonly string _connectionString = "Server=tcp:kotecki-cdv.database.windows.net,1433;Initial Catalog=kotecki_cdv;Persist Security Info=False;User ID=kocurrek98;Password=Daniel435;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
