using System.Reflection;
using Backbone.Storage.File.ContentType.Abstractions.Attributes;
using Backbone.Storage.File.ContentType.Abstractions.Enums;
using Backbone.Storage.File.ContentType.Abstractions.Models;

namespace Backbone.Storage.File.ContentType.Abstractions.Extensions;

/// <summary>
/// Contains extensions for enums
/// </summary>
public static class EnumExtensions
{
    /// <summary>
    /// Gets the file content type information based on the provided content type enum value.
    /// </summary>
    /// <param name="contentType">The content type enum value to retrieve information for.</param>
    /// <returns>A <see cref="FileContentTypeInfo"/> object containing the file content type information.</returns>
    public static FileContentTypeInfo GetFileContentTypeInfo(this FileContentTypes contentType)
    {
        var fieldInfo = typeof(FileContentTypes).GetField(contentType.ToString());
        if (fieldInfo == null) throw new NullReferenceException($"FieldInfo for {contentType} is null");

        var attribute = fieldInfo.GetCustomAttribute<FileContentTypeDefinitionAttribute>()!;

        return new FileContentTypeInfo(attribute.FileCategory, contentType, attribute.ContentType, attribute.Extension);
    }
}