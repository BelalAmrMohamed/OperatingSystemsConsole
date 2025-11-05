using System;
using System.Diagnostics;
using System.Threading;

namespace Operating_Systems_Console
{
    public class StopWatchTimer
    {
        private static Stopwatch stopwatch = new Stopwatch();
        private static bool stopwatchRunning = false;

        private static void RunLiveTimer()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.CursorVisible = false;
            while (!Console.KeyAvailable)
            {
                Console.Write($"\rTimer: {stopwatch.Elapsed.ToString().Substring(0, 8)} / {stopwatch.ElapsedMilliseconds} ms");
                Thread.Sleep(3);// ex: 00:00:33 / 33012 ms
            }
            Console.ResetColor();
            Console.CursorVisible = true;
        }
        public static void StartTimer(int n)
        {
            Display_StopWatch();
            Console.WriteLine("Press [Esc] to go to the Main screen.");
            Console.WriteLine("Press [Enter] to Pause the timer.");
            Console.WriteLine("Press [R] to restart the timer.\n");

            if (n == 1) stopwatch.Start(); // continue 
            else if (n == 2) stopwatch.Restart(); // restart

            if (!stopwatchRunning)
            {
                stopwatchRunning = true;
                stopwatch.Reset();
                PauseTimer();
            }
            else
            {
                RunLiveTimer();
                ConsoleKey key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.Escape:
                        break;
                    case ConsoleKey.Enter:
                        PauseTimer();
                        break;
                    case ConsoleKey.R:
                        StartTimer(2);
                        break;
                }
            }
        }
        private static void PauseTimer()
        {
            Console.Clear();
            Display_StopWatch();
            Console.WriteLine("Press [Esc] to go to the Main screen.");
            Console.WriteLine("Press [Enter] to Continue the timer.");
            Console.WriteLine("Press [R] to Restart the timer.\n");

            stopwatch.Stop();
            Animations.DisplayAnimation($"\rTimer: {stopwatch.Elapsed.ToString().Substring(0, 8)} / {stopwatch.ElapsedMilliseconds} ms");
            //stopwatchRunning = false;

            ConsoleKey key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.Escape:
                    break;
                case ConsoleKey.Enter:
                    StartTimer(1);
                    break;
                case ConsoleKey.R:
                    stopwatchRunning = false;
                    StartTimer(2);
                    break;
                default:
                    break;
            }
        }
        private static void Display_StopWatch()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
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
            Console.WriteLine(word);
            Console.ResetColor();
        }
    }
}
