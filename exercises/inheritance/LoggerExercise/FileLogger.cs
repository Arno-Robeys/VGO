using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LoggerExercise
{
    internal class FileLogger : StreamLogger
    {
        private readonly FileStream fileStream;
        private FileLogger(FileStream fileStream) : base(new StreamWriter(fileStream))
        {
            this.fileStream = fileStream;
        }

        public static FileLogger Create(string filename)
        {
            var file = File.OpenWrite(filename);
            return new FileLogger(file);
        }

        public override void Close()
        {
            this.fileStream.Close();
        }
    }
}
