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
        //create a globel desk and deskquote
        public Desk desk;
        public DeskQuote deskQuote;
        private decimal _basePrice = 200;

        public AddQuote()
        {
            
            InitializeComponent();
            //load date
            DateTime dateTime = DateTime.Now;
            labDate.Text = dateTime.ToString("dd MMMM yyyy");
            //load background image
            //this.tansD.Image = Image.FromFile(@"C:\Users\cdes5\source\repos\CIT365\image\TransD.png");
            //this.tansD.Size = this.tansD.Image.Size;
            List<SurfaceMaterial> materials = Enum.GetValues(typeof(SurfaceMaterial))
                .Cast<SurfaceMaterial>().ToList();

            comSurfaceMaterial.DataSource = materials;

            comSurfaceMaterial.SelectedIndex = -1;

            List<Shipping> shopping = Enum.GetValues(typeof(Shipping))
                .Cast<Shipping>().ToList();
            comDeliveryOption.DataSource = shopping;
            //make combo box empty
            comDeliveryOption.SelectedIndex = 3;
            

            widthNum.Text = String.Empty;
            depthNum.Text = String.Empty;
            drawerNum.Text = String.Empty;

            lbBasePrice.Text = "" + _basePrice;

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
            

            desk = new Desk(widthNum.Value, depthNum.Value, (int)drawerNum.Value, (SurfaceMaterial)comSurfaceMaterial.SelectedItem);
            // set desk properties
            // desk.Width = widthNum.Value;
            
            desk.SurfaceMaterial = (SurfaceMaterial)comSurfaceMaterial.SelectedItem;
            // create a desk quote
            deskQuote = new DeskQuote();
            deskQuote.Shipping = (Shipping)comDeliveryOption.SelectedIndex;
            deskQuote.QuoteDate = DateTime.Now;
            //set desk quote properties
            deskQuote.CustomerName = txtCustomerName.Text;

            //deskQuote.Shipping = comDeliveryOption.SelectedIndex;
            deskQuote.Desk = desk;
            // set quote price
            deskQuote.QuotePrice = deskQuote.GetQuotePrice(deskQuote.Desk.SurfaceMaterial, comDeliveryOption.SelectedIndex);

            string QutoeFile = @"quote.json";
            List<DeskQuote> deskQuotes = new List<DeskQuote>();

            if (File.Exists(QutoeFile))
            {
                using(StreamReader reader = new StreamReader(QutoeFile))
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
            //add a new quote
            deskQuotes.Add(deskQuote);

            //save quotes to file
            try
            {
                var jsonToWrite = JsonConvert.SerializeObject(deskQuotes, Formatting.Indented);
                using(var writer = new StreamWriter(QutoeFile))
                {
                    writer.Write(jsonToWrite);
                    writer.Close();
                }
            }
            catch(Exception ex)
            {

            }
            
            this.Hide();
            DisplayQuote displayQuote = new DisplayQuote(deskQuote);

            //add reference to MainMenu
            displayQuote.Tag = (MainMenu)this.Tag;

            //show displayQuote form
            displayQuote.Show();
            
        }

        private void countSum_Leave(object sender, EventArgs e)
        {
            decimal area = widthNum.Value * depthNum.Value;
            decimal areaPrice = 0;
            int limit = 1000;
            if (area > limit)
            {
                areaPrice = area - limit;
            }
            lbSurfaceArea.Text = "" + area;
            lbSurfaceAreaPrice.Text = "" + areaPrice;

            decimal drawerPrice = 50;
            decimal totalDrawerPrice = drawerNum.Value * drawerPrice;
            lbDrawerPrice.Text = "" + totalDrawerPrice;

            decimal materialPrice = 0;
            switch (comSurfaceMaterial.SelectedIndex)
            {
                case 0:
                    materialPrice = 50;
                    break;
                case 1:
                    materialPrice = 100;
                    break;
                case 2:
                    materialPrice = 125;
                    break;
                case 3:
                    materialPrice = 200;
                    break;
                case 4:
                    materialPrice = 300;
                    break;
            }
            lbMaterialPrice.Text = "" + materialPrice;

            decimal shippingPrice;
            decimal[,] shippingPriceArray = { { 60, 70, 80 }, { 40, 50, 60}, { 30, 35, 40} };
            
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
            else
            {
                shippingPrice = 0;
            }
            

            lbShippingPrice.Text = "" + shippingPrice;
            lbTotalCost.Text = "" + (_basePrice + areaPrice + totalDrawerPrice + materialPrice +shippingPrice);
        }

        private void txtCustomerName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomerName.Text) || string.IsNullOrEmpty(comSurfaceMaterial.Text) || string.IsNullOrEmpty(comDeliveryOption.Text) || drawerNum.Text.Equals(String.Empty))
            {
                errorProvider1.SetError(btnGetQuote, "Please fill out the form to get quote!");
            }
            else
            {
                btnGetQuote.Enabled = true;
                errorProvider1.SetError(btnGetQuote, null);
            }
        }
    }
}
