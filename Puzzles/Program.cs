using System;
using System.Collections.Generic;


namespace Puzzles
{
    class Program
    {
        // Create a function called RandomArray() that returns an integer array
        public static int[] RandomArray()
        {
            Random rand = new Random();
            int[] Output = new int[10];

            int Min = 26;
            int Max = 0;
            int Sum = 0;

            // Place 10 random integer values between 5 - 25 into the array
            for (int i=0; i<Output.Length; i++)
            {
                Output[i] = rand.Next(5,25);
                Sum += Output[i];
                if (Output[i] < Min) { Min = Output[i]; }
                else if (Output[i] > Max) { Max = Output[i]; }
            }

            // Print the min and max values of the array
            Console.WriteLine($"Min: {Min}");
            Console.WriteLine($"Max: {Max}");

            // Print the sum of all the values
            Console.WriteLine($"Sum: {Sum}");

            return Output;
        }

        // Create a function called TossCoin() that returns a string
        public static string TossCoin()
        {
            Random rand = new Random();
            // Have the function print "Tossing a Coin!"
            Console.WriteLine("Tossing a Coin!");

            // Randomize a coin toss with a result signaling either side of the coin 
            int Result = rand.Next(0, 2);

            // Have the function print either "Heads" or "Tails"
            // Finally, return the result
            if (Result == 0)
            {
                Console.WriteLine("Tails!");
                return "Tails!";
            }
            else
            {
                Console.WriteLine("Heads!");
                return "Heads!";
            }
        }

        // Create another function called TossMultipleCoins(int num) that returns a Double
        public static double TossMultipleCoins(int num)
        {
            int heads = 0;
            int tails = 0;

            // Have the function call the tossCoin function multiple times based on num value
            for (int i=0; i<num; i++)
            {
                string Result = TossCoin();
                if (Result == "Tails!")
                {
                    tails += 1;
                }
                else { heads += 1; }
            }

            // Have the function return a Double that reflects the ratio of head toss to total toss
            double HeadsValue = heads;
            double TotalValue = num;

            Console.WriteLine($"{heads} heads were flipped out of {num} coin tosses. This is a ratio of {HeadsValue / TotalValue}.");
            return HeadsValue / TotalValue;

        }


        // Build a function Names that returns a list of strings.  In this function:
        public static List<string> GetNames()
        {
            // Create a list with the values: Todd, Tiffany, Charlie, Geneva, Sydney
            List<string> NamesList = new List<string>();
            NamesList.Add("Tood");
            NamesList.Add("Tiffany");
            NamesList.Add("Charlie");
            NamesList.Add("Geneva");
            NamesList.Add("Sydney");

            // Shuffle the list and print the values in the new order
            Random rand = new Random();
            // Fisher-Yates Shuffle
            int n = NamesList.Count;
            while (n > 1)
            {
                n--;
                int k = rand.Next(n + 1);
                string Temp = NamesList[k];
                NamesList[k] = NamesList[n];
                NamesList[n] = Temp;
            }

            foreach (string Name in NamesList)
            {

                Console.WriteLine(Name);
            }

            // Return a list that only includes names longer than 5 characters
            for (int i=0; i<NamesList.Count; i++)
            {
                if (NamesList[i].Length <= 5)
                {
                    NamesList.Remove(NamesList[i]);
                }
            }


            return NamesList;
        }

        static void Main(string[] args)
        {
            // int[] RandomNumbers = RandomArray();
            // string CoinToss = TossCoin();
            // TossMultipleCoins(20);
            // GetNames();
        }
    }
}
