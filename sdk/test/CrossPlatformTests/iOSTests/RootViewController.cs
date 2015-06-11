using System;
using System.Drawing;
using Foundation;
using UIKit;
using System.Threading.Tasks;
using System.Linq;
using System.Reflection;
using System.IO;

namespace iOSTests
{
    public partial class RootViewController : UIViewController
    {
        static bool UserInterfaceIdiomIsPhone
        {
            get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
        }

        public RootViewController(IntPtr handle)
            : base(handle)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        private async Task RunTests()
        {
            try
            {
                mainTextView.Text = string.Empty;
                var runner = new iOSRunner(mainLabel, mainTextView, InvokeOnMainThread);
                await runner.ExecuteAllTestsAsync();
            }
            catch (Exception e)
            {
                mainTextView.Text = e.ToString();
            }
        }

        #region View lifecycle

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.

            mainTextView.Frame = View.Bounds;
            RunTests();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }

        #endregion
    }
}