using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progetto_API
{
    public partial class FormDetails : Form
    {
        int i = 0;
        string temp = "";
        string image_path = "https://image.tmdb.org/t/p/w500";

        public FormDetails(string n_serie, Rootobject Root_Series)
        {
            InitializeComponent();
            temp = n_serie;
            i = Convert.ToInt32(temp);
            label_title.Text =
            label_title.Text = Root_Series.results[i].name;
            label_fist_result.Text = Root_Series.results[i].first_air_date;
            string s = string.Join("" , Root_Series.results[i].genre_ids);
            label_genre_result.Text= s;
            s = string.Join("", Root_Series.results[i].origin_country);
            label_orgin_country_result.Text = s;
            label_language_result.Text = Root_Series.results[i].original_language.ToString();
            label_origin_name_result.Text = Root_Series.results[i].original_name;
            label_popularity_result.Text = Root_Series.results[i].popularity.ToString();
            label_vote_average_result.Text = Root_Series.results[i].vote_average.ToString();
            label_vote_count_result.Text = Root_Series.results[i].vote_count.ToString();
            pictureBox_poster_path.Load(image_path + Root_Series.results[i].poster_path);
            pictureBox_backdrop_image.Load(image_path + Root_Series.results[i].backdrop_path);
            textBox_overview.Text = Root_Series.results[i].overview;
            label_title.ForeColor= Color.FromArgb(0, 38, 64);
            label_first_air_date.ForeColor = Color.FromArgb(0, 38, 64);
            label_vote_count.ForeColor = Color.FromArgb(0, 38, 64);
            label_genre_ids.ForeColor = Color.FromArgb(0, 38, 64);
            label_original_name.ForeColor = Color.FromArgb(0, 38, 64);
            label_origin_country.ForeColor = Color.FromArgb(0, 38, 64);
            label_overview.ForeColor = Color.FromArgb(0, 38, 64);
            label_popularity.ForeColor = Color.FromArgb(0, 38, 64);
            label_voto_average.ForeColor = Color.FromArgb(0, 38, 64);
            panel_logo.BackColor = Color.FromArgb(0, 38, 64);
            label_or_language.ForeColor = Color.FromArgb(0, 38, 64);
            buttons_review.BackColor = Color.FromArgb(0, 38, 64);
        }

        private void FormDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
