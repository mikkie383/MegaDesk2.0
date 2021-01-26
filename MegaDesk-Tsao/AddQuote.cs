using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            List<SurfaceMaterial> Materials = new List<SurfaceMaterial>();
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
            var desk = new Desk();

            // set desk properties
            desk.Width = widthNum.Value;

            // create a desk quote
            var deskQuote = new DeskQuote();

            //set desk quote properties
            deskQuote.CustomerName = txtCustomerName.Text;

            // set quote price
            deskQuote.QuotePrice = deskQuote.GetQuotePrice();
            this.Close();
            DisplayQuote displayQuote = new DisplayQuote();

            //add reference to MainMenu
            displayQuote.Tag = (MainMenu)this.Tag;

            //show displayQuote form
            displayQuote.Show();
            
        }
    }
}
