using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ParkingSlot
    {

       static string[] spaces = new string[6];

        public void ParkNewCar(string carNumber, string color)
        {
            for(int i=0; i<6; i++)
            {
                if(string.IsNullOrEmpty(spaces[i]))
                {
                    spaces[i] = carNumber + "" + color;
                    Console.WriteLine("Allocating slot :"+ i+1);
                }
            }
        }

        public void TakeOutThecar(int slotNumber)
        {
            spaces[slotNumber - 1] = "";
            Console.WriteLine(slotNumber + " Empty");
        }






    }
}
