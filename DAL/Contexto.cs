using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroAnimes.Entidades;

namespace RegistroAnimes.DAL
{
    public class Contexto : DbContext
    {
        
        public DbSet<Animes> Animes { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= DATA\Animes.db");
        }
    }
}
