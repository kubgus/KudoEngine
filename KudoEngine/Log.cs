﻿#pragma warning disable IDE1006

namespace KudoEngine
{
    /// <summary>
    /// <see langword="Kudo"/>
    /// A simple good-looking console extension
    /// </summary>
    public class Log
    {
        /// <summary>
        /// Normal Console Log
        /// </summary>
        public static void write(dynamic message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Highlighted Console Log
        /// </summary>
        public static void mark(dynamic message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Warning Console Log
        /// </summary>
         // Naming Styles
        public static void warn(dynamic message)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"[WARN] {message}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Error Console Log
        /// </summary>
        public static void error(dynamic message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[ERR] {message}");
            Console.ReadKey();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
