using System;
using System.IO;

namespace Operating_Systems_Console
{
    internal class FileWriter
    {
        public static void FileWriting()
        {
            UI.Display_FileWriting();
            string path = GetPath.GetFullPath();
            string content = GetPath.GetContent();

            switch (Path.GetExtension(path))
            {
                case ".txt":
                    WriteToTextFile(path, content);
                    break;

                case ".bin":
                    WriteToBinaryFile(path, content);
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Error!");
                    Console.ResetColor();

                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
            }
            Console.WriteLine();
            Animations.DisplayAnimation("The file has been written successfully");
            Console.ReadKey(true);
        }
        private static void WriteToTextFile(string path, string content)
        {
            using (FileStream fileS = new FileStream(path, FileMode.Append))
            using (BufferedStream buffer = new BufferedStream(fileS))
            using (StreamWriter writer = new StreamWriter(buffer))
                writer.WriteLine(content);
        }
        private static void WriteToBinaryFile(string path, string content)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
                writer.Write(content);
        }
    }
}
