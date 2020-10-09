using Android.Telecom;
using Android.Webkit;
using Android.Widget;
using Foundation;
using FunitureExample.Data;
using FunitureExample.Models;
using FunitureExample.Themes;
using FunitureExample.ViewModels;
using NHibernate.Util;
using Sharpnado.MaterialFrame;
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

            Device.StartTimer(TimeSpan.FromSeconds(2), (Func<bool>)(() =>
            {
                CarouseViewImage.Position = (CarouseViewImage.Position + 1) % GetData.Productss.Count();
                return true;
            }));
            var listProduct = GetData.GetProducts().ToList();
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

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            bool isToggle = e.Value;
            ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
            if (mergedDictionaries != null)
            {
                if (isToggle == false)
                {
                    mergedDictionaries.Clear();
                    mergedDictionaries.Add(new DarkMode());
                    modeTheme.Text = "Dark Mode";
                }
                else
                {
                    mergedDictionaries.Clear();
                    mergedDictionaries.Add(new LightMode());
                    modeTheme.Text = "Light Mode";
                }
            }
        }

        //public const string DynamicPrimaryTextColor = nameof(DynamicPrimaryTextColor);
        //public const string DynamicSecondaryTextColor = nameof(DynamicSecondaryTextColor);

        //public const string DynamicNavigationBarColor = nameof(DynamicNavigationBarColor);
        //public const string DynamicBackgroundColor = nameof(DynamicBackgroundColor);
        //public const string DynamicBarTextColor = nameof(DynamicBarTextColor);

        //public const string DynamicTopShadow = nameof(DynamicTopShadow);
        //public const string DynamicBottomShadow = nameof(DynamicBottomShadow);

        //public const string DynamicHasShadow = nameof(DynamicHasShadow);

        //public const string Elevation4dpColor = nameof(Elevation4dpColor);


        //public static void SetDynamicResource(string targetResourceName, string sourceResourceName)
        //{
        //    if (!Application.Current.Resources.TryGetValue(sourceResourceName, out var value))
        //    {
        //        throw new InvalidOperationException($"key {sourceResourceName} not found in the resource dictionary");
        //    }

        //    Application.Current.Resources[targetResourceName] = value;
        //}

        //public static void SetDynamicResource<T>(string targetResourceName, T value)
        //{
        //    Application.Current.Resources[targetResourceName] = value;
        //}

        //public static void SetDarkMode()
        //{
        //    MaterialFrame.ChangeGlobalTheme(MaterialFrame.Theme.Dark);
        //    SetDynamicResource(DynamicNavigationBarColor, "DarkElevation2dp");
        //    SetDynamicResource(DynamicBarTextColor, "TextPrimaryDarkColor");

        //    SetDynamicResource(DynamicTopShadow, ShadowType.None);
        //    SetDynamicResource(DynamicBottomShadow, ShadowType.None);
        //    SetDynamicResource(DynamicHasShadow, false);

        //    SetDynamicResource(DynamicPrimaryTextColor, "TextPrimaryDarkColor");
        //    SetDynamicResource(DynamicSecondaryTextColor, "TextSecondaryDarkColor");

        //    SetDynamicResource(DynamicBackgroundColor, "DarkSurface");

        //    SetDynamicResource(Elevation4dpColor, "DarkElevation4dp");
        //}

        //public static void SetLightMode()
        //{
        //    MaterialFrame.ChangeGlobalTheme(MaterialFrame.Theme.Light);
        //    SetDynamicResource(DynamicNavigationBarColor, "Accent");
        //    SetDynamicResource(DynamicBarTextColor, "TextPrimaryDarkColor");

        //    SetDynamicResource(DynamicTopShadow, ShadowType.Top);
        //    SetDynamicResource(DynamicBottomShadow, ShadowType.Bottom);
        //    SetDynamicResource(DynamicHasShadow, true);

        //    SetDynamicResource(DynamicPrimaryTextColor, "TextPrimaryLightColor");
        //    SetDynamicResource(DynamicSecondaryTextColor, "TextSecondaryLightColor");

        //    SetDynamicResource(DynamicBackgroundColor, "LightSurface");

        //    SetDynamicResource(Elevation4dpColor, "OnSurfaceColor");
        //}
        //}



    }
}