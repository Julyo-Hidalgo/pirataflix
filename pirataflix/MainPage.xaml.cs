using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace pirataflix
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            logo.Source = ImageSource.FromResource("pirataflix.img.logo.png");
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new categoria.marvel());
            }catch (Exception ex)
            {
                await DisplayAlert("Ops, algo deu errado...", ex.Message.ToString(), "Ok");
            }
        }
    }
}
