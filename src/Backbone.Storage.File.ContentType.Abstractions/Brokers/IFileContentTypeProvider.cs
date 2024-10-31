using Backbone.Storage.File.ContentType.Abstractions.Enums;
using Backbone.Storage.File.ContentType.Abstractions.Models;

namespace Backbone.Storage.File.ContentType.Abstractions.Brokers;

/// <summary>
/// Defines functionality of broker for providing file content types.
/// </summary>
public interface IFileContentTypeProvider
{
    /// <summary>
    /// Gets all supported content types.
    /// </summary>
    /// <returns>A collection of all content type information.</returns>
    IReadOnlyCollection<FileContentTypeInfo> GetAll();

    /// <summary>
    ///Gets all matching content types by file extension.
    /// </summary>
    /// <param name="category">The file content category.</param>
    /// <returns>A collection of matching content type information</returns>
    IReadOnlyCollection<FileContentTypeInfo> GetByCategory(FileContentCategories category);

    /// <summary>
    /// Gets all matching content types by file extension.
    /// </summary>
    /// <param name="fileContentType">The file content type.</param>
    /// <returns>A collection of matching content type information</returns>
    IReadOnlyCollection<FileContentTypeInfo> GetByType(FileContentTypes fileContentType);

    /// <summary>
    ///Gets all matching content types by file extension.
    /// </summary>
    /// <param name="contentType">The MIME content type.</param>
    /// <returns>A collection of matching content type information</returns>
    IReadOnlyCollection<FileContentTypeInfo> GetByContentType(string contentType);

    /// <summary>
    /// Gets all matching content types by file extension.
    /// </summary>
    /// <param name="extension">The file extension.</param>
    /// <returns>A collection of matching content type information</returns>
    IReadOnlyCollection<FileContentTypeInfo> GetByExtension(string extension);

    /// <summary>
    /// Checks if two file content types belong to the same category.
    /// </summary>
    /// <param name="contentTypeA">The first file content type.</param>
    /// <param name="contentTypeB">The second file content type.</param>
    /// <returns>True if both file content types belong to the same category; otherwise, false.</returns>
    bool CheckIfInSameCategory(FileContentTypes contentTypeA, FileContentTypes contentTypeB);
}