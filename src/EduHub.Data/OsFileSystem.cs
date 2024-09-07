using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Runtime.Remoting.Contexts;

namespace EduHub.Data
{
    /// <summary>
    /// An implementation of IFileSystem that uses the operating systems file system
    /// </summary>
    public class OsFileSystem : IFileSystem
    {
        /// <summary>
        /// The base directory for the file system
        /// </summary>
        public string BaseLocation { get; }

        /// <summary>
        /// Creates a new OsFileSystem
        /// </summary>
        /// <param name="baseLocation"></param>
        public OsFileSystem(string baseLocation)
        {
            if (!Directory.Exists(baseLocation))
                throw new ArgumentException($"EduHub Directory [{baseLocation}] does not exist");

            BaseLocation = baseLocation;
        }

        /// <inheritdoc/>
        public bool DirectoryExists(string path)
            => Directory.Exists(path);

        /// <inheritdoc/>
        public bool FileExists(string path)
            => File.Exists(path);

        /// <inheritdoc/>
        public IEnumerable<string> EnumerateCsvFiles()
            => Directory.EnumerateFiles(BaseLocation, "*.csv");

        /// <inheritdoc/>
        public IEnumerable<string> EnumerateCsvFilesForSiteIdentifier(string siteIdentifier)
            => Directory.EnumerateFiles(BaseLocation, $"*_{siteIdentifier}.csv");

        /// <inheritdoc/>
        public string GetFileName(string path)
            => Path.GetFileName(path);

        /// <inheritdoc/>
        public string CombinePath(string path1, string path2)
            => Path.Combine(path1, path2);

        /// <inheritdoc/>
        public long GetFileSize(string path)
            => new FileInfo(path).Length;

        /// <inheritdoc/>
        public DateTime GetFileLastWriteTime(string path)
            => File.GetLastWriteTime(path);

        /// <inheritdoc/>
        public Stream OpenFile(string path)
        {
            // Copy to memory stream (don't directly process eduHub files)
            var stream = new MemoryStream();
            using (var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                fileStream.CopyTo(stream);
            stream.Position = 0;
            return stream;
        }
    }
}
