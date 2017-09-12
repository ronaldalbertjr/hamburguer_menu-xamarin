using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

[assembly: Xamarin.Forms.Dependency(typeof(DropdownMenu.Droid.DependencyImplementation))]
namespace DropdownMenu.Droid
{
    class DependencyImplementation:IDependencyService
    { 
        public void SendNotification(string title, string text)
        {
            Notification.Builder mBuilder = (Notification.Builder)new Notification.Builder(MainActivity.context).SetContentTitle(title).SetContentText(text).SetAutoCancel(true);
            mBuilder.SetVibrate(new long[] { 100, 250, 100, 500 });
            NotificationManager mNotificationManager = (NotificationManager)MainActivity.context.GetSystemService(Context.NotificationService);
            mNotificationManager.Notify(0, mBuilder.Build());
        }
    }
}