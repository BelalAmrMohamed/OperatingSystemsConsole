using System;
using System.IO;

namespace Operating_Systems_Console
{
    internal class FileReader
    {
        public static void ReadFile()
        {
            Console.Clear();
            UI.Display_FileReading();

            string path = GetPath.GetFullPath();
            switch (Path.GetExtension(path))
            {
                case ".txt":
                    Console.Write($"The content of {Path.GetFileName(path)} is:\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(ReadTextFile(path) + "\n");
                    Console.ResetColor();
                    break;

                case ".bin":
                    Console.Write($"The content of {Path.GetFileName(path)} is:\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(ReadBinaryFile(path) + "\n");
                    Console.ResetColor();
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
            Animations.DisplayAnimation("Finished reading");
            Console.ReadKey(true);
        }
        private static string ReadTextFile(string path)
        {
            using (FileStream fileS = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (BufferedStream buffer = new BufferedStream(fileS))
            using (StreamReader reader = new StreamReader(buffer))
                return reader.ReadToEnd();
        }
        private static string ReadBinaryFile(string path)
        {
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
                return reader.ReadString();
        }
    }
}
