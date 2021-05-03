using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop
{
    class Order
    {
        //Constructor
        public Order(string name, int coffee, int donuts)
        {
            Name = name;
            Coffee = coffee;
            Donuts = donuts;
        }

        //Getter and Setters
        public string Name { get; set; }
        public int Coffee { get; set; }
        public int Donuts { get; set; }

        //Method that returns a string
        public override string ToString()
        {
            return this.Name + " : " + this.Coffee + " coffee & " + this.Donuts + " donuts";
        }

    }
}
