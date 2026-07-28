namespace FinanceTracker.API.Domain.Entities;

// Represents a category for transactions and budgets, allowing users to organize their financial data.
public class Category : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string Type { get; set; } = "Expense";

    public string? Color { get; set; }

    public bool IsDefault { get; set; }

    public Guid UserId { get; set; }

    public User User { get; set; } = null!;

    public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

    public ICollection<BudgetCategory> BudgetCategories { get; set; } = new List<BudgetCategory>();
}
