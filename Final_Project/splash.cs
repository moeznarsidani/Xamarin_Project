using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using System.Threading;
using Android.Views;
using Android.Widget;
using System.Threading.Tasks;

namespace Final_Project
{
    [Activity(Label = "Project", Theme = "@style/splashTheme", MainLauncher = true, NoHistory = true)]
    public class splash : Activity
    {
        public override void OnCreate(Bundle savedInstanceState, PersistableBundle bundle)
        {
            base.OnCreate(savedInstanceState, bundle);

            // Create your application here
        }
        public override void OnBackPressed()
        {

        }

        protected override void OnResume()
        {
            base.OnResume();
            Task tk = new Task(() => { StartMainActivity(); });
            tk.Start();
        }

        async void StartMainActivity()
        {
            await Task.Run(() =>
            {
                Task.Delay(12000);
                StartActivity(new Intent(Application.Context, typeof(MainActivity)));
            });
        }


    }
}