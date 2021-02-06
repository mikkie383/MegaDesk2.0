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
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
           
            InitializeComponent();
            loadGrid();
        }

        private void loadGrid()
        {
            try
            {
                string QuoteFile = @"quote.json";
                string jsonFromFile;
                using (var reader = new StreamReader(QuoteFile))
                {
                    jsonFromFile = reader.ReadToEnd();
                }
                List<DeskQuote> showQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(jsonFromFile);

                dataGridView1.DataSource = showQuotes
                    .Select(d => new
                    {
                        Date = d.QuoteDate,
                        Name = d.CustomerName,
                        Width = d.Desk.Width,
                        Depth = d.Desk.Depth,
                        Drawer = d.Desk.NumberofDrawer,
                        Material = d.Desk.SurfaceMaterial,
                        DeliveryType = d.Shipping,
                        QuoteAmount = d.QuotePrice.ToString("c")
                    }).ToList();
            }
            catch (Exception ex)
            {

            }
        }

        private void ViewAllQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainMenu = (MainMenu)this.Tag;
            mainMenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //deskQuotes.RemoveAt(dataGridView1.CurrentRow.Index);
            //loadGrid();
            ////////////////////////////////////////////////
            //assign var to JSON and deskQuotes which will hold the deserialized quotes
            string QuoteFile = @"quote.json";
            List<DeskQuote> deskQuotes = new List<DeskQuote>();

            if (File.Exists(QuoteFile))
            {
                using (StreamReader reader = new StreamReader(QuoteFile))
                {
                    //load existing quotes
                    string quotes = reader.ReadToEnd();

                    if (quotes.Length > 0)
                    {
                        //deserialize quotes
                        deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);
                    }
                }
            }
            //removes quote from the deserialized JSON list
            deskQuotes.RemoveAt(dataGridView1.CurrentRow.Index);

            ////Convert deskQuotes back to a serialized form and rewrite the JSON file without the deleted data point
            try
            {
                var jsonToWrite = JsonConvert.SerializeObject(deskQuotes, Formatting.Indented);
                using (var writer = new StreamWriter(QuoteFile))
                {
                    writer.Write(jsonToWrite);
                    writer.Close();
                }
            }
            catch (Exception ex)
            {

            }
            loadGrid();
        }
    }
}
