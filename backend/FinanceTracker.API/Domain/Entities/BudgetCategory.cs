namespace FinanceTracker.API.Domain.Entities;

// This is the join entity that connects Budget and Category, allowing for a many-to-many relationship between them.
// It allows a single budget to cover multiple categories and gives each category an allocated amount.
public class BudgetCategory : BaseEntity
{
    public Guid BudgetId { get; set; }

    public Budget Budget { get; set; } = null!;

    public Guid CategoryId { get; set; }

    public Category Category { get; set; } = null!;

    public decimal AllocatedAmount { get; set; }
}
