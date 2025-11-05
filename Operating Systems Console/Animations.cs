using System;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace Operating_Systems_Console
{
    internal class Animations
    {
        private static int counter = 0;
        private static Random _random = new Random(); 
        public static void DisplayAnimation(string text)
        {
            Console.CursorVisible = false;
            string[] frames = { $"{text}   ", $"{text}.  ", $"{text}.. ", $"{text}..." };
            int frameIndex = 0;

            while (!Console.KeyAvailable)
            {
                // Display animation
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"\r{frames[frameIndex]}");
                Console.ResetColor();

                frameIndex = (frameIndex + 1) % frames.Length;
                Thread.Sleep(300);
            }

            Console.CursorVisible = true;
        }
        public static void DisplayBackwardsTimer(string text, int seconds)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.CursorVisible = false;
            for(int i = seconds; i >= 0; i--) // i = 5
            {
                Console.Write($"\r{text}{i}");  
                Thread.Sleep(1000);
            }
            Console.ResetColor();
            Console.CursorVisible = true;
        }
        public static void DisplayLoading()
        {
            Console.CursorVisible = false;
            string[] frames = { $"Loading   ", $"Loading.  ", $"Loading.. ", $"Loading..." };
            int frameIndex = 0;

            while (frameIndex < frames.Length)
            {
                // Display animation
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"\r{frames[frameIndex]}");
                Console.ResetColor();

                frameIndex++;
                Thread.Sleep(300);
            }

            Console.CursorVisible = true;
        }
        public static void DisplayAnimatedAsciiArt(string ascii)
        {
            //Console.WriteLine(ascii + "\n");
            switch ((counter++ % 4) + 1) // The counter counts from 1 to 4
            {                
                case 1: AnimateSlideFromLeft(ascii); break; // ok
                case 2: AnimateSlideFromRight(ascii); break; // Good one
                case 3: AnimateRevealFromCenter(ascii); break; // Best one
                case 4: AnimateWaveEffect(ascii); break; // beautiful and colorful
            }
            // **Temporarily disabled animations**
        }        

        // Animation 1: Slide from Left
        static void AnimateSlideFromLeft(string ascii)
        {
            string[] lines = ascii.Split('\n');
            int maxLength = 0;
            foreach (string line in lines)
                if (line.Length > maxLength) maxLength = line.Length;

            for (int offset = maxLength; offset >= 0; offset -= 2)
            {
                if (CheckSkip(ascii)) return;
                Console.Clear();
                foreach (string line in lines)
                {
                    if (offset < line.Length)
                        Console.WriteLine(line.Substring(offset));
                    else
                        Console.WriteLine();
                }
                Thread.Sleep(50);
            }
            Console.WriteLine("\n");
        }

        // Animation 2: Slide from Right
        static void AnimateSlideFromRight(string ascii)
        {
            string[] lines = ascii.Split('\n');
            int maxLength = 0;
            foreach (string line in lines)
                if (line.Length > maxLength) maxLength = line.Length;

            for (int reveal = 1; reveal <= maxLength; reveal += 2)
            {
                if (CheckSkip(ascii)) return;
                Console.Clear();
                foreach (string line in lines)
                {
                    int startPos = Math.Max(0, line.Length - reveal);
                    if (startPos < line.Length)
                        Console.WriteLine(new string(' ', startPos) + line.Substring(startPos));
                    else
                        Console.WriteLine();
                }
                Thread.Sleep(50);
            }
            Console.WriteLine("\n");
        }

        // Animation 3: Reveal from Center
        static void AnimateRevealFromCenter(string ascii)
        {
            string[] lines = ascii.Split('\n');
            int maxLength = 0;
            foreach (string line in lines)
                if (line.Length > maxLength) maxLength = line.Length;

            for (int width = 0; width <= maxLength / 2 + 1; width += 2)
            {
                if (CheckSkip(ascii)) return;
                Console.Clear();
                foreach (string line in lines)
                {
                    int center = line.Length / 2;
                    int start = Math.Max(0, center - width);
                    int end = Math.Min(line.Length, center + width);

                    if (start < end)
                    {
                        string visible = line.Substring(start, end - start);
                        Console.WriteLine(new string(' ', start) + visible);
                    }
                    else
                        Console.WriteLine();
                }
                Thread.Sleep(60);
            }
            Console.WriteLine("\n");
        }

        // Animation 4: Wave Effect
        static void AnimateWaveEffect(string ascii)
        {
            string[] lines = ascii.Split('\n');
            int totalLines = lines.Length;

            for (int wave = 0; wave < totalLines; wave++)
            {
                if (CheckSkip(ascii)) return;
                Console.Clear();

                for (int i = 0; i < lines.Length; i++)
                {
                    if (i <= wave)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(lines[i]);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine(lines[i]);
                    }
                }
                Thread.Sleep(100);
            }

            Console.ResetColor();
            Console.WriteLine("\n");
        }
        
        // Helper: Check if user wants to skip animation
        static bool CheckSkip(string ascii)
        {
            if (Console.KeyAvailable)
            {
                _ = Console.ReadKey(true);
                CleanAndPrint(ascii);
                return true;
            }
            return false;
        }

        // Helper: Clear and print full ASCII art
        static void CleanAndPrint(string ascii)
        {
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine(ascii);
            Console.WriteLine("\n");
        }
    }
}
