namespace Backbone.Storage.File.ContentType.Abstractions.Extensions;

/// <summary>
/// Contains extensions for a file path.
/// </summary>
public static class FilePath
{
    /// <summary>
    /// Gets the file extension from the file name without the leading dot.
    /// </summary>
    /// <param name="fileName">The name of the file.</param>
    /// <returns>The file extension without the dot, or an empty string if no extension exists.</returns>
    public static string GetExtensionWithoutDot(this string fileName)
    {
        return string.IsNullOrEmpty(fileName) ? string.Empty : Path.GetExtension(fileName)?.TrimStart('.') ?? string.Empty;
    }
}