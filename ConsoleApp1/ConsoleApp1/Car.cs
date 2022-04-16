using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ConsoleApp1
{
    public class Car
    {
        protected Color Col;
        protected double CarPrice;
        public static int CarCount = 0;
        protected static double AveragePrice;

        public Car(Color MyColor, double carPrice)
        {
            CarCount += 1;
            Col = MyColor;
            CarPrice = carPrice;
            AveragePrice += CarPrice;
            AveragePrice /= CarCount;
        }

        public void Move()
        {
            Console.WriteLine("Moving...");
        }

        public Color MyColor
        {
            get { return Col; }
            set 
            { 
                if (value != Color.Red)
                {
                    Col = value;
                }
                else
                {
                    Console.WriteLine("Cannot use RED color!");
                }
            }
        }
    }
}
