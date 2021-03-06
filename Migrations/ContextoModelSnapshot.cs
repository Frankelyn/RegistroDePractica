// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegistroAnimes.DAL;

namespace RegistroAnimes.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("RegistroAnimes.Entidades.Animes", b =>
                {
                    b.Property<int>("AnimeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("TEXT");

                    b.Property<string>("nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("AnimeId");

                    b.ToTable("Animes");
                });
#pragma warning restore 612, 618
        }
    }
}
