﻿// <auto-generated />
using System;
using EfCore.Api.Game.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EfCore.Api.Game.Migrations
{
    [DbContext(typeof(HeroiContext))]
    [Migration("20200129003405_HeroisBatalhas_Identidade")]
    partial class HeroisBatalhas_Identidade
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EfCore.Api.Game.Models.Arma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HeroiId");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("HeroiId");

                    b.ToTable("Armas");
                });

            modelBuilder.Entity("EfCore.Api.Game.Models.Batalha", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao");

                    b.Property<DateTime>("DtFim");

                    b.Property<DateTime>("DtIncio");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Batalhas");
                });

            modelBuilder.Entity("EfCore.Api.Game.Models.Heroi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Herois");
                });

            modelBuilder.Entity("EfCore.Api.Game.Models.HeroiBatalha", b =>
                {
                    b.Property<int>("BatalhaId");

                    b.Property<int>("HeroiId");

                    b.HasKey("BatalhaId", "HeroiId");

                    b.HasIndex("HeroiId");

                    b.ToTable("HeroiBatalhas");
                });

            modelBuilder.Entity("EfCore.Api.Game.Models.IdentidadeSecreta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HeroiId");

                    b.Property<string>("NomeReal");

                    b.HasKey("Id");

                    b.HasIndex("HeroiId")
                        .IsUnique();

                    b.ToTable("IdentidadeSecretas");
                });

            modelBuilder.Entity("EfCore.Api.Game.Models.Arma", b =>
                {
                    b.HasOne("EfCore.Api.Game.Models.Heroi", "Heroi")
                        .WithMany("Armas")
                        .HasForeignKey("HeroiId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EfCore.Api.Game.Models.HeroiBatalha", b =>
                {
                    b.HasOne("EfCore.Api.Game.Models.Batalha", "Batalha")
                        .WithMany()
                        .HasForeignKey("BatalhaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EfCore.Api.Game.Models.Heroi", "Heroi")
                        .WithMany("HeroiBatalhas")
                        .HasForeignKey("HeroiId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EfCore.Api.Game.Models.IdentidadeSecreta", b =>
                {
                    b.HasOne("EfCore.Api.Game.Models.Heroi", "Heroi")
                        .WithOne("Identidade")
                        .HasForeignKey("EfCore.Api.Game.Models.IdentidadeSecreta", "HeroiId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
