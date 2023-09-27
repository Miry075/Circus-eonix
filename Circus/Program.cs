// See https://aka.ms/new-console-template for more information
using Circus.Enums;
using Circus.Models;

Console.WriteLine("Hello, World!");

while (true)
{
    
    List<Tour> tours = new List<Tour> { Tour.Acrobatie, Tour.Musique };
    var index = 0;
    Console.WriteLine("Choisissez un tour:");
    foreach (var tour in tours)
    {
        Console.WriteLine($"\t{index} - {tour}");
        index++;
    }

    Console.WriteLine("Votre option?");
    var tourToBeExecuted = tours[Convert.ToInt32(Console.ReadLine())];
    Show show = new Show();
    show.Launch(tourToBeExecuted);

    Console.Write("Pressez un bouton pour choisir un nouveau tour...");
    Console.ReadKey();
}


