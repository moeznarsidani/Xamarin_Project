using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections.Generic;
using System;
using SupportActionBar = Android.Support.V7.App.ActionBar;
using Android.Views;
using Android.Content;


namespace Final_Project
{
    [Activity(Label = "Xamarin Tutorials", Theme = "@style/AppTheme")]
    public class ListActivity : AppCompatActivity
    {
        private List<ListItem> mItems;
        private ListView mListView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ListActivity);

            SupportActionBar ab = SupportActionBar;
            //  ab.SetHomeAsUpIndicator(Resource.Drawable.ic_menu);
            ab.SetDisplayShowHomeEnabled(true);
            ab.SetDisplayHomeAsUpEnabled(true);
            mListView = FindViewById<ListView>(Resource.Id.mylview);


            mItems = new List<ListItem>();
            ListItem a = new ListItem();
            a.user = "";
            a.topics = "installation";

            a.forward = "";
            mItems.Add(a);

            mItems.Add(new ListItem() { user = "", topics = "First Xamarin Application", forward = "" });
            mItems.Add(new ListItem() { user = "", topics = "App Manifest", forward = "" });
            mItems.Add(new ListItem() { user = "", topics = "Android Resources", forward = "" });
            mItems.Add(new ListItem() { user = "", topics = "Android Activity Lifecycle", forward = "" });
            mItems.Add(new ListItem() { user = "", topics = "Permissions", forward = "" });
            mItems.Add(new ListItem() { user = "", topics = "Building The App UI", forward = "" });
            mItems.Add(new ListItem() { user = "", topics = "Menus", forward = "" });
            mItems.Add(new ListItem() { user = "", topics = "Layouts", forward = "" });
            mItems.Add(new ListItem() { user = "", topics = "android widgets", forward = "" });
            mItems.Add(new ListItem() { user = "", topics = "Andeoid Dialogs", forward = "" });
            mItems.Add(new ListItem() { user = "", topics = "End projects", forward = "" });



            ListAdapter ada = new ListAdapter(this, mItems);


            mListView.Adapter = ada;
            // Create your application here
        }
    }
}