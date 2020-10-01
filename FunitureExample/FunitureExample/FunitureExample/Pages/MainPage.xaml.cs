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

        //private void Button_Clicked(object sender, EventArgs e)
        //{
        //     Navigation.PushAsync(new DetailPage(product));
        //}

        //private void OpenMenu()
        //{
        //    MenuGrid.IsVisible = true;

        //    Action<double> callback = input => MenuView.TranslationX = input;
        //    MenuView.Animate("anim", callback, -260, 0, 16, 300, Easing.CubicInOut);
        //}

        //private void CloseMenu()
        //{
        //    Action<double> callback = input => MenuView.TranslationX = input;
        //    MenuView.Animate("anim", callback, 0, -260, 16, 300, Easing.CubicInOut);

        //    MenuGrid.IsVisible = false;
        //}


        //private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        //{
        //    OpenMenu();
        //}

        //private void OverlayTapped(object sender, EventArgs e)
        //{
        //    CloseMenu();
        //}


    }
}