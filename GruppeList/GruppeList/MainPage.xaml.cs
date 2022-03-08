using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GruppeList
{
    public partial class MainPage : ContentPage
    {
        private const string monkeyUrl = "https://montemagno.com/monkeys.json";

        private readonly HttpClient httpClient = new HttpClient();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
