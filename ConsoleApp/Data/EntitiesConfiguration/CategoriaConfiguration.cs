﻿using ConsoleApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace ConsoleApp.Data.EntitiesConfiguration
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("category");
            builder.Property(c => c.Id).HasColumnName("category_id");
            builder.Property(c => c.Nome).HasColumnName("name").HasColumnType("varchar(25)").IsRequired();
            builder.Property<DateTime>("last_update").HasColumnType("datetime").HasDefaultValueSql("getdate()");
        }
    }
}
