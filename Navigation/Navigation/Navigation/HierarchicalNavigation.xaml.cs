using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HierarchicalNavigation : ContentPage
    {
        public HierarchicalNavigation()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HierarchicalNavigation2());
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}