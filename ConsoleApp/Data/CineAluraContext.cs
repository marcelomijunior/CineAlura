using ConsoleApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Data
{
    public class CineAluraContext : DbContext
    {
        public DbSet<Ator> Atores { get; set; }

        public CineAluraContext()
        {
        }

        public CineAluraContext(DbContextOptions<CineAluraContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=AluraFilmes;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Mapeando tabela de atores...
            modelBuilder.Entity<Ator>()
                .ToTable("actor", "dbo");
            modelBuilder.Entity<Ator>()
                .Property(a => a.Id)
                .HasColumnName("actor_id");
            modelBuilder.Entity<Ator>()
                .Property(a => a.PrimeiroNome)
                .HasColumnName("first_name")
                .HasColumnType("varchar(45)");
            modelBuilder.Entity<Ator>()
                .Property(a => a.SegundoNome)
                .HasColumnName("last_name")
                .HasColumnType("varchar(45)");
            modelBuilder.Entity<Ator>()
                .Property(a => a.UltimaAtualizacao)
                .HasColumnName("last_update")
                .HasColumnType("datetime");
        }
    }
}
