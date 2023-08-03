using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Source source = new Source
            {
                Id = 1,
                Name = "SreeCharan",
                Age = 22,
                Occupation = "Software Engineer"

            };

            Destination destination = new Destination();

            PropertyMapper.MapProperties(source, destination);

            Console.WriteLine("Mapped properties in the Destination class:");
            Console.WriteLine($"Id: {destination.Id}");
            Console.WriteLine($"Name: {destination.Name}");
            Console.WriteLine($"Occupation: {destination.Occupation}");
        }
    }
}
