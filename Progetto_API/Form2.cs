using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Progetto_API
{
    public partial class Form2 : Form
    {
        static HttpClient client = new HttpClient();
        Rootobject Root_Series = new Rootobject();
        Result[] series = null;
        int i = 0;

        public Form2()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            panel_logo.BackColor = Color.FromArgb(0, 38, 64);
            buttons_avvia_ric.BackColor = Color.FromArgb(0, 38, 64);
            label_torna_indietro.ForeColor = Color.FromArgb(0, 38, 64);
            client.BaseAddress = new Uri("https://api.themoviedb.org/3/tv/top_rated?api_key=c576ca5974295b2a0cc99a98e910425c");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        async void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void label_torna_indietro_MouseHover(object sender, EventArgs e)
        {
           //label_torna_indietro.;
        }

        private void label_torna_indietro_Click(object sender, EventArgs e)
        {
            Form1 f1 =  new Form1();
            f1.Show();
            this.Close();
        }

        async Task<Rootobject> GetSeriesAsync()
        {
            string url = "https://api.themoviedb.org/3/tv/top_rated?api_key=c576ca5974295b2a0cc99a98e910425c&language=it-IT&page=1";
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                Root_Series = await JsonSerializer.DeserializeAsync<Rootobject>(await response.Content.ReadAsStreamAsync());
                ShowSeries(i);
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

        private void buttons1_Click(object sender, EventArgs e)
        {
            string lingua = comboBox_selected_language.Text;
            decimal n_pagine = numericUpDown_n_pagine.Value;
            GetSeriesAsync();
        }
    }
}
