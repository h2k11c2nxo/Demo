using Android.Telecom;
using Android.Webkit;
using FunitureExample.Data;
using FunitureExample.Models;
using FunitureExample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.PancakeView;
using Xamarin.Forms.Xaml;

namespace FunitureExample.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : BaseContentPage<MainPageViewModel>
    {
        public MainPage()
        {
            InitializeComponent();
            
            Device.StartTimer(TimeSpan.FromSeconds(2), (Func<bool>)(() => {
                CarouseViewImage.Position = (CarouseViewImage.Position + 1) % GetData.Productss.Count();
                return true;
            }));

        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var pancake = (PancakeView)sender;
            pancake.BackgroundColor = Color.FromHex("#F5C03E");

        }

        private void TapGestureRecognizer_Close(object sender, EventArgs e)
        {

            textSearch.Text = string.Empty;
        }
        private void TapGestureRecognizer_Search(object sender, EventArgs e)
        {
            textSearch.Focus();
        }
        
    }
}