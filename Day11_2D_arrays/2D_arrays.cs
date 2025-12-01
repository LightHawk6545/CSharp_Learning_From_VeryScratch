using System;
using System.CodeDom;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Xml.Schema;

namespace Mobin_learning
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CocoGoesJungle();
            InTheJungle();
        }

        private const string coco = "coco";
        private const string mobin = "mobin";

        private static void CocoGoesJungle()
        {
            Say(mobin, "Hey coco.");
            Say(coco, "oh hey mobin");
            Hold();

            Say(mobin, "im gonna do something today wanna try?");
            Say(coco, "sure why not, what is it?");
            Hold();

            Scene("mobin smiles and looks at coco", ConsoleColor.Magenta);

            Say(mobin, "im going to the jungle today");
            Hold();

            Say(coco, "wow what, why?");
            Hold();

            Say(mobin, "well every few weekends like now you've seen me go out...");
            Say(mobin, "i've been planting trees, you can help if you want!");
            Hold();

            Say(coco, "sure I'd love to!");
            Hold();

            Drama("And like this they were off to the jungle on a sunday morning.", ConsoleColor.DarkYellow);
            Hold();
        }

        private static void InTheJungle()
        {
            Scene("half an hour later they arrived at the jungle", ConsoleColor.White);
            Hold();

            Say(mobin, "okay coco we arrived at the jungle");
            Say(mobin, "the plan is to plant total of 6 trees in 4 areas today");
            Hold();

            Say(coco, "Alright! we have south, north, east and west of jungle");
            Say(coco, "we will manage it!");
            Hold();

            Say(mobin, "Okay here we are at the south");
            Say(mobin, "plant one here and one there.");
            Hold();

            int totalTrees = TreeCalculation();
            totalTrees -= 2;

            Say(coco, "Mobin i did it!! i planted 1 tree");
            Say(mobin, $"good job coco now we have {totalTrees} left");
            Hold();

            Drama("They moved to west of jungle", ConsoleColor.White);
            Hold();

            Scene("coco slips and falls on the ground.");
            Console.WriteLine();

            Say(mobin, $"Oh no {coco} are you okay?");
            Say(coco, "yes i am, it is jut a scratch");
            Hold();

            Say(mobin, "okay good, get some rest i'll do your turn");
            Say(mobin, "we will have 2 left by east and north");
            Hold();

            Say(mobin, $"All good west done now what left are {totalTrees}");
            Say(coco, "Hooray mobin, lets get done.");
            Hold();

            Drama("and then they move to east and north finishing 2 hours of work", ConsoleColor.Yellow);
            Hold();

            totalTrees -= 4;

            Scene($"They arrive home with {totalTrees} trees undone, they have planted it all", ConsoleColor.Cyan);
            Hold();

            Say(coco, "hey mobin have i ever told you about my favorite tree?");
            Say(mobin, "wow that's actually new, you never really told me");
            Hold();

            Scene("Coco looking at mobin with a smirk", ConsoleColor.Magenta);
            Hold();

            Say(coco, "i have 3 favorites, pine, apple and another one. which you're gonna guess.");
            Hold();

            Say(coco, "well you already know the first two");
            Hold();

            Say(coco, "pine tree, and apple tree. they are amazing trees");
            Say(coco, "third is even better, can you guess?");
            Hold();

            Say(coco, "Well it is quite easy to be blunt.");
            Say(mobin, "oh wow im excited to guess");
            Hold();

            Say(coco, "Alright it is those two trees mixed together, hint: pineap.. tree");
            Hold();

            Say(coco, "it should be easy now, go ahead and guess:");

            GuessCocoTree();

            Say(coco, "Glad you guessed it mobin");
            Say(coco, "Well now you know... i love the fruit aswell.");
            Hold();

            Say(mobin, "Thank you for telling me");
            Say(coco, "you're welcome.");
            Hold();

            Say(coco, "mobin want some tea?");
            Say(mobin, "yes please.");
            Hold();

            Drama("See you!", ConsoleColor.White);
            Hold();
        }

        private static int TreeCalculation()
        {
            string[] cocoFavoriteTree = { "pine", "apple", "" };
            cocoFavoriteTree[2] = cocoFavoriteTree[0] + cocoFavoriteTree[1];

            int[,] treesPlanted = new int[2, 2];
            treesPlanted[0, 0] = 1;
            treesPlanted[0, 1] = 1;
            treesPlanted[1, 0] = 2;
            treesPlanted[1, 1] = 2;

            int total = 0;

            for (int r = 0; r < 2; r++)
                for (int c = 0; c < 2; c++)
                {
                    total += treesPlanted[r, c];
                }

            return total;
        }

        private static void GuessCocoTree()
        {
            string mobinGuess = Console.ReadLine().Trim().ToLower();

            while (mobinGuess != "pineapple" || string.IsNullOrEmpty(mobinGuess))
            {
                Say(coco, "no mobin, that's not it. its the easiest guess ever.");
                Say(coco, "try again...");
                Console.WriteLine();
                mobinGuess = Console.ReadLine().Trim().ToLower();
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

        private static void Say(string speaker, string text, ConsoleColor? color = null)
        {
            speaker = Capitalize(speaker);
            text = Capitalize(text);

            if (color != null) Console.ForegroundColor = color.Value;
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
                Thread.Sleep(55);
            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}