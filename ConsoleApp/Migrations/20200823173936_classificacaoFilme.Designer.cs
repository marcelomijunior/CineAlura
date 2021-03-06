﻿// <auto-generated />
using System;
using ConsoleApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConsoleApp.Migrations
{
    [DbContext(typeof(CineAluraContext))]
    [Migration("20200823173936_classificacaoFilme")]
    partial class classificacaoFilme
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ConsoleApp.Models.Ator", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("actor_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PrimeiroNome")
                        .IsRequired()
                        .HasColumnName("first_name")
                        .HasColumnType("varchar(45)");

                    b.Property<string>("SegundoNome")
                        .IsRequired()
                        .HasColumnName("last_name")
                        .HasColumnType("varchar(45)");

                    b.Property<DateTime>("last_update")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.HasKey("Id");

                    b.HasAlternateKey("PrimeiroNome", "SegundoNome");

                    b.HasIndex("SegundoNome")
                        .HasName("idx_actor_last_name");

                    b.ToTable("actor");
                });

            modelBuilder.Entity("ConsoleApp.Models.Categoria", b =>
                {
                    b.Property<byte>("Id")
                        .HasColumnName("category_id")
                        .HasColumnType("tinyint");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("varchar(25)");

                    b.Property<DateTime>("last_update")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.HasKey("Id");

                    b.ToTable("category");
                });

            modelBuilder.Entity("ConsoleApp.Models.Filme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("film_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnoLancamento")
                        .HasColumnName("release_year")
                        .HasColumnType("varchar(4)");

                    b.Property<string>("Classificacao")
                        .HasColumnName("rating")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Descricao")
                        .HasColumnName("description")
                        .HasColumnType("text");

                    b.Property<short>("Duracao")
                        .HasColumnName("length")
                        .HasColumnType("smallint");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnName("title")
                        .HasColumnType("varchar(255)");

                    b.Property<byte>("language_id")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("last_update")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<byte?>("original_language_id")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("language_id");

                    b.HasIndex("original_language_id");

                    b.ToTable("film");
                });

            modelBuilder.Entity("ConsoleApp.Models.FilmeAtor", b =>
                {
                    b.Property<int>("film_id")
                        .HasColumnType("int");

                    b.Property<int>("actor_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("last_update")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.HasKey("film_id", "actor_id");

                    b.HasIndex("actor_id");

                    b.ToTable("film_actor");
                });

            modelBuilder.Entity("ConsoleApp.Models.FilmeCategoria", b =>
                {
                    b.Property<int>("film_id")
                        .HasColumnType("int");

                    b.Property<byte>("category_id")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("last_update")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.HasKey("film_id", "category_id");

                    b.HasIndex("category_id");

                    b.ToTable("film_category");
                });

            modelBuilder.Entity("ConsoleApp.Models.Idioma", b =>
                {
                    b.Property<byte>("Id")
                        .HasColumnName("language_id")
                        .HasColumnType("tinyint");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("last_update")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.HasKey("Id");

                    b.ToTable("language");
                });

            modelBuilder.Entity("ConsoleApp.Models.Filme", b =>
                {
                    b.HasOne("ConsoleApp.Models.Idioma", "IdiomaFalado")
                        .WithMany("FilmesFalados")
                        .HasForeignKey("language_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleApp.Models.Idioma", "IdiomaOriginal")
                        .WithMany("FilmesOriginais")
                        .HasForeignKey("original_language_id");
                });

            modelBuilder.Entity("ConsoleApp.Models.FilmeAtor", b =>
                {
                    b.HasOne("ConsoleApp.Models.Ator", "Ator")
                        .WithMany("Filmografia")
                        .HasForeignKey("actor_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleApp.Models.Filme", "Filme")
                        .WithMany("Elenco")
                        .HasForeignKey("film_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConsoleApp.Models.FilmeCategoria", b =>
                {
                    b.HasOne("ConsoleApp.Models.Categoria", "Categoria")
                        .WithMany("Filmes")
                        .HasForeignKey("category_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleApp.Models.Filme", "Filme")
                        .WithMany("Categorias")
                        .HasForeignKey("film_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
