using System;

namespace Operating_Systems_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                UI.Display_EntryUI();
                switch (Console.ReadLine().ToLower())
                {
                    case "1": // Write content to a File in a path taken from the user
                        FileWriter.FileWriting();
                        break;

                    case "2": // Reads a File from a path taken from the user
                        FileReader.ReadFile();
                        break;

                    case "3": // Monitors a directory taken from the user
                        FolderMonitor.Monitor();
                        break;

                    case "4": // Starts a timer to calculate the time of any process
                        StopWatchTimer.StartTimer(1);
                        break;

                    case "5": // Gets the information of anything the user asks for 
                        WMI.GetUserChoice();
                        break;

                    case "6": // Performs Shutdown, Restart, Sleep, or Hibernate
                        WMI.GetPowerOption();
                        break;

                    case "7": // Help Menu
                        UI.Display_HelpMenu();
                        break;

                    case "exit": // Quits the program
                    case "quit":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Error!");
                        Console.ResetColor();
                        _ = Console.ReadKey(true); // Wait for key press and ignore
                        continue;
                }
            }
        }
    }
}