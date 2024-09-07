using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace EduHub.Data.Samples
{
    public class ArchiveFileSystem : IFileSystem
    {
        private readonly ZipArchive archive;

        public string BaseLocation { get; } = "zip://";

        public ArchiveFileSystem(MemoryStream archiveStream)
        {
            archive = new ZipArchive(archiveStream, ZipArchiveMode.Read);
        }

        public string CombinePath(string path1, string path2)
            => Path.Combine(path1, path2);

        public bool DirectoryExists(string path)
            => string.Equals(BaseLocation, path, StringComparison.OrdinalIgnoreCase);

        public IEnumerable<string> EnumerateCsvFiles()
        {
            return archive.Entries
                .Where(e => e.FullName.EndsWith(".csv", StringComparison.OrdinalIgnoreCase) && !e.FullName.Contains("/") && !e.FullName.Contains(@"\"))
                .Select(e => Path.Combine(BaseLocation, e.FullName));
        }

        public IEnumerable<string> EnumerateCsvFilesForSiteIdentifier(string siteIdentifier)
        {
            return archive.Entries
                .Where(e => e.FullName.EndsWith($"_{siteIdentifier}.csv", StringComparison.OrdinalIgnoreCase) && !e.FullName.Contains("/") && !e.FullName.Contains(@"\"))
                .Select(e => Path.Combine(BaseLocation, e.FullName));
        }

        public bool FileExists(string path)
        {
            if (!path.StartsWith(BaseLocation, StringComparison.OrdinalIgnoreCase))
                return false;

            return archive.GetEntry(path.Substring(BaseLocation.Length)) != null;
        }

        public DateTime GetFileLastWriteTime(string path)
        {
            if (TryGetEntry(path, out var entry))
                return entry.LastWriteTime.LocalDateTime;
            else
                throw new FileNotFoundException(path);
        }

        public string GetFileName(string path)
            => Path.GetFileName(path);

        public long GetFileSize(string path)
        {
            if (TryGetEntry(path, out var entry))
                return entry.Length;
            else
                throw new FileNotFoundException(path);
        }

        public Stream OpenFile(string path)
        {
            if (TryGetEntry(path, out var entry))
                return entry.Open();
            else
                throw new FileNotFoundException(path);
        }

        private bool TryGetEntry(string path, out ZipArchiveEntry entry)
        {
            entry = archive.GetEntry(path.Substring(BaseLocation.Length));
            return entry != null;
        }
    }
}
