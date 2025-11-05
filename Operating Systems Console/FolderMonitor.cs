using System;
using System.IO;

namespace Operating_Systems_Console
{
    internal class FolderMonitor
    {
        public static void Monitor()
        {
            Console.Clear();
            UI.Display_Monitoring();
            string path = GetPath.GetDirectory();

            FileSystemWatcher Watcher = new FileSystemWatcher(path);
            Watcher.EnableRaisingEvents = true;
            Watcher.Changed += Changed;
            Watcher.Created += Created;
            Watcher.Renamed += Renamed;
            Watcher.Deleted += Deleted;

            Animations.DisplayAnimation("Monitoring");
            Console.ReadKey(true);
            Watcher.EnableRaisingEvents = false;
        }

        private static void Changed(object sender, FileSystemEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\r[{e.Name}] has been changed");
            Console.ResetColor();
        }

        private static void Created(object sender, FileSystemEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\r[{e.Name}] has been Created");
            Console.ResetColor();
        }

        private static void Renamed(object sender, RenamedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\r[{e.OldName}] has been Renamed to {e.Name}");
            Console.ResetColor();
        }

        private static void Deleted(object sender, FileSystemEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\r[{e.Name}] has been Deleted");
            Console.ResetColor();
        }
    }
}
