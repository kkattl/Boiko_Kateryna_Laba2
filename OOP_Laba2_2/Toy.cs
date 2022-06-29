using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Laba2_2
{
    public abstract class Toy
    {
        public string Description { get; set; }
        public double Price { get; set; }
        public ToySize Size { get; set; }

        protected Toy(string description, double price, ToySize size)
        {
            Description = description;
            Price = price;
            Size = size;
        }
    }
}
