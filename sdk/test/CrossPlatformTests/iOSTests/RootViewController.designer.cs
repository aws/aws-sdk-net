// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace iOSTests
{
	[Register ("RootViewController")]
	partial class RootViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel mainLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextView mainTextView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (mainLabel != null) {
				mainLabel.Dispose ();
				mainLabel = null;
			}
			if (mainTextView != null) {
				mainTextView.Dispose ();
				mainTextView = null;
			}
		}
	}
}
