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
using CommonTests;
using System.IO;

namespace AndroidApp
{
    public class AndroidRunner : TestRunner
    {
        private TextView _textView = null;

        public AndroidRunner(Stream credentials, TextView txtView)
            : base(credentials)
        {
            _textView = txtView;
        }

        public override void WriteLine(string message)
        {
            _textView.Append(message);
        }
    }
}