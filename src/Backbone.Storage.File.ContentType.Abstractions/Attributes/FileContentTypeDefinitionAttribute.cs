using Backbone.Storage.File.ContentType.Abstractions.Enums;

namespace Backbone.Storage.File.ContentType.Abstractions.Attributes;

/// <summary>
/// Attribute to specify file content type information for enum values.
/// </summary>
/// <param name="fileCategory">The file content category.</param>
/// <param name="contentType">The exact file content type.</param>
/// <param name="extension">The exact file content type.</param>
[AttributeUsage(AttributeTargets.Field)]
internal class FileContentTypeDefinitionAttribute(
    FileContentCategories fileCategory,
    string contentType,
    string extension
) : Attribute
{
    /// <summary>
    /// Gets the file content category.
    /// </summary>
    public FileContentCategories FileCategory { get; } = fileCategory;

    /// <summary>
    /// Gets the MIME content type.
    /// </summary>
    public string ContentType { get; } = contentType;

    /// <summary>
    /// Gets the file extension.
    /// </summary>
    public string Extension { get; } = extension;
}