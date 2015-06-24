using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace XFormsPortableTests.Droid
{
    [Activity(Label = "XFormsPortableTests", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

			AndroidEnvironment.UnhandledExceptionRaiser += MyApp_UnhandledExceptionHandler;

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }

		void MyApp_UnhandledExceptionHandler(object sender, RaiseThrowableEventArgs e)
		{
			Console.WriteLine (e);
			Console.WriteLine (e.Exception.ToString ());
		}

		protected override void Dispose(bool disposing)
		{
			AndroidEnvironment.UnhandledExceptionRaiser -= MyApp_UnhandledExceptionHandler;
			base.Dispose(disposing);
		}
    }
}

