using System;
using System.Xml.Linq;

namespace Circus.Models
{
	public class Spectateur: Person
	{
		public Spectateur(string name):base(name)
		{
		}

		public void Bravo()
        {
			Console.WriteLine($"----> {Name} Bravo...");
            Console.WriteLine("----------------------------------------------------------------------\n");
        }

        public void Siffle()
        {
            Console.WriteLine($"----> {Name} Siffle...");
            Console.WriteLine("----------------------------------------------------------------------\n");
        }
    }
}

