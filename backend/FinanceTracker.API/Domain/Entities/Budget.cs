namespace FinanceTracker.API.Domain.Entities;

// Represents a budget, including its details and associated categories.
// Connects to Category through the BudgetCategory join entity, allowing for many-to-many relationships between budgets and categories.
public class Budget : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public decimal LimitAmount { get; set; }

    public DateTimeOffset StartDate { get; set; }

    public DateTimeOffset EndDate { get; set; }

    public string Currency { get; set; } = "USD";

    public Guid UserId { get; set; }

    public User User { get; set; } = null!;

    public ICollection<BudgetCategory> BudgetCategories { get; set; } = new List<BudgetCategory>();
}
