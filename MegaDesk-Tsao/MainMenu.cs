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
        //Implement Visual Studio Designer support
        public MainMenu()
        {
            InitializeComponent();
        }
        //ADD QUOTE
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
        //SEARCH QUOTE
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
        //VIEW QUOTE
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
        //EXIT
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
