using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._03.Modules
{
    public class Product
    {
        public Product():this("")    { }
        public Product(string pin):this(pin,"")
        { }
        public Product(string pin, string brend):this(pin, brend, "")   { }
        public Product(string pin, string brend, string name)
        {
            this.pin = pin;
            this.brend = brend;
            this.name = name;
        }
        public string pin { get; set; }
        public string brend { get; set; }
        public string name { get; set; }
        public bool analog { get; set; }
        public string artid { get; set; }
        private double price_;
        public double price
        {
            get { return price_; }
            set {
                if (value > 0) price_ = value; else  price_ = 0;
            }

             }
        public static void printInfo(List<Product> products)
        {
            foreach (Product item in products)
            {
                string info = string.Format("# {0} PIN: {1} \tBRAND: {2} \tNAME: {3}", 1, item.pin, item.brend, item.name);
                Console.WriteLine(info);
                
            }
        }
    }
}
