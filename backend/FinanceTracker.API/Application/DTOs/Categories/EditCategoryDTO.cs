namespace FinanceTracker.API.Application.DTOs.Categories;

public class EditCategoryDTO
{
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string Type { get; set; } = "Expense";

    public string? Color { get; set; }
}