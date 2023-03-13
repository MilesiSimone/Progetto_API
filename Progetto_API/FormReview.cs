using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Progetto_API
{
    public partial class FormReview : Form
    {
        static HttpClient client = null;
        string scelta;
        public Form _fr1;
        string ContentType = "application/json;charset=utf-8";
        string api_key = "c576ca5974295b2a0cc99a98e910425c";
        string guest_session_id = "8166f2859e2d95371dc776cb00ef3cf4";
        string image_path = "https://image.tmdb.org/t/p/w500";

        public FormReview(string s, string a, string b, string c)
        {
            InitializeComponent();
            client = new HttpClient();
            //_fr1 = f1;
            scelta = s;
            if (scelta == "add")
            {
                label_titolo.Text = "ADD REVIEW";
                label_value.Visible = true;
                comboBox_valutazione.Visible = true;
                client.BaseAddress = new Uri("https://api.themoviedb.org/3/tv/");
            }
            else
            {
                label_titolo.Text = "DELETE REVIEW";
                client.BaseAddress = new Uri("https://api.themoviedb.org/3/tv/");
            }
            if (s == "from_form_details")
            {
                label_titolo_series.Text = c;
                label_titolo_series.Visible = true;
                pictureBox2.Load(b);
                pictureBox2.Visible = true;
                textBox_id_series.Text = a;
            }
            panel_logo.BackColor = Color.FromArgb(0, 38, 64);
            label_torna_indietro.ForeColor = Color.FromArgb(0, 38, 64);
            buttons_send.ForeColor = Color.FromArgb(0, 38, 64);

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

        //static async Task<Uri> CreateReviewAsync(string path)
        //{

        //    HttpResponseMessage response = await client.PostAsJsonAsync("/comments", product); response.EnsureSuccessStatusCode();

        //    return response.Headers.Location;
        //}
    }
}
