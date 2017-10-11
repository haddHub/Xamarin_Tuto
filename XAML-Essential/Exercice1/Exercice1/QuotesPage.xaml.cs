using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exercice1
{
    public partial class QuotesPage : ContentPage
    {
        private string[] quotes;
        private int quotesIndice;

        public QuotesPage()
        {
            InitializeComponent();
            quotes = new string[] {
                "Phrase1",
                "Phrase2",
                "Phrase3"
            };
            quotesIndice = 0;
            SetQuote();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            quotesIndice++;

            if (quotesIndice > quotes.Length - 1)
                quotesIndice = 0;

            SetQuote();
        }

        private void SetQuote()
        {
            QuoteLabel.Text = quotes[quotesIndice];
        }
    }
}