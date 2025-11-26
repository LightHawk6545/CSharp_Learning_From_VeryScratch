using System;
using System.Net.Http;

namespace Mobin_learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameSuggestion();
            GameStarts();
        }

        // string empty, and equal function practice.

        static void GameSuggestion()
        {
            Say("Mobin", "Hey coco come here");
            Hold();

            Console.ForegroundColor = ConsoleColor.Green;
            Scene("Coco comes down the stairs with excitment");
            Console.ResetColor();
            Hold();

            Say("Coco", "Yes what's up mobin?");
            Say("Mobin", "Lets do a guessing game!!");
            Hold();

            Say("Coco", "Awesome how do we play?");
            Say("Mobin", "So basically you say a word with hints and i try to guess it.");
            Hold();

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;
            Scene("Mobin pauses");
            Console.ResetColor();
            Hold();

            Say("Mobin", "And... we both get a prize for playing");
            Say("Coco", "Hooray, that's what i wanted to hear!");
            Hold();

        }

        static void GameStarts()
        {

            Say("Mobin", "here we begin!");
            Hold();

            Say("Mobin", "Whats an animal that's mostly brown, very large and it starts with Be..");

            string guessOne = Console.ReadLine();

            while (!guessOne.Equals("Bear"))
            {
                Say("Mobin", "Not correct, maybe you're missing something");
                guessOne = Console.ReadLine();
            }

            Say("Mobin", "Well done coco!!");
            Hold();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Scene("Coco prepares for his turn");
            Console.ResetColor();
            Hold();

            Say("Coco", "Okay my turn now");
            Hold();

            Say("Coco", "Whats an animal in the jungle and it starts with Li..");

            string guessTwo = Console.ReadLine();

            while (guessTwo.Equals(string.Empty) || !guessTwo.Equals("Lion"))
            {
                Say("Coco", "Nope mobin thats not it.");
                guessTwo = Console.ReadLine();

            }

            Console.WriteLine();
            Say("Coco", "Hooray well done!");
            Hold();

            Console.ForegroundColor = ConsoleColor.White;
            Scene("Coco waiting with excitment");
            Console.ResetColor();
            Hold();

            Say("Mobin", "I know that look coco");
            Say("Mobin", "The prize is a hot warm milk with cinammon!!");
            Hold();

            Say("Coco", "Yay Thank you!");
            Hold();
        }

        static void Hold()
        {
            Console.ReadLine();
        }

        static void Say(string speaker, string text, ConsoleColor? color = null)
        {
            if (color != null) Console.ForegroundColor = color.Value;
            Console.WriteLine($"[{speaker}] {text}");
            Console.ResetColor();
        }

        static void Scene(string scene)
        {
            Console.WriteLine($"* {scene} *");
        }

    }
}
