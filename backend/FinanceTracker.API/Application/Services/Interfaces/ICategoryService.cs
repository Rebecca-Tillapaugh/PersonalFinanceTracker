using FinanceTracker.API.Application.DTOs.Categories;

namespace FinanceTracker.API.Application.Services.Interfaces;

public interface ICategoryService
{
    Task<IEnumerable<CategoryDTO>> GetCategoriesAsync();

    Task<CategoryDTO?> GetCategoryAsync(Guid id);

    Task<CategoryDTO> CreateCategoryAsync(CreateCategoryDTO dto);

    Task<bool> UpdateCategoryAsync(Guid id, EditCategoryDTO dto);

    Task<bool> DeleteCategoryAsync(Guid id);
}