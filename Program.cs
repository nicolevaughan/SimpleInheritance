using System;

namespace Inheritance
{

    // base class
    class Animal
    {
        public string name;

        // constructor
        public Animal()
        {
            name = "";

        }
        //parameterized constructor
        public Animal(string name)
        {
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine($"I am an animal, my name is {name}");
        }

    }

    // derived class of Animal 
    class Bird : Animal
    {
        public string type;
        public string color;
        public string location;

        //constructor
        public Bird()
            : base() //calls the Animal class constructor
        {
            type = "";
            color = "";
            location = "";
        }
        //parameterized constructor
        public Bird(string name, string type, string color, string location)
            : base(name)
        {
            this.type = type;
            this.color = color;
            this.location = location;
        }
        public void getName()
        {
            Console.WriteLine($"My name is {name}");
        }
        public void getType()
        {
            Console.WriteLine($"I am a {type}");
        }
        public void getColor()
        {
            Console.WriteLine($"I am a beautiful {color} color");
        }
        public void getLocation()
        {
            Console.WriteLine($"I live in {location}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // object of base class
            Animal myPet = new Animal();
            myPet.name = "Sparky";
            myPet.display();

            // derived class object using default constructor
            Bird birdy = new Bird();

            birdy.name = "Pablo";
            birdy.type = "penguin";
            birdy.color = "black";
            birdy.location = "Antarctica";
            //birdy.display();
            birdy.getName();
            birdy.getType();
            birdy.getColor();
            birdy.getLocation();

            //derived class object using parameterized constructor
            Bird tweety = new Bird("Petey", "parrot", "red and blue", "South America");
            //tweety.display();
            tweety.getName();
            tweety.getType();
            tweety.getColor();
            tweety.getLocation();
        }

    }
}
