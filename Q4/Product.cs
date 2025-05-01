
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Product
    {
        private string name;
        private double price;
        private int quantity;
        public Product(string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }
        public double CalculateCost()
        {
            return price * quantity;
        }
        public double CalculateCost(double newPrise, double newQuntity)
        {
            return  newPrise * newQuntity;
        }

      
        }
    }


    

