using FunitureExample.Models;
using FunitureExample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FunitureExample.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : BaseContentPage<DetailViewModel>
    {
        public DetailPage( Product product)
        {
            InitializeComponent();
            ViewModel.Product = product;
        }
    }
}