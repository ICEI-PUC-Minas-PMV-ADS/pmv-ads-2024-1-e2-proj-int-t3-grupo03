using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Kippa.Models;

public partial class KippaContext : DbContext
{
    public KippaContext()
    {
    }

    public KippaContext(DbContextOptions<KippaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Lembrete> Lembretes { get; set; }

    public virtual DbSet<Tarefa> Tarefas { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder);
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=localhost;Database=KIPPA;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Lembrete>(entity =>
        {
            entity.HasKey(e => e.IdLembrete).HasName("PK__Lembrete__6A2A398C3F7414E0");

            entity.ToTable("Lembrete");

            entity.Property(e => e.IdLembrete).HasColumnName("Id_Lembrete");
            entity.Property(e => e.HoraLembrete).HasColumnName("Hora_Lembrete");
            entity.Property(e => e.NomeLembrete)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Nome_Lembrete");
            entity.Property(e => e.UsuarioId).HasColumnName("Usuario_Id");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Lembretes)
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("fk_Lembrete_Usuario_1");
        });

        modelBuilder.Entity<Tarefa>(entity =>
        {
            entity.HasKey(e => e.IdTarefa).HasName("PK__Tarefa__0F2013DB955AFE74");

            entity.ToTable("Tarefa");

            entity.Property(e => e.IdTarefa).HasColumnName("Id_Tarefa");
            entity.Property(e => e.DataTarefa).HasColumnName("Data_Tarefa");
            entity.Property(e => e.HoraTarefa).HasColumnName("Hora_Tarefa");
            entity.Property(e => e.TipoTarefa)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Tipo_Tarefa");
            entity.Property(e => e.UsuarioId).HasColumnName("Usuario_Id");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Tarefas)
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("fk_Tarefa_Usuario_1");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuario__63C76BE2788B1FD5");

            entity.ToTable("Usuario");

            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Profissao)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Senha).HasMaxLength(250);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
