﻿// <auto-generated />
using GamerServer.Models.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace GamerServer.Migrations
{
    [DbContext(typeof(GamerAiContext))]
    [Migration("20181016195515_FixedHappinessModel")]
    partial class FixedHappinessModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("GamerServer.Models.Db.Happiness", b =>
                {
                    b.Property<int>("HappinessId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Level");

                    b.HasKey("HappinessId");

                    b.ToTable("Happinesses");
                });
#pragma warning restore 612, 618
        }
    }
}
