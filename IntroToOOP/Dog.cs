using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Dog
    {
        //Create a Dog Class
        //Your dog class should have fields for hair length, height, running speed, and weight
        //Your class should have the following behaviors: run, bark, potty, cuddle
        //You should have atleast one constructor
        private string length;
        private double height;
        private int speed;
        private int weight;
        private bool crap = true;

        //Properties
        public string Length
        {
            get { return this.length; }
        }
        public double Height
        {
            get { return this.height; }
        }
        public int Speed
        {
            get { return this.speed; }
        }
        public int Weight
        {
            get { return this.weight; }
        }

        public double BarkVolume { get; set; }

        //Constructor
        public Dog()
        {
            //This is my default constructor
        }

        public Dog(string length, double height, int speed, int weight, bool crap)
        {
            this.length = length; 
            this.height = height;
            this.speed = speed;
            this.weight = weight;
            this.crap = crap;
        }

        public int Run()
        {
            Console.WriteLine("Go doggy, go!!");
            speed -= 1;
            return speed; 
        }

        public void Bark()
        {
            Console.WriteLine("Bark, bark, bark!");
        }

        public void Potty()
        {
            if(crap == true)
            {
                Console.WriteLine("Your dog just made a mess.");
            }
            else
            {
                Console.WriteLine("Your dog still has to relieve itself.");
            }
        }
        public void Cuddle()
        {
            Console.WriteLine("Aww, doggo is so sweet");
        }

        



        }
    }

