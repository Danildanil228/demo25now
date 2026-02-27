using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace demo25now.Models;

public partial class Demo25nowContext : DbContext
{
    public Demo25nowContext()
    {
    }

    public Demo25nowContext(DbContextOptions<Demo25nowContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Manufacture> Manufactures { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Productsale> Productsales { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-U7H675S;Initial Catalog=demo25now;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Manufacture>(entity =>
        {
            entity.HasKey(e => e.ManufactureName).HasName("PK__manufact__00DD03CFBF69C4DD");

            entity.ToTable("manufacture");

            entity.Property(e => e.ManufactureName).HasMaxLength(100);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductName).HasName("PK__product__DD5A978BE8A91326");

            entity.ToTable("product");

            entity.Property(e => e.ProductName).HasMaxLength(100);
            entity.Property(e => e.Cost).HasColumnType("money");
            entity.Property(e => e.MainImagePath).HasMaxLength(100);
            entity.Property(e => e.ManufactureName).HasMaxLength(100);

            entity.HasOne(d => d.ManufactureNameNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.ManufactureName)
                .HasConstraintName("FK_product_manufacture");
        });

        modelBuilder.Entity<Productsale>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__products__3214EC272C3736E4");

            entity.ToTable("productsale");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ProductName).HasMaxLength(100);
            entity.Property(e => e.SaleDate).HasColumnType("datetime");

            entity.HasOne(d => d.ProductNameNavigation).WithMany(p => p.Productsales)
                .HasForeignKey(d => d.ProductName)
                .HasConstraintName("FK_product_productsale");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("users");

            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .HasColumnName("login");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
