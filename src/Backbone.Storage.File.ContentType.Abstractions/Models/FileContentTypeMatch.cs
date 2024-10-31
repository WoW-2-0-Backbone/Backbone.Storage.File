namespace Backbone.Storage.File.ContentType.Abstractions.Models;

/// <summary>
/// Represents a file content type match with multiple possible extensions.
/// </summary>
/// <param name="ContentType">The MIME content type.</param>
/// <param name="Extensions">The possible file extensions.</param>
public record FileContentTypeMatch(string ContentType, IReadOnlySet<string> Extensions);
