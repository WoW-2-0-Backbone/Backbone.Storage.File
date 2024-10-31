using Backbone.Storage.File.ContentType.Abstractions.Models;

namespace Backbone.Storage.File.ContentType.Abstractions.Brokers;

/// <summary>
/// Provides functionality for parsing content types from file streams.
/// </summary>
public interface IFileStreamContentTypeParser
{
    /// <summary>
    /// Detects the content type from a file stream.
    /// </summary>
    /// <param name="fileStream">The file stream to analyze.</param>
    /// <param name="fileName">Optional file name to help match extension for detected content type.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation.</param>
    /// <returns>The detected content file content type.</returns>
    ValueTask<FileContentTypeInfo> ParseContentTypeAsync(
        Stream fileStream, 
        string? fileName = null, 
        CancellationToken cancellationToken = default);
}