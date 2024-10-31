using Backbone.Storage.File.ContentType.Abstractions.Brokers;
using Backbone.Storage.File.ContentType.Abstractions.Models;

namespace Backbone.Storage.File.ContentType.Basic.Brokers;

/// <summary>
/// Defines functionality for broker to parse and validate file content types.
/// </summary>
public class FileContentTypeParser(IFileContentTypeProvider fileContentTypeProvider) : IFileContentTypeParser
{
    /// <inheritdoc />
    public (FileContentTypeInfo? FileInfo, bool IsValid) GetFileInfo(string fileName, string contentType)
    {
        var fileExtension = Path.GetExtension(fileName)?.TrimStart('.') ?? string.Empty;

        var matchesByContentType = !string.IsNullOrEmpty(contentType)
            ? fileContentTypeProvider.GetByContentType(contentType)
            : Array.Empty<FileContentTypeInfo>();

        if (!string.IsNullOrEmpty(fileExtension))
        {
            var matchesByExtension = fileContentTypeProvider.GetByExtension(fileExtension);

            var fileInfo = matchesByContentType!.Any()
                ? matchesByExtension.Intersect(matchesByContentType).FirstOrDefault()
                : matchesByExtension.FirstOrDefault();

            return fileInfo is not null ? (fileInfo, true) : (null, false);
        }

        var contentTypeMatch = matchesByContentType.FirstOrDefault();
        
        return contentTypeMatch is not null ? (contentTypeMatch, true) : (null, false);
    }
}