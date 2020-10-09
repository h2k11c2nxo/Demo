using Android;
using FunitureExample.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FunitureExample.ViewModels
{
    [Android.Runtime.Preserve]
    public class DetailViewModel : BaseViewModel
    {
        public Product Product { get; set; }
        public Command PopDetailPageCommand { get; set; }


        public DetailViewModel()
        {
            PopDetailPageCommand = new Command(async () => await ProductDetail());
        }
        
        async Task ProductDetail()
        {
            await App.Current.MainPage.Navigation.PopAsync();
        }
   

    }
}
