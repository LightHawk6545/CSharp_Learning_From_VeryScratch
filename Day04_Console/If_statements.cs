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
            // this section is about practicing my exposure to "if" and conditional statements
            //i'll practice using a guest story


            int guests = 0;
            double time = 5;

            string greeting = "your welcome, we are more than glad to have you.";
            string greeting_1 = "please make yourself comfortable, we have a seat right there";

            Console.WriteLine("ALRIGHT MOBIN!!!, do we the guests here for dinner?");
            Console.ReadLine();

            Console.WriteLine("Not yet, but i can check for you!");
            Console.ReadLine();

            Console.WriteLine("Yes that is amazing, i'll count on you then, they should all be here at 8 pm");
            Console.WriteLine();
            Console.ReadLine();


            if (guests <= 0 && time >= 5)
            {
                Console.WriteLine("mobin: no one seem to come so early at 5 pm"); Console.ReadLine();
                Console.WriteLine("maybe i should come an hour later, i can do some preparation meanwhile.");
                Console.ReadLine();
                time++;
            }


            if (time == 6)
            {
                Console.WriteLine("An hour later..., time: " + time + "pm.");
                Console.ReadLine();

                Console.WriteLine("*Door bell rang*");
                Console.ReadLine();

                ++guests;

                Console.WriteLine("mobin: OH we have " + guests + " guest by the door, i'll be opening");
                Console.ReadLine();

                Console.WriteLine(greeting + ", just about great timing, henry.");
                ++time;
            }


            Console.WriteLine("so henry what kind of drink would you just tell me any number from 1 to 3, i'll serve you!");
            Console.ReadLine();

            Console.WriteLine("henry: thank you mobin let me see what you have, i like the diversity here");
            Console.ReadLine();


            Console.WriteLine("I choose:");
            Console.WriteLine("*choose now");
            int choice = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine();

            if (choice == 1)
            {
                Console.WriteLine("mobin: marvelous choice we have the best wines over here, please let me pour some, special for you.");
                Console.ReadLine();

            }


            else if (choice == 2)
            {
                Console.WriteLine("Oh beer is a delight in this cold weather, right away!");
                Console.ReadLine();
            }


            else if (choice == 3)
            {
                Console.WriteLine("sure i'll have you some cold water now");
                Console.ReadLine();
            }


            else
            {
                Console.WriteLine("sorry, i dont think we have that right now.");
                Console.ReadLine();

                Console.WriteLine("would you like to reconsider choices? ");
                Console.ReadLine();

                Console.WriteLine("I'll come back later in case you're not sure yet.");
                Console.ReadLine();

            }


            guests++;
            Console.WriteLine("*Door bell rang again*");
            Console.WriteLine("Finally our last guest is here");
            Console.ReadLine();

            if (guests == 2 && time >= 7)
            {
                Console.WriteLine("coco has arrived!");
                Console.ReadLine();
                Console.WriteLine("I'll serve dinner and ask both if they need anything");
                Console.ReadLine();

            }
        }
    }
}
