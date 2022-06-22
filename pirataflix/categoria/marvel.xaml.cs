using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace pirataflix.categoria
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class marvel : ContentPage
    {
        public marvel()
        {
            InitializeComponent();
            logo.Source = ImageSource.FromResource("pirataflix.img.logo.png");
            avengers_eg.Source = ImageSource.FromResource("");
            capitaoamerica_gc.Source = ImageSource.FromResource("pirataflix.poster.capitaoamerica_gc.jpg");
            ironman3.Source = ImageSource.FromResource("pirataflix.poster.ironman3.jpg");
            spidermannwh.Source = ImageSource.FromResource("pirataflix.poster.spidermannwh.jpg");
        }
    }
}