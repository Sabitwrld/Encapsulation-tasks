using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    public class Product
    {
        private double _price;
        private int _count;

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }
        public int Count
        {
            get { return _count; }
            set
            {
                if (value >= 0)
                {
                    _count = value;
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }

        public Product(int id, string name, double price)
        {
            Name = name;
            Id = id;
            Price = price;

        }
    }
}

