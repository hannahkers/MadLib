using System;

namespace MadLib
{
    static class Madlib
    {
        //declare variables
      static string Creature;
      static string Luminous;
      static string Ghastly;
      static string Spectral;
      static string Countryman;
      static string Farrier;
      static string Farmer;
      static string Dreadful;
      static string Apparition;
      static string Hound;
      static string Story;

        //method with statements
        public static void Run()
        {
            Start();
            GetWords();
            WriteStory();
            End();
        }

        static void Start()
        {
            //write out a header
            Console.WriteLine("-------");
            Console.WriteLine("Madlib!");
            Console.WriteLine("-------");
        }

        static void GetWords()
        {
            //ask player to enter words
            Console.Write("Please enter a noun: ");
            Creature = Console.ReadLine();

            Console.Write("Please enter a adjective: ");
            Luminous = Console.ReadLine();

            Console.Write("Please enter a adjective: ");
            Ghastly = Console.ReadLine();

            Console.Write("Please enter a adjective: ");
            Spectral = Console.ReadLine();

            Console.Write("Please enter a occupation: ");
            Countryman = Console.ReadLine();

            Console.Write("Please enter a occupation: ");
            Farrier = Console.ReadLine();

            Console.Write("Please enter a occupation: ");
            Farmer = Console.ReadLine();

            Console.Write("Please enter a adjective: ");
            Dreadful = Console.ReadLine();

            Console.Write("Please enter a noun: ");
            Apparition = Console.ReadLine();

            Console.Write("Please enter a noun: ");
            Hound = Console.ReadLine();
        }

        static void WriteStory()
        {
            //write out finished story
            Story = "They all agreed that it was a huge " + Creature + ", " + Luminous + ", " + Ghastly + ", and " + Spectral + ". I have cross-examined these men, one of them a hard-headed " + Countryman + ", one a " + Farrier + ", and one a moorland " + Farmer + ", who all tell the same story of this " + Dreadful + " " + Apparition + ", exactly corresponding to the " + Hound + " of the legend.";
            Console.WriteLine(Story);
        }

        static void End()
        { 
            //keep window open and prompt for exit
            Console.WriteLine("Press enter to exit");
            Console.ReadKey();
        }

    }
    class Program
    {
        static void Main()
        {
            Madlib.Run();

            //application for madlib
        }
    }
}
