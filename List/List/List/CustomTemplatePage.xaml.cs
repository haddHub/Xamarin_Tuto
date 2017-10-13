using List.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace List
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomTemplatePage : ContentPage
    {
        public CustomTemplatePage()
        {
            InitializeComponent();

            MyList.ItemsSource = new List<ContactGroup>()
            {
                new ContactGroup("A", "A")
                {
                    new Contact{ Name = "Adrien", Status = "", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                    new Contact{ Name = "Alfred", Status = "La lambo moret", ImageUrl = "http://lorempixel.com/100/100/people/3" }
                },
                new ContactGroup("E", "E")
                {
                    new Contact{ Name = "Emilie", Status = "Hey, let's talk", ImageUrl = "http://lorempixel.com/100/100/people/2" }
                }
            };
        }
    }
}