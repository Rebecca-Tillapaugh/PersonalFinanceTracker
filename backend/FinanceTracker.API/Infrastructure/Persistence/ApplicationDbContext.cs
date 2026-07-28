using FinanceTracker.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinanceTracker.API.Infrastructure.Persistence;

// This is the main Entity Framework Core database context for the application.
// It acts as the bridge between the domain entities and the relational database.
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // Each DbSet represents a table in the database.
    // These are the core entities for the finance tracker domain.
    public DbSet<User> Users => Set<User>();
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<Transaction> Transactions => Set<Transaction>();
    public DbSet<Budget> Budgets => Set<Budget>();
    public DbSet<BudgetCategory> BudgetCategories => Set<BudgetCategory>();

    // This method configures the schema, constraints, and relationships for the database.
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // User configuration:
        // - Email is required and must be unique
        // - Basic validation rules are applied for important fields
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.FullName).IsRequired().HasMaxLength(200);
            entity.Property(e => e.Email).IsRequired().HasMaxLength(256);
            entity.Property(e => e.PasswordHash).IsRequired();
            entity.Property(e => e.Currency).HasMaxLength(10);
            entity.HasIndex(e => e.Email).IsUnique();
        });

        // Category configuration:
        // - A category belongs to one user
        // - Deleting a user will also remove their categories
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
            entity.Property(e => e.Type).IsRequired().HasMaxLength(20);
            entity.HasOne(e => e.User)
                .WithMany(e => e.Categories)
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        // Transaction configuration:
        // - Transactions belong to a user and a category
        // - A transaction is stored with a decimal amount and a date
        // - Removing a category is restricted to avoid orphaned financial records
        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Description).IsRequired().HasMaxLength(500);
            entity.Property(e => e.Amount).HasColumnType("decimal(18,2)");
            entity.Property(e => e.Type).IsRequired().HasMaxLength(20);
            entity.HasOne(e => e.User)
                .WithMany(e => e.Transactions)
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            entity.HasOne(e => e.Category)
                .WithMany(e => e.Transactions)
                .HasForeignKey(e => e.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        // Budget configuration:
        // - A budget belongs to one user
        // - Budget limits are stored as decimal values for money precision
        modelBuilder.Entity<Budget>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired().HasMaxLength(150);
            entity.Property(e => e.Currency).IsRequired().HasMaxLength(10);
            entity.Property(e => e.LimitAmount).HasColumnType("decimal(18,2)");
            entity.HasOne(e => e.User)
                .WithMany(e => e.Budgets)
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        // BudgetCategory configuration:
        // - This is the join table that links budgets to categories
        // - It allows a budget to cover multiple categories with allocated amounts
        modelBuilder.Entity<BudgetCategory>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.AllocatedAmount).HasColumnType("decimal(18,2)");
            entity.HasOne(e => e.Budget)
                .WithMany(e => e.BudgetCategories)
                .HasForeignKey(e => e.BudgetId)
                .OnDelete(DeleteBehavior.Cascade);
            entity.HasOne(e => e.Category)
                .WithMany(e => e.BudgetCategories)
                .HasForeignKey(e => e.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);
        });
    }
}
