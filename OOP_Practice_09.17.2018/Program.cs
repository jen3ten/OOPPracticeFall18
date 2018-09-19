using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice_09._17._2018
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dog fido = new Dog(); //Declared a variable named fido of type Dog, and instantiated it in memory
            //Dog spot = new Dog(); //Creates a second instance of the Dog class

            Dog fido = new Dog(7, 8.5, 33.2, 190.1, "Fido");
            Dog spot = new Dog(2, 10.2, 23.7, 78.2, "Spot");
            Console.WriteLine("Fido's hair length is {0}", fido.HairLength);
            Console.WriteLine("Spot's hair length is {0}", spot.HairLength);

            fido.HairLength = 4;
            spot.HairLength = 6;
            fido.GetSpeed(7);
            spot.GetSpeed(11);
            //Console.WriteLine("Fido's hair length is {0}", fido.HairLength);
            //Console.WriteLine("Spot's hair length is {0}", spot.HairLength);
            //Console.WriteLine("Fido is running {0}", fido.GetSpeed(7));

        }
    }
}
