using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Database_Manager.DbContext;

public partial class ZooContext : DbContext
{
    public ZooContext()
    {

    }

    public DbSet<Gady> Gadies { get; set; }

    public virtual DbSet<Plazy> Plazies { get; set; }

    public virtual DbSet<Ptaki> Ptakis { get; set; }

    public virtual DbSet<Ryby> Rybies { get; set; }

    public virtual DbSet<Ssaki> Ssakis { get; set; }

    public virtual DbSet<Zwierzetum> Zwierzeta { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ZOO;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Gady>(entity =>
        {
            entity.HasKey(e => e.ZwierzeId).HasName("PK__GADY__149FF718233FD438");

            entity.ToTable("GADY");

            entity.Property(e => e.ZwierzeId)
                .ValueGeneratedNever()
                .HasColumnName("zwierze_id");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nazwa");
            entity.Property(e => e.SposobOdzywiania)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sposob_odzywiania");

            entity.HasOne(d => d.Zwierze).WithOne(p => p.Gady)
                .HasForeignKey<Gady>(d => d.ZwierzeId)
                .HasConstraintName("FK__GADY__zwierze_id__31EC6D26");
        });

        modelBuilder.Entity<Plazy>(entity =>
        {
            entity.HasKey(e => e.ZwierzeId).HasName("PK__PLAZY__149FF718169DD6E8");

            entity.ToTable("PLAZY");

            entity.Property(e => e.ZwierzeId)
                .ValueGeneratedNever()
                .HasColumnName("zwierze_id");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nazwa");
            entity.Property(e => e.SposobOdzywiania)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sposob_odzywiania");

            entity.HasOne(d => d.Zwierze).WithOne(p => p.Plazy)
                .HasForeignKey<Plazy>(d => d.ZwierzeId)
                .HasConstraintName("FK__PLAZY__zwierze_i__2F10007B");
        });

        modelBuilder.Entity<Ptaki>(entity =>
        {
            entity.HasKey(e => e.ZwierzeId).HasName("PK__PTAKI__149FF718E4334C38");

            entity.ToTable("PTAKI");

            entity.Property(e => e.ZwierzeId)
                .ValueGeneratedNever()
                .HasColumnName("zwierze_id");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nazwa");
            entity.Property(e => e.SposobOdzywiania)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sposob_odzywiania");

            entity.HasOne(d => d.Zwierze).WithOne(p => p.Ptaki)
                .HasForeignKey<Ptaki>(d => d.ZwierzeId)
                .HasConstraintName("FK__PTAKI__zwierze_i__2C3393D0");
        });

        modelBuilder.Entity<Ryby>(entity =>
        {
            entity.HasKey(e => e.ZwierzeId).HasName("PK__RYBY__149FF718D0AAB623");

            entity.ToTable("RYBY");

            entity.Property(e => e.ZwierzeId)
                .ValueGeneratedNever()
                .HasColumnName("zwierze_id");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nazwa");
            entity.Property(e => e.SposobOdzywiania)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sposob_odzywiania");

            entity.HasOne(d => d.Zwierze).WithOne(p => p.Ryby)
                .HasForeignKey<Ryby>(d => d.ZwierzeId)
                .HasConstraintName("FK__RYBY__zwierze_id__29572725");
        });

        modelBuilder.Entity<Ssaki>(entity =>
        {
            entity.HasKey(e => e.ZwierzeId).HasName("PK__SSAKI__149FF718900757F1");

            entity.ToTable("SSAKI");

            entity.Property(e => e.ZwierzeId)
                .ValueGeneratedNever()
                .HasColumnName("zwierze_id");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nazwa");
            entity.Property(e => e.SposobOdzywiania)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sposob_odzywiania");

            entity.HasOne(d => d.Zwierze).WithOne(p => p.Ssaki)
                .HasForeignKey<Ssaki>(d => d.ZwierzeId)
                .HasConstraintName("FK__SSAKI__zwierze_i__267ABA7A");
        });

        modelBuilder.Entity<Zwierzetum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ZWIERZET__3213E83FA7C79269");

            entity.ToTable("ZWIERZETA");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nazwa");
            entity.Property(e => e.SposobOdzywiania)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sposob_odzywiania");
            entity.Property(e => e.Typ)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("typ");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
