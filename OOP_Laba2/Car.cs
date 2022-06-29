using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Створити додаток, який задовольняє вимогам, наведеним в завданні.
//Наслідування застосовувати тільки в тих завданнях, в яких воно логічно обґрунтоване(+).
//Аргументувати належність класу кожного створюваного методу і коректно перевизначити для кожного класу
//методи Equals, GetHashCode, ToString(+).
//При виклику будь-которого методу класу, виводити на екран текстове повідомлення.


//Створити об'єкт класу Автомобіль, використовуючи класи Колесо, Двигун. (+!)
//Методи: їхати, заправлятися, заміняти колесо, вивести на консоль марку автомобіля. (+!)


namespace OOP_Laba2
{
    internal class Car
    {
        public string CarModel { get; set; }
        public string CarYear { get; set; }

        

        public override string ToString()
        {
            Motor motor = new Motor();
            return CarModel + " (" + CarYear + " року випуску) " + "\nМотор => " + motor.ToString();
        }


        public string  Move()
        {
            Car car = new Car();
            Motor motor = new Motor();
            Wheel wheel = new Wheel();
            var move = " ";
            
            if (motor.IsMotorOn() == true && wheel.IsWheelSpin() == true)
            {
                move = "Машина рухається";
                Console.WriteLine(move);
            }
            else
            {
                move = "Упс!Щось не так";
                Console.WriteLine(move);
            }

            return move;           
        }

        public string Refuel()
        {
            Car car = new Car();
            string done = " ";
            if (Program.petrol == 0)
            {
                done = "Ваш бак повністю заповнено";
                Console.WriteLine(done);
            }
            else if (Program.GasTankSize - Program.PetrolSize == 0)
            {
                done = "Упс!Ваш бак уже повний, ми не можеммо його наповнити знову";
                Console.WriteLine(done);
            }
            else if (Program.GasTankSize - Program.PetrolSize < Program.petrol)
            {
                done = "Ви хочете влити занадто велику кількість бензину";
                Console.WriteLine(done);
            }
            else
            {
                done = "Ви успішно влили {0}л бензину!";
                Console.WriteLine(done, Program.petrol);
            }
            return done;
        }
        
        public string Changes()
        {
            Wheel wheel1 = new Wheel();
            Wheel wheel2 = new Wheel();
            Wheel wheel3 = new Wheel();
            Wheel wheel4 = new Wheel();
            string changes = " ";
            switch (Program.change)
            {
                case 1:
                    Console.WriteLine(wheel1.ToString());
                    Console.WriteLine(wheel2.ToString());
                    Console.WriteLine(wheel3.ToString());
                    Console.WriteLine(wheel4.ToString());
                    changes = "Ви успішно замінили зимню резину на літню";
                    Console.WriteLine(changes);
                    break;
                case 2:
                    Console.WriteLine(wheel1.ToString());
                    Console.WriteLine(wheel2.ToString());
                    Console.WriteLine(wheel3.ToString());
                    Console.WriteLine(wheel4.ToString());
                    changes = "Ви успішно замінили літню резину на зимню";
                    Console.WriteLine(changes);
                    break;
                case 3:
                    switch (Program.wheel)
                    {
                        case 1:
                            Console.WriteLine(wheel1.ToString());
                            changes = "Замінено переднє праве";
                            Console.WriteLine(changes);
                            break ;
                        case 2:
                            Console.WriteLine(wheel2.ToString());
                            changes = "Замінено переднє ліве";
                            Console.WriteLine(changes);
                            break;
                        case 3:
                            Console.WriteLine(wheel3.ToString());
                            changes = "Замінено заднє праве";
                            Console.WriteLine(changes);
                            break; 
                        case 4:
                            Console.WriteLine(wheel4.ToString());
                            changes = "Замінено заднє ліве";
                            Console.WriteLine(changes);
                            break;
                    }
                    return changes;

            }
            return changes;
        }
        public override int GetHashCode()
        {
            bool v = true;
            return v.GetHashCode();
        }     

    }
}
