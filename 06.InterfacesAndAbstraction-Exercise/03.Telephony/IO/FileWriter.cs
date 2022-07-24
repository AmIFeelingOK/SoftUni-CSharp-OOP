using _03.Telephony.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _03.Telephony.IO
{
    public class FileWriter : IWriter
    {
        private string fileContent;

        public FileWriter(string filepath)
        {
            this.FilePath = filepath;
            this.fileContent = File.ReadAllText(filepath);
        }

        public string FilePath { get; set; }

        public void Write(string text)
        {
            string output = this.fileContent + text;
            File.WriteAllText(this.FilePath, output);
            this.fileContent = output;
        }

        public void WriteLine(string text)
        {
            string output = this.fileContent + Environment.NewLine + text;
            File.WriteAllText(this.FilePath, output);
            this.fileContent = output;
        }
    }
}
