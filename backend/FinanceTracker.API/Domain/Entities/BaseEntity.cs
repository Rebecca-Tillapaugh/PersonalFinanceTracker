namespace FinanceTracker.API.Domain.Entities;

// Shared base class for all domain entities, providing common properties.
// Keeps common audit fields consistent across the model and avoids repeating them in every entity.
public abstract class BaseEntity
{
    public Guid Id { get; set; }
    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? UpdatedAt { get; set; }
}
