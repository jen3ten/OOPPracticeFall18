using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice_09._17._2018
{
    class Dog
    {
        //Fields
        private int hairLength;
        private double height;
        private double runningSpeed;
        private double weight;
        private string name;

        //Properties (using longhand format of assigning get/set functions
        public int HairLength
        {
            get { return this.hairLength; } 
            set { this.hairLength = value; }
        }

        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public double RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }  
        }

        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        //Constructors
        public Dog()
        {
            //default constructor
        }

        //Loaded constructor
        public Dog(int hair, double tall, double speed, double fatness, string id)
        {
            this.HairLength = hair;
            this.Height = tall;
            this.RunningSpeed = speed;
            this.Weight = fatness;
            this.Name = id;
        }

        //Methods
        public double GetSpeed(int distance)
        {
            RunningSpeed = RunningSpeed * distance;
            GetDetails();
            return RunningSpeed;
        }

        private void GetDetails() //This can be private because it is called within the Dog class
        {
            Console.WriteLine("Your pets name is {0}.  It has {1} inches of hair", Name, HairLength);
            Console.WriteLine("{0} is {1} inches tall and weights {2} pounds", Name, Height, Weight);
            Console.WriteLine("{0} can run {1} mph.", Name, RunningSpeed);
        }
    }
}
