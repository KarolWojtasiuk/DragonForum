namespace DragonForum;

/// <summary>
/// Forum permissions, also apply to child forums
/// </summary>
[Flags]
public enum ForumPermissions
{
    /// <summary>
    /// No permissions
    /// </summary>
    None = 0,

    /// <summary>
    /// Read forum properties
    /// </summary>
    ReadForum = 1 << 0,

    /// <summary>
    /// List forum threads and read their properties
    /// </summary>
    ReadThread = 1 << 2,

    /// <summary>
    /// Read thread messages
    /// </summary>
    ReadMessage = 1 << 3,

    /// <summary>
    /// Create child forums
    /// </summary>
    CreateForum = 1 << 4,

    /// <summary>
    /// Create new threads
    /// </summary>
    CreateThread = 1 << 5,

    /// <summary>
    /// Create new messages
    /// </summary>
    CreateMessage = 1 << 6,

    /// <summary>
    /// Edit forum properties
    /// </summary>
    EditForum = 1 << 7,

    /// <summary>
    /// Edit thread properties
    /// </summary>
    EditThread = 1 << 8,

    /// <summary>
    /// Edit own thread properties
    /// </summary>
    EditOwnThread = 1 << 9,

    /// <summary>
    /// Edit messages
    /// </summary>
    EditMessage = 1 << 10,

    /// <summary>
    /// Edit own messages
    /// </summary>
    EditOwnMessage = 1 << 11,

    /// <summary>
    /// Delete forum and child forums
    /// </summary>
    DeleteForum = 1 << 12,

    /// <summary>
    /// Delete threads
    /// </summary>
    DeleteThread = 1 << 13,

    /// <summary>
    /// Delete own threads
    /// </summary>
    DeleteOwnThread = 1 << 14,

    /// <summary>
    /// Delete messages
    /// </summary>
    DeleteMessage = 1 << 15,

    /// <summary>
    /// Delete own messages
    /// </summary>
    DeleteOwnMessage = 1 << 16,

    /// <summary>
    /// Full read permissions
    /// </summary>
    ReadAll = ReadForum | ReadThread | ReadMessage,

    /// <summary>
    /// Full create permissions
    /// </summary>
    CreateAll = CreateForum | CreateThread | CreateMessage,

    /// <summary>
    /// Full edit permissions
    /// </summary>
    EditAll = EditForum | EditThread | EditMessage,

    /// <summary>
    /// Edit own entities
    /// </summary>
    EditOwnAll = EditOwnThread | EditOwnMessage,

    /// <summary>
    /// Full delete permissions
    /// </summary>
    DeleteAll = DeleteForum | DeleteThread | DeleteMessage,

    /// <summary>
    /// Delete own entities
    /// </summary>
    DeleteOwnAll = DeleteOwnThread | DeleteOwnMessage,
}