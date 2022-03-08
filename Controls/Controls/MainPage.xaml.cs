using Controls.Pages;
using System;
using Xamarin.Forms;

namespace Controls
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ButtonPage());
        }

        private void btnEntryButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EntryPage());
        }
    }
}
