using System;

namespace FunctionsWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] colors = { "red", "blue", "green" };
            string randomColor = "";
            DisplayRandomColor(colors);
            Console.WriteLine($"Arvuti valis {randomColor}.");
        }

        private static string pickRandomColor(string[] someArray);
        { 
        Random rnd = new Random();
        int randomIndex = rnd.Next(0, someArray.Length);
        return someArray[randomIndex]);
        }
    private static void DisplayRandomColor(string[] someArray)
    {
        Random rnd = new Random();
        int randomIndex = rnd.Next(0, someArray.Length);

        Console.WriteLine(someArray[randomIndex]);



    }
}



