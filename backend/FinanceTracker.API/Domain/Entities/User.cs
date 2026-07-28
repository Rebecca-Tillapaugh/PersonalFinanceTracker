namespace FinanceTracker.API.Domain.Entities;

// Represents a user in the finance tracking system, containing personal and account information.
public class User : BaseEntity
{
    public string FullName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string PasswordHash { get; set; } = string.Empty;

    public string? Currency { get; set; }

    public bool IsActive { get; set; } = true;

    public ICollection<Category> Categories { get; set; } = new List<Category>();

    public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

    public ICollection<Budget> Budgets { get; set; } = new List<Budget>();
}
