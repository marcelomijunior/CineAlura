﻿
using ConsoleApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace ConsoleApp.Data.EntitiesConfiguration
{
    public class FilmeConfiguration : IEntityTypeConfiguration<Filme>
    {
        public void Configure(EntityTypeBuilder<Filme> builder)
        {
            builder.ToTable("film");
            builder.Property(f => f.Id).HasColumnName("film_id");
            builder.Property(f => f.Titulo).HasColumnName("title").HasColumnType("varchar(255)").IsRequired();
            builder.Property(f => f.Descricao).HasColumnName("description").HasColumnType("text");
            builder.Property(f => f.AnoLancamento).HasColumnName("release_year").HasColumnType("varchar(4)");
            builder.Property(f => f.Duracao).HasColumnName("length").HasColumnType("smallint");
            builder.Property<DateTime>("last_update").HasColumnType("datetime").HasDefaultValueSql("getdate()").IsRequired();
            builder.Property<byte>("language_id");
            builder.Property<byte?>("original_language_id");
            builder.HasOne(f => f.IdiomaFalado).WithMany(i => i.FilmesFalados).HasForeignKey("language_id");
            builder.HasOne(f => f.IdiomaOriginal).WithMany(i => i.FilmesOriginais).HasForeignKey("original_language_id");
            builder.Property(f => f.Classificacao).HasColumnName("rating").HasColumnType("varchar(10)");
        }
    }
}
