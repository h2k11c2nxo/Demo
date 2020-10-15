using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Gms.Common;
using Firebase;
using Firebase.Iid;
using Firebase.Messaging;
using Android.Util;
using Android.Content;
using FunitureExample.Pages;
using FunitureExample.Models;
using FunitureExample.Data;
using Java.Lang;

namespace FunitureExample.Droid
{
    [Activity(Label = "FunitureExample", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        static readonly string TAG = "MainActivity";

        internal static readonly string CHANNEL_ID = "my_notification_channel";
        internal static readonly int NOTIFICATION_ID = 100;

        [Obsolete]
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            LoadApplication(new App());

            var refreshedToken = FirebaseInstanceId.Instance.Token;
            System.Diagnostics.Debug.WriteLine($"FCM Token: {refreshedToken}");
            Intent i = new Intent(this, typeof(MainActivity));
            OnNewIntent(i);
        }


        protected override void OnNewIntent(Intent intent)
        {

            //base.OnNewIntent(intent);
            //    int userMedId =intent.GetIntExtra("id",0);
            //if (userMedId != 0)
            //{
            //    Product product = new Product();
            //    product = GetData.GetProductByName(userMedId);
            //    var action = intent.Action;
            //    App.Current.MainPage.Navigation.PushAsync(new DetailPage(product));
            //}

            if (intent != null)
            {
                string NotificationId = Intent.GetStringExtra("notificationId");
                if (NotificationId != null)
                {
                    int userMedId = Convert.ToInt32( intent.GetStringExtra("id"));
                    //App.IsNotified = true;
                    //App.NotifiedId = NotificationId;

                    //Page currentPage = App.Current.MainPage.Navigation.NavigationStack.LastOrDefault();
                    //var content = currentPage.FindByName<ContentView>("cvContentPlaceHolder");
                    //var notificationsSegmentedBarPage = new NotificationsSegmentedBarPage(Convert.ToInt32(App.NotifiedId));
                    //content.Content = notificationsSegmentedBarPage.Content;
                }
            }
        }




        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        

    }
}