﻿using ConsoleApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace ConsoleApp.Data.EntitiesConfiguration
{
    public class AtorConfiguration : IEntityTypeConfiguration<Ator>
    {
        public void Configure(EntityTypeBuilder<Ator> builder)
        {
            builder.ToTable("actor");
            builder.Property(a => a.Id).HasColumnName("actor_id");
            builder.Property(a => a.PrimeiroNome).HasColumnName("first_name").HasColumnType("varchar(45)").IsRequired();
            builder.Property(a => a.SegundoNome).HasColumnName("last_name").HasColumnType("varchar(45)").IsRequired();
            builder.Property<DateTime>("last_update").HasColumnType("datetime").HasDefaultValueSql("getdate()").IsRequired();
            builder.HasIndex(a => a.SegundoNome).HasName("idx_actor_last_name");
            builder.HasAlternateKey(a => new { a.PrimeiroNome, a.SegundoNome });
        }
    }
}
