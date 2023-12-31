﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TFSSincronizador.Context;

#nullable disable

namespace TFSSincronizador.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231113161302_Mappings")]
    partial class Mappings
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TFSSincronizador.Models.MappingField", b =>
                {
                    b.Property<int>("MappingFieldId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MappingFieldId"), 1L, 1);

                    b.Property<string>("JiraField")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MappingFieldProfile")
                        .HasColumnType("int");

                    b.Property<string>("TFSField")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MappingFieldId");

                    b.HasIndex("MappingFieldProfile");

                    b.ToTable("MappingField");
                });

            modelBuilder.Entity("TFSSincronizador.Models.MappingStatus", b =>
                {
                    b.Property<int>("MappingStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MappingStatusId"), 1L, 1);

                    b.Property<string>("JiraField")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MappingStatusProfile")
                        .HasColumnType("int");

                    b.Property<string>("TFSField")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MappingStatusId");

                    b.HasIndex("MappingStatusProfile");

                    b.ToTable("MappingStatus");
                });

            modelBuilder.Entity("TFSSincronizador.Models.MappingType", b =>
                {
                    b.Property<int>("MappingTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MappingTypeId"), 1L, 1);

                    b.Property<string>("JiraField")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MappingTypeProfile")
                        .HasColumnType("int");

                    b.Property<string>("TFSField")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MappingTypeId");

                    b.HasIndex("MappingTypeProfile");

                    b.ToTable("MappingType");
                });

            modelBuilder.Entity("TFSSincronizador.Models.Profile", b =>
                {
                    b.Property<int>("ProfileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProfileId"), 1L, 1);

                    b.Property<string>("JProject")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("ProfileName")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SyncDirection")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("TFSCollection")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("TFSProject")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("ProfileId");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("TFSSincronizador.Models.MappingField", b =>
                {
                    b.HasOne("TFSSincronizador.Models.Profile", "Profile")
                        .WithMany("MappingFields")
                        .HasForeignKey("MappingFieldProfile")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("TFSSincronizador.Models.MappingStatus", b =>
                {
                    b.HasOne("TFSSincronizador.Models.Profile", "Profile")
                        .WithMany("MappingStatuses")
                        .HasForeignKey("MappingStatusProfile")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("TFSSincronizador.Models.MappingType", b =>
                {
                    b.HasOne("TFSSincronizador.Models.Profile", "Profile")
                        .WithMany("MappingTypes")
                        .HasForeignKey("MappingTypeProfile")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("TFSSincronizador.Models.Profile", b =>
                {
                    b.Navigation("MappingFields");

                    b.Navigation("MappingStatuses");

                    b.Navigation("MappingTypes");
                });
#pragma warning restore 612, 618
        }
    }
}
