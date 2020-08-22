using ConsoleApp.Data.EntitiesConfiguration;
using ConsoleApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp.Data
{
    public class CineAluraContext : DbContext
    {
        public DbSet<Ator> Atores { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<FilmeAtor> Elenco { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<FilmeCategoria> FilmeCategorias { get; set; }
        public DbSet<Idioma> Idiomas { get; set; }

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
            modelBuilder.ApplyConfiguration(new AtorConfiguration());
            modelBuilder.ApplyConfiguration(new FilmeConfiguration());
            modelBuilder.ApplyConfiguration(new FilmeAtorConfiguration());
            modelBuilder.ApplyConfiguration(new CategoriaConfiguration());
            modelBuilder.ApplyConfiguration(new FilmeCategoriaConfiguration());
            modelBuilder.ApplyConfiguration(new IdiomaConfiguration());
        }
    }
}
