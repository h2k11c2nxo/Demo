using FunitureExample.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FunitureExample.Pages
{
    public class BaseContentPage : ContentPage
    {
        public BaseContentPage()
        {
        }
    }

    public class BaseContentPage<T> : ContentPage where T : BaseViewModel
    {
        public T ViewModel { get; set; }
        public BaseContentPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            ViewModel = Activator.CreateInstance<T>();
            ViewModel.Initialize();

            BindingContext = ViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ViewModel.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            ViewModel.OnDisappearing();
        }
    }
}
