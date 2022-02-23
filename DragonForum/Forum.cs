namespace DragonForum;

public record Forum
{
    /// <summary>
    /// Forum id
    /// </summary>
    public ForumId Id { get; init; } = new(Guid.NewGuid());

    /// <summary>
    /// Parent forum id;
    /// If is empty, it means this forum is main forum
    /// </summary>
    public ForumId? ParentId { get; init; } = default;
    
    /// <summary>
    /// Name of the forum
    /// </summary>
    public string Name { get; init; } = String.Empty;
    
    /// <summary>
    /// Description of the forum
    /// </summary>
    public string? Description { get; init; } = default;
    
    /// <summary>
    /// Default permissions that apply to every active user
    /// </summary>
    public ForumPermissions? DefaultPermissions = default;

    /// <summary>
    /// Indicates whether the forum is read-only
    /// </summary>
    public bool IsReadOnly { get; init; } = default;

    /// <summary>
    /// UTC date of forum creation
    /// </summary>
    public DateTime CreationDate { get; init; } = default;
}