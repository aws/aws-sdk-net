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
        public AndroidRunner(Stream credentials)
            : base(credentials)
        {
        }
    }
}