using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemExercise
{
    internal class ChangedFilesCounter
    {

        private readonly HashSet<string> files;

        public int ChangeCount => files.Count;

        public ChangedFilesCounter(IFileSystem fileSystem)
        {
            files = new HashSet<string>();
            fileSystem.FileCreated += onModified;
            fileSystem.FileDeleted += onModified;
            fileSystem.FileWritten += onModified;
        }

        private void onModified(string path)
        {
            files.Add(path);  
        }
    }
}
