using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    public class Book : Product
    {
        public string Genre;
        public Book(int id, string name, double price, string genre) : base(id, name, price)
        {
            Genre = genre;
        }
    }
}
