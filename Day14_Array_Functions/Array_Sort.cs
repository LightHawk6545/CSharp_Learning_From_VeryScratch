using System;
using System.Linq;
using System.Threading;

namespace Mobin_learning
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CocoScores();
        }

        private const string coco = "coco";
        private const string mobin = "mobin";

        private static int[] cocoSchoolScores = new[] { 9, 20, 5, 15, 18, 14, 15 };

        //Array.Clear(numbers);
        //Array.Sort();
        //Array.Reverse();
        private static void CocoScores()
        {
            Say(mobin, "Hey coco good morning, oh what are you doing?");
            Hold();

            Say(coco, "mobin i can't do it....");
            Say(coco, "i want to sort my school scores but they are too messed up");
            Hold();

            Say(mobin, "where and how are they arranged, i feel like i can help");
            Say(coco, "mobin they are arranged in an array");
            Hold();

            Say(mobin, "okay give it to me i'll help you out");
            Say(coco, "Thank you mobin!!");
            Hold();

            CocoArraySort();

            Say(mobin, "alright coco this is done good for you");
            Say(mobin, "the scores look kinda not bad by the way.");
            Hold();

            Say(coco, "now mobin how do i see the sorted numbers again?");
            Say(mobin, "dont worry i will show you now");
            Hold();

            Say("System Viewer", "Coco Scchool Scores:", ConsoleColor.DarkRed);
            ShowCocoScore();
            Hold();

            Say(coco, "mobin can you do something else too?");
            Say(mobin, "absloutely coco, what can i do?");
            Hold();

            Say(coco, "i know it might be hard but i want to sort them from descending");
            Say(mobin, "Thats as easy as it gets coco, just watch");
            Hold();

            CocoScoresDescending();

            Say(mobin, "now it should be just fine, lets see");
            Say(coco, "yes lets see");
            Hold();

            Say("System Viewer", "Coco Scchool Scores:", ConsoleColor.DarkRed);
            ShowCocoScore();
            Hold();

            Say(coco, "wow that's just awesome mobin");
            Say(mobin, "now i'll show one last thing");
            Hold();

            Say(mobin, "since i know you want to reuse the array later...");
            Say(mobin, "you can also clear its elements as well!");
            Hold();

            Say(mobin, "watch this");
            Hold();

            CocoScoresClear();

            Say("System Viewer", "Coco Scchool Scores:", ConsoleColor.DarkRed);
            ShowCocoScore();
            Hold();

            Say(mobin, "see they are back to default values");
            Say(coco, "thank you, you've helped me a lot today.");
            Hold();

            Say(mobin, "You're welcome");
            Hold();
        }

        private static void CocoArraySort()
        {
            Array.Sort(cocoSchoolScores);
        }

        private static void ShowCocoScore()
        {
            for (int i = 0; i < cocoSchoolScores.Length; i++)
            {
                Console.Write($"{cocoSchoolScores[i]} ");
                Thread.Sleep(100);
            }
        }

        private static void CocoScoresDescending()
        {
            Array.Reverse(cocoSchoolScores);
        }

        private static void CocoScoresClear()
        {
            Array.Clear(cocoSchoolScores, 0, 3);
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

        private static void Drama(string drama, ConsoleColor? color = null)
        {
            drama = Capitalize(drama);
            if (color != null) Console.ForegroundColor = color.Value;
            for (int i = 0; i < drama.Length; i++)
            {
                Console.Write($"{drama[i]}");
                Thread.Sleep(48);
            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}