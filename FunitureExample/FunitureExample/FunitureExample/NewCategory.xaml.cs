using FunitureExample.Data;
using FunitureExample.Models;
using FunitureExample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FunitureExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewCategory : ContentPage
    {
        //MainPageViewModels ViewModel = new MainPageViewModels(Navigation);

        public NewCategory(Category category)
        {
            InitializeComponent();
            //BindingContext = ViewModel;
        }



        private void Button_Clicked(object sender, EventArgs e)
        {
            
             var item = (sender as Button).BindingContext as Category;
            //ViewModel.DeleteCategory(item);
        }
    }
}