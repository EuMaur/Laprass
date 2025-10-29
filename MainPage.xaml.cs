using Microsoft.Maui.Controls;
using System;

namespace Laprass
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            
            await Navigation.PushAsync(new LoginPage());
        }
    }
}
