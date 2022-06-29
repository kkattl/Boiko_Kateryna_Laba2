using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Laba2
{
    internal class Motor
    {
        public string MotorMark { get; set; }
        public bool IsMotorOn()
        {
            bool ismotoron = true;
            switch (Program.n)
            {
                case 0:
                    ismotoron = false;
                    break;
                case 1: 
                    ismotoron = true;
                    break;
            }
            return ismotoron;
        }
        public override int GetHashCode()
        {
            bool v = IsMotorOn();
            return v.GetHashCode();
        }

        public override string ToString()
        {
            return MotorMark;
        }
    }
}
