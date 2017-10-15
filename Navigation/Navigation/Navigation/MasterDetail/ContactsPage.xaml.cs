using Navigation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigation.MasterDetail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsPage : ContentPage
    {
        public ContactsPage()
        {
            InitializeComponent();

            MyList.ItemsSource = GetContacts();
        }


        private IEnumerable<Contact> GetContacts()
        {
            return new List<Contact>()
            {
                new Contact() {Name= "Adrien", Status = "Oereerk" },
                new Contact() {Name= "Emilie", Status = "ssdsds" }
            };
        }

        private async void MyList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var contact = e.SelectedItem as Contact;
            await Navigation.PushAsync(new ContactDetail(contact));
            MyList.SelectedItem = null;
        }
    }
}