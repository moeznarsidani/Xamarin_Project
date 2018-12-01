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
using Java.Lang;

namespace Final_Project
{
    class ListAdapter : BaseAdapter<ListItem>
    {

        private List<ListItem> mItems;
        private Context mContext;
        public ListAdapter(Context context, List<ListItem> items)
        {
            mItems = items;
            mContext = context;
        }



        public override int Count
        {
            get
            {
                return mItems.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override ListItem this[int position]
        {
            get
            {
                return mItems[position];
            }
        }


        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;
            if (row == null)
            {
                row = LayoutInflater.From(mContext).Inflate(Resource.Layout.ListItem, null, false);
            }
            ImageView user = row.FindViewById<ImageView>(Resource.Id.imageView1);

            TextView topics = row.FindViewById<TextView>(Resource.Id.lName);
            Button forward = row.FindViewById<Button>(Resource.Id.signup);

            topics.Text = mItems[position].topics;

            return row;
        }


    }
}