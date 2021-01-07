using autotextApp.Models;
using autotextApp.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace autotextApp
{
    public partial class MainPage : ContentPage
    {
        public MainPageViewModel ViewModel { get; set; }

        public MainPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            ViewModel = new MainPageViewModel();
            await ViewModel.LoadProductos();
            this.BindingContext = ViewModel;
           
        }

        private async void SfAutoComplete_SelectionChanged(object sender, Syncfusion.SfAutoComplete.XForms.SelectionChangedEventArgs e)
        {
            var Producto = e.Value as ProductoUso;

          //  await DisplayAlert("",Producto.Descripcion,"OK");
        }
    }
}
