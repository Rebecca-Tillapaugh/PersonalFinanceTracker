namespace FinanceTracker.API.Domain.Entities;

// Represents a financial transaction, including details.
public class Transaction : BaseEntity
{
    public string Description { get; set; } = string.Empty;

    public decimal Amount { get; set; }

    public DateTimeOffset TransactionDate { get; set; }

    public string Type { get; set; } = "Expense";

    public string? Notes { get; set; }

    public Guid UserId { get; set; }

    public User User { get; set; } = null!;

    public Guid CategoryId { get; set; }

    public Category Category { get; set; } = null!;
}
