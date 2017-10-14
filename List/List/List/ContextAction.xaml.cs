using List.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace List
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContextAction : ContentPage
    {
        private ObservableCollection<Contact> _contacts;

        public ContextAction()
        {
            InitializeComponent();
            _contacts = new ObservableCollection<Contact>()
            {
                new Contact{ Name = "Adrien", Status = "", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                new Contact{ Name = "Alfred", Status = "La lambo moret", ImageUrl = "http://lorempixel.com/100/100/people/3" },
                new Contact{ Name = "Emilie", Status = "Hey, let's talk", ImageUrl = "http://lorempixel.com/100/100/people/2" }
            };

            MyList.ItemsSource = _contacts;
        }

        private void Call_Clicked(object sender, EventArgs e)
        {
            var menuTiem = sender as MenuItem;
            var contact = menuTiem.CommandParameter as Contact;
            DisplayAlert("Call", contact.Name, "OK");
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            _contacts.Remove(contact);
        }

        private void MyList_Refreshing(object sender, EventArgs e)
        {
            // Call to the remote service
            _contacts = new ObservableCollection<Contact>()
            {
                new Contact{ Name = "Adrien", Status = "", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                new Contact{ Name = "Alfred", Status = "La lambo moret", ImageUrl = "http://lorempixel.com/100/100/people/3" },
                new Contact{ Name = "Emilie", Status = "Hey, let's talk", ImageUrl = "http://lorempixel.com/100/100/people/2" }
            };

            MyList.ItemsSource = _contacts;

            MyList.EndRefresh();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Chopper les contact qui on le text avec du linq et Name.StartWith et donner a MyList.ItemsSource
        }
    }
}