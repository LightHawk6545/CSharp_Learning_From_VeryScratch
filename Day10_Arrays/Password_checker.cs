using System;
using System.Threading;

namespace Mobin_learning
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            {
                Password();
            }
        }

        private const string system = "system checker";

        private static void Password()
        {
            string password = "";
            string passwordConfirm = "";

            while (true)
            {
                Say(system, "welcome to password creation wizard", ConsoleColor.White, ConsoleColor.DarkGreen);
                Hold();

                Say(system, "please enter your password:");
                password = Console.ReadLine();

                Say(system, "confirm password:");
                passwordConfirm = Console.ReadLine();

                if (password != passwordConfirm || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(passwordConfirm))
                {
                    if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(passwordConfirm))
                    {
                        Say(system, "you password is empty, try again.");
                        Hold();
                        continue;
                    }
                    else if (password != passwordConfirm)
                    {
                        Say("system", "password doesn't match, try again.");
                        Hold();
                        continue;
                    }
                }
                else if (password == passwordConfirm)
                {
                    Say(system, "password has been set, creating account...");
                    Hold();
                    break;
                }
            }
        }

        private static void Hold()
        {
            Console.ReadLine();
        }

        private static string Capitalize(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return text;

            text = text.Trim();

            return char.ToUpper(text[0]) + text.Substring(1);
        }

        private static void Say(string speaker, string text, ConsoleColor? color = null, ConsoleColor? colorBackground = null)
        {
            speaker = Capitalize(speaker);
            text = Capitalize(text);

            if (color != null) Console.ForegroundColor = color.Value;
            if (colorBackground != null) Console.BackgroundColor = colorBackground.Value;
            Console.WriteLine($"[{speaker}] {text}");
            Console.ResetColor();
        }

        private static void Scene(string scene, ConsoleColor? color = null)
        {
            if (color != null) Console.ForegroundColor = color.Value;
            Console.WriteLine($"* {scene} *");
            Console.ResetColor();
        }

        private static void Dramatic(string drama, ConsoleColor? color = null)
        {
            drama = Capitalize(drama);
            if (color != null) Console.ForegroundColor = color.Value;
            for (int i = 0; i < drama.Length; i++)
            {
                Console.Write($"{drama[i]}");
                Thread.Sleep(55);
            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}