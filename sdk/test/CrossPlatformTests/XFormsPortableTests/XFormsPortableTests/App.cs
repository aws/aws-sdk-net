using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFormsPortableTests
{
    public class App : Application
    {
		private XFormsPortableRunner runner;
		
        public App()
        {
            var mainLabel = new Label
            {
                XAlign = TextAlignment.Center,
                Text = "Starting test run..."
            };
            var testsLabel = new Label
            {
                XAlign = TextAlignment.Center,
                Text = ""
            };

            // The root page of your application
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
						mainLabel, testsLabel
					}
                }
            };

            try
            {
                runner = new XFormsPortableRunner(mainLabel, testsLabel, Xamarin.Forms.Device.BeginInvokeOnMainThread);
            }
            catch(Exception e)
            {
                testsLabel.Text += e.ToString();
            }
            TestSdk(testsLabel);
        }

        private async Task TestSdk(Label label)
        {
            try
            {
                await runner.ExecuteAllTestsAsync();
            }
            catch (Exception e)
            {
                label.Text += e.ToString();
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
