﻿// <auto-generated />
using System;
using InsanKaynaklari.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InsanKaynaklari.DataAccess.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InsanKaynaklari.Entities.Concrete.AdvancePayment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DateOfIssue")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("PersonelID")
                        .HasColumnType("int");

                    b.Property<int>("TaskStatus")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PersonelID");

                    b.ToTable("AdvancePayments");
                });

            modelBuilder.Entity("InsanKaynaklari.Entities.Concrete.Company", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Activation")
                        .HasColumnType("bit");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("CountOfPersonel")
                        .HasColumnType("int");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("InsanKaynaklari.Entities.Concrete.Debit", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfIssue")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime?>("DateOfReturn")
                        .HasColumnType("datetime2");

                    b.Property<string>("DebitCode")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DebitName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("PersonelID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PersonelID");

                    b.ToTable("Debits");
                });

            modelBuilder.Entity("InsanKaynaklari.Entities.Concrete.Event", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("End")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.Property<string>("TextColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("InsanKaynaklari.Entities.Concrete.Expense", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("CheckDocument")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ExpenseTypeID")
                        .HasColumnType("int");

                    b.Property<string>("Explanation")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("PersonelID")
                        .HasColumnType("int");

                    b.Property<int>("TaskStatus")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ExpenseTypeID");

                    b.HasIndex("PersonelID");

                    b.ToTable("Expenses");
                });

            modelBuilder.Entity("InsanKaynaklari.Entities.Concrete.ExpenseType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ExpenseTypeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("ExpenseTypes");
                });

            modelBuilder.Entity("InsanKaynaklari.Entities.Concrete.Leave", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("EndLeaveDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("LeaveDocument")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("LeaveTypeID")
                        .HasColumnType("int");

                    b.Property<int>("PersonelID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartLeaveDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("TaskStatus")
                        .HasColumnType("int");

                    b.Property<int>("TotalDaysOff")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("LeaveTypeID");

                    b.HasIndex("PersonelID");

                    b.ToTable("Leaves");
                });

            modelBuilder.Entity("InsanKaynaklari.Entities.Concrete.LeaveType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("LeaveTypes");
                });

            modelBuilder.Entity("InsanKaynaklari.Entities.Concrete.Personel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Activation")
                        .HasColumnType("bit");

                    b.Property<int>("CompanyID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CompanyID");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Personels");
                });

            modelBuilder.Entity("InsanKaynaklari.Entities.Concrete.PersonelDetail", b =>
                {
                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Birthday")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("StartDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Wage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("WorkStyle")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ID");

                    b.ToTable("PersonelDetails");
                });

            modelBuilder.Entity("InsanKaynaklari.Entities.Concrete.PersonelEvent", b =>
                {
                    b.Property<int>("EventID")
                        .HasColumnType("int");

                    b.Property<int>("PersonelID")
                        .HasColumnType("int");

                    b.HasKey("EventID", "PersonelID");

                    b.HasIndex("PersonelID");

                    b.ToTable("PersonelEvent");
                });

            modelBuilder.Entity("InsanKaynaklari.Entities.Concrete.Shift", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("EndOfShift")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("PersonelID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ShiftDay")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime>("StartOfShift")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.HasKey("ID");

                    b.HasIndex("PersonelID");

                    b.ToTable("Shifts");
                });

            modelBuilder.Entity("InsanKaynaklari.Entities.Concrete.AdvancePayment", b =>
                {
                    b.HasOne("InsanKaynaklari.Entities.Concrete.Personel", "Personel")
                        .WithMany("AdvancePayments")
                        .HasForeignKey("PersonelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("InsanKaynaklari.Entities.Concrete.Debit", b =>
                {
                    b.HasOne("InsanKaynaklari.Entities.Concrete.Personel", "Personel")
                        .WithMany("Debits")
                        .HasForeignKey("PersonelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("InsanKaynaklari.Entities.Concrete.Expense", b =>
                {
                    b.HasOne("InsanKaynaklari.Entities.Concrete.ExpenseType", "ExpenseType")
                        .WithMany("Expenses")
                        .HasForeignKey("ExpenseTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InsanKaynaklari.Entities.Concrete.Personel", "Personel")
                        .WithMany("Expenses")
                        .HasForeignKey("PersonelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExpenseType");

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("InsanKaynaklari.Entities.Concrete.Leave", b =>
                {
                    b.HasOne("InsanKaynaklari.Entities.Concrete.LeaveType", "LeaveType")
                        .WithMany("Leaves")
                        .HasForeignKey("LeaveTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InsanKaynaklari.Entities.Concrete.Personel", "Personel")
                        .WithMany("Leaves")
                        .HasForeignKey("PersonelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LeaveType");

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("InsanKaynaklari.Entities.Concrete.Personel", b =>
                {
                    b.HasOne("InsanKaynaklari.Entities.Concrete.Company", "Company")
                        .WithMany("Personels")
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("InsanKaynaklari.Entities.Concrete.PersonelDetail", b =>
                {
                    b.HasOne("InsanKaynaklari.Entities.Concrete.Personel", "Personel")
                        .WithOne("PersonelDetail")
                        .HasForeignKey("InsanKaynaklari.Entities.Concrete.PersonelDetail", "ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("InsanKaynaklari.Entities.Concrete.PersonelEvent", b =>
                {
                    b.HasOne("InsanKaynaklari.Entities.Concrete.Event", "Event")
                        .WithMany("PersonelEvents")
                        .HasForeignKey("EventID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InsanKaynaklari.Entities.Concrete.Personel", "Personel")
                        .WithMany("PersonelEvents")
                        .HasForeignKey("PersonelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("InsanKaynaklari.Entities.Concrete.Shift", b =>
                {
                    b.HasOne("InsanKaynaklari.Entities.Concrete.Personel", "Personel")
                        .WithMany("Shifts")
                        .HasForeignKey("PersonelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("InsanKaynaklari.Entities.Concrete.Company", b =>
                {
                    b.Navigation("Personels");
                });

            modelBuilder.Entity("InsanKaynaklari.Entities.Concrete.Event", b =>
                {
                    b.Navigation("PersonelEvents");
                });

            modelBuilder.Entity("InsanKaynaklari.Entities.Concrete.ExpenseType", b =>
                {
                    b.Navigation("Expenses");
                });

            modelBuilder.Entity("InsanKaynaklari.Entities.Concrete.LeaveType", b =>
                {
                    b.Navigation("Leaves");
                });

            modelBuilder.Entity("InsanKaynaklari.Entities.Concrete.Personel", b =>
                {
                    b.Navigation("AdvancePayments");

                    b.Navigation("Debits");

                    b.Navigation("Expenses");

                    b.Navigation("Leaves");

                    b.Navigation("PersonelDetail");

                    b.Navigation("PersonelEvents");

                    b.Navigation("Shifts");
                });
#pragma warning restore 612, 618
        }
    }
}
