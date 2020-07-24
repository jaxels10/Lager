using System;
using System.Collections.Generic;
using System.Text;

namespace Lager.Core
{
    class Product
    {
        public int price;
        public string name; 

        public Product(int price, string name)
        {
            this.price = price;
            this.name = name; 
        }
    }
}
