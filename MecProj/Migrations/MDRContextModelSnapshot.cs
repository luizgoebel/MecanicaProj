﻿// <auto-generated />
using System;
using MecProj.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MecProj.Migrations
{
    [DbContext(typeof(MDRContext))]
    partial class MDRContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MecProj.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Complemento")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Cpf_Cnpj")
                        .IsRequired()
                        .HasMaxLength(19)
                        .HasColumnType("nvarchar(19)");

                    b.Property<string>("Email")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Numero")
                        .HasMaxLength(5)
                        .HasColumnType("int");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TelefoneCelular")
                        .IsRequired()
                        .HasMaxLength(17)
                        .HasColumnType("nvarchar(17)");

                    b.Property<string>("TelefoneRecado")
                        .HasMaxLength(17)
                        .HasColumnType("nvarchar(17)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("Cpf_Cnpj")
                        .IsUnique();

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("MecProj.Models.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasMaxLength(19)
                        .HasColumnType("nvarchar(19)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Data_Cadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Numero")
                        .HasMaxLength(5)
                        .HasColumnType("int");

                    b.Property<string>("Observacao")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CNPJ")
                        .IsUnique();

                    b.ToTable("Fornecedores");
                });

            modelBuilder.Entity("MecProj.Models.OrdemServico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("Entrada")
                        .HasColumnType("datetime2");

                    b.Property<string>("Pecas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Service")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Situacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Servicos");
                });

            modelBuilder.Entity("MecProj.Models.Recibo", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Saida")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Recibos");
                });

            modelBuilder.Entity("MecProj.Models.Cliente", b =>
                {
                    b.HasOne("MecProj.Models.Cliente", null)
                        .WithMany("clientes")
                        .HasForeignKey("ClienteId");
                });

            modelBuilder.Entity("MecProj.Models.OrdemServico", b =>
                {
                    b.HasOne("MecProj.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("MecProj.Models.Recibo", b =>
                {
                    b.HasOne("MecProj.Models.Cliente", "Cliente")
                        .WithMany("Recibos")
                        .HasForeignKey("ClienteId");

                    b.HasOne("MecProj.Models.OrdemServico", "OrdemServico")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("OrdemServico");
                });

            modelBuilder.Entity("MecProj.Models.Cliente", b =>
                {
                    b.Navigation("clientes");

                    b.Navigation("Recibos");
                });
#pragma warning restore 612, 618
        }
    }
}
