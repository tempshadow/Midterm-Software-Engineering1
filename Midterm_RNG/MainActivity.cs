using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace Midterm_RNG
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            EditText ipAddress = FindViewById<EditText>(Resource.Id.IPAddress);
            TextView output = FindViewById<TextView>(Resource.Id.Result);
            Button rngBtn = FindViewById<Button>(Resource.Id.BtnRng);
            rngBtn.Click += (sender, e) =>
            {
                string number = Midterm_RNG.PingIP.GetRng(ipAddress.Text);
                if (string.IsNullOrWhiteSpace(number))
                {
                    output.Text = string.Empty;
                }
                else
                {
                    output.Text = number;
                }
            };
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}