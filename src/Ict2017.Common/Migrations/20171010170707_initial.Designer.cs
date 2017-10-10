﻿// <auto-generated />
using Ict2017.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Ict2017.Common.Migrations
{
    [DbContext(typeof(IctDbContext))]
    [Migration("20171010170707_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ict2017.Common.Asset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Location");

                    b.Property<string>("Name");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.ToTable("Assets");
                });

            modelBuilder.Entity("Ict2017.Common.Presentation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AssetId");

                    b.Property<int>("ClapCount");

                    b.Property<int>("PresenterId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.HasIndex("PresenterId");

                    b.ToTable("Presentations");
                });

            modelBuilder.Entity("Ict2017.Common.Presenter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Forename");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.ToTable("Presenters");
                });

            modelBuilder.Entity("Ict2017.Common.Presentation", b =>
                {
                    b.HasOne("Ict2017.Common.Asset", "Asset")
                        .WithMany()
                        .HasForeignKey("AssetId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ict2017.Common.Presenter", "Presenter")
                        .WithMany("Presentations")
                        .HasForeignKey("PresenterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}