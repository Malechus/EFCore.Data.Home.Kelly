using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Configuration;

namespace EntityFrameworkCore.Data.Home.Kelly
{
    public partial class Data_Home_KellyContext : DbContext
    {
        public Data_Home_KellyContext()
        {
        }

        public Data_Home_KellyContext(DbContextOptions<Data_Home_KellyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Item> Items { get; set; } = null!;
        public virtual DbSet<Metadatum> Metadata { get; set; } = null!;
        public virtual DbSet<Review> Reviews { get; set; } = null!;
        public virtual DbSet<Store> Stores { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(ConfigurationManager.ConnectionStrings["PGConnection"].ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>(entity =>
            {
                entity.ToTable("item", "Inventory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Alias)
                    .HasMaxLength(255)
                    .HasColumnName("alias");

                entity.Property(e => e.Asin)
                    .HasMaxLength(100)
                    .HasColumnName("asin");

                entity.Property(e => e.Barcode).HasColumnName("barcode");

                entity.Property(e => e.Brand)
                    .HasMaxLength(100)
                    .HasColumnName("brand");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .HasColumnName("category");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.Error).HasColumnName("error");

                entity.Property(e => e.Images).HasColumnName("images");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .HasColumnName("location");

                entity.Property(e => e.Manufacturer)
                    .HasMaxLength(100)
                    .HasColumnName("manufacturer");

                entity.Property(e => e.Metadata).HasColumnName("metadata");

                entity.Property(e => e.Mpn).HasColumnName("mpn");

                entity.Property(e => e.Msrp).HasColumnName("msrp");

                entity.Property(e => e.Reviews).HasColumnName("reviews");

                entity.Property(e => e.Stores)
                    .HasColumnType("json")
                    .HasColumnName("stores");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<Metadatum>(entity =>
            {
                entity.ToTable("metadata", "Inventory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Age)
                    .HasMaxLength(50)
                    .HasColumnName("age");

                entity.Property(e => e.Author)
                    .HasMaxLength(50)
                    .HasColumnName("author");

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .HasColumnName("color");

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .HasColumnName("gender");

                entity.Property(e => e.Genre)
                    .HasMaxLength(50)
                    .HasColumnName("genre");

                entity.Property(e => e.Item).HasColumnName("item");

                entity.Property(e => e.Length)
                    .HasMaxLength(50)
                    .HasColumnName("length");

                entity.Property(e => e.Publisher)
                    .HasMaxLength(100)
                    .HasColumnName("publisher");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Releasedate).HasColumnName("releasedate");

                entity.Property(e => e.Size)
                    .HasMaxLength(50)
                    .HasColumnName("size");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .HasColumnName("unit");

                entity.Property(e => e.Weight)
                    .HasMaxLength(50)
                    .HasColumnName("weight");

                entity.Property(e => e.Width)
                    .HasMaxLength(50)
                    .HasColumnName("width");
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.ToTable("review", "Inventory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Item).HasColumnName("item");

                entity.Property(e => e.Thumbsdown).HasColumnName("thumbsdown");

                entity.Property(e => e.Thumbsup).HasColumnName("thumbsup");
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.ToTable("store", "Inventory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Item).HasColumnName("item");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("url");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
