﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using lemosst.laboratorio.Data.Contexto;

#nullable disable

namespace lemosst.laboratorio.Data.Migrations
{
    [DbContext(typeof(DataContexto))]
    [Migration("20230806163445_SubItens")]
    partial class SubItens
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("lemosst.laboratorio.Domain.Entidades.ProdutoItens", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("DescricaoItens")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int?>("ProdutosId")
                        .HasColumnType("int");

                    b.Property<int>("SubItensId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("ProdutosId");

                    b.HasIndex("SubItensId");

                    b.ToTable("ProdutoItens");
                });

            modelBuilder.Entity("lemosst.laboratorio.Domain.Entidades.Produtos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NomeProduto")
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Produtos", (string)null);
                });

            modelBuilder.Entity("lemosst.laboratorio.Domain.Entidades.SubItens", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SubItens");
                });

            modelBuilder.Entity("lemosst.laboratorio.Domain.Entidades.ProdutoItens", b =>
                {
                    b.HasOne("lemosst.laboratorio.Domain.Entidades.Produtos", "Produtos")
                        .WithMany("ProdutoItens")
                        .HasForeignKey("ProdutosId");

                    b.HasOne("lemosst.laboratorio.Domain.Entidades.SubItens", "SubItens")
                        .WithMany("ProdutoItens")
                        .HasForeignKey("SubItensId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produtos");

                    b.Navigation("SubItens");
                });

            modelBuilder.Entity("lemosst.laboratorio.Domain.Entidades.Produtos", b =>
                {
                    b.Navigation("ProdutoItens");
                });

            modelBuilder.Entity("lemosst.laboratorio.Domain.Entidades.SubItens", b =>
                {
                    b.Navigation("ProdutoItens");
                });
#pragma warning restore 612, 618
        }
    }
}