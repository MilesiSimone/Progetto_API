using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Progetto_API
{
    public partial class Form2 : Form
    {
        static HttpClient client = null;
        public Rootobject Root_Series { set; get; }
   
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
                client.BaseAddress = new Uri("https://api.themoviedb.org/3/tv/popular");
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
            label_torna_indietro.Font = new Font(label_torna_indietro.Font.Name, label_torna_indietro.Font.Size, label_torna_indietro.Font.Style | FontStyle.Underline);
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
            }
            return Root_Series;
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
            label_total_results.Visible = true;
            label_ris_trovati.Visible = true;
            label_total_pages.Visible = true;
            label_total_pages_result.Visible = true;
            label_total_results.Text = Root_Series.total_results.ToString();
            label_total_pages_result.Text=Root_Series.total_pages.ToString();
            ViewResult(numericUpDown_n_pagine.Value);
        }

        private void label_torna_indietro_MouseLeave(object sender, EventArgs e)
        {
            label_torna_indietro.Font = new Font(label_torna_indietro.Font.Name, label_torna_indietro.Font.Size, label_torna_indietro.Font.Style & ~FontStyle.Underline);
        }

        private void ViewResult(decimal n)
        {
            int panelWidth = 255;
            int panelHeight = 400;

            Font labelFont = new Font("Arial", 19, FontStyle.Bold);
            int a = Convert.ToInt32(n);
            int startValue = (a - 1) * 20;
            int x = startValue + 1;

            for (int i = 0; i < Root_Series.results.Length; i++){

                // Crea un nuovo panel
                Panel panel = new Panel();
                panel.Name = "panel_generate_" + (i);
                panel.Size = new Size(panelWidth, panelHeight);
                panel.Location = new Point(((this.Width-1355)/2) + (i % 5) * (panelWidth + 20), 280 + (i / 5) * (panelHeight + 20));
                panel.BorderStyle = BorderStyle.FixedSingle;

                // Aggiunge una label identificativa al panel
                System.Windows.Forms.Label label = new System.Windows.Forms.Label();
                label.Name = "label_number_generate_" + (i);
                label.Text = (x + i).ToString();
                label.Font = labelFont;
                label.AutoSize = true;
                label.Location = new Point(5, 5);
                label.ForeColor = Color.FromArgb(0, 38, 64);
                panel.Controls.Add(label);

                // Aggiunge una picture box al panel
                PictureBox pictureBox = new PictureBox();
                pictureBox.Name = "picture_box_generate_" + (i);
                pictureBox.Width = panelWidth - 10;
                pictureBox.Height = panelHeight - 15 - label.Height - 35;
                pictureBox.Location = new Point(5, label.Height + 10);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Load(image_path + Root_Series.results[i].poster_path);
                pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                panel.Controls.Add(pictureBox);

                // Aggiunge una label titolo al panel
                System.Windows.Forms.Label titleLabel = new System.Windows.Forms.Label();
                titleLabel.Name = "label_title_generate_" + (i);
                titleLabel.Text = Root_Series.results[i].name;
                titleLabel.Font = new Font("Arial", 11, FontStyle.Bold);
                titleLabel.AutoSize = false;
                titleLabel.Width= panelWidth - 10;
                //titleLabel.Anchor = AnchorStyles.None;
                titleLabel.Location = new Point(panel.Width / 2 - titleLabel.Width / 2, pictureBox.Bottom + 15);
                titleLabel.MouseEnter += (sender, e) => { titleLabel.Font = new Font(titleLabel.Font, FontStyle.Underline | FontStyle.Bold); };
                titleLabel.MouseLeave += (sender, e) => { titleLabel.Font = new Font(titleLabel.Font, FontStyle.Bold); };
                
                titleLabel.MouseClick += (sender, e) => 
                { 
                    string n_serie = titleLabel.Name.Substring(21);
                    FormDetails formDetails= new FormDetails(n_serie, Root_Series);
                    formDetails.ShowDialog();
                };
                
                titleLabel.ForeColor = Color.DarkBlue;
                titleLabel.TextAlign = ContentAlignment.MiddleCenter;
                titleLabel.ForeColor = Color.FromArgb(0, 38, 64);
                titleLabel.Cursor = Cursors.Hand;

                // Check if title label width exceeds panel width
                if (titleLabel.Width > panel.Width)
                {
                    int lines = (int)Math.Ceiling(titleLabel.Width / (double)panel.Width);
                    int lineHeight = titleLabel.Font.Height;
                    titleLabel.Height = lines * lineHeight;
                    titleLabel.Width = panel.Width;
                    titleLabel.Location = new Point(panel.Width / 2 - titleLabel.Width / 2, pictureBox.Bottom + 15);
                }
                panel.Controls.Add(titleLabel);

                // Aggiunge il panel al form
                this.Controls.Add(panel);
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && _fr1.Visible != true)
            {
                DialogResult result = MessageBox.Show("Sei sicuro di voler chiudere l'applicazione?", "Conferma chiusura", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Annulla la chiusura dell'applicazione
                }
                else
                {
                    _fr1.Close(); // Chiude l'applicazione
                }
            }
        }


    }
}
