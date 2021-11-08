using System;
using System.IO;

namespace MethodExecrise1
{

    class Program
    {



        static void Main(string[] args)
        {
         //var to hold user input  
             string uName;
             string uAnimal;
             string uColor;
             string uBand;

            Console.WriteLine("Press the Enter key after inputting an answer for each question.\n");
            //prompte user for input
            Console.WriteLine("Hello user, what name do you go by? :");
            uName = getName();
            Console.WriteLine("What color do you like most? :");
            uColor = getColor();
            Console.WriteLine("What is your favorite animal? :");
            uAnimal = getAnimal();
            Console.WriteLine("What band do you like? :");
            uBand = getBand();
            //add blank lines for story
            Console.WriteLine("\n\n\n\n");

            Console.WriteLine($"Once upon a time, a person named {uName} was strolling along a road humming a tune.");
            Console.WriteLine($"When a z{uColor} {uAnimal} came out of no of nowhere and darted across {uName}'s path.");
            Console.WriteLine($"Quickly {uName} followed the {uAnimal } as not to loose sight of it.");
            Console.WriteLine($"The {uAnimal } took {uName} off the road and deep into the woods.");
            Console.WriteLine($"As the {uColor} {uAnimal} took {uName} deeper into the woods, a familar sound could be heard.");
            Console.WriteLine($"Finally the {uAnimal} stopped. {uName} looked around to find {uBand} performing.");
            Console.WriteLine($"Out of breath, {uName} found a stump to sit and watch {uBand}.");
            Console.WriteLine();
            Console.WriteLine("Press any key to quit");



        }
        //methods to store user input
      
        public static string getName()
        {
        
        string strName = Console.ReadLine();
        return strName;
    }
        public static string getColor()
        {
            string strColor = Console.ReadLine();
            return strColor;
        }
        public static string getAnimal()
        {
            string strAnimal = Console.ReadLine();
            return strAnimal;
        }
        public static string getBand()
        {
            string strBand = Console.ReadLine();
            return strBand;
        }
                   
       


}
}
