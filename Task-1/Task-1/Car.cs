using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_1
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Speed { get; set; }
        public string CarCode {  get; set; }
        public int CarCount;

        
        public Car(int id, string name, int speed,string carCode)
        {
            Id = id;
            Name = name;
            Speed = speed;
            CarCode = carCode;
            CarCount++;
            CarCode= name.Substring(0,2).ToUpper()+(1000+CarCount);
            
        }
        
    }

}
