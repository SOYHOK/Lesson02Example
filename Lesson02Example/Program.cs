using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02Example
{
    class House
    {
        public string strType;
        private string strAddress;
        public string Address
        {
            get { return strAddress; }  
            set { strAddress = value; }
        }
        private float fltPrice;
        public float FltPrice
        {
            get { return fltPrice; }
            set { fltPrice = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            House hObj = new House();
            Console.WriteLine("Enter the type of house: ");
            hObj.strType = Console.ReadLine();
            Console.WriteLine("Enter the address: ");
            hObj.Address = Console.ReadLine();

            Console.WriteLine("Enter the pric: ");
            hObj.FltPrice = float.Parse(Console.ReadLine());
            Console.WriteLine("Type = {0} Address = {1} Price = {2}", hObj.strType, hObj.Address, hObj.FltPrice);
        }

    }
}
