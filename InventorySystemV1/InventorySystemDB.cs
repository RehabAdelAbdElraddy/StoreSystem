namespace InventorySystemV1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class InventorySystemDB : DbContext
    {
        public InventorySystemDB()
            : base("name=InventorySystemDB")
        {
        }

        public virtual DbSet<Customer_Suppliers> Customer_Suppliers { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<MeasurmentUnit> MeasurmentUnits { get; set; }
        public virtual DbSet<Permission_Products> Permission_Products { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Transfere> Transferes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer_Suppliers>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Customer_Suppliers>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Customer_Suppliers>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Customer_Suppliers>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<Customer_Suppliers>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Customer_Suppliers>()
                .Property(e => e.Website)
                .IsUnicode(false);

            modelBuilder.Entity<Customer_Suppliers>()
                .HasMany(e => e.Permission_Products)
                .WithOptional(e => e.Customer_Suppliers)
                .HasForeignKey(e => e.Supplier_ID);

            modelBuilder.Entity<Customer_Suppliers>()
               .HasMany(e => e.Transferes)
               .WithOptional(e => e.Customer_Suppliers)
               .HasForeignKey(e => e.supplierid);

            modelBuilder.Entity<Inventory>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Inventory>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Inventory>()
                .Property(e => e.Admin)
                .IsUnicode(false);

            modelBuilder.Entity<Inventory>()
                .HasMany(e => e.Permissions)
                .WithOptional(e => e.Inventory)
                .HasForeignKey(e => e.Inventory_ID);
            modelBuilder.Entity<Inventory>()
               .HasMany(e => e.Transferes)
               .WithOptional(e => e.Inventory)
               .HasForeignKey(e => e.FromInventory);

            modelBuilder.Entity<Inventory>()
                .HasMany(e => e.Transferes1)
                .WithOptional(e => e.Inventory1)
                .HasForeignKey(e => e.ToInventory);

            modelBuilder.Entity<MeasurmentUnit>()
                .Property(e => e.Unit_Name)
                .IsUnicode(false);

            modelBuilder.Entity<MeasurmentUnit>()
                .HasMany(e => e.Products)
                .WithMany(e => e.MeasurmentUnits)
                .Map(m => m.ToTable("Product_measurment").MapLeftKey("Unit_ID").MapRightKey("P_Code"));

            modelBuilder.Entity<Permission_Products>()
                .Property(e => e.P_Code)
                .IsUnicode(false);

            modelBuilder.Entity<Permission>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Permission>()
                .HasMany(e => e.Permission_Products)
                .WithRequired(e => e.Permission)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.P_Code)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Permission_Products)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transfere>()
               .Property(e => e.P_Code)
               .IsUnicode(false);

            modelBuilder.Entity<Transfere>()
                .Property(e => e.TransfereDate)
                .IsUnicode(false);

            modelBuilder.Entity<Transfere>()
                .Property(e => e.PDate)
                .IsUnicode(false);

            modelBuilder.Entity<Transfere>()
                .Property(e => e.EDate)
                .IsUnicode(false);
        }
    }
}
