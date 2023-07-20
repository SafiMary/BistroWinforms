using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BistroWinforms
{
    internal class Dish
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Dish(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }
        public override string ToString()
        {
            return $"{this.Name} {this.Price}";
        }
        //public void SumPrice()
        //{
        //    int sum = 0;
        //    foreach (var price in objs)
        //    {
        //            sum += Convert.ToDecimal(obj);

        //    }
        //    return sum;
        //}
    }
}
