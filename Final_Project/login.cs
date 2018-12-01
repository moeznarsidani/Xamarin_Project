using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V4.Widget;
using SupportFragment = Android.Support.V4.App.Fragment;
using SupportFragmentManager = Android.Support.V4.App.FragmentManager;
using SupportToolbar = Android.Support.V7.Widget.Toolbar;
using SupportActionBar = Android.Support.V7.App.ActionBar;
using Android.Support.V7.App;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Support.V4.App;
using System.Collections.Generic;
using Java.Lang;
using System.Threading;

namespace Final_Project
{
    [Activity(Label = "login", Theme = "@style/AppTheme")]
    public class login : AppCompatActivity
    {
      
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.login);
           
            try

            {
                SupportToolbar toolBar = FindViewById<SupportToolbar>(Resource.Id.toolBar);
                SetSupportActionBar(toolBar);

                SupportActionBar ab = SupportActionBar;
                ab.SetDisplayHomeAsUpEnabled(true);
                ab.SetHomeButtonEnabled(true);
            }
            catch
            {

            }
            //  mDrawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);

            /* NavigationView navigationView = FindViewById<NavigationView>(Resource.Id.nav_view);
             if (navigationView != null)
             {
                 SetUpDrawerContent(navigationView);
             }*/
        }

       
        

       /* public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    mDrawerLayout.OpenDrawer((int)GravityFlags.Left);
                    return true;

                default:
                    return base.OnOptionsItemSelected(item);
            }
        }*/
        /*private void SetUpDrawerContent(NavigationView navigationView)
        {
            navigationView.NavigationItemSelected += (object sender, NavigationView.NavigationItemSelectedEventArgs e) =>
            {
                switch (e.MenuItem.ItemId)
                {
                    case Resource.Id.nav_home:
                        Toast.MakeText(this, "Hello!welcome to xamarin world", ToastLength.Long);
                        return;
                    case Resource.Id.login:
                        var i = new Intent(this, typeof(login));
                        StartActivity(i);

                        return;
                    case Resource.Id.logout:
                        i = new Intent(this, typeof(login));
                        StartActivity(i);

                        return;
                    case Resource.Id.Register:
                        i = new Intent(this, typeof(login));
                        StartActivity(i);

                        return;

                    default:
                        e.MenuItem.SetChecked(true);
                        mDrawerLayout.CloseDrawers();
                        return;
                }
            };

        }*/
    }
}