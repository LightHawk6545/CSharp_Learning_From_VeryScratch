using System;

namespace Mobin_learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CocoProblem();
            TeachingCoco();
        }

        // verbatim and escape slash practice.
        static void CocoProblem()
        {
            Say("Coco", "Mobin i am sad.");
            Hold();

            Say("Mobin", "Oh why coco?");
            Say("Coco", "Becasue look at here, i cant seem to make it work.");
            Hold();

            Say("Coco", "I am trying to paste my C drive address but the compiler throws an error on me");
            Say("System", "Error: Unrecognized escape format.", ConsoleColor.DarkYellow);
            Hold();

            Say("Mobin", "Oh my little coco i will help you!");
            Say("Mobin", "In this case you need verbatim or escape slash.");
            Hold();

            Say("Coco", "But mobin... how?");
            Console.WriteLine(@"[Mobin] All you need are these two ""\"" and ""@"" ");
            Hold();
        }

        static void TeachingCoco()
        {
            Say("Mobin", "First if you wish to use backslash, use two, because the compiler reads it as one.");
            Say("Mobin", "Let's use an exmaple adn compile");
            Hold();

            string path = "C:\\users\\Coco\\VisualStudio\\Main_Project\\Desktop";

            Say("Mobin", "Compiler i command you to write it correctly!...");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"[System] {path}");
            Console.ResetColor();
            Hold();

            Say("Coco", "wow it worked!!");
            Hold();
            Say("Mobin", "Now watch this.");
            Hold();

            string message = " \"Coco\" see \"system\" using double quotation too";
            Console.WriteLine(message, Console.ForegroundColor = ConsoleColor.DarkMagenta);
            Console.ResetColor();
            Hold();

            Say("Coco", "Actually i feel problem solved right now!!, by the way what was @ for?");
            Hold();

            Say("Mobin", "I was just about to get there");
            Say("Mobin", "It makes your life easier by printing everything as a literal string");
            Hold();

            Say("Mobin", "And the best is you can combine it with string interpolation, see.");
            Hold();

            Console.WriteLine($@"You can use it with interpolation while ignoring backslashes, \n \t \\.",
            Console.ForegroundColor = ConsoleColor.DarkCyan);
            Console.ResetColor();
            Hold();

            Say("Coco", "Thank you mobin, i couldn't have done it without you.");
            Say("Mobin", "You're very welcome coco.");
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
