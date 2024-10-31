using Backbone.Storage.File.ContentType.Abstractions.Enums;

namespace Backbone.Storage.File.ContentType.Abstractions.Models;

/// <summary>
/// Represents an exact file content type match.
/// </summary>
/// <param name="Category">The file content category.</param>
/// <param name="Type">The exact file content type.</param>
/// <param name="ContentType">The exact file content type.</param>
/// <param name="Extension">The exact file content type.</param>
public record FileContentTypeInfo(
    FileContentCategories Category,
    FileContentTypes Type,
    string ContentType,
    string Extension
);