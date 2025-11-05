using System;

namespace Operating_Systems_Console
{
    internal class UI
    {
        public static void Display_EntryUI()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string word =
@" _____                                                         _____ 
( ___ )                                                       ( ___ )
 |   |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|   | 
 |   |   ___                            _    _                 |   | 
 |   |  / _ \  _ __    ___  _ __  __ _ | |_ (_) _ __    __ _   |   | 
 |   | | | | || '_ \  / _ \| '__|/ _` || __|| || '_ \  / _` |  |   | 
 |   | | |_| || |_) ||  __/| |  | (_| || |_ | || | | || (_| |  |   | 
 |   |  \___/ | .__/  \___||_|   \__,_| \__||_||_| |_| \__, |  |   | 
 |   |        |_|                                      |___/   |   | 
 |   |      ____               _                               |   | 
 |   |     / ___|  _   _  ___ | |_  ___  _ __ ___   ___        |   | 
 |   |     \___ \ | | | |/ __|| __|/ _ \| '_ ` _ \ / __|       |   | 
 |   |      ___) || |_| |\__ \| |_|  __/| | | | | |\__ \       |   | 
 |   |     |____/  \__, ||___/ \__|\___||_| |_| |_||___/       |   | 
 |   |             |___/                                       |   | 
 |___|~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|___| 
(_____)                                                       (_____)";

            Animations.DisplayAnimatedAsciiArt(word);
            Console.ResetColor();
            Console.WriteLine("[1] File Writer.");
            Console.WriteLine("[2] File Reader.");
            Console.WriteLine("[3] Folder Monitor.");
            Console.WriteLine("[4] StopWatch Timer.");
            Console.WriteLine("[5] Windows Management Instrumentation.");
            Console.WriteLine("[6] Power Options.");
            Console.WriteLine("[7] Help Menu.");
            Console.Write("Choose: ");
        }
        public static void Display_FileWriting()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            string word =
@" _____                                                          _____ 
( ___ )                                                        ( ___ )
 |   |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|   | 
 |   |  _____  _  _        __        __      _  _               |   | 
 |   | |  ___|(_)| |  ___  \ \      / /_ __ (_)| |_  ___  _ __  |   | 
 |   | | |_   | || | / _ \  \ \ /\ / /| '__|| || __|/ _ \| '__| |   | 
 |   | |  _|  | || ||  __/   \ V  V / | |   | || |_|  __/| |    |   | 
 |   | |_|    |_||_| \___|    \_/\_/  |_|   |_| \__|\___||_|    |   | 
 |___|~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|___| 
(_____)                                                        (_____)";
            Animations.DisplayAnimatedAsciiArt(word);
            Console.ResetColor();
        }
        public static void Display_FileReading()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            string word =
@" _____                                                            _____ 
( ___ )                                                          ( ___ )
 |   |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|   | 
 |   |  _____  _  _         ____                   _              |   | 
 |   | |  ___|(_)| |  ___  |  _ \  ___   __ _   __| |  ___  _ __  |   | 
 |   | | |_   | || | / _ \ | |_) |/ _ \ / _` | / _` | / _ \| '__| |   | 
 |   | |  _|  | || ||  __/ |  _ <|  __/| (_| || (_| ||  __/| |    |   | 
 |   | |_|    |_||_| \___| |_| \_\\___| \__,_| \__,_| \___||_|    |   | 
 |___|~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|___| 
(_____)                                                          (_____)";
            Animations.DisplayAnimatedAsciiArt(word);
            Console.ResetColor();
        }
        public static void Display_Monitoring()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            string word =
@" _____                                                                               _____ 
( ___ )                                                                             ( ___ )
 |   |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|   | 
 |   |  _____       _      _               __  __                _  _                |   | 
 |   | |  ___|___  | |  __| |  ___  _ __  |  \/  |  ___   _ __  (_)| |_  ___   _ __  |   | 
 |   | | |_  / _ \ | | / _` | / _ \| '__| | |\/| | / _ \ | '_ \ | || __|/ _ \ | '__| |   | 
 |   | |  _|| (_) || || (_| ||  __/| |    | |  | || (_) || | | || || |_| (_) || |    |   | 
 |   | |_|   \___/ |_| \__,_| \___||_|    |_|  |_| \___/ |_| |_||_| \__|\___/ |_|    |   | 
 |___|~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|___| 
(_____)                                                                             (_____)";
            Animations.DisplayAnimatedAsciiArt(word);
            Console.ResetColor();
        }
        public static void Display_StopWatch()
        {
            Console.Clear();
            string word =
@" _____                                                             _____ 
( ___ )                                                           ( ___ )
 |   |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|   | 
 |   |    ____   _              __        __      _         _      |   | 
 |   |   / ___| | |_  ___   _ __\ \      / /__ _ | |_  ___ | |__   |   | 
 |   |   \___ \ | __|/ _ \ | '_ \\ \ /\ / // _` || __|/ __|| '_ \  |   | 
 |   |    ___) || |_| (_) || |_) |\ V  V /| (_| || |_| (__ | | | | |   | 
 |   |   |____/  \__|\___/ | .__/  \_/\_/  \__,_| \__|\___||_| |_| |   | 
 |   |                     |_|                                     |   | 
 |___|~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|___| 
(_____)                                                           (_____)";
            Console.WriteLine($"\u001b[34m{word}\n");
            Console.WriteLine("\u001b[35mPress [Esc] to go to the Main screen.");
            Console.WriteLine("Press [Enter] to Start/Pause the timer.");
            Console.WriteLine("Press [R] to restart the timer.\n");
            Console.ResetColor();
        }
        public static void Display_WMI()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            string word =
@" .--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--. 
/ .. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \
\ \/\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ \/ /
 \/ /`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'\/ / 
 / /\                          __        __ _             _                                                  / /\ 
/ /\ \                         \ \      / /(_) _ __    __| |  ___ __      __ ___                            / /\ \
\ \/ /                          \ \ /\ / / | || '_ \  / _` | / _ \\ \ /\ / // __|                           \ \/ /
 \/ /                            \ V  V /  | || | | || (_| || (_) |\ V  V / \__ \                            \/ / 
 / /\                   __  __    \_/\_/   |_||_| |_| \__,_| \___/  \_/\_/  |___/         _                  / /\ 
/ /\ \                 |  \/  |  __ _  _ __    __ _   __ _   ___  _ __ ___    ___  _ __  | |_               / /\ \
\ \/ /                 | |\/| | / _` || '_ \  / _` | / _` | / _ \| '_ ` _ \  / _ \| '_ \ | __|              \ \/ /
 \/ /                  | |  | || (_| || | | || (_| || (_| ||  __/| | | | | ||  __/| | | || |_                \/ / 
 / /\                  |_|  |_| \__,_||_| |_| \__,_| \__, | \___||_| |_| |_| \___||_| |_| \__|               / /\ 
/ /\ \      ___              _                       |___/             _          _    _                    / /\ \
\ \/ /     |_ _| _ __   ___ | |_  _ __  _   _  _ __ ___    ___  _ __  | |_  __ _ | |_ (_)  ___   _ __       \ \/ /
 \/ /       | | | '_ \ / __|| __|| '__|| | | || '_ ` _ \  / _ \| '_ \ | __|/ _` || __|| | / _ \ | '_ \       \/ / 
 / /\       | | | | | |\__ \| |_ | |   | |_| || | | | | ||  __/| | | || |_| (_| || |_ | || (_) || | | |      / /\ 
/ /\ \     |___||_| |_||___/ \__||_|    \__,_||_| |_| |_| \___||_| |_| \__|\__,_| \__||_| \___/ |_| |_|     / /\ \
\ \/ /                                                                                                      \ \/ /
 \/ /                                                                                                        \/ / 
 / /\.--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--./ /\ 
/ /\ \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \/\ \
\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `' /
 `--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--' ";
            Animations.DisplayAnimatedAsciiArt(word);
            Console.ResetColor();

            Console.WriteLine("\u001b[1m[1] Computer system information.");
            Console.WriteLine("[2] Processor information.");
            Console.WriteLine("[3] Computer system product information.");
            Console.WriteLine("[4] Operating system information.");
            Console.WriteLine("[5] All information.\u001b[0m");
            Console.Write("Choose: ");
        }
        public static void Display_PowerOptions()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            string word =
@" .--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--. 
/ .. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \
\ \/\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ \/ /
 \/ /`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'\/ / 
 / /\                                                                                / /\ 
/ /\ \  ____                               ___          _    _                      / /\ \
\ \/ / |  _ \  ___ __      __ ___  _ __   / _ \  _ __  | |_ (_)  ___   _ __   ___   \ \/ /
 \/ /  | |_) |/ _ \\ \ /\ / // _ \| '__| | | | || '_ \ | __|| | / _ \ | '_ \ / __|   \/ / 
 / /\  |  __/| (_) |\ V  V /|  __/| |    | |_| || |_) || |_ | || (_) || | | |\__ \   / /\ 
/ /\ \ |_|    \___/  \_/\_/  \___||_|     \___/ | .__/  \__||_| \___/ |_| |_||___/  / /\ \
\ \/ /                                          |_|                                 \ \/ /
 \/ /                                                                                \/ / 
 / /\.--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--./ /\ 
/ /\ \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \/\ \
\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `' /
 `--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--' ";
            Animations.DisplayAnimatedAsciiArt(word);
            Console.ResetColor();

            Console.Write("\u001b[1m" +
            "[1] ShutDown.\n" +
            "[2] Restart.\n" +
            "[3] Hibernate.\n" +
            "[4] Sleep.\u001b[0m\n" +
            "Choose: ");
        }
        public static void Display_HelpMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            const string word =
@" _____                                                      _____ 
( ___ )                                                    ( ___ )
 |   |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|   | 
 |   |  _   _        _          __  __                      |   | 
 |   | | | | |  ___ | | _ __   |  \/  |  ___  _ __   _   _  |   | 
 |   | | |_| | / _ \| || '_ \  | |\/| | / _ \| '_ \ | | | | |   | 
 |   | |  _  ||  __/| || |_) | | |  | ||  __/| | | || |_| | |   | 
 |   | |_| |_| \___||_|| .__/  |_|  |_| \___||_| |_| \__,_| |   | 
 |   |                 |_|                                  |   | 
 |___|~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|___| 
(_____)                                                    (_____)";
            Animations.DisplayAnimatedAsciiArt(word); // \u001b[96m    <-- Cyan   |   Reset --> \u001b[0m

            

            DisplayMenuItem("File Writer", "Creates a new file (text or binary) and writes content to it");
            DisplayMenuItem("File Reader", "Reads an existing file (text or binary)");
            DisplayMenuItem("Folder Monitor", "Watches what's happening in a folder and reports any of the next:" +
                            "\n  - File/Folder creation." +
                            "\n  - File/Folder deletion." +
                            "\n  - File/Folder change." +
                            "\n  - File/Folder Name change.");
            DisplayMenuItem("StopWatch", "Helps you calculate the time of doing any of the tasks in this list");
            DisplayMenuItem("Windows Management Instrumentation", "A Microsoft framework that allows access," +
                            " management,\n and monitoring of Windows system information and settings");
            DisplayMenuItem("Power Options", "Gives you the ability to Shutdown, Restart, Hibernate, or Sleep you computer");

            const string blue = "\u001b[94m";
            const string red = "\u001b[91m";

            Animations.DisplayAnimation($"Your can write [{blue}exit{red}] or [{blue}quit{red}] to exit any mode");
            Console.ReadKey(true);
        }

        private static void DisplayMenuItem(string header, string text)
        {
            const string cyan = "\u001b[96m";
            const string bold = "\u001b[1m";
            const string resetColor = "\u001b[0m";

            Console.WriteLine($"[{cyan}{bold}{header}{resetColor}]: {text}.\n");
        }
    }
}
