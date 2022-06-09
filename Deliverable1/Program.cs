// See https://aka.ms/new-console-template for more information

using System;
class MainClass
{
    public static void Main(String[] args)
    {



        Console.WriteLine("Hello, World!");

        int slicePerLoaf = 28;
        int tbsPerJarPB = 32;
        int tsPerJarJelly = 48;

        while (true)
        {
            Console.Write("How many people are we making PB&J sandwiches for? ");
            int numberOfPeople = int.Parse(Console.ReadLine());
            

            Console.WriteLine("You need: ");

            //Slices of bread
            Console.Write("Slices of Bread: ");
            int totalSlicesNeeded = numberOfPeople * 2;
            Console.WriteLine(totalSlicesNeeded);

            //Total peanutbutter needed
            Console.Write("Tablespoons of Peanut Butter: ");
            int totalPeanutButterNeeded = numberOfPeople * 2;
            Console.WriteLine(totalPeanutButterNeeded);

            //Total Jelly Needed
            Console.Write("Teaspoons of jelly: ");
            int totalJellyNeeded = numberOfPeople * 4;
            Console.WriteLine(totalJellyNeeded);

            Console.WriteLine("Which is ...");

            // # Loaves of bread
            Console.Write("Loaves of bread: ");
            int totalLoavesNeeded = (totalSlicesNeeded / slicePerLoaf);
            if (totalSlicesNeeded % slicePerLoaf == 0)
            {

            }
            else { totalLoavesNeeded++; }
            Console.WriteLine(totalLoavesNeeded);



            // # jars of Peanut Butter
            Console.Write("Jars of PeanytButter: ");
            int totalJarsOfPBNeeded = totalPeanutButterNeeded / tbsPerJarPB;
            if (totalPeanutButterNeeded % tbsPerJarPB == 0)
            {

            }
            else { totalJarsOfPBNeeded++; }
            Console.WriteLine(totalJarsOfPBNeeded);

            // # Jars of jelly
            Console.Write("jars of jelly needed: ");
            int totalJarsOfJellyNeeded = totalJellyNeeded / tsPerJarJelly;
            if (totalJellyNeeded % tsPerJarJelly == 0)
            {

            }
            else { totalJarsOfJellyNeeded++; }
            Console.WriteLine(totalJarsOfJellyNeeded);

            Console.Write("Would you like to restart? Enter yes or y to continue, or enter any other key to exit: ");
            string userInput = Console.ReadLine();

            if (userInput == "y" || userInput == "yes")
            {

            }
            else
            {
                break;
            }
        }
        Console.WriteLine("Good Bye! ");
    }

}


