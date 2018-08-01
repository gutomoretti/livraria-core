﻿// <auto-generated />
using System;
using Livraria_Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Livraria_Core.Migrations
{
    [DbContext(typeof(LivrariaDbContext))]
    partial class LivrariaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Livraria_Core.Models.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Cadastro");

                    b.Property<bool>("Inativo");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("generos");
                });

            modelBuilder.Entity("Livraria_Core.Models.Livro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Autor");

                    b.Property<DateTime>("Cadastro");

                    b.Property<string>("Descricao");

                    b.Property<int?>("GeneroId");

                    b.Property<bool>("Inativo");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("GeneroId");

                    b.ToTable("livros");
                });

            modelBuilder.Entity("Livraria_Core.Models.Livro", b =>
                {
                    b.HasOne("Livraria_Core.Models.Genero", "Genero")
                        .WithMany()
                        .HasForeignKey("GeneroId");
                });
#pragma warning restore 612, 618
        }
    }
}