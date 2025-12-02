using System;
using System.Linq;
using System.Threading;

namespace Mobin_learning
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            GameBegins();
            TheMainEntrance();
            TheSeperationHall();
        }

        private const string coco = "coco";
        private const string mobin = "mobin";

        private static void GameBegins()
        {
            Drama("It was a rainy midnight at a lush rocky jungle...", ConsoleColor.Red);
            Hold();

            Say(mobin, "COCO take cover the pterodactyl is attacking us!!!!!");
            Say(coco, "MOBIN give me your firesword i'll take it down.");
            Hold();

            Drama("It was then that coco spinned the pterodactyl on a tree and...", ConsoleColor.Magenta);
            Hold();

            Say(coco, "Mobin.....!!!!");
            Hold();

            Say(mobin, "coco did you get him? coco??? are you there?");
            Hold();

            Scene(" ... ", ConsoleColor.DarkMagenta);
            Hold();

            Say(coco, "mobin i got him!", ConsoleColor.Red);
            Console.WriteLine();

            Say(mobin, "oh coco, im glad you're okay, but... you're injured.");
            Hold();

            Say(coco, "Im okay it is just a scratch, we need to get to the dungeon.");
            Say(mobin, "You're right we came all the way to this place, we can't give up.");
            Hold();

            Scene("They go past the sharp rocks and the unbearable mud to get to the ... dungeon.", ConsoleColor.Green);
            Hold();

            Say(mobin, "I can see some unnatural light illuminating from afar...");
            Say(coco, "mobin it is raining too hard, i can barely see anything");
            Hold();

            Say(mobin, "im pretty sure, i feel like we're closer");
            Say(coco, "i can feel a weird energy, i can trust your instinct");
            Hold();

            Say(mobin, "lets go i'll hold the fenrir lamp, its the most useful tool here", ConsoleColor.Cyan);
            Say(coco, "yes it illumnates even when raining.");
            Hold();

            Drama("Soon they arrive to the great entrance.", ConsoleColor.Yellow);
            Hold();

            Scene(" The Great entrance was emittng immense power ", ConsoleColor.Yellow);
            Hold();

            Say(coco, "mobin this door is too strong, its giving me headache.");
            Say(mobin, $"coco this place is called {dungeonDirections[0]}");
            Hold();

            Say(mobin, @"It has been sealed with two ""varin"" mark", ConsoleColor.DarkRed);
            Say(mobin, "The ancient magical marks used to seal mythic creature");
            Hold();

            Say(mobin, "i feel like you have a guess how strong this place is");
            Say(coco, "i do, it is terrifying, but... we will manage it.");
            Hold();
        }

        private static void TheMainEntrance()
        {
            Say(mobin, "We cannot break this seal, we can temporarily turn it off tho.");
            Say(mobin, "with this, starblood dagger.");
            Hold();

            Say(coco, "yeah that means,... this dagger is not strong, so if we go in...");
            Say(mobin, "yes... we will be locked inside", ConsoleColor.Red);
            Hold();

            Drama("mobin then does a special move to unleash the starblood dagger.", ConsoleColor.Green);
            Hold();

            Scene("He stabs the seal to open the doors for a few seconds.", ConsoleColor.DarkBlue);
            Hold();

            Say(mobin, "the dagger broke, now is our chance, lets go now!");
            Say(coco, "im on it!");

            Scene("They jumped inside... and the door closed", ConsoleColor.DarkGreen);
            Hold();

            Say(mobin, "wow im surprised");
            Say(coco, "me too, i've never thought i would find so many fenrir lamps in here");
            Hold();

            Say(mobin, "looks menancing... i will analyze this area, groans are common here");
            Say(coco, "you can take your firesword, i can use my icesword now, its the only thing we have here.");
            Hold();

            Say(mobin, "although there are fenrir lamps here but they look mucher dimmer");
            Say(coco, "mobin... i think i see something lurking there");
            Hold();

            Scene("Suddenly the lurking glow in the dark, rages and attacks", ConsoleColor.DarkRed);
            Hold();

            Say(mobin, "be careful Coco! its a groan");
            Hold();

            Drama("Coco freezes the groan with ice and they move carefully", ConsoleColor.Cyan);
            Hold();

            dungeonIntel[0, 0] -= 1;

            Say(mobin, "well done coco, its frozen now");
            Say(mobin, $"based on my calculations there are {dungeonIntel[0, 0]} groans left");
            Hold();

            Scene("right when he was speaking he unleashed firesword and stabbed backwards", ConsoleColor.DarkRed);
            Console.WriteLine();

            dungeonIntel[0, 0] -= 1;

            Say(coco, $"now that leaves {dungeonIntel[0, 0]}");
            Say(mobin, "i heard him behind me, lets clear this area's treasures");
            Hold();

            Say(coco, "yeah, we need all the help we can get for the next halls");
            Say(mobin, $"according to my analysis this hall has {dungeonRoomsInHalls[0][0] + dungeonRoomsInHalls[0][1]} rooms", ConsoleColor.DarkYellow);
            Hold();

            Drama(" They spererate and clear both room's goods, defeating the leftover groans", ConsoleColor.Magenta);
            Console.WriteLine();

            Say(mobin, $"i found {dungeonTreasureBags[0][0]} treasure bags here");
            Say(coco, $"my yield was {dungeonTreasureBags[0][1]} treasure bag");
            Hold();

            dungeonIntel[0, 0] -= 2;

            Say(mobin, $"Good there are {dungeonIntel[0, 0]} groans left here, thanks to our swords");
            Hold();
        }

        private static void TheSeperationHall()
        {
            Say(mobin, $"I've read the acient text coco it says this is {dungeonDirections[1]}", ConsoleColor.DarkGreen);
            Say(coco, "i dont like the name");
            Hold();

            Scene("They step foot inside and both of their bodies get stiff on the ground", ConsoleColor.White);
            Console.WriteLine();

            Say("Coco & Mobin", "What is this??", ConsoleColor.DarkMagenta);
            Say(mobin, "i feel like we are under an enormous spell");
            Say(coco, "i cant feel my hands mobin");
            Hold();

            Say("Anonymous voice", "You shall be left alone in the dark.", ConsoleColor.Black, ConsoleColor.White);
            Hold();

            Scene(" Seperation spell has been casted and coco couldn't get close to mobin within 2 meter.", ConsoleColor.White);
            Hold();

            Say(mobin, "oh no, not this evil glow now, the venirs are getting closer.");
            Say(coco, "this is too bad i can't move now and they are...");
            Hold();

            Scene("a venir sets eye on coco who is fallen on the ground.", ConsoleColor.Blue);
            Hold();

            Say(mobin, "they are stronger than groans because of the more starblood essence they have");
            Console.WriteLine();

            Drama("Mobin slowly tries to get up and unleash his sword but a venir jumps on him", ConsoleColor.Blue);
            Hold();

            Say(mobin, "it... has gotten my arm- its injuring me, that's not good...");
            Say(coco, "Ah...");
            Hold();

            Scene("a venir kicked coco to the wall.", ConsoleColor.Red);
            Hold();

            Say(mobin, "Oh no coco!");
            Hold();

            Drama("Mobin finally got up on his feet, kicked the venir and stabbed him with firesword \n and went to save coco but he got repelled", ConsoleColor.Red);
            Hold();

            Say(coco, "mobin behind you!");
            Say(mobin, "got it!, ... okay this one is down too, too bad i can't be close to you");
            Hold();

            dungeonIntel[1, 0] -= 2;

            Scene("coco got up on his feet and started treating himself", ConsoleColor.Blue);
            Hold();

            Say(coco, "i know right. we should keep each other updated from afar.");
            Say(mobin, $"alright, im analyzing this looks like we've got {dungeonRoomsInHalls[1][0] + dungeonRoomsInHalls[1][1] + dungeonRoomsInHalls[1][2]} rooms");
            Hold();

            Say(coco, "okay, i can already sense a strong venir from left side, there is one room i'll go there.");
            Say(mobin, "alright i'll take the right side, in fact i sense 2 venirs there.");
            Hold();

            Scene(" They spereately move into each room", ConsoleColor.Magenta);
            Hold();

            dungeonIntel[1, 0] -= 3;

            Say(mobin, "Take that venir, and give me your treasure.");
            Say(coco, "ah these creatures are vulnerable to ice, good thingm i will take the bags from here.");
            Hold();

            Say(coco, "how was the yield mobin?");
            Say(mobin, $"great i found {dungeonTreasureBags[1][0] + dungeonTreasureBags[1][1]} treasure bags");
            Hold();

            Say(coco, $"that's actually good i found {dungeonTreasureBags[1][2]} treasure bags");
            Hold();

            Say(mobin, "the spell is coming off too, well everything compared together");
            Say(mobin, $"the total danger level was {dungeonIntel[0, 2] + dungeonIntel[1, 2]}");
            Hold();

            int totalRooms = 0;

            foreach (int[] halls in dungeonRoomsInHalls)
            {
                foreach (int room in halls)
                    totalRooms += room;
            }

            Say(coco, $"and total of {dungeonIntel[0, 1] + dungeonIntel[1, 1]} bags in {totalRooms} rooms");
            Say(mobin, "we call it a day and go back home, we will explore the rest later...");
            Hold();

            Say(coco, "yes lets the shortcut");
            Say(mobin, "it was a great adventure");
            Hold();

            Drama("To be continued...", ConsoleColor.DarkYellow);
            Hold();
        }

        // logic and methods
        private static string[] dungeonDirections = new string[]
        { "The Main Entrance of Corren",
           "The Seperation Hall" };

        // Enemy-count, Treasure-count, Danger-level
        private static readonly int[,] dungeonIntel =
        {
            { 4, 2, 1},
            { 5, 3, 2}
        };

        // Room-count
        private static readonly int[][] dungeonRoomsInHalls = new int[][]
        {
            new[] { 1 , 1 },
            new[] { 1 , 1 , 1 }
        };

        // Treasue in each room
        private static int[][] dungeonTreasureBags = new int[][]
        {
            new[] { 2 , 1 },
            new[] { 2 , 1 , 2 }
        };

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