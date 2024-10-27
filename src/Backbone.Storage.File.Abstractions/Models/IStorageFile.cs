namespace Backbone.Storage.File.Abstractions.Models;

/// <summary>
/// Defines properties for a stored file in the system.
/// </summary>
public interface IStorageFile
{
    /// <summary>
    /// Gets or sets the original name of the file.
    /// </summary>
    string OriginalName { get; set; }

    /// <summary>
    /// Gets or sets the physical name of the file in storage.
    /// </summary>
    string PhysicalName { get; set; }

    /// <summary>
    /// Gets or sets the content type (MIME type) of the file.
    /// </summary>
    string ContentType { get; set; }

    /// <summary>
    /// Gets or sets the file extension.
    /// </summary>
    string Extension { get; set; }

    /// <summary>
    /// Gets or sets the file size in bytes.
    /// </summary>
    ulong Size { get; set; }
}