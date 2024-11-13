using System;

    abstract class Animal
    {
        public string Name { get; private set; }

        public Animal(string name)
        {
            Name = name;
        }

       
        public abstract void Speak();
    }

    class Dog : Animal
    {
        public Dog(string name) : base(name) { }

      
        public override void Speak()
        {
            Console.WriteLine($"{Name} says: Woof!");
        }
    }

   
    class Cat : Animal
    {
        public Cat(string name) : base(name) { }

        
        public override void Speak()
        {
            Console.WriteLine($"{Name} says: Meow!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
          
            Animal myDog = new Dog("Buddy");
            Animal myCat = new Cat("Whiskers");

            myDog.Speak();  
            myCat.Speak();  
        }
    }
