﻿// <auto-generated />
using _3DStore.Data.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace _3DStore.Data.EF.Migrations
{
    [DbContext(typeof(StoreDB))]
    [Migration("20180125101935_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("_3DStore.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int?>("StoreId");

                    b.HasKey("Id");

                    b.HasIndex("StoreId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("_3DStore.Entities.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Stores");
                });

            modelBuilder.Entity("_3DStore.Entities.Category", b =>
                {
                    b.HasOne("_3DStore.Entities.Store")
                        .WithMany("Categories")
                        .HasForeignKey("StoreId");
                });
#pragma warning restore 612, 618
        }
    }
}
