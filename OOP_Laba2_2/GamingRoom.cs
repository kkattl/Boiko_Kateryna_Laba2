using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Laba2_2
{
    internal class GamingRoom
    {

        public List<Toy> Toys { get; set; }
        public double Budget { get; set; }
        public int MinimalAge { get; set; }

        public GamingRoom(double budget, int minimalAge)
        {
            Budget = budget;
            MinimalAge = minimalAge;

            Toys = new List<Toy>();
        }

        public void BuyToy(Toy toy)
        {
            if (Budget >= toy.Price)
            {
                Budget -= toy.Price;
                Toys.Add(toy);
                Console.WriteLine($"Куплено iграшку - {toy.Description} за {toy.Price}");
                return;
            }
        }
    }
}
