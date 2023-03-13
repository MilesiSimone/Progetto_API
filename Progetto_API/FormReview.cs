using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Progetto_API
{
    public partial class FormReview : Form
    {
        static HttpClient client = null;
        GuestSession guest_session = null;
        string scelta, scelta1;
        public Form _fr1;
        string ContentType = "application/json;charset=utf-8";
        string api_key = "c576ca5974295b2a0cc99a98e910425c";
        string guest_session_id = "e6140b88ee47b41e7cc254bc4fa6df85";

        public FormReview(string s, string a, string b, string c, string d)
        {
            InitializeComponent();
            client = new HttpClient();
            //_fr1 = f1;
            scelta = s;
            scelta1 = d;
            if (scelta == "add" || scelta1 == "add")
            {
                label_titolo.Text = "ADD REVIEW";
                label_value.Visible = true;
                comboBox_valutazione.Visible = true;
                client.BaseAddress = new Uri("https://api.themoviedb.org/3/tv/");
                if (scelta1 == "add")
                {
                    label_titolo_series.Text = c;
                    label_titolo_series.Visible = true;
                    pictureBox2.Load(b);
                    pictureBox2.Visible = true;
                    textBox_id_series.Text = a;
                    label_value.Visible = true;
                    comboBox_valutazione.Visible = true;
                }
            }
            else
            {
                label_titolo.Text = "DELETE REVIEW";
                client.BaseAddress = new Uri("https://api.themoviedb.org/3/tv/");
            }
            
            panel_logo.BackColor = Color.FromArgb(0, 38, 64);
            label_torna_indietro.ForeColor = Color.FromArgb(0, 38, 64);
            buttons_send.BackColor = Color.FromArgb(0, 38, 64);
            label_titolo_series.Top = (pictureBox2.Height - label_titolo_series.Height) / 2;

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private void FormReview_Load(object sender, EventArgs e)
        {

        }

        private void label_torna_indietro_Click(object sender, EventArgs e)
        {
            //_fr1.Visible = true;
            this.Close();
        }

        private void label_torna_indietro_MouseHover(object sender, EventArgs e)
        {
            label_torna_indietro.Font = new Font(label_torna_indietro.Font.Name, label_torna_indietro.Font.Size, label_torna_indietro.Font.Style | FontStyle.Underline);
        }

        private void label_torna_indietro_MouseLeave(object sender, EventArgs e)
        {
            label_torna_indietro.Font = new Font(label_torna_indietro.Font.Name, label_torna_indietro.Font.Size, label_torna_indietro.Font.Style & ~FontStyle.Underline);
        }

        async void buttons_send_Click(object sender, EventArgs e)
        {
            guest_session = await GetSessionGuestAsync();
            MessageBox.Show(guest_session.guest_session_id);
            var url = await CreateReviewAsync();
            MessageBox.Show("Eseguito con successo");
        }

        private async Task<Uri> CreateReviewAsync()
        {

            HttpResponseMessage response = await client.PostAsJsonAsync(client.BaseAddress + textBox_id_series.Text + "/rating?api_key=" + api_key + "&guest_session=" + guest_session.guest_session_id, comboBox_valutazione.Text); 
            response.EnsureSuccessStatusCode();

            return response.Headers.Location;
        }

        private async Task<GuestSession> GetSessionGuestAsync()
        {
            GuestSession guest_session = null;
            HttpResponseMessage response = await client.GetAsync("https://api.themoviedb.org/3/authentication/guest_session/new?api_key=c576ca5974295b2a0cc99a98e910425c");
            if (response.IsSuccessStatusCode)
            {
                guest_session = await JsonSerializer.DeserializeAsync<GuestSession>(await response.Content.ReadAsStreamAsync());
            }
            return guest_session;
        }

    }
}
