using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_API
{
    public class series
    {
        public string poster_path { get; set; }
        public int popularity { get; set; }
        public int id { get; set; }
        public string backdrop_path { get; set; }
        public int vote_average { get; set; }
        public string overview { get; set; }
        public string first_air_date { get; set; }
        public string[] origin_country { get; set; }
        public int[] genre_ids { get; set; }
        public string original_language { get; set; }
        public int vote_count { get; set; }
        public string name { get; set; }
        public string original_name { get; set; }

        /*
        override
         public string ToString()
         {
             return "{" + Environment.NewLine + "'postId': " + postId + "," + Environment.NewLine + "'id': " + id + "," + Environment.NewLine + "'name': " + name + "," + Environment.NewLine + "'email': " + email + "," + Environment.NewLine + "'body': " + body + Environment.NewLine + "}";
         }*/
    }
}
