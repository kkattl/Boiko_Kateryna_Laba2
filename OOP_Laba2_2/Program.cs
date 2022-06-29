using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ігрова кімната.
//Підготувати ігрову кімнату для дітей різних вікових груп.
//Іграшок повинно бути фіксована кількість в межах виділеної суми грошей.
//Повинні зустрічатися іграшки схожих груп: маленькі, середні і великі машини, ляльки, м'ячі, кубики.
//Провести сортування іграшок в кімнаті по одному з параметрів.
//Знайти іграшки в кімнаті, відповідні заданому діапазону параметрів.

namespace OOP_Laba2_2
{
    internal class Program
    {
        //public int money;
        static void Main(string[] args)
        {
            var gamingRoom = new GamingRoom(3000, 10);

            var ball = new Ball("м'яч", 700, ToySize.Medium);
            var doll = new Doll("лялька", 300, ToySize.Small);
            var car = new Car("машина", 500, ToySize.Big);
            var cube = new Cube("кубики", 200, ToySize.Big);

            gamingRoom.BuyToy(ball);
            gamingRoom.BuyToy(doll);
            gamingRoom.BuyToy(car);
            gamingRoom.BuyToy(cube);

            var foundToy = gamingRoom.Toys.FirstOrDefault(toy => toy.Price < 700 && toy.Size == ToySize.Big);
            if (foundToy != null)
            {
                Console.WriteLine($"Знайдено iграшку - {foundToy.Description} за {foundToy.Price}");
            }
            else
            {
                Console.WriteLine("Iграшку не знайдено");
            }
            Console.ReadKey();
        }
    }
    public enum ToySize
    {
        Small,
        Medium,
        Big
    }
    public class Car : Toy
    {
        public Car(string description, double price, ToySize size) : base(description, price, size)
        {
        }
    }

    public class Doll : Toy
    {
        public Doll(string description, double price, ToySize size) : base(description, price, size)
        {
        }
    }

    public class Cube : Toy
    {
        public Cube(string description, double price, ToySize size) : base(description, price, size)
        {
        }
    }

    public class Ball : Toy
    {
        public Ball(string description, double price, ToySize size) : base(description, price, size)
        {
        }

    }
    
    
}
