using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LocationThree
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPage : ContentPage
    {
        public SecondPage(string name, string lastname, string age, string address)
        {
            InitializeComponent();

            Label namelabel = this.FindByName<Label>("namelbl");
            Label lastnamelabel = this.FindByName<Label>("lastnamelbl");
            Label agelabel = this.FindByName<Label>("agelbl");
            Label addresslabel = this.FindByName<Label>("addresslbl");

            namelabel.Text = name;
            lastnamelabel.Text = lastname;
            agelabel.Text = age;
            addresslabel.Text = address;
        }
    }
}