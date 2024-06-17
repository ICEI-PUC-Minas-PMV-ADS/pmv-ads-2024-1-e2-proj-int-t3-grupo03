﻿// <auto-generated />
using System;
using Kippa.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Kippa.Migrations
{
    [DbContext(typeof(KippaContext))]
    [Migration("20240610235654_AdicionaColunaCategoria")]
    partial class AdicionaColunaCategoria
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Kippa.Models.Lembrete", b =>
                {
                    b.Property<int>("IdLembrete")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_Lembrete");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdLembrete"));

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DataLembrete")
                        .HasColumnType("datetime2");

                    b.Property<TimeOnly?>("HoraLembrete")
                        .HasColumnType("time")
                        .HasColumnName("Hora_Lembrete");

                    b.Property<string>("NomeLembrete")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Nome_Lembrete");

                    b.Property<int?>("Notificacoes")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int")
                        .HasColumnName("Usuario_Id");

                    b.HasKey("IdLembrete")
                        .HasName("PK__Lembrete__6A2A398C3F7414E0");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Lembrete", (string)null);
                });

            modelBuilder.Entity("Kippa.Models.Tarefa", b =>
                {
                    b.Property<int>("IdTarefa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_Tarefa");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTarefa"));

                    b.Property<DateTime?>("DataTarefa")
                        .HasColumnType("datetime2")
                        .HasColumnName("Data_Tarefa");

                    b.Property<TimeOnly?>("HoraTarefa")
                        .HasColumnType("time")
                        .HasColumnName("Hora_Tarefa");

                    b.Property<string>("TipoTarefa")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Tipo_Tarefa");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int")
                        .HasColumnName("Usuario_Id");

                    b.HasKey("IdTarefa")
                        .HasName("PK__Tarefa__0F2013DB955AFE74");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Tarefa", (string)null);
                });

            modelBuilder.Entity("Kippa.Models.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_Usuario");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUsuario"));

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Nome")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Objetivo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Perfil")
                        .HasColumnType("int");

                    b.Property<string>("Profissao")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("IdUsuario")
                        .HasName("PK__Usuario__63C76BE2788B1FD5");

                    b.ToTable("Usuario", (string)null);
                });

            modelBuilder.Entity("Kippa.Models.Lembrete", b =>
                {
                    b.HasOne("Kippa.Models.Usuario", "Usuario")
                        .WithMany("Lembretes")
                        .HasForeignKey("UsuarioId")
                        .HasConstraintName("fk_Lembrete_Usuario_1");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Kippa.Models.Tarefa", b =>
                {
                    b.HasOne("Kippa.Models.Usuario", "Usuario")
                        .WithMany("Tarefas")
                        .HasForeignKey("UsuarioId")
                        .HasConstraintName("fk_Tarefa_Usuario_1");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Kippa.Models.Usuario", b =>
                {
                    b.Navigation("Lembretes");

                    b.Navigation("Tarefas");
                });
#pragma warning restore 612, 618
        }
    }
}
