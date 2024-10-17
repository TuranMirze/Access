using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Product
    {


        public string Name;
        public int No;
        private double _price;
        private int _count;



        public double Price
        {
            get {
                return _price; 
            }
            set
            {

                if (value > 0)
                {
                    _price = value;
                }
            }
        }

        public int Count
        {
            get { 
                return _count; 
            }
            set
            {
                if (value > 0)
                {
                    _count = value;
                }
            }
        }

    }
}
