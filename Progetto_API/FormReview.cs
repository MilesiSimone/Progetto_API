using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
            client.BaseAddress = new Uri("https://api.themoviedb.org/3/tv/");
            scelta = s;
            scelta1 = d;
            if (scelta == "add" || scelta1 == "add")
            {
                label_titolo.Text = "ADD REVIEW";
                label_value.Visible = true;
                comboBox_valutazione.Visible = true;
                
                if (scelta1 == "add")
                {
                    label_titolo_series.Text = c;
                    label_titolo_series.Visible = true;
                    label_titolo_series.Location = new Point(pictureBox2.Left + pictureBox2.Width / 2 - label_titolo_series.Width / 2, label_titolo_series.Top);
                    pictureBox2.Load(b);
                    pictureBox2.Visible = true;
                    textBox_id_series.Text = a;
                    label_value.Visible = true;
                    comboBox_valutazione.Visible = true;
                }
                if (scelta == "add")
                {
                    textBox_id_series.Text = "";
                    //label_id_series.Location = new Point(this.Width / 2)
                    label_nota_1.Visible = true;
                    label_nota_2.Visible = true;
                }
            }
            else
            {
                label_titolo.Text = "DELETE REVIEW";
                textBox_id_series.Text = "";
                label_nota_1.Visible = true;
                label_nota_2.Visible = true;
            }

            panel_logo.BackColor = Color.FromArgb(0, 38, 64);
            label_torna_indietro.ForeColor = Color.FromArgb(0, 38, 64);
            buttons_send.BackColor = Color.FromArgb(0, 38, 64);

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
            if (label_titolo.Text == "ADD REVIEW" && textBox_id_series.Text != "")
            {
                guest_session = await GetSessionGuestAsync();
                //MessageBox.Show(guest_session.guest_session_id);
                Body_Info body_Info = new Body_Info(decimal.Parse(comboBox_valutazione.Text));
                var url = await CreateReviewAsync(body_Info);
                MessageBox.Show("Richiesta eseguita con successo, status code: " + url);
                this.Close();
            }
            else if (label_titolo.Text == "DELETE REVIEW" && textBox_id_series.Text != "")
            {
                guest_session = await GetSessionGuestAsync();
                var url = await DeleteReviewAsync();
                MessageBox.Show("Richiesta eseguita con successo, status code: " + url);
                this.Close();
            }
        }

        private async Task<HttpStatusCode> CreateReviewAsync(Body_Info value)
        {
            //MessageBox.Show(client.BaseAddress + textBox_id_series.Text + "/rating?api_key=" + api_key + "&guest_session=" + guest_session.guest_session_id);
            HttpResponseMessage response = await client.PostAsJsonAsync(client.BaseAddress + textBox_id_series.Text + "/rating?api_key=" + api_key + "&guest_session_id=" + guest_session.guest_session_id, value);

            //MessageBox.Show(decimal.Parse(comboBox_valutazione.Text).ToString());
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }

        private void comboBox_valutazione_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async Task<HttpStatusCode> DeleteReviewAsync()
        {
            HttpResponseMessage response = await client.DeleteAsync(
                client.BaseAddress + textBox_id_series.Text + "/rating?api_key=" + api_key + "&guest_session_id=" + guest_session.guest_session_id);
            return response.StatusCode;
        }

    }
}
