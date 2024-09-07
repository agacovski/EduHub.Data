using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduHub.Data
{
    /// <summary>
    /// An interface for interacting with a file system
    /// </summary>
    public interface IFileSystem
    {
        /// <summary>
        /// Returns the base location of the file system
        /// </summary>
        string BaseLocation { get; }

        /// <summary>
        /// Returns true if the directory exists
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        bool DirectoryExists(string path);

        /// <summary>
        /// Returns true if the file exists
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        bool FileExists(string path);

        /// <summary>
        /// Enumerates the CSV files in the file system
        /// </summary>
        /// <returns></returns>
        IEnumerable<string> EnumerateCsvFiles();

        /// <summary>
        /// Enumerates the CSV files for a site identifier
        /// </summary>
        /// <param name="siteIdentifier"></param>
        /// <returns></returns>
        IEnumerable<string> EnumerateCsvFilesForSiteIdentifier(string siteIdentifier);

        /// <summary>
        /// Returns the file name part of a path including the file extension
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        string GetFileName(string path);

        /// <summary>
        /// Returns the path of a file that is the combination of two paths
        /// </summary>
        /// <param name="path1"></param>
        /// <param name="path2"></param>
        /// <returns></returns>
        string CombinePath(string path1, string path2);

        /// <summary>
        /// Returns the size of a file in bytes
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        long GetFileSize(string path);

        /// <summary>
        /// Returns the last write time of a file
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        DateTime GetFileLastWriteTime(string path);

        /// <summary>
        /// Opens a file for reading
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        Stream OpenFile(string path);
    }
}
