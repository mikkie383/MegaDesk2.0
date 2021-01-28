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
        public AddQuote()
        {
            InitializeComponent();
            this.tansD.Image = Image.FromFile(@"C:\Users\cdes5\source\repos\CIT365\image\TransD.png");
            this.tansD.Size = this.tansD.Image.Size;
            List<SurfaceMaterial> materials = Enum.GetValues(typeof(SurfaceMaterial))
                .Cast<SurfaceMaterial>().ToList();

            comSurfaceMaterial.DataSource = materials;

            comSurfaceMaterial.SelectedIndex = -1;

            List<Shipping> shopping = Enum.GetValues(typeof(Shipping))
                .Cast<Shipping>().ToList();
            comDeliveryOption.DataSource = shopping;
            //make combo box empty
            comDeliveryOption.SelectedIndex = -1;

            widthNum.Text = String.Empty;
            depthNum.Text = String.Empty;
            drawerNum.Text = String.Empty;
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
            //create a new desk
            var desk = new Desk(widthNum.Value, depthNum.Value, (int)depthNum.Value, (SurfaceMaterial)comSurfaceMaterial.SelectedItem);

            // set desk properties
           // desk.Width = widthNum.Value;

            // create a desk quote
            var deskQuote = new DeskQuote();

            //set desk quote properties
            deskQuote.CustomerName = txtCustomerName.Text;

            deskQuote.Shipping = (Shipping)comDeliveryOption.SelectedIndex;
            deskQuote.Desk = desk;
            // set quote price
            deskQuote.QuotePrice = deskQuote.GetQuotePrice(deskQuote.Desk.SurfaceMaterial, deskQuote.Shipping);

            string QutoeFile = @"\quote.txt";
            List<string> quote = new List<string>();

            try
            {
                var jsonToWrite = JsonConvert.SerializeObject(deskQuote);
                using(var writer = new StreamWriter(QutoeFile))
                {
                    writer.Write(jsonToWrite);
                }
            }
            catch(Exception ex)
            {

            }

            this.Close();
            DisplayQuote displayQuote = new DisplayQuote();

            //add reference to MainMenu
            displayQuote.Tag = (MainMenu)this.Tag;

            //show displayQuote form
            displayQuote.Show();
            
        }
    }
}
