﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestProject.Context;

namespace TestProject.Migrations
{
    [DbContext(typeof(TestDbContext))]
    [Migration("20200204093036_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TestProject.Entities.CustomerBase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("CustomerBase");
                });

            modelBuilder.Entity("TestProject.Entities.BigCustomer", b =>
                {
                    b.HasBaseType("TestProject.Entities.CustomerBase");

                    b.ToTable("Customers");

                    b.HasDiscriminator().HasValue("BigCustomer");
                });

            modelBuilder.Entity("TestProject.Entities.ProjectCustomer", b =>
                {
                    b.HasBaseType("TestProject.Entities.CustomerBase");

                    b.ToTable("Customers");

                    b.HasDiscriminator().HasValue("ProjectCustomer");
                });

            modelBuilder.Entity("TestProject.Entities.SmallCustomer", b =>
                {
                    b.HasBaseType("TestProject.Entities.CustomerBase");

                    b.ToTable("Customers");

                    b.HasDiscriminator().HasValue("SmallCustomer");
                });

            modelBuilder.Entity("TestProject.Entities.BigCustomer", b =>
                {
                    b.OwnsOne("TestProject.Entities.ContactInfo", "Info", b1 =>
                        {
                            b1.Property<int>("BigCustomerId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Email")
                                .IsRequired();

                            b1.Property<string>("FirstName")
                                .IsRequired();

                            b1.Property<string>("LastName")
                                .IsRequired();

                            b1.HasKey("BigCustomerId");

                            b1.ToTable("Customers");

                            b1.HasOne("TestProject.Entities.BigCustomer")
                                .WithOne("Info")
                                .HasForeignKey("TestProject.Entities.ContactInfo", "BigCustomerId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });

            modelBuilder.Entity("TestProject.Entities.ProjectCustomer", b =>
                {
                    b.OwnsOne("TestProject.Entities.ContactInfo", "Info", b1 =>
                        {
                            b1.Property<int>("ProjectCustomerId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Email")
                                .IsRequired()
                                .HasColumnName("ContactInfo_Info_Email");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasColumnName("ContactInfo_Info_FirstName");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasColumnName("ContactInfo_Info_LastName");

                            b1.HasKey("ProjectCustomerId");

                            b1.ToTable("Customers");

                            b1.HasOne("TestProject.Entities.ProjectCustomer")
                                .WithOne("Info")
                                .HasForeignKey("TestProject.Entities.ContactInfo", "ProjectCustomerId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });

            modelBuilder.Entity("TestProject.Entities.SmallCustomer", b =>
                {
                    b.OwnsOne("TestProject.Entities.ContactInfo", "Info", b1 =>
                        {
                            b1.Property<int>("SmallCustomerId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Email")
                                .IsRequired()
                                .HasColumnName("ContactInfo_Info_Email1");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasColumnName("ContactInfo_Info_FirstName1");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasColumnName("ContactInfo_Info_LastName1");

                            b1.HasKey("SmallCustomerId");

                            b1.ToTable("Customers");

                            b1.HasOne("TestProject.Entities.SmallCustomer")
                                .WithOne("Info")
                                .HasForeignKey("TestProject.Entities.ContactInfo", "SmallCustomerId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
