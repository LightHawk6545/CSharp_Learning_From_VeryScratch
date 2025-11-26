using System;

namespace Mobin_learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CocoColorPallete();
            HelpingCoco();
        }

        static void CocoColorPallete()
        {
            Say("Coco", "Hello mobin what do you think of my new color pallete?");
            Hold();

            Say("Mobin", "Wow it is marvelous, did you do it yourself?");
            Say("Coco", "Absloutely, but you know im missing something.");
            Hold();

            Say("Mobin", "Oh what it is it?");
            Say("Coco", "You know i need to type each hex infront its own color.");
            Hold();

            Say("Coco", "I don't have time for that can you concatenate it for me?");
            Say("Mobin", "Easy work coco leave it to me.");
            Hold();
        }

        static void HelpingCoco()
        {
            Say("Mobin", "Alright i'll sort the colors and type the hex for you");
            Hold();

            Say("Coco", "Okayy");
            Hold();

            string palleteOne = "Iris spring";
            string hexOne = "D3D1E0";

            string palleteTwo = "Pastel red";
            string hexTwo = "FF746C";

            string palleteThree = "Pastel blue";
            string hexThree = "B3EBF2";

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(string.Concat("Your first color will be ", palleteOne, " and the hex is ", hexOne));
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(string.Concat("Second Color is ", palleteTwo, " and its hex is ", hexTwo));
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(string.Concat("Third Color is ", palleteThree, " and its hex is ", hexThree));
            Console.ResetColor();
            Hold();

            Say("Mobin", "All done.");
            Hold();

            Say("Coco", "Thank you mobin.");
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
