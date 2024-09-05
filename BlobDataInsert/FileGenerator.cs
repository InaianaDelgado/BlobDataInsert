using System;
using System.IO;

namespace BlobDataInsert
{
    public static class FileGenerator
    {
        public static string Generate(string path)
        {
            string fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
            var localFilePath = Path.Combine(path, fileName);
            StreamWriter writer = new StreamWriter(localFilePath);
            writer.Close();

            return fileName;
        }

        public static FileStream GenerateStream(string path, string fileName)
        {
            string localFilePath = string.Concat(path, fileName);
            using FileStream uploadFileStream = File.OpenRead(localFilePath);

            return uploadFileStream;
        }
    }
}
