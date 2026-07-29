namespace FinanceTracker.API.Application.DTOs.Categories;

public class CategoryDTO
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string Type { get; set; } = "Expense";

    public string? Color { get; set; }

    public bool IsDefault { get; set; }
}