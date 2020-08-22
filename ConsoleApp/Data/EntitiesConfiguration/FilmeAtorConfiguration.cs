using ConsoleApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace ConsoleApp.Data.EntitiesConfiguration
{
    public class FilmeAtorConfiguration : IEntityTypeConfiguration<FilmeAtor>
    {
        public void Configure(EntityTypeBuilder<FilmeAtor> builder)
        {
            builder.ToTable("film_actor");
            builder.Property<int>("film_id").IsRequired();
            builder.Property<int>("actor_id").IsRequired();
            builder.HasKey("film_id", "actor_id");
            builder.Property<DateTime>("last_update").HasColumnType("datetime").IsRequired().HasDefaultValueSql("getdate()");
            builder.HasOne(fa => fa.Filme).WithMany(f => f.Elenco).HasForeignKey("film_id");
            builder.HasOne(fa => fa.Ator).WithMany(a => a.Filmografia).HasForeignKey("actor_id");
        }
    }
}
