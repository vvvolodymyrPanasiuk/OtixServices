﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Money.EF;

namespace Money.EF.Migrations
{
    [DbContext(typeof(MoneyContext))]
    [Migration("20220710143601_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Money.Domain.Entities.AccountAggregate.DebtAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountCurrency")
                        .HasColumnType("int");

                    b.Property<double>("Balance")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("DebtAccounts");
                });

            modelBuilder.Entity("Money.Domain.Entities.AccountAggregate.RegularAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountCurrency")
                        .HasColumnType("int");

                    b.Property<double>("Balance")
                        .HasColumnType("float");

                    b.Property<double>("CreditLimit")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeRegularAccount")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("RegularAccounts");
                });

            modelBuilder.Entity("Money.Domain.Entities.AccountAggregate.SavingAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountCurrency")
                        .HasColumnType("int");

                    b.Property<double>("Balance")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("GoalSavingBalance")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("SavingAccounts");
                });

            modelBuilder.Entity("Money.Domain.Entities.CategoryAggregate.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Balance")
                        .HasColumnType("float");

                    b.Property<int>("CategoryCurrency")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeCategory")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Money.Domain.Entities.CategoryAggregate.Subcategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Subcategories");
                });

            modelBuilder.Entity("Money.Domain.Entities.TransactionAggregate.DebtAccountTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountProvideTransactionId")
                        .HasColumnType("int");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("DebtAccountId")
                        .HasColumnType("int");

                    b.Property<string>("Nodes")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DebtAccountId");

                    b.ToTable("DebtAccountTransactions");
                });

            modelBuilder.Entity("Money.Domain.Entities.TransactionAggregate.DefaultTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountProvideTransactionId")
                        .HasColumnType("int");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nodes")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("DefaultTransactions");
                });

            modelBuilder.Entity("Money.Domain.Entities.TransactionAggregate.RegularAccountTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountProvideTransactionId")
                        .HasColumnType("int");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nodes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RegularAccountId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RegularAccountId");

                    b.ToTable("RegularAccountTransactions");
                });

            modelBuilder.Entity("Money.Domain.Entities.TransactionAggregate.SavingAccountTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountProvideTransactionId")
                        .HasColumnType("int");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nodes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SavingAccountId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SavingAccountId");

                    b.ToTable("SavingAccountTransactions");
                });

            modelBuilder.Entity("Money.Domain.Entities.UserAggregate.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsEmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Money.Domain.Entities.AccountAggregate.DebtAccount", b =>
                {
                    b.HasOne("Money.Domain.Entities.UserAggregate.User", null)
                        .WithMany("DebtAccounts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Money.Domain.Entities.AccountAggregate.RegularAccount", b =>
                {
                    b.HasOne("Money.Domain.Entities.UserAggregate.User", null)
                        .WithMany("RegularAccounts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Money.Domain.Entities.AccountAggregate.SavingAccount", b =>
                {
                    b.HasOne("Money.Domain.Entities.UserAggregate.User", null)
                        .WithMany("SavingAccounts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Money.Domain.Entities.CategoryAggregate.Category", b =>
                {
                    b.HasOne("Money.Domain.Entities.UserAggregate.User", null)
                        .WithMany("Categories")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Money.Domain.Entities.CategoryAggregate.Subcategory", b =>
                {
                    b.HasOne("Money.Domain.Entities.CategoryAggregate.Category", null)
                        .WithMany("Subcategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Money.Domain.Entities.TransactionAggregate.DebtAccountTransaction", b =>
                {
                    b.HasOne("Money.Domain.Entities.AccountAggregate.DebtAccount", null)
                        .WithMany("DebtAccountTransactions")
                        .HasForeignKey("DebtAccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Money.Domain.Entities.TransactionAggregate.DefaultTransaction", b =>
                {
                    b.HasOne("Money.Domain.Entities.CategoryAggregate.Category", null)
                        .WithMany("DefaultTransactions")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Money.Domain.Entities.TransactionAggregate.RegularAccountTransaction", b =>
                {
                    b.HasOne("Money.Domain.Entities.AccountAggregate.RegularAccount", null)
                        .WithMany("RegularAccountTransactions")
                        .HasForeignKey("RegularAccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Money.Domain.Entities.TransactionAggregate.SavingAccountTransaction", b =>
                {
                    b.HasOne("Money.Domain.Entities.AccountAggregate.SavingAccount", null)
                        .WithMany("SavingAccountTransactions")
                        .HasForeignKey("SavingAccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Money.Domain.Entities.AccountAggregate.DebtAccount", b =>
                {
                    b.Navigation("DebtAccountTransactions");
                });

            modelBuilder.Entity("Money.Domain.Entities.AccountAggregate.RegularAccount", b =>
                {
                    b.Navigation("RegularAccountTransactions");
                });

            modelBuilder.Entity("Money.Domain.Entities.AccountAggregate.SavingAccount", b =>
                {
                    b.Navigation("SavingAccountTransactions");
                });

            modelBuilder.Entity("Money.Domain.Entities.CategoryAggregate.Category", b =>
                {
                    b.Navigation("DefaultTransactions");

                    b.Navigation("Subcategories");
                });

            modelBuilder.Entity("Money.Domain.Entities.UserAggregate.User", b =>
                {
                    b.Navigation("Categories");

                    b.Navigation("DebtAccounts");

                    b.Navigation("RegularAccounts");

                    b.Navigation("SavingAccounts");
                });
#pragma warning restore 612, 618
        }
    }
}