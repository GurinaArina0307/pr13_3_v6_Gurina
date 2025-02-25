using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_13._3_v_Gurina
{
    public class Suit
    {
        private string title;
        private string material;
        private string price;
        public Suit(string title, string material, string price)
        {
            this.title = title;
            this.material = material;
            this.price = price;
        }
        public string getTitle()
        {
            return this.title;
        }
        public string getMaterial()
        {
            return this.material;
        }
        public string getPrice()
        {
            return this.price;
        }
        public void setTitle(string title)
        {
            this.title = title;
        }
        public void setMaterial(string material)
        {
            this.material = material;
        }
        public void setPrice(string price)
        {
            this.price = price;
        }
    }
}
