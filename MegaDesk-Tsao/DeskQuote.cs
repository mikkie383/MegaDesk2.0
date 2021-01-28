using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace MegaDesk_Tsao
{
    public enum Shipping
    {
        Rush3Day,
        Rush5Day,
        Rush7Day,
        NoRush
    }

    public class DeskQuote
    {
        private decimal[,] ShippingPrice = GetRushOrder();


        public string CustomerName { get; set; }

        public DateTime QuoteDate { get; set; }

        public decimal QuotePrice { get; set; }

        public Shipping Shipping { get; set; }

        public Desk Desk { get; set; }

        public decimal GetQuotePrice(SurfaceMaterial material, Shipping shipping)
        {
            decimal Base = 200;
            return Base + GetAreaPrice() + GetDrawerPrice() + GetMaterialPrice(material) + GetShipping(shipping);
        }

        public decimal GetAreaPrice()
        {
            decimal price = 0;
            int limit = 1000;
            if(Desk.GetArea() > limit)
            {
                price = Desk.GetArea() - limit;
            }
            return price;
        }

        public decimal GetDrawerPrice()
        {
            decimal drawePrice = 50;
            return drawePrice * Desk.NumberofDrawer;
        }

        public decimal GetMaterialPrice(SurfaceMaterial material)
        {
            return (decimal)material;
        }

        public decimal GetShipping(Shipping shipping)
        {
            if(Desk.GetArea() < 1000 && (int)shipping == 0)
            {
                return ShippingPrice[(int)shipping, 0];
            }
            else if(Desk.GetArea() < 2000 && (int)shipping == 1)
            {
                return ShippingPrice[(int)shipping, 1];
            }
            else if(Desk.GetArea() < 2000 && (int)shipping == 2)
            {
                return ShippingPrice[(int)shipping, 2];
            }
            else
            {
                return 0;
            }
        }

        public static decimal[,] GetRushOrder()
        {
            int size = 3;
            decimal[,] rushOrderValue = new decimal[size, size];
            string[] readLine;
            
            string file = @"\rushOrderPrices.txt";
            
            readLine = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + file);
            
            int i = 0;
            for(int y = 0; y < size; y++)
            {
                 for(int x = 0; x < size; x++)
                 {
                      rushOrderValue[y, x] = decimal.Parse(readLine[i]);
                      i++;
                 }
            }            
            return rushOrderValue;
        }
    }
}
