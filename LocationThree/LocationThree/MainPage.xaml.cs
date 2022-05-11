using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LocationThree
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void ButtonClicked(object obj, EventArgs args)
        {   
            string name = entAppName.Text;
            string lastname = entAppLastName.Text;
            string age = entAppAge.Text;
            string address = entAppAddress.Text;

            await Navigation.PushAsync(new SecondPage(name, lastname, age, address));

        }
    }
}
