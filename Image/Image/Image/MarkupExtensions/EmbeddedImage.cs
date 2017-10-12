using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Image.MarkupExtensions
{
    [ContentProperty("RessourceID")]
    public class EmbeddedImage : IMarkupExtension
    {
        public string RessourceID { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (string.IsNullOrWhiteSpace(RessourceID))
                return null;

            return ImageSource.FromResource(RessourceID);
        }
    }
}
