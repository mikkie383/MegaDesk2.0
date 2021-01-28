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
        public DisplayQuote()
        {
            try { 
                string QuoteFile = @"\quote.txt";
                InitializeComponent();
                string jsonFromFile;
                using (var reader = new StreamReader(QuoteFile))
                {
                    jsonFromFile = reader.ReadToEnd();
                }
            }
            catch(Exception ex)
            {

            }

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
