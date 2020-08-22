using ConsoleApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace ConsoleApp.Data.EntitiesConfiguration
{
    public class FilmeCategoriaConfiguration : IEntityTypeConfiguration<FilmeCategoria>
    {
        public void Configure(EntityTypeBuilder<FilmeCategoria> builder)
        {
            builder.ToTable("film_category");
            builder.Property<int>("film_id");
            builder.Property<byte>("category_id");
            builder.HasKey("film_id", "category_id");
            builder.Property<DateTime>("last_update").HasColumnType("datetime").HasDefaultValueSql("getdate()");
            builder.HasOne(fc => fc.Filme).WithMany(f => f.Categorias).HasForeignKey("film_id");
            builder.HasOne(fc => fc.Categoria).WithMany(c => c.Filmes).HasForeignKey("category_id");
        }
    }
}
