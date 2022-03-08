using GruppeList.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using GruppeList.Pages;

namespace GruppeList
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCarusel_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CaruselPage());
        }

        private void btnList_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListPage());
        }

        private void btnPiker_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PikerPage());
        }

        private void btnTable_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TablePage());
        }
    }
}
