using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace AzureStorageTestingApplication.Managers
{
    public class FileManager
    {
        private string _tempPath;
        private string _tempTxtFile;

        /// <summary>
        /// The path to the downloads-folder.
        /// </summary>
        public String DownloadsPath => _tempPath;

        /// <summary>
        /// The path of the temp txt-file.
        /// </summary>
        public string TempTxtFile => _tempTxtFile;

        public FileManager()
        {
            _tempPath = @"Downloads\\";
            if (!Directory.Exists(_tempPath)) Directory.CreateDirectory(_tempPath);
        }

        /// <summary>
        /// Create a new filename into the downloads-folder.
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public String CreateNewFilenameForDownloads(string filename = null)
        {
            if (String.IsNullOrWhiteSpace(filename)) filename = Guid.NewGuid() + ".txt";

            return DownloadsPath + filename;
        }

        /// <summary>
        /// Checks if the file already exists.
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public Boolean FileExists(string filename)
        {
            var fullpath = DownloadsPath + filename;

            return File.Exists(fullpath);
        }

        /// <summary>
        /// Create the temp txt-file if it doesn't exist.
        /// </summary>
        public void CreateTempFile()
        {
            _tempTxtFile = _tempPath + Guid.NewGuid() + ".txt";

            if (!File.Exists(TempTxtFile))
            {
                using (var fileStream = new FileStream(TempTxtFile, FileMode.CreateNew))
                {
                    
                }
                //File.Create(TempTxtFile);
                //File.SetAttributes(TempTxtFile, FileAttributes.Normal);
            }
        }

        /// <summary>
        /// Delete the temp txt-file (if it isn't locked).
        /// </summary>
        public void DeleteTempFile()
        {
            try
            {
                if (!File.Exists(TempTxtFile)) return;
                
                if (!IsFileLocked(TempTxtFile)) File.Delete(TempTxtFile);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
        }

        /// <summary>
        /// Checks if file is opened (by another program).
        /// </summary>
        /// <param name="filepath">Path to the file.</param>
        /// <returns></returns>
        public bool IsFileLocked(string filepath)
        {
            try
            {
                File.Open(filepath, FileMode.Open);
            }
            catch (IOException ex)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Delete all files from the Downloads-folder for this application.
        /// </summary>
        public void DeleteAllDownloads()
        {
            foreach (string file in Directory.GetFiles(_tempPath))
            {
                try
                {
                    File.Delete(file);
                }
                catch (Exception ex)
                {
                    string message = ex.Message;
                }
            }
        }

        public void OpenFileFromPath(string filepath)
        {
            if (!File.Exists(filepath))
            {
                MessageBox.Show("File does not exist!");
                return;
            }

            Process.Start(filepath);
        }
    }
}
