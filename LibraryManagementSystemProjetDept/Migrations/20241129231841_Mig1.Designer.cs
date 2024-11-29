﻿// <auto-generated />
using System;
using LibraryManagementSystemProjetDept.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibraryManagementSystemProjetDept.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20241129231841_Mig1")]
    partial class Mig1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LibraryManagementSystemProjetDept.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<DateTime>("PublishedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("BookId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            Author = "Andrew Hunt and David Thomas",
                            ISBN = "978-0201616224",
                            IsAvailable = true,
                            PublishedDate = new DateTime(2021, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Pragmatic Programmer"
                        },
                        new
                        {
                            BookId = 2,
                            Author = "Robert C. Martin",
                            ISBN = "978-0132350884",
                            IsAvailable = true,
                            PublishedDate = new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Design Pattern using C#"
                        },
                        new
                        {
                            BookId = 3,
                            Author = "Pranaya Kumar Rout",
                            ISBN = "978-0451616235",
                            IsAvailable = true,
                            PublishedDate = new DateTime(2022, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Mastering ASP.NET Core"
                        },
                        new
                        {
                            BookId = 4,
                            Author = "Rakesh Kumat",
                            ISBN = "978-4562350123",
                            IsAvailable = true,
                            PublishedDate = new DateTime(2020, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "SQL Server with DBA"
                        });
                });

            modelBuilder.Entity("LibraryManagementSystemProjetDept.Models.BorrowRecord", b =>
                {
                    b.Property<int>("BorrowRecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BorrowRecordId"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<DateTime>("BorrowDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BorrowerEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BorrowerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BorrowRecordId");

                    b.HasIndex("BookId");

                    b.ToTable("BorrowRecords");
                });

            modelBuilder.Entity("LibraryManagementSystemProjetDept.Models.BorrowRecord", b =>
                {
                    b.HasOne("LibraryManagementSystemProjetDept.Models.Book", "Book")
                        .WithMany("BorrowRecords")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("LibraryManagementSystemProjetDept.Models.Book", b =>
                {
                    b.Navigation("BorrowRecords");
                });
#pragma warning restore 612, 618
        }
    }
}
