using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _28._03.Modules;

namespace _28._03
{
    class Program
    {
        static List<string[]> getData(string data)
        {
            List<string[]> rows = new List<string[]>();
            foreach (string item in data.Replace("},", "}").Split('}'))
            {
                string[] rasparse = item.Split(',');
                foreach (var item1 in rasparse)
                {
                    string[] rasparseInner = item1.Replace("{\"", "").Replace("\"", "").Split(':');
                    rows.Add(rasparseInner);
                }
            }
            return rows;
        }
        static void Main(string[] args)
        {
            #region data
            string data = "{\"PIN\":\"2288\",\"BRAND\":\"NGK\",\"NAME\":\"свеча зажигания!\\ BMW E30/E36/E46/E39/E34/E32, Opel Astra/Omega 1.6-4.0 82-98\",\"ARTID\":\"21943\",\"PARNR\":\"0000000000\",\"KEYZAK\":\"MOV0000075\",\"RVALUE\":\">20\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"VENSL\":\"98.0\",\"PRICE\":\"135.50\",\"WAERS\":\"RUB\",\"DLVDT\":\"20170602181500\",\"ANALOG\":\"\",\"MSG\":null,\"PriceTenge\":0,\"PriceRub\":0.0,\"ArtificialPrice\":null,\"ShowArtificialByDefault\":false,\"SupplierId\":0,\"Delivery\":null,\"DeliveryEx\":0,\"DeliveryGu\":0,\"Vkorg\":null,\"Kunnr\":null}," +

" {\"PIN\":\"2288\",\"BRAND\":\"NGK\",\"NAME\":\"свеча зажигания!\\ BMW E30/E36/E46/E39/E34/E32, Opel Astra/Omega 1.6-4.0 82-98\",\"ARTID\":\"21943\",\"PARNR\":\"0000000000\",\"KEYZAK\":\"MOV0000086\",\"RVALUE\":\">20\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"VENSL\":\"98.0\",\"PRICE\":\"142.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20170601181500\",\"ANALOG\":\"\",\"MSG\":null,\"PriceTenge\":0,\"PriceRub\":0.0,\"ArtificialPrice\":null,\"ShowArtificialByDefault\":false,\"SupplierId\":0,\"Delivery\":null,\"DeliveryEx\":0,\"DeliveryGu\":0,\"Vkorg\":null,\"Kunnr\":null}," +

"{\"PIN\":\"2288\",\"BRAND\":\"NGK\",\"NAME\":\"свеча зажигания!\\ BMW E30/E36/E46/E39/E34/E32, Opel Astra/Omega 1.6-4.0 82-98\",\"ARTID\":\"21943\",\"PARNR\":\"0000000000\",\"KEYZAK\":\"MOV0000073\",\"RVALUE\":\">20\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"VENSL\":\"100.0\",\"PRICE\":\"138.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20170529181500\",\"ANALOG\":\"\",\"MSG\":null,\"PriceTenge\":0,\"PriceRub\":0.0,\"ArtificialPrice\":null,\"ShowArtificialByDefault\":false,\"SupplierId\":0,\"Delivery\":null,\"DeliveryEx\":0,\"DeliveryGu\":0,\"Vkorg\":null,\"Kunnr\":null}," +

"{\"PIN\":\"0 241 235 751\",\"BRAND\":\"BOSCH\",\"NAME\":\"свеча зажигания!\\ BMW E36/E46/E39/E34/E32, Opel Astra/Omega 1.6-4.0 82-98\",\"ARTID\":\"21939\",\"PARNR\":\"0000000000\",\"KEYZAK\":\"MOV0000073\",\"RVALUE\":\">20\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"VENSL\":\"100.0\",\"PRICE\":\"77.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20170529181500\",\"ANALOG\":\"X\",\"MSG\":null,\"PriceTenge\":0,\"PriceRub\":0.0,\"ArtificialPrice\":null,\"ShowArtificialByDefault\":false,\"SupplierId\":0,\"Delivery\":null,\"DeliveryEx\":0,\"DeliveryGu\":0,\"Vkorg\":null,\"Kunnr\":null}," +

"{\"PIN\":\"0 241 235 751\",\"BRAND\":\"BOSCH\",\"NAME\":\"свеча зажигания!\\ BMW E36/E46/E39/E34/E32, Opel Astra/Omega 1.6-4.0 82-98\",\"ARTID\":\"21939\",\"PARNR\":\"0000000000\",\"KEYZAK\":\"MOV0000086\",\"RVALUE\":\">20\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"VENSL\":\"98.0\",\"PRICE\":\"79.50\",\"WAERS\":\"RUB\",\"DLVDT\":\"20170601181500\",\"ANALOG\":\"X\",\"MSG\":null,\"PriceTenge\":0,\"PriceRub\":0.0,\"ArtificialPrice\":null,\"ShowArtificialByDefault\":false,\"SupplierId\":0,\"Delivery\":null,\"DeliveryEx\":0,\"DeliveryGu\":0,\"Vkorg\":null,\"Kunnr\":null}," +

"{\"PIN\":\"0 241 235 751\",\"BRAND\":\"BOSCH\",\"NAME\":\"свеча зажигания!\\ BMW E36/E46/E39/E34/E32, Opel Astra/Omega 1.6-4.0 82-98\",\"ARTID\":\"21939\",\"PARNR\":\"0000000000\",\"KEYZAK\":\"MOV0000075\",\"RVALUE\":\">20\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"VENSL\":\"98.0\",\"PRICE\":\"75.50\",\"WAERS\":\"RUB\",\"DLVDT\":\"20170602181500\",\"ANALOG\":\"X\",\"MSG\":null,\"PriceTenge\":0,\"PriceRub\":0.0,\"ArtificialPrice\":null,\"ShowArtificialByDefault\":false,\"SupplierId\":0,\"Delivery\":null,\"DeliveryEx\":0,\"DeliveryGu\":0,\"Vkorg\":null,\"Kunnr\":null}," +

"{\"PIN\":\"0 241 235 751\",\"BRAND\":\"BOSCH\",\"NAME\":\"свеча зажигания!\\ BMW E36/E46/E39/E34/E32, Opel Astra/Omega 1.6-4.0 82-98\",\"ARTID\":\"21939\",\"PARNR\":\"0000000000\",\"KEYZAK\":\"MOV0003701\",\"RVALUE\":\">20\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"VENSL\":\"98.0\",\"PRICE\":\"77.50\",\"WAERS\":\"RUB\",\"DLVDT\":\"20170602181500\",\"ANALOG\":\"X\",\"MSG\":null,\"PriceTenge\":0,\"PriceRub\":0.0,\"ArtificialPrice\":null,\"ShowArtificialByDefault\":false,\"SupplierId\":0,\"Delivery\":null,\"DeliveryEx\":0,\"DeliveryGu\":0,\"Vkorg\":null,\"Kunnr\":null}," +

"{\"PIN\":\"Z101\",\"BRAND\":\"BERU\",\"NAME\":\"свеча зажигания!\\ MB Sprinter/Vito 2.0/2.3 95-06, VW LT 2.3 96>\",\"ARTID\":\"21940\",\"PARNR\":\"0000111848\",\"KEYZAK\":\"0000007743\",\"RVALUE\":\"87\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"VENSL\":\"85.0\",\"PRICE\":\"265.50\",\"WAERS\":\"RUB\",\"DLVDT\":\"20170605181500\",\"ANALOG\":\"X\",\"MSG\":null,\"PriceTenge\":0,\"PriceRub\":0.0,\"ArtificialPrice\":null,\"ShowArtificialByDefault\":false,\"SupplierId\":0,\"Delivery\":null,\"DeliveryEx\":0,\"DeliveryGu\":0,\"Vkorg\":null,\"Kunnr\":null}";

            #endregion

            List<Product> products = new List<Product>();
            //int productCount = 0;
            //Console.WriteLine("Enter amount of products -");


            foreach (string[] item in getData(data))
            {
                Product product = new Product();

                switch (item[0])
                {
                    case "PIN": { product.pin = (item[1]); }
                        break;
                    case "BRAND":
                        { product.brend = (item[1]); }
                        break;
                    case "NAME":
                        { product.name = (item[1]); }
                        break;
                    default:
                        break;
                }
                //product.pin = r.Next(0, 1513131385);
                //product.brend = Console.ReadLine();

                products.Add(product);
            }
            Product.printInfo(products);

            
            Console.ReadKey();
        }
       
    }
}
