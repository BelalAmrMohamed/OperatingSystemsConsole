using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Management;
using static System.Net.Mime.MediaTypeNames;

namespace Operating_Systems_Console
{
    internal class WMI
    {
        // P/Invoke declarations for sleep and hibernate functionality
        [DllImport("PowrProf.dll", SetLastError = true)]
        private static extern bool SetSuspendState(bool hibernate, bool forceCritical, bool disableWakeEvent);

        public static void GetUserChoice()
        {
            UI.Display_WMI();
            string choice = Console.ReadLine() ?? string.Empty;
            Console.Clear();
            switch (choice.ToLower())
            {
                case "1":
                    Console.WriteLine($"\u001b[1mComputer system information: \n\u001b[96m{GetComputerSystemInfo()}");
                    break;

                case "2":
                    Console.WriteLine($"\u001b[1mProcessor information: \n\u001b[96m{GetProcessorInfo()}");
                    break;

                case "3":
                    Console.WriteLine($"\u001b[1mComputer system product information: \n\u001b[96m{GetProductInfo()}");
                    break;

                case "4":
                    Console.WriteLine($"\u001b[1mOperating system information: \n\u001b[96m{Get_OS_Info()}");
                    break;

                case "5":
                    Console.WriteLine($"\u001b[1mComputer system information: \n\u001b[96m{GetComputerSystemInfo()}");
                    Console.WriteLine($"\u001b[1mComputer system product information: \n\u001b[96m{GetProductInfo()}");
                    Console.WriteLine($"\u001b[1mOperating system information: \n\u001b[96m{Get_OS_Info()}");
                    Animations.DisplayLoading();
                    Console.WriteLine($"\u001b[1mProcessor information: \n\u001b[96m{GetProcessorInfo()}");
                    break;

                case "exit":
                case "quit":
                    break;

                default:
                    Animations.DisplayAnimation("\u001b[33mInvalid input!");
                    break;
            }
            Animations.DisplayAnimation("\u001b[1mPress any key to go back or [Esc] to go to the main menu");

            var key = Console.ReadKey(true).Key;
            if (key != ConsoleKey.Escape) WMI.GetUserChoice();
            Console.ResetColor();
        }
        public static void GetPowerOption()
        {
            UI.Display_PowerOptions();
            string choice = Console.ReadLine() ?? string.Empty;            
            Console.Clear();
            switch (choice.ToLower())
            {
                case "1":
                    Animations.DisplayBackwardsTimer("Your computer will Shutdown in ", 5);
                    //ShutDown();
                    break;

                case "2":
                    Animations.DisplayBackwardsTimer("Your computer will Restart in ", 5);
                    //Restart();
                    break;

                case "3":
                    Animations.DisplayBackwardsTimer("Your computer will Hibernate in ", 5);
                    //HibernateComputer();
                    break;

                case "4":
                    Animations.DisplayBackwardsTimer("Your computer will Sleep in ", 5);
                    //SleepComputer();
                    break;

                case "exit":
                case "quit":
                    break;

                default:
                    Console.Write("\u001b[91mInvalid input! try again in \u001b[0m");
                    _ = Console.ReadKey(true); // Wait for key press and ignore
                    GetPowerOption();
                    break;
            }
        }
        private static string GetComputerSystemInfo()
        {
            string something = "\u001b[96m";/*Cyan*/
            ManagementObjectSearcher Searcher = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");

            foreach (ManagementObject obj in Searcher.Get())
            {
                something += $"{"Computer Name:",-20} {obj["Name"]}\n";
                something += $"{"Domain:",-20} {obj["Domain"]}\n";
                something += $"{"Model:",-20} {obj["Model"]}\n";
            }
            return something + "\u001b[0m";
        }
        private static string GetProcessorInfo()
        {
            ManagementObjectSearcher cpu = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");

            string info = "\u001b[93m"; // Color
            foreach (ManagementObject obj in cpu.Get())
            {
                info += $"Number of Cores: {obj["NumberOfCores"]}";
            }
            return info + "\u001b[0m\n"; // Reset colors
        }
        private static string GetProductInfo()
        {
            string info = "\u001b[93m"; // Color 
            ManagementObjectSearcher os = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystemProduct");

            foreach (ManagementObject obj in os.Get())
            {
                info += $"{"Manufacturer:",-20} {obj["Vendor"]}\n";
                info += $"{"UUID:",-20} {obj["UUID"]}\n";
                info += $"{"Name:",-20} {obj["Name"]}\n";
                info += $"{"Identifying Number:",-20} {obj["IdentifyingNumber"]}\n";
            }
            return info + "\u001b[0m"; // Reset colors
        }
        private static string Get_OS_Info()
        {
            string info = "\u001b[36m";
            ManagementObjectSearcher os = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");

            foreach (ManagementObject obj in os.Get())
            {
                info += $"{"Name:",-20}{obj["Caption"]}\n";
                info += $"{"Version:",-20}{obj["Version"]}\n";
                info += $"{"Manufacturer:",-20}{obj["Manufacturer"]}\n";
                info += $"{"Windows Directory:",-20}{obj["WindowsDirectory"]}\n";
            }
            return info + "\u001b[0m";
        }
        private static void RestartComputer() // Very problematic, Destroyed my display settings and driver
        {
            ManagementObjectSearcher os = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");

            foreach (ManagementObject obj in os.Get())
            {
                obj.Scope.Options.EnablePrivileges = true;
                obj.InvokeMethod("Reboot", null);
            }
        }
        private static void ShutDownComputer() // Very problematic, Destroyed my display settings and driver
        {
            ManagementObjectSearcher os = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");

            foreach (ManagementObject obj in os.Get())
            {
                obj.Scope.Options.EnablePrivileges = true;
                obj.InvokeMethod("Shutdown", null);
            }
        }
        private static void SleepComputer()
        {
            try
            {
                SetSuspendState(false, true, true);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Sleeping Computer: { ex.Message}");
            }
            
        }
        private static void HibernateComputer()
        {
            try
            {
                SetSuspendState(true, true, true);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Hibernating Computer: {ex.Message}");
            }
        }
        private static void ShutDown()
        {
            try
            {
                Process.Start("shutdown", "/s /t 0"); // Shutdown immediately
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error shutting down computer: {ex.Message}");
            }
        }
        private static void Restart()
        {
            try
            {
                Process.Start("shutdown", "/r /t 0"); // Restart immediately
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error restarting computer: {ex.Message}");
            }
        }        
    }
}