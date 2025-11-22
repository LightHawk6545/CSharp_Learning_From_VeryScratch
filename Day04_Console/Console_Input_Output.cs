using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mobin_learning
{
    internal class Program
    {
        private static object coco;

        static void Main(string[] args)
        {
            // This session is dedicated for practicing console input and output


            Console.WriteLine("mobin: come here take the shopping list put two extra items if you want: ");
            Console.WriteLine(" ");
            Console.WriteLine("Press Enter again and then add your desireable items ... ");
            Console.ReadLine();


            string item_1 = Console.ReadLine();
            string item_2 = Console.ReadLine();
            const int pin = 3342;
            int Receipt_Code = 435376;

            Console.WriteLine(" ");


            Console.WriteLine("Okay so for the list you want me to get, " + item_1 + " first and then " + item_2 + " right?, leave it to me.");
            Console.ReadLine();


            Console.WriteLine("Oh also i could get your favorite snack, what was the name again? ");
            Console.WriteLine("Enter your favorite snack's name... "); string Ask_Favorite = Console.ReadLine();
            Console.WriteLine("Oh yes so it is... " + Ask_Favorite + " Sure i'll get it for you");
            Console.ReadLine();


            Console.WriteLine("Clerk: Hello mobin do you wanna pay for those items aswell? i'll put them for you in one list");
            Console.ReadLine();
            Console.WriteLine("Oh yes please");
            Console.WriteLine("The items are " + item_1 + " " + item_2 + " " + Ask_Favorite + " That's all, it will be 59.99$");
            Console.ReadLine();


            Console.WriteLine("Please insert your pin and receipt code all at once");
            Console.ReadLine();


            Console.Write("Sure ");
            Console.Write(pin);
            Console.Write(", That is my pin, ");
            Console.Write(Receipt_Code);
            Console.WriteLine("And the following is my receipt code");


            Console.WriteLine("Clerk: Thank you, please rate our service if you would like...");
            Console.WriteLine("Enter your rating from 5 stars: ");
            Console.ReadLine();

            int rate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your rating out of 5 was... " + rate + " stars. Thank you for helping us grow.");


        }
    }
}
