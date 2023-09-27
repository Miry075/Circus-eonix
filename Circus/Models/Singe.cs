using System;
using Circus.Enums;
using Circus.Interfaces;

namespace Circus.Models
{
	public class Singe: IActionExecute
    {
		public string  Name { get; set; }

		public List<Tour> Tours { get => new List<Tour> { Tour.Acrobatie, Tour.Musique }; } 

		public Singe(string name)
		{
			Name = name;
		}

		public void ExecuteTour(Tour tour)
		{
			if (Tours.Contains(tour))
			{
				Console.WriteLine($"--> {Name} execute le tour {tour}");
                Console.WriteLine($"--> {Name} a terminé le tour {tour}!");
            }
			else { Console.WriteLine("......"); }
		}
	}
}

