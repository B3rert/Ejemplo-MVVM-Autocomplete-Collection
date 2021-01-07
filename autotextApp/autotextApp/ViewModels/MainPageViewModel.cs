﻿using autotextApp.Helpers;
using autotextApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace autotextApp.ViewModels
{
    public class MainPageViewModel:BaseViewModel
    {
        public ObservableCollection<ProductoUso> ProductoUsos { get; set; }
        public ICommand SerachCommand { get; set; }

        public MainPageViewModel()
        {
            SerachCommand =
                new Command(async (Text) =>
                {
                  //la variable text tiene el valor agregado en serachBar
                });
        }

        public async Task LoadProductos()
        {
            var url = "http://190.149.177.249:81/api/PA_bsc_Producto_Uso_2";
            var service =
                new HttpHelper<ProductosUso>();
            var productos = await service.GetRestServiceDataAsync(url);

            ProductoUsos = new ObservableCollection<ProductoUso>(productos.Table);
        }
    }
}
