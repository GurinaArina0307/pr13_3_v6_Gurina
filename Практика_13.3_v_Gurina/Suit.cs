using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_13._3_v_Gurina
{
    public class Suit
    {
        public string Brand { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Price { get; set; }
        public DateTime DataPostupleniy { get; set; }
        public Suit(string brand, string color, string size, string price, DateTime dataPostupleniy)
        {
            Brand = brand;
            Color = color;
            Size = size;
            Price = price;
            DataPostupleniy = dataPostupleniy;
        }
        public int CompareTo(Suit other)
        {
            return this.Brand.CompareTo(other.Brand);
        }
        public override string ToString()
        {
            return $"{Brand} | {Color} | {Size} | {Price} | {DataPostupleniy.ToShortDateString()}";
        }
    }
}
