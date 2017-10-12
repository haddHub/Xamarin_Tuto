using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Image
{
    public partial class ActivityIndicatorExemple : ContentPage
    {
        public ActivityIndicatorExemple()
        {
            InitializeComponent();

            var imageSource = new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/sports/7/") };
            imageSource.CachingEnabled = false;
            //imageSource.CacheValidity = TimeSpan.FromHours(1);

            image.Source = imageSource;
        }
    }
}
