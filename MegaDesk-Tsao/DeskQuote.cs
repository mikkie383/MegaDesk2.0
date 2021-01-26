using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Tsao
{
    public enum Shpping
    {
        NoRush,
        Rush3Day,
        Rush5Day,
        Rush7Day
    }

    public class DeskQuote
    {
        public string CustomerName { get; set; }

        public DateTime QuoteDate { get; set; }

        public decimal QuotePrice { get; set; }

        public Shpping Shipping { get; set; }

        public Desk Desk { get; set; }

        public decimal GetQuotePrice()
        {
            decimal Base = 200;
            return 0;
        }

        public decimal GetAreaPrice()
        {
            /*decimal price = 0;
            int limit = 1000;
            if(Desk.GetArea() > limit)
            {
                price = Desk.GetArea() - limit;
            }*/
            return 0;
        }

        /*public decimal GetDrawerPrice()
        {
            decimal drawePrice = 50;
            return drawePrice * Desk.NumberofDrawer;
        }

        public decimal GetMaterialPrice()
        {
            return 0;
        }*/
    }
}
