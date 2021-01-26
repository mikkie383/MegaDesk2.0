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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            this.background.Image = Image.FromFile(@"C:\Users\cdes5\source\repos\CIT365\image\MDesk.png");
            this.background.Size = this.background.Image.Size;
        }

        private void btnAddNewQuote_Click(object sender, EventArgs e)
        {
            //create AddQuote form
            var frmAddQuote = new AddQuote();

            //add reference to MainMenu
            frmAddQuote.Tag = this;

            //show AddQuote form
            frmAddQuote.Show();

            //hide MainMenu
            this.Hide();
        }

        private void btnSearchQuote_Click(object sender, EventArgs e)
        {
            //create SearchQuote form
            var frmSearchQuote  = new SearchQuotes();

            //add reference to MainMenu
            frmSearchQuote.Tag = this;

            //show SearchQuote form
            frmSearchQuote.Show();

            //hide MainMenu
            this.Hide();
        }

        private void btnViewQuote_Click(object sender, EventArgs e)
        {
            
            //create ViewQuote form
            var frmViewQuote = new ViewAllQuotes();

            //add reference to MainMenu
            frmViewQuote.Tag = this;

            //show SearchQuote form
            frmViewQuote.Show();

            //hide MainMenu
            this.Hide();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
