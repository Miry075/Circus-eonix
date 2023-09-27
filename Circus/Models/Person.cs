using System;
using Circus.Enums;

namespace Circus.Models
{
	public class Person
	{
		public string Name { get; set; }

		//public CatPerson Category { get; set; }

		public Person(string name)
		{
			Name = name;
			//Category = category;
		}
	}
}
