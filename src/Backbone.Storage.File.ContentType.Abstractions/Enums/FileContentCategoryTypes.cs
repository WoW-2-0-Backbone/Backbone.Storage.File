namespace Backbone.Storage.File.ContentType.Abstractions.Enums;

/// <summary>
/// Defines common file content categories.
/// </summary>
public enum FileContentCategories : ushort
{
    #region Media - 1x

    /// <summary>
    /// Refers to image files (e.g., JPEG, PNG, GIF).
    /// </summary>
    Image = 11,

    /// <summary>
    /// Refers to video files (e.g., MP4, AVI, MOV).
    /// </summary>
    Video = 12,

    /// <summary>
    /// Refers to audio files (e.g., MP3, WAV, OGG).
    /// </summary>
    Audio = 13,

    /// <summary>
    /// Refers to archive files (e.g., ZIP, RAR, 7Z).
    /// </summary>
    Archive = 14,

    #endregion

    #region Documents - 2x

    /// <summary>
    /// Refers to document files (e.g., PDF, DOC, DOCX).
    /// </summary>
    Document = 21,

    /// <summary>
    /// Refers to spreadsheet files (e.g., XLS, XLSX).
    /// </summary>
    Spreadsheet = 22,

    /// <summary>
    /// Refers to presentation files (e.g., PPT, PPTX).
    /// </summary>
    Presentation = 23,

    /// <summary>
    /// Refers to eBook files (e.g., EPUB, MOBI).
    /// </summary>
    Ebook = 24,

    /// <summary>
    /// Refers to CAD files (e.g., DWG, DXF).
    /// </summary>
    CAD = 25,

    /// <summary>
    /// Refers to GIS files (e.g., SHP, KML).
    /// </summary>
    GIS = 26,

    #endregion

    #region Code and Data - 3x

    /// <summary>
    /// Refers to data files (e.g., JSON, XML, CSV).
    /// </summary>
    Data = 31,
    
    /// <summary>
    /// Refers to database files (e.g., MDB, ACCDB, SQL).
    /// </summary>
    Database = 32,

    /// <summary>
    /// Refers to source code files (e.g., CS, JS, PY).
    /// </summary>
    SourceCode = 33,

    /// <summary>
    /// Refers to markup files (e.g., HTML, MD).
    /// </summary>
    Markup = 34,

    /// <summary>
    /// Refers to configuration files (e.g., INI, CFG, YAML).
    /// </summary>
    Configuration = 35,

    /// <summary>
    /// Refers to markup style files (e.g., CSS, SCSS).
    /// </summary>
    MarkupStyle = 36,

    /// <summary>
    /// Refers to web script files (e.g., JS, TS).
    /// </summary>
    WebScript = 37,

    /// <summary>
    /// Refers to 3D model files (e.g., STL, OBJ).
    /// </summary>
    Model3D = 38,
    
    /// <summary>
    /// Refers to programming project files (e.g., SLN, PROJ).
    /// </summary>
    ProjectFile = 39,
    
    /// <summary>
    /// Refers to certificate files (e.g., CER, CRT).
    /// </summary>
    Certificate = 40,

    /// <summary>
    /// Refers to log files (e.g., LOG).
    /// </summary>
    Log = 41,

    #endregion

    #region Miscellaneous - 4x

    /// <summary>
    /// Refers to text files (e.g., TXT, RTF).
    /// </summary>
    Text = 42,

    /// <summary>
    /// Refers to email files (e.g., EML, MSG).
    /// </summary>
    Email = 43,

    /// <summary>
    /// Refers to calendar files (e.g., ICS).
    /// </summary>
    Calendar = 44,

    /// <summary>
    /// Refers to contact files (e.g., VCF).
    /// </summary>
    Contact = 45,

    /// <summary>
    /// Refers to backup files (e.g., BAK).
    /// </summary>
    Backup = 46,

    /// <summary>
    /// Refers to virtual disk files (e.g., VHD, VMDK).
    /// </summary>
    VirtualDisk = 47,

    #endregion
}