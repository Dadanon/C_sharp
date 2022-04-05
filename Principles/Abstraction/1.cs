// 1st level of abstraction

// Here I will create a Car class with detailed methods and fields.
// But you can only create instances of Car class without possibility to create 
// a class inherited from Car, no flexibility

using System;

namespace Car1
{
    class Car
    {
        public int wheelsCount;
        public string color;
        public float weight;
        public float currentVelocity = 0;
        public float maxVelocity;
        public int seatsCount;
        public float tankCapacity;
        public float price;

        public void addGas()
        {
            if (this.currentVelocity <= 140)
            {
                this.currentVelocity += 20;
            }
        }

        public void reduceGas()
        {
            if (this.currentVelocity >= 20)
            {
                this.currentVelocity -= 20;
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello pip")
        }
    }
}
