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
    public partial class AddQuote : Form
    {
        //Instantiate desk (Desk.cs) and deskQuote (DeskQuote.cs) for AddQuote.cs
        public Desk desk;
        public DeskQuote deskQuote;
        //Declare read-only base price for all desks
        private decimal _basePrice = 200;

        public AddQuote()
        {
            
            InitializeComponent();
            //load date
            DateTime dateTime = DateTime.Now;
            labDate.Text = dateTime.ToString("dd MMMM yyyy");

            ///SURFACE MATERIAL DROP DOWN
            //Create array of enumerated SurfaceMaterial types from DeskQuote.cs, then cast to list
            List<SurfaceMaterial> materials = Enum.GetValues(typeof(SurfaceMaterial))
                .Cast<SurfaceMaterial>().ToList();
            //Populate surface material drop down with the list above
            comSurfaceMaterial.DataSource = materials;
            //Set default value of surface material to null
            comSurfaceMaterial.SelectedIndex = -1;

            //DELIVERY OPTION DROP DOWN
            //Create array of enum description strings
            List<string> shipDescs = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                string shipDesc = DeskQuote.GetEnumDescription((Shipping)i);
                shipDescs.Add(shipDesc);
            }
            comDeliveryOption.DataSource = shipDescs;
            //set drop down value to NoRush by default
            comDeliveryOption.SelectedIndex = 3;

            /////////////////////////OLD CODE///////////////////////////////////////////////////////////////////////
            //List<Shipping> shopping = Enum.GetValues(typeof(Shipping))
            //    .Cast<Shipping>().ToList();
            //comDeliveryOption.DataSource = shopping;
            ////set drop down value to NoRush by default
            //comDeliveryOption.SelectedIndex = 3;
            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            //Replaces minimum accepted values in width depth and drawer fields with empty strings
            widthNum.Text = String.Empty;
            depthNum.Text = String.Empty;
            drawerNum.Text = String.Empty;

            //Set base price automatically, y'know, cuz its the base price
            lbBasePrice.Text = "" + _basePrice;

            //Disables Get Quote button, is enabled once all inputs have been verified
            btnGetQuote.Enabled = false;
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            //assign the Mainmenu reference
            var mainMenu = (MainMenu)this.Tag;
            mainMenu.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGetQuote_Click(object sender, EventArgs e)
        {
            
            //Create desk and set properties
            desk = new Desk(widthNum.Value, depthNum.Value, (int)drawerNum.Value, (SurfaceMaterial)comSurfaceMaterial.SelectedItem);
            desk.SurfaceMaterial = (SurfaceMaterial)comSurfaceMaterial.SelectedItem;

            //Create deskQuote and set properties
            deskQuote = new DeskQuote();
            deskQuote.Shipping = (Shipping)comDeliveryOption.SelectedIndex;
            deskQuote.QuoteDate = DateTime.Now;
            deskQuote.CustomerName = txtCustomerName.Text;
            deskQuote.Desk = desk;
            deskQuote.QuotePrice = deskQuote.GetQuotePrice(deskQuote.Desk.SurfaceMaterial, comDeliveryOption.SelectedIndex);

            //assign var to JSON and deskQuotes which will hold the deserialized quotes
            string QuoteFile = @"quote.json";
            List<DeskQuote> deskQuotes = new List<DeskQuote>();

            if (File.Exists(QuoteFile))
            {
                using(StreamReader reader = new StreamReader(QuoteFile))
                {
                    //load existing quotes
                    string quotes = reader.ReadToEnd();
                    
                    if(quotes.Length > 0)
                    {
                        //deserialize quotes
                        deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);                        
                    }
                }
            }
            //add new quote to the deserialized JSON list
            deskQuotes.Add(deskQuote);

            ////Convert deskQuotes back to a serialized form and rewrite the JSON file with the new data point
            try
            {
                var jsonToWrite = JsonConvert.SerializeObject(deskQuotes, Formatting.Indented);
                using(var writer = new StreamWriter(QuoteFile))
                {
                    writer.Write(jsonToWrite);
                    writer.Close();
                }
            }
            catch(Exception ex)
            {

            }
            
            //Hide AddQuote form and create DisplayQuote form
            this.Hide();
            DisplayQuote displayQuote = new DisplayQuote(deskQuote);

            //add reference to MainMenu
            displayQuote.Tag = (MainMenu)this.Tag;

            //show displayQuote form
            displayQuote.Show();
            
        }

        private void countSum_Leave(object sender, EventArgs e)
        {
            //Set surface area price
            decimal area = widthNum.Value * depthNum.Value;
            decimal areaPrice = 0;
            int limit = 1000;
            if (area > limit)
            {
                areaPrice = area - limit;
            }
            lbSurfaceArea.Text = "" + area;
            lbSurfaceAreaPrice.Text = "" + areaPrice;

            //Set drawer price
            decimal drawerPrice = 50;
            decimal totalDrawerPrice = drawerNum.Value * drawerPrice;
            lbDrawerPrice.Text = "" + totalDrawerPrice;

            //Set material price
            decimal materialPrice = 0;
            switch (comSurfaceMaterial.SelectedIndex)
            {
                //Pine
                case 0:
                    materialPrice = 50;
                    break;
                //Laminate
                case 1:
                    materialPrice = 100;
                    break;
                //Veneer
                case 2:
                    materialPrice = 125;
                    break;
                //Oak
                case 3:
                    materialPrice = 200;
                    break;
                //Rosewood
                case 4:
                    materialPrice = 300;
                    break;
            }
            lbMaterialPrice.Text = "" + materialPrice;

            //Set shipping price
            decimal shippingPrice;
            ////////////////////////////////////3 Day Rush/////5 Day Rush/////7 Day Rush//////////////
            decimal[,] shippingPriceArray = { { 60, 70, 80 }, { 40, 50, 60}, { 30, 35, 40} };
            //Evaluates shipping price based on area and rush selection
            if(area < 1000 && comDeliveryOption.SelectedIndex != 3)
            {
                shippingPrice = shippingPriceArray[comDeliveryOption.SelectedIndex, 0];
            }else if(area < 2000 && comDeliveryOption.SelectedIndex != 3)
            {
                shippingPrice = shippingPriceArray[comDeliveryOption.SelectedIndex, 1];
            }
            else if (area > 2000 && comDeliveryOption.SelectedIndex != 3)
            {
                shippingPrice = shippingPriceArray[comDeliveryOption.SelectedIndex, 2];
            }
            //NoRush Selection
            else
            {
                shippingPrice = 0;
            }
            

            lbShippingPrice.Text = "" + shippingPrice;

            //Set total cost
            lbTotalCost.Text = "" + (_basePrice + areaPrice + totalDrawerPrice + materialPrice +shippingPrice);
        }

        //Check the AddQuote fields for completion before allowing user to add quote
        private void txtCustomerName_Validating(object sender, CancelEventArgs e)
        {
            //Get Quote Button (All fields)
            if (string.IsNullOrEmpty(txtCustomerName.Text) || string.IsNullOrEmpty(comSurfaceMaterial.Text) || drawerNum.Text.Equals(String.Empty) || widthNum.Text.Equals(String.Empty) || depthNum.Text.Equals(String.Empty))
            {
                errorProvider1.SetError(btnGetQuote, "Please fill out the form to get quote!");
            } else {
                btnGetQuote.Enabled = true;
                errorProvider1.SetError(btnGetQuote, null);
            }
            //Name
            if (string.IsNullOrEmpty(txtCustomerName.Text)) {
                errorProvider2.SetError(txtCustomerName, "Enter name");
            } else {
                errorProvider2.SetError(txtCustomerName, null);
            }
            //Surface Material
            if (string.IsNullOrEmpty(comSurfaceMaterial.Text))
            {
                errorProvider3.SetError(comSurfaceMaterial, "Choose a surface material");
            } else {
                errorProvider3.SetError(comSurfaceMaterial, null);
            }
            //Desk Width
            if (widthNum.Text.Equals(String.Empty))
            {
                errorProvider6.SetError(widthNum, "Choose the width of the desk");
            } else {
                errorProvider6.SetError(widthNum, null);
            }
            //Desk Depth
            if (depthNum.Text.Equals(String.Empty))
            {
                errorProvider7.SetError(depthNum, "Choose the depth of the desk");
            } else {
                errorProvider7.SetError(depthNum, null);
            }
            //Drawer Number
            if (drawerNum.Text.Equals(String.Empty))
            {
                errorProvider5.SetError(drawerNum, "Select the number of drawers");
            } else {
                errorProvider5.SetError(drawerNum, null);
            }
           
            
           
        }
    }
}
