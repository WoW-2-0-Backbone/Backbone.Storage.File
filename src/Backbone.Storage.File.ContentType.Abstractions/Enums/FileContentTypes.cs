using Backbone.Storage.File.ContentType.Abstractions.Attributes;

namespace Backbone.Storage.File.ContentType.Abstractions.Enums;

/// <summary>
/// Defines common file content types with their MIME types and extensions.
/// </summary>
public enum FileContentTypes : ushort
{
    #region Media - Images

    /// <summary>
    /// JPEG Image file
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.Image, "image/jpeg", "jpg")]
    Jpeg = 11101,

    /// <summary>
    /// JPEG Image file alternative extension
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.Image, "image/jpeg", "jpeg")]
    Jpeg2 = 11102,

    /// <summary>
    /// PNG Image file
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.Image, "image/png", "png")]
    Png = 11103,

    /// <summary>
    /// GIF Image file
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.Image, "image/gif", "gif")]
    Gif = 11104,

    /// <summary>
    /// SVG Image file
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.Image, "image/svg+xml", "svg")]
    Svg = 11105,

    /// <summary>
    /// WebP Image file
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.Image, "image/webp", "webp")]
    Webp = 11106,

    #endregion

    #region Media - Video

    /// <summary>
    /// MP4 Video file
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.Video, "video/mp4", "mp4")]
    Mp4 = 12101,

    /// <summary>
    /// AVI Video file
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.Video, "video/x-msvideo", "avi")]
    Avi = 12102,

    /// <summary>
    /// MOV Video file
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.Video, "video/quicktime", "mov")]
    Mov = 12103,

    /// <summary>
    /// WebM Video file
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.Video, "video/webm", "webm")]
    WebM = 12104,

    #endregion

    #region Media - Audio

    /// <summary>
    /// MP3 Audio file
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.Audio, "audio/mpeg", "mp3")]
    Mp3 = 13101,

    /// <summary>
    /// WAV Audio file
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.Audio, "audio/wav", "wav")]
    Wav = 13102,

    /// <summary>
    /// AAC Audio file
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.Audio, "audio/aac", "aac")]
    Aac = 13103,

    #endregion

    #region Media - Archives

    /// <summary>
    /// ZIP Archive file
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.Archive, "application/zip", "zip")]
    Zip = 14101,

    /// <summary>
    /// RAR Archive file
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.Archive, "application/x-rar-compressed", "rar")]
    Rar = 14102,

    /// <summary>
    /// 7Z Archive file
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.Archive, "application/x-7z-compressed", "7z")]
    SevenZip = 14103,

    #endregion

    #region Documents - Documents

    /// <summary>
    /// PDF Document file
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.Document, "application/pdf", "pdf")]
    Pdf = 21101,

    /// <summary>
    /// Word Document file
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.Document, "application/msword", "doc")]
    Doc = 21102,

    /// <summary>
    /// Word Document file (OpenXML)
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.Document, "application/vnd.openxmlformats-officedocument.wordprocessingml.document", "docx")]
    Docx = 21103,

    #endregion

    #region Documents - Spreadsheets

    /// <summary>
    /// Excel Spreadsheet file
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.Spreadsheet, "application/vnd.ms-excel", "xls")]
    Xls = 22101,

    /// <summary>
    /// Excel Spreadsheet file (OpenXML)
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.Spreadsheet, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "xlsx")]
    Xlsx = 22102,

    #endregion

    #region Documents - Presentations

    /// <summary>
    /// PowerPoint Presentation file
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.Presentation, "application/vnd.ms-powerpoint", "ppt")]
    Ppt = 23101,

    /// <summary>
    /// PowerPoint Presentation file (OpenXML)
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.Presentation, "application/vnd.openxmlformats-officedocument.presentationml.presentation",
        "pptx")]
    Pptx = 23102,

    #endregion

    #region Documents - eBooks

    /// <summary>
    /// EPUB eBook file
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.Ebook, "application/epub+zip", "epub")]
    Epub = 24101,

    #endregion

    #region Documents - CAD

    /// <summary>
    /// AutoCAD Drawing file
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.CAD, "application/x-dwg", "dwg")]
    Dwg = 25101,

    #endregion

    #region Documents - GIS

    /// <summary>
    /// ESRI Shapefile
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.GIS, "application/x-shapefile", "shp")]
    Shp = 26101,

    #endregion

    #region Source code - Data

    /// <summary>
    /// JSON Data file
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.Data, "application/json", "json")]
    Json = 31101,

    /// <summary>
    /// XML Data file
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.Data, "application/xml", "xml")]
    Xml = 31102,

    /// <summary>
    /// CSV Data file
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.Data, "text/csv", "csv")]
    Csv = 31103,

    #endregion

    #region Source code - Database

    /// <summary>
    /// SQLite Database file
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.Database, "application/x-sqlite3", "sqlite")]
    Sqlite = 32101,

    #endregion

    #region Source code - SourceCode

    /// <summary>
    /// C# Source Code file
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.SourceCode, "text/x-csharp", "cs")]
    CSharp = 33101,

    #endregion

    #region Source code - Markup

    /// <summary>
    /// HTML Markup file
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.Markup, "text/html", "html")]
    Html = 34101,

    #endregion

    #region Source code - Configuration

    /// <summary>
    /// YAML Configuration file
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.Configuration, "text/yaml", "yaml")]
    Yaml = 35101,

    #endregion

    #region Source code - MarkupStyle

    /// <summary>
    /// CSS Style file
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.MarkupStyle, "text/css", "css")]
    Css = 36101,

    #endregion

    #region Source code - WebScript

    /// <summary>
    /// JavaScript file
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.WebScript, "text/javascript", "js")]
    JavaScript = 37101,

    #endregion

    #region Source code - Model3D

    /// <summary>
    /// STL 3D Model file
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.Model3D, "application/sla", "stl")]
    Stl = 38101,

    #endregion

    #region Source code - ProjectFile

    /// <summary>
    /// Visual Studio Solution file
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.ProjectFile, "text/plain", "sln")]
    Solution = 39101,

    #endregion

    #region Source code - Certificate

    /// <summary>
    /// X.509 Certificate file
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.Certificate, "application/x-x509-ca-cert", "crt")]
    Crt = 40101,

    #endregion

    #region Source code - Log

    /// <summary>
    /// Log file
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.Log, "text/plain", "log")]
    Log = 41101,

    #endregion

    #region Miscellaneous - Text

    /// <summary>
    /// Text file
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.Text, "text/plain", "txt")]
    Txt = 42101,

    #endregion

    #region Miscellaneous - Email

    /// <summary>
    /// Email Message file
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.Email, "message/rfc822", "eml")]
    Eml = 43101,

    #endregion

    #region Miscellaneous - Calendar

    /// <summary>
    /// iCalendar file
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.Calendar, "text/calendar", "ics")]
    Ics = 44101,

    #endregion

    #region Miscellaneous - Contact

    /// <summary>
    /// vCard Contact file
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.Contact, "text/vcard", "vcf")]
    Vcf = 45101,

    #endregion

    #region Miscellaneous - Backup

    /// <summary>
    /// Backup file
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.Backup, "application/octet-stream", "bak")]
    Bak = 46101,

    #endregion

    #region Miscellaneous - VirtualDisk

    /// <summary>
    /// Virtual Hard Disk file
    /// </summary>
    [FileContentTypeDefinition(FileContentCategories.VirtualDisk, "application/x-vhd", "vhd")]
    Vhd = 47101,

    #endregion
}