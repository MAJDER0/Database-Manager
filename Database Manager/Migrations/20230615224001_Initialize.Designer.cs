﻿// <auto-generated />
using Database_Manager;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Database_Manager.Migrations
{
    [DbContext(typeof(ZooContext))]
    [Migration("20230615224001_Initialize")]
    partial class Initialize
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Database_Manager.Models.Gady", b =>
                {
                    b.Property<int>("ZwierzeId")
                        .HasColumnType("int")
                        .HasColumnName("zwierze_id");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nazwa");

                    b.Property<string>("SposobOdzywiania")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("sposob_odzywiania");

                    b.HasKey("ZwierzeId")
                        .HasName("PK__GADY__149FF718233FD438");

                    b.ToTable("GADY", (string)null);
                });

            modelBuilder.Entity("Database_Manager.Models.Plazy", b =>
                {
                    b.Property<int>("ZwierzeId")
                        .HasColumnType("int")
                        .HasColumnName("zwierze_id");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nazwa");

                    b.Property<string>("SposobOdzywiania")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("sposob_odzywiania");

                    b.HasKey("ZwierzeId")
                        .HasName("PK__PLAZY__149FF718169DD6E8");

                    b.ToTable("PLAZY", (string)null);
                });

            modelBuilder.Entity("Database_Manager.Models.Ptaki", b =>
                {
                    b.Property<int>("ZwierzeId")
                        .HasColumnType("int")
                        .HasColumnName("zwierze_id");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nazwa");

                    b.Property<string>("SposobOdzywiania")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("sposob_odzywiania");

                    b.HasKey("ZwierzeId")
                        .HasName("PK__PTAKI__149FF718E4334C38");

                    b.ToTable("PTAKI", (string)null);
                });

            modelBuilder.Entity("Database_Manager.Models.Ryby", b =>
                {
                    b.Property<int>("ZwierzeId")
                        .HasColumnType("int")
                        .HasColumnName("zwierze_id");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nazwa");

                    b.Property<string>("SposobOdzywiania")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("sposob_odzywiania");

                    b.HasKey("ZwierzeId")
                        .HasName("PK__RYBY__149FF718D0AAB623");

                    b.ToTable("RYBY", (string)null);
                });

            modelBuilder.Entity("Database_Manager.Models.Ssaki", b =>
                {
                    b.Property<int>("ZwierzeId")
                        .HasColumnType("int")
                        .HasColumnName("zwierze_id");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nazwa");

                    b.Property<string>("SposobOdzywiania")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("sposob_odzywiania");

                    b.HasKey("ZwierzeId")
                        .HasName("PK__SSAKI__149FF718900757F1");

                    b.ToTable("SSAKI", (string)null);
                });

            modelBuilder.Entity("Database_Manager.Models.Zwierzetum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nazwa");

                    b.Property<string>("SposobOdzywiania")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("sposob_odzywiania");

                    b.Property<string>("Typ")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("typ");

                    b.HasKey("Id")
                        .HasName("PK__ZWIERZET__3213E83FA7C79269");

                    b.ToTable("ZWIERZETA", (string)null);
                });

            modelBuilder.Entity("Database_Manager.Models.Gady", b =>
                {
                    b.HasOne("Database_Manager.Models.Zwierzetum", "Zwierze")
                        .WithOne("Gady")
                        .HasForeignKey("Database_Manager.Models.Gady", "ZwierzeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__GADY__zwierze_id__31EC6D26");

                    b.Navigation("Zwierze");
                });

            modelBuilder.Entity("Database_Manager.Models.Plazy", b =>
                {
                    b.HasOne("Database_Manager.Models.Zwierzetum", "Zwierze")
                        .WithOne("Plazy")
                        .HasForeignKey("Database_Manager.Models.Plazy", "ZwierzeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__PLAZY__zwierze_i__2F10007B");

                    b.Navigation("Zwierze");
                });

            modelBuilder.Entity("Database_Manager.Models.Ptaki", b =>
                {
                    b.HasOne("Database_Manager.Models.Zwierzetum", "Zwierze")
                        .WithOne("Ptaki")
                        .HasForeignKey("Database_Manager.Models.Ptaki", "ZwierzeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__PTAKI__zwierze_i__2C3393D0");

                    b.Navigation("Zwierze");
                });

            modelBuilder.Entity("Database_Manager.Models.Ryby", b =>
                {
                    b.HasOne("Database_Manager.Models.Zwierzetum", "Zwierze")
                        .WithOne("Ryby")
                        .HasForeignKey("Database_Manager.Models.Ryby", "ZwierzeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__RYBY__zwierze_id__29572725");

                    b.Navigation("Zwierze");
                });

            modelBuilder.Entity("Database_Manager.Models.Ssaki", b =>
                {
                    b.HasOne("Database_Manager.Models.Zwierzetum", "Zwierze")
                        .WithOne("Ssaki")
                        .HasForeignKey("Database_Manager.Models.Ssaki", "ZwierzeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__SSAKI__zwierze_i__267ABA7A");

                    b.Navigation("Zwierze");
                });

            modelBuilder.Entity("Database_Manager.Models.Zwierzetum", b =>
                {
                    b.Navigation("Gady");

                    b.Navigation("Plazy");

                    b.Navigation("Ptaki");

                    b.Navigation("Ryby");

                    b.Navigation("Ssaki");
                });
#pragma warning restore 612, 618
        }
    }
}