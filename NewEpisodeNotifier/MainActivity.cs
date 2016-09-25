using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;

namespace NewEpisodeNotifier
{
    [Activity(Label = "NewEpisodeNotifier", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = " ";

            var editToolbar = FindViewById<Toolbar>(Resource.Id.edit_toolbar);
            editToolbar.Title = " ";
            editToolbar.InflateMenu(Resource.Menu.edit_menus);
            editToolbar.MenuItemClick += (sender, e) => {
                Toast.MakeText(this, "Bottom toolbar tapped: " + e.Item.TitleFormatted, ToastLength.Short).Show();
            };
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.top_menus, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            Toast.MakeText(this, "Action selected: " + item.TitleFormatted,
                ToastLength.Short).Show();
            return base.OnOptionsItemSelected(item);
        }
    }
}

