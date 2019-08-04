using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace CTUMobile
{
    class Campus
    {
        public int Id { get; set; }
        public string CampusName { get; set; }
        public Uri CampusLocation { get; set; }
        public BitmapImage CampusImage { get; set; }
        public string CampusContact { get; set; }
        public string CampusDescription { get; set; }
        public Dictionary<String, String> CampusCourses { get; set; }
        public string CampusActivities { get; set; }
        public System.Uri CampusVideos { get; set; }
        public double MapLong { get; set; }
        public double MapLat { get; set; }
    }
}
