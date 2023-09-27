using System;
using Circus.Enums;
using Circus.Interfaces;

namespace Circus.Models
{
	public class Dresseur: Person, IActionExecute
    {

		public Singe singe { get; }

		public List<Tour> tours { get => new List<Tour> { Tour.Acrobatie, Tour.Musique }; }

		public Dresseur(string name, string singeName):base(name)
		{
            singe = new Singe(singeName);
		}

        public void ExecuteTour(Tour tour)
        {
            if (tours.Contains(tour))
            {
                Console.WriteLine($"{Name} donne de l'ordre à {this.singe.Name} d'executer le tour {tour}");
                singe.ExecuteTour(tour);
                Console.WriteLine($"{Name} donne de l'odre à {this.singe.Name} de retourner à sa place");
                Console.WriteLine("----------------------------------------------------------------------\n");
            }
        }
    }
}

