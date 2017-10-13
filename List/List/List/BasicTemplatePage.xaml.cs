using List.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace List
{
    public partial class BasicTemplatePage : ContentPage
    {
        public BasicTemplatePage()
        {
            InitializeComponent();

            MyList.ItemsSource = new List<Contact>()
            {
                new Contact{ Name = "Adrien", Status = "", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                new Contact{ Name = "Emilie", Status = "Hey, let's talk", ImageUrl = "http://lorempixel.com/100/100/people/2" }
            };
        }
    }
}
