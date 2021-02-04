using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Tsao
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(DeskQuote deskQuote)
        {                
            InitializeComponent();
            lbName.Text = "" + deskQuote.CustomerName;
            DateTime dateTime = DateTime.Now;
            lbDate.Text = dateTime.ToString("dd MMMM yyyy");

            lbWidth.Text = "" + deskQuote.Desk.Width;
            lbDepth.Text = "" + deskQuote.Desk.Depth;
            lbArea.Text = "" + deskQuote.Desk.GetArea();
            lbDrawer.Text = "" + deskQuote.Desk.NumberofDrawer;
            lbMaterial.Text = "" + deskQuote.Desk.SurfaceMaterial;
            lbDelivery.Text = "" + deskQuote.Shipping;

            lbBasePrice.Text = "" + deskQuote.GetBasePrice();
            lbAreaPrice.Text = "" + deskQuote.GetAreaPrice();
            lbDrawerPrice.Text = "" + deskQuote.GetDrawerPrice();
            lbMaterialPrice.Text = "" + deskQuote.GetMaterialPrice(deskQuote.Desk.SurfaceMaterial);
            lbShippingPrice.Text = "" + deskQuote.GetShipping((int)deskQuote.Shipping);
            lbTotalPrice.Text = "" + deskQuote.GetQuotePrice(deskQuote.Desk.SurfaceMaterial, (int)deskQuote.Shipping);

        }

        private void DisplayQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            //var mainMenu = new MainMenu();
            //mainMenu.Show();
            //Hide();
            var mainMenu = (MainMenu)this.Tag;
            mainMenu.Show();
        }
    }
}
