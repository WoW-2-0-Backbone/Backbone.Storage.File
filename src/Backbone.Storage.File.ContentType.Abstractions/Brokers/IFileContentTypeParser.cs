using Backbone.Storage.File.ContentType.Abstractions.Models;

namespace Backbone.Storage.File.ContentType.Abstractions.Brokers;

/// <summary>
/// Defines functionality for broker to parse and validate file content types.
/// </summary>
public interface IFileContentTypeParser
{
    /// <summary>
    /// Gets file information based on file name and content type.
    /// </summary>
    /// <param name="fileName">The name of the file.</param>
    /// <param name="contentType">The content type of the file.</param>
    /// <returns>The file content type information.</returns>
    (FileContentTypeInfo? FileInfo, bool IsValid) GetFileInfo(string fileName, string contentType);
}