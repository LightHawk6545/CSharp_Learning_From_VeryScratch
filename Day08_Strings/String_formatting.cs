using System;

namespace Mobin_learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderFood();
        }

        // String formatting practice
        static void OrderFood()
        {
            Say("Mcdonalds", "Hello this is mcdonalds what is your order", ConsoleColor.Magenta);
            Hold();

            Say("Mobin", "Hello can i have two iced coffees, a soda, 2 chesse burgers with extra cheese and mayo please.");
            Say("Mcdonalds", "Please hang on im writing your order", ConsoleColor.Magenta);
            Hold();

            string order = "cheese burgers with extra cheese";
            int amountOfOrder = 2;

            string drinks = "iced coffees and a soda";
            int amountOfDrinks = 3;

            string extras = "mayo";
            int price = 15;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("[Mcdonalds] Alright so you ordered \n{0} {1}, {2} drinks which are {3} and extra {4}. Is that correct?",
                amountOfOrder, order, amountOfDrinks, drinks, extras);
            Console.ResetColor();
            Hold();

            Say("Mobin", "Yes that is correct.");
            Hold();

            Console.WriteLine("[Mcdonald] that will be {0} dollars please come to window to recieve order.", price);
            Hold();

            Say("Mobin", "Thank you very much");
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
