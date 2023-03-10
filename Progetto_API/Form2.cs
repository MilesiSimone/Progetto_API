using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Progetto_API
{
    public partial class Form2 : Form
    {
        static HttpClient client = null;
        public Rootobject Root_Series { set; get; }
   
        int i = 0;
        string image_path = "https://image.tmdb.org/t/p/w500";
        string api_key = "c576ca5974295b2a0cc99a98e910425c";
        public Form _fr1;

        public Form2(Form1 f1, string a)
        {
            InitializeComponent();
            _fr1= f1;
            client = new HttpClient();
            label_titolo.Text= a;
            this.BackColor = Color.White;
            panel_logo.BackColor = Color.FromArgb(0, 38, 64);
            buttons_avvia_ric.BackColor = Color.FromArgb(0, 38, 64);
            label_torna_indietro.ForeColor = Color.FromArgb(0, 38, 64);
            if(label_titolo.Text == "TOP RATED")
            {
                client.BaseAddress = new Uri("https://api.themoviedb.org/3/tv/top_rated");
                
            }else if(label_titolo.Text == "GET POPULAR")
            {
                client.BaseAddress = new Uri("https://api.themoviedb.org/3/tv/get_popular");
            }
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void label_torna_indietro_MouseHover(object sender, EventArgs e)
        {
           //label_torna_indietro.;
        }

        private void label_torna_indietro_Click(object sender, EventArgs e)
        {
            _fr1.Visible = true;
            this.Close();
        }

        private async Task<Rootobject> GetSeriesAsync(string path)
        {
            Rootobject Root_Series = null;
            
            HttpResponseMessage response = await client.GetAsync(client.BaseAddress + path);
            if (response.IsSuccessStatusCode)
            {
                Root_Series = await JsonSerializer.DeserializeAsync<Rootobject>(await response.Content.ReadAsStreamAsync());
                //ShowSeries(i);
            }
            return Root_Series;
        }

        public void ShowSeries(int i)
        {
            try
            {
                //aoao.Text = Serie.ToString();
                //pictureBox_image_serie.Image = Root_Series.results[0].poster_path;
                label_titolo_series.Text = Root_Series.results[0].name;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void buttons1_Click(object sender, EventArgs e)
        {
            Root_Series = await GetSeriesAsync($"?api_key={api_key}&language={comboBox_selected_language.Text.Substring(0, 5)}&page={numericUpDown_n_pagine.Value}");
            label_total_results.Text = Root_Series.total_results.ToString();
           
                label_prova.Text = Root_Series.results[2].name;
           
        }
    }
}
