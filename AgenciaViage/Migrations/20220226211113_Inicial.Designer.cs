﻿// <auto-generated />
using System;
using AgenciaVorazes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AgenciaVorazes.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20220226211113_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AgenciaVorazes.Models.Pacotes", b =>
                {
                    b.Property<int>("IdPacotes")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdPacotes")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataIda")
                        .HasColumnType("datetime")
                        .HasColumnName("DataIda");

                    b.Property<DateTime>("DataVolta")
                        .HasColumnType("datetime")
                        .HasColumnName("DataVolta");

                    b.Property<string>("Destino")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Destino");

                    b.Property<string>("Origem")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Origem");

                    b.Property<double>("Preço")
                        .HasColumnType("float")
                        .HasColumnName("Preço");

                    b.HasKey("Id");

                    b.ToTable("Pacotes");
                });
#pragma warning restore 612, 618
        }
    }
}