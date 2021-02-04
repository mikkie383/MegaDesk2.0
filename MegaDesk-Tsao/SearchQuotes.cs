﻿using Newtonsoft.Json;
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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
            loadGrid();
            List<SurfaceMaterial> materials = Enum.GetValues(typeof(SurfaceMaterial))
                .Cast<SurfaceMaterial>().ToList();

            comSearch.DataSource = materials;

            //comSearch.SelectedIndex = -1;
        }

        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainMenu = (MainMenu)this.Tag;
            mainMenu.Show();
        }

        private void comSearch_SelectedIndexChanged(object sender, EventArgs e)
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
                    }).Where(d => d.Material == (SurfaceMaterial)comSearch.SelectedItem)
                    .ToList();
            }
            catch (Exception ex)
            {
                
            }
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
    }
}
