using System;
namespace Uppgift3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Frågar
            Console.WriteLine("Hur lång är din låt?\nSkriv två heltal: antal minuter och antal sekunder. De ska sepereras med ett mellanslag.");
            string userInput = Console.ReadLine();

            //Index på mellanslaget
            int spaceIndex = userInput.IndexOf(" ");

            int minutes = int.Parse(userInput[..spaceIndex]); //Hur många minuter?
            int seconds = int.Parse(userInput[(spaceIndex+1)..]); //Hur många sekunder?

            int songTime = minutes * 60 + seconds;  //Total tid

            //Får låten spelas
            if ((songTime >= (2 * 60 + 45)) && (songTime <= (4 * 60 + 20)))
            {
                Console.WriteLine("Låten får spelas!");
            }
            else
            {
                Console.WriteLine("Låten får ej spelas!");
            }
        }
    }
}
