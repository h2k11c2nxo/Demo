﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FunitureExample.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainViewPage : Xamarin.Forms.TabbedPage
    {
        public MainViewPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }   
    }
}