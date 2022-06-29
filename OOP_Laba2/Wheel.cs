using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Laba2
{
    internal class Wheel 
    {
       
        public bool IsWheelSpin()
        {
            bool iswheelspin = true;
            switch (Program.k)
            {
                case 0:
                    iswheelspin = false;
                    break;
                case 1:
                    iswheelspin = true;
                    break;
            }
            return iswheelspin;
        }

        public override int GetHashCode()
        {
            bool v = IsWheelSpin();
            return v.GetHashCode();
        } 
        public override string ToString()
        {
            return "Колесо успішно замінено";
        }
    }
}
