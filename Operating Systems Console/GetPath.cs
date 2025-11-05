using System;

namespace Operating_Systems_Console
{
    internal class GetPath
    {
        public static string GetDirectory()
        {
            Console.Write("Enter the path: ");
            string directory = Console.ReadLine();
            if (string.IsNullOrEmpty(directory))
            {
                directory = @"C:\Users\" + Environment.UserName + @"\Downloads\";
                Console.Write($"The default Directory is: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(directory + "\n");
                Console.ResetColor();
            }
            return directory;
        }
        public static string GetFullPath()
        {
            string directory = GetDirectory();

            Console.Write("Enter a file name: ");
            string fileName = Console.ReadLine();
            if (string.IsNullOrEmpty(fileName))
            {
                fileName = "file.txt";
                Console.Write($"The default file name is: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(fileName + "\n");
                Console.ResetColor();
            }
            return directory + fileName;
        }
        public static string GetContent()
        {
            Console.Write("Enter the content: ");
            string content = Console.ReadLine();

            if (string.IsNullOrEmpty(content))
            {
                content = "Hello World!";
                Console.Write("The default content is: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(content + "\n");
                Console.ResetColor();
            }
            return content;
        }
    }
}
