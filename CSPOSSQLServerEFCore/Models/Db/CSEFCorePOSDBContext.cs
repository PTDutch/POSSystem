using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CSPOSSQLServerEFCore.Models.Db
{
    public partial class CSEFCorePOSDBContext : DbContext
    {
        public CSEFCorePOSDBContext()
        {
        }

        public CSEFCorePOSDBContext(DbContextOptions<CSEFCorePOSDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Sale> Sales { get; set; } = null!;
        public virtual DbSet<SaleDetail> SaleDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(System.Configuration.ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasIndex(e => new { e.ProductId, e.ProductBarcode, e.ProductName, e.CategoryName, e.UnitName, e.Note }, "IX_Search");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.CategoryName).HasMaxLength(20);

                entity.Property(e => e.CostPrice).HasColumnType("money");

                entity.Property(e => e.Note).HasMaxLength(100);

                entity.Property(e => e.ProductBarcode).HasMaxLength(15);

                entity.Property(e => e.ProductName).HasMaxLength(50);

                entity.Property(e => e.SellingPrice).HasColumnType("money");

                entity.Property(e => e.UnitName).HasMaxLength(20);
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.HasKey(e => new { e.AutoId, e.SaleId });

                entity.HasIndex(e => e.SaleId, "IX_SalesID")
                    .IsUnique();

                entity.Property(e => e.AutoId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("AutoID");

                entity.Property(e => e.SaleId)
                    .HasMaxLength(20)
                    .HasColumnName("SaleID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.SaleChange).HasColumnType("money");

                entity.Property(e => e.SaleDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SaleReceive).HasColumnType("money");

                entity.Property(e => e.SaleTotal).HasColumnType("money");
            });

            modelBuilder.Entity<SaleDetail>(entity =>
            {
                entity.HasKey(e => e.AutoId);

                entity.Property(e => e.AutoId).HasColumnName("AutoID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductName).HasMaxLength(50);

                entity.Property(e => e.ProductPrice).HasColumnType("money");

                entity.Property(e => e.SaleId)
                    .HasMaxLength(20)
                    .HasColumnName("SaleID");

                entity.Property(e => e.Subtotal).HasColumnType("money");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.SaleDetails)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_SaleDetails_Products");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.SaleDetails)
                    .HasPrincipalKey(p => p.SaleId)
                    .HasForeignKey(d => d.SaleId)
                    .HasConstraintName("FK_SaleDetails_Sales");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
