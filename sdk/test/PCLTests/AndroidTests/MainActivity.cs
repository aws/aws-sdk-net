using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using AndroidTests.Utils;
using Amazon.DynamoDBv2.Model;
using Amazon.DynamoDBv2;
using Amazon.Runtime;
using Amazon;

namespace AndroidTests
{
    [Activity(Label = "AndroidTests", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        AWSCredentials sdkCredentials = null;
        RegionEndpoint sdkRegion = Amazon.RegionEndpoint.USEast1;
        EditText text = null;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var button = FindViewById<Button>(Resource.Id.MyButton);
            text = FindViewById<EditText>(Resource.Id.TextField);

            sdkCredentials = new VendedCredentials(Assets.Open("credentials.json"));

            button.Click += (s, e) =>
            {
                button.Text = string.Format("{0} clicks!", count++);
                text.Text = string.Empty;
                MakeSdkCall();
            };
            MakeSdkCall();

            //text.Text += System.Environment.NewLine + "end of custom logic";
        }

        private async void MakeSdkCall()
        {
            try
            {
                using (var client = new AmazonDynamoDBClient(sdkCredentials, sdkRegion))
                {
					var result = await client.ListTablesAsync(new ListTablesRequest());
                    var tables = result.TableNames;
					Log("{0} tables found", tables.Count);
					Log(string.Join(System.Environment.NewLine, tables));
                }
            }
            catch (Exception e)
            {
				Log (e.ToString ());
            }
        }

		private void Log(string format, params object[] args)
		{
			var message = string.Format (format, args);
			text.Text += System.Environment.NewLine + message;
		}
    }
}

