using Backbone.Storage.File.ContentType.Abstractions.Brokers;
using Backbone.Storage.File.ContentType.Abstractions.Enums;
using Backbone.Storage.File.ContentType.Abstractions.Extensions;
using Backbone.Storage.File.ContentType.Abstractions.Models;

namespace Backbone.Storage.File.ContentType.Basic.Brokers;

/// <summary>
/// Provides functionality of broker for providing file content types.
/// </summary>
public class FileContentTypeProvider : IFileContentTypeProvider
{
    private readonly List<FileContentTypeInfo> _fileContentInfos;

    public FileContentTypeProvider()
    {
        _fileContentInfos = Enum.GetValues<FileContentTypes>()
            .Select(contentType => contentType.GetFileContentTypeInfo())
            .ToList();
    }

    /// <inheritdoc />
    public IReadOnlyCollection<FileContentTypeInfo> GetAll()
    {
        return _fileContentInfos;
    }

    /// <inheritdoc />
    public IReadOnlyCollection<FileContentTypeInfo> GetByCategory(FileContentCategories category)
    {
        return _fileContentInfos.Where(fileContentType => fileContentType.Category == category).ToList().AsReadOnly();
    }

    /// <inheritdoc />
    public IReadOnlyCollection<FileContentTypeInfo> GetByType(FileContentTypes fileContentType)
    {
        return _fileContentInfos.Where(fileContentTypeInfo => fileContentTypeInfo.Type == fileContentType).ToList().AsReadOnly();
    }

    /// <inheritdoc />
    public IReadOnlyCollection<FileContentTypeInfo> GetByContentType(string contentType)
    {
        return _fileContentInfos.Where(fileContentTypeInfo => fileContentTypeInfo.ContentType == contentType).ToList().AsReadOnly();
    }

    /// <inheritdoc />
    public IReadOnlyCollection<FileContentTypeInfo> GetByExtension(string extension)
    {
        return _fileContentInfos.Where(fileContentTypeInfo => fileContentTypeInfo.Extension == extension).ToList().AsReadOnly();
    }
    
    /// <inheritdoc />
    public bool CheckIfInSameCategory(FileContentTypes contentTypeA, FileContentTypes contentTypeB)
    {
        var contentTypeInfoA = _fileContentInfos.First(fileContentTypeInfo => fileContentTypeInfo.Type == contentTypeA);
        var contentTypeInfoB = _fileContentInfos.First(fileContentTypeInfo => fileContentTypeInfo.Type == contentTypeB);

        return contentTypeInfoA.Category == contentTypeInfoB.Category;
    }
}