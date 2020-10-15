using System;
using System.Collections;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Media;
using Android.Support.V4.App;
using Android.Widget;
using FunitureExample.Data;
using FunitureExample.Droid;
using FunitureExample.Models;
using FunitureExample.Pages;
using Java.Net;
using MediatR;
using Xamarin.Forms;

[assembly: Dependency(typeof(NotificationHelper))]
namespace FunitureExample.Droid
{
    class NotificationHelper : INotification
    {
        private Context mContext;
        private NotificationCompat.Builder mBuilder;
        public static String NOTIFICATION_CHANNEL_ID = "10023";

        public NotificationHelper()
        {
            mContext = global::Android.App.Application.Context;
        }

        

        [Obsolete]
        public void CreateNotification(String title, String message, IDictionary<string, string> data)
     {
            try
            {
                var intent = new Intent(mContext, typeof(MainActivity));
                intent.AddFlags(ActivityFlags.ClearTop);
                intent.PutExtra(title, message);
                intent.PutExtra("notificationId", NOTIFICATION_CHANNEL_ID);
                foreach (var key in data.Keys)
                {
                    if(key == "id")
                    {
                        intent.PutExtra("userMedId", data[key]);
                    }
                    else
                    {
                        intent.PutExtra(key, data[key]);
                    }

                   
                }
                
                var pendingIntent = PendingIntent.GetActivity(mContext, 0, intent, PendingIntentFlags.OneShot);


                // Creating an Audio Attribute
                var alarmAttributes = new AudioAttributes.Builder()
                    .SetContentType(AudioContentType.Sonification)
                    .SetUsage(AudioUsageKind.Notification).Build();

                mBuilder = new NotificationCompat.Builder(mContext);
                mBuilder.SetSmallIcon(Resource.Drawable.clear_button_icon);
                mBuilder.SetContentTitle(title)
                        .SetAutoCancel(true)
                        .SetContentTitle(title)
                        .SetContentText(message)
                        .SetChannelId(NOTIFICATION_CHANNEL_ID)
                        .SetPriority((int)NotificationPriority.High)
                        .SetVibrate(new long[0])
                        .SetDefaults((int)NotificationDefaults.Sound | (int)NotificationDefaults.Vibrate)
                        .SetVisibility((int)NotificationVisibility.Public)
                        .SetSmallIcon(Resource.Drawable.close)
                        .SetContentIntent(pendingIntent);

                if (data.ContainsKey("image"))
                {
                    var urlString = data["image"].ToString();
                    var url = new URL(urlString);
                    var connection = (HttpURLConnection)url.OpenConnection();
                    connection.DoInput = true;
                    connection.Connect();
                    var input = connection.InputStream;
                    var bitmap = BitmapFactory.DecodeStream(input);
                    var style = new NotificationCompat.BigPictureStyle()
                            .BigPicture(bitmap)
                            .SetSummaryText(message);
                    connection.Dispose();
                    mBuilder.SetStyle(style);
                }
               




                NotificationManager notificationManager = mContext.GetSystemService(Context.NotificationService) as NotificationManager;

                if (global::Android.OS.Build.VERSION.SdkInt >= global::Android.OS.BuildVersionCodes.O)
                {
                    NotificationImportance importance = global::Android.App.NotificationImportance.High;

                    NotificationChannel notificationChannel = new NotificationChannel(NOTIFICATION_CHANNEL_ID, title, importance);
                    notificationChannel.EnableLights(true);
                    notificationChannel.EnableVibration(true);
                    notificationChannel.SetShowBadge(true);
                    notificationChannel.Importance = NotificationImportance.High;
                    notificationChannel.SetVibrationPattern(new long[] { 100, 200, 300, 400, 500, 400, 300, 200, 400 });

                    if (notificationManager != null)
                    {
                        mBuilder.SetChannelId(NOTIFICATION_CHANNEL_ID);
                        notificationManager.CreateNotificationChannel(notificationChannel);
                    }
                }

                notificationManager.Notify(0, mBuilder.Build());
            }
            catch (Exception ex)
            {
                //
            }

           
        }
    }
}