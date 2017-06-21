using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBook.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string Description { get; set; } // get n set harus string juga
        public Artist[] Artists { get; set; } // panggil kelas artist atribut tipe [] dari Artist dinamain Artists

        public string DisplayText   //Untuk nampilin Nama Bukunya
        {
            get
            {
                return SeriesTitle + "#" + IssueNumber;
            }
        }

        public string getCoverImageName
        {
            get
            {
                return SeriesTitle.ToLower().Replace(" ", "-") + "-" + IssueNumber +".jpg";
                //karna di folder image nama imagenya huruf kecil dan ada - (strip)
            }
        }
    }
}



