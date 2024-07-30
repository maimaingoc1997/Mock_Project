﻿// <auto-generated />
using ContactManagementAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ContactManagementAPI.Migrations
{
    [DbContext(typeof(ContactDbContext))]
    partial class ContactDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("ContactManagementAPI.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BestContactMethod")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ContactType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("JobRole")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("KnowAs")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ManagerNameId")
                        .HasColumnType("int");

                    b.Property<string>("MobilePhone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("OfficePhone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("StHomePhone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Workbase")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ManagerNameId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("ContactManagementAPI.Models.ManagerName", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("ManagerNames");
                });

            modelBuilder.Entity("ContactManagementAPI.Models.Contact", b =>
                {
                    b.HasOne("ContactManagementAPI.Models.ManagerName", "ManagerName")
                        .WithMany("Contacts")
                        .HasForeignKey("ManagerNameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ManagerName");
                });

            modelBuilder.Entity("ContactManagementAPI.Models.ManagerName", b =>
                {
                    b.Navigation("Contacts");
                });
#pragma warning restore 612, 618
        }
    }
}
