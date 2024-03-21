﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using School_Managment.DBcontext;

#nullable disable

namespace School_Managment.Migrations
{
    [DbContext(typeof(ApplicationDBcontext))]
    [Migration("20240321110237_database")]
    partial class database
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("School_Managment.Model.Student", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<int>("cgpa")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numofClass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("performance")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("roll")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("student");
                });
#pragma warning restore 612, 618
        }
    }
}