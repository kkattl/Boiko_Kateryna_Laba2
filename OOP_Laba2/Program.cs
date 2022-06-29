using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Laba2
{
    internal class Program
    {
        public static int n, k, choose, petrol, GasTankSize, PetrolSize, change, wheel;
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            string moving;
            Car car = new Car();
            Motor motor = new Motor();
            Console.WriteLine("Введiть марку машини:");
            car.CarModel = Console.ReadLine();
            Console.WriteLine("Введiть рiк випуску машини:");
            car.CarYear = Console.ReadLine();
            Console.WriteLine("Введiть данi про мотор:");
            motor.MotorMark = Console.ReadLine();
            Console.WriteLine("Введіть розмір бензобаку:");
            Program.GasTankSize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть поточну кількість бензину в баці:");
            Program.PetrolSize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Що ви хочете зробити:\n1 - Їхати\n2 - Заправитись\n3 - Замінити колесо\n4 - Вивести марку машини");
            choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    Console.WriteLine("Завести двигун:\n1 - так\n0 - ні");
                    Program.n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Чи всі колеса цілі?\n1 - так \n0 - нi");
                    Program.k = Convert.ToInt32(Console.ReadLine());
                    moving = car.Move();
                    break;
                case 2:
                    Console.WriteLine("Введіть на скільки літрів хочете заправитись\n     -Введіть '0' якщо бажаєте заправити повний бак\n     -Або введіть літри для заправки ");
                    Program.petrol = Convert.ToInt32(Console.ReadLine());
                    car.Refuel();
                    break;
                case 3:
                    Console.WriteLine("Що ви бажаєте зробити?\n1 - Змінити зимню резину на літню\n2 - Змінити літню резину на зимню\n3 - Замінити пошкоджену шину ");
                    Program.change = Convert.ToInt32(Console.ReadLine());
                    if (Program.change == 3)
                    {
                        Console.WriteLine("Яке саме колесо ви бажаєте замінити?\n1 - Переднє праве\n2 - Переднє ліве\n3 - Заднє праве\n4 - Заднє ліве");
                        Program.wheel = Convert.ToInt32(Console.ReadLine());
                    }
                    car.Changes();
                    break;
                case 4:
                    Console.WriteLine("Ваша машина => " + car.ToString());
                    break;
                default:
                    Console.WriteLine("Невiрно обрана дiя!");
                    break;

            }
            
            Console.ReadLine();
        }
    }
}
