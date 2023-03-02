using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Progetto_API
{
    public partial class Form1 : Form
    {
        static HttpClient client = new HttpClient();
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
          /* series Series = null;*/

        public Form1()
        {
            InitializeComponent();
            panel_logo.BackColor = Color.FromArgb(0,38,64);
            button_top_rated.BackColor = Color.FromArgb(0, 38, 64);
            button_get_popular.BackColor = Color.FromArgb(0, 38, 64);
            buttons_get_similar.BackColor = Color.FromArgb(0, 38, 64);
            buttons_get_latest.BackColor = Color.FromArgb(0, 38, 64);
            buttons_add_review.BackColor = Color.FromArgb(0, 38, 64);
            buttons_delete_review.BackColor = Color.FromArgb(0, 38, 64);
            label_benv.ForeColor = Color.FromArgb(0, 38, 64);
            client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private void buttons1_Click(object sender, EventArgs e)
        {
              Form2 f2 = new Form2();
              f2.Show();
              this.Hide();
        }

        private void buttons2_Click(object sender, EventArgs e)
        {

        }

        private void panel_logo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_get_popular_Click(object sender, EventArgs e)
        {

        }

        /* static async Task<series> GetAlbumAsync(string path)
         {
             series Series = null;
             HttpResponseMessage response = await client.GetAsync(path);
             if (response.IsSuccessStatusCode)
             {
                 Series = await JsonSerializer.DeserializeAsync<series>(await response.Content.ReadAsStreamAsync());
             }
             return Series;
         }
           }*/
    }
}
