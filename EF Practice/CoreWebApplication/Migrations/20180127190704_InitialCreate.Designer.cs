﻿// <auto-generated />
using CoreWebApplication.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace CoreWebApplication.Migrations
{
    [DbContext(typeof(UserDbContext))]
    [Migration("20180127190704_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreWebApplication.Address", b =>
                {
                    b.Property<string>("AddressId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("HouseOrFlatNumber");

                    b.Property<string>("PostalCode");

                    b.Property<string>("Street");

                    b.Property<string>("UserProfileForeignKey");

                    b.HasKey("AddressId");

                    b.HasIndex("UserProfileForeignKey")
                        .IsUnique()
                        .HasFilter("[UserProfileForeignKey] IS NOT NULL");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("CoreWebApplication.UserProfile", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AboutMe");

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("FirstName");

                    b.Property<string>("Interests");

                    b.Property<string>("LastName");

                    b.Property<string>("ProfilePhoto");

                    b.HasKey("Id");

                    b.ToTable("UserProfiles");
                });

            modelBuilder.Entity("CoreWebApplication.Address", b =>
                {
                    b.HasOne("CoreWebApplication.UserProfile", "UserProfile")
                        .WithOne("Address")
                        .HasForeignKey("CoreWebApplication.Address", "UserProfileForeignKey");
                });
#pragma warning restore 612, 618
        }
    }
}
