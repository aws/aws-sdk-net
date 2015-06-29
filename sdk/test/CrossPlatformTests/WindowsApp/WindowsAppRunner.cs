using CommonTests.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls;

namespace WindowsApp
{
    public class WindowsAppRunner : TestRunner
    {        
        private TextBlock _output;
        private Windows.UI.Core.CoreDispatcher _dispatcher;

        public WindowsAppRunner(CoreDispatcher dispatcher, TextBlock textBlock)
        {
            _dispatcher = dispatcher;
            _output = textBlock;
        }

        protected override void WriteLine(string message)
        {
            _dispatcher.RunAsync(CoreDispatcherPriority.Normal,
                () => { _output.Text = _output.Text + "\n" + message; }).AsTask().Wait();
            
        }

        protected override string TestTypeNamePrefix
        {
            get { return "Windows Store 8.1"; }
        }
    }
}
