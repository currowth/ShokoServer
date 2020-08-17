namespace Shoko.Renamer.Abstractions.DataModels
{
    public interface IVideoFile
    {
        /// <summary>
        /// The name of the file being renamed or moved, before any actions are applied
        /// </summary>
        string Filename { get; }

        /// <summary>
        /// The Absolute Path of the file being moved or renamed.
        /// </summary>
        string FilePath { get; }

        /// <summary>
        /// The AniDB File Info. This will be null for manual links, which can reliably be used to tell if it was manually linked.
        /// </summary>
        IAniDBFile AniDBFileInfo { get; }

        /// <summary>
        /// The MediaInfo data for the file. This can be null, but it shouldn't be.
        /// </summary>
        IMediaContainer MediaInfo { get; }
    }
}