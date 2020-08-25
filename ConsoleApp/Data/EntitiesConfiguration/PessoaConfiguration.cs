using ConsoleApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace ConsoleApp.Data.EntitiesConfiguration
{
    public class PessoaConfiguration<T> : IEntityTypeConfiguration<T> where T : Pessoa
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            // TPH - Table Per Hierarchy - suporta
            // TPC - Table Per Concret Type - não suporta
            // TPT - Table Per Type - não suporta
            // Pesquisar sobre isso depois!
            builder.Property(c => c.PrimeiroNome).HasColumnName("first_name").HasColumnType("varchar(45)").IsRequired();
            builder.Property(c => c.UltimoNome).HasColumnName("last_name").HasColumnType("varchar(45)").IsRequired();
            builder.Property(c => c.Email).HasColumnName("email").HasColumnType("varchar(50)");
            builder.Property(c => c.Ativo).HasColumnName("active");
            builder.Property<DateTime>("last_update").HasColumnType("datetime").HasDefaultValueSql("getdate()").IsRequired();
        }
    }
}
