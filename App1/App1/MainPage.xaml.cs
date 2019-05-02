using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            button.Clicked += Button_Clicked;
        }

        public async void  Button_Clicked(object sender, EventArgs e)
        {
            string name = entry.Text;
            string car_name = entry_car.Text;
            string hours_spend = entry_hours.Text;
            await DisplayAlert($"Hi there {name}",$"You will park your car {car_name} for {hours_spend} hours","OK");
        }
    }
}
