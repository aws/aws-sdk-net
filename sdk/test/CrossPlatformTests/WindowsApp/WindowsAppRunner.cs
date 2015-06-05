using CommonTests;
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
        private Stream stream;
        private Windows.UI.Core.CoreDispatcher _dispatcher;

        public WindowsAppRunner(Stream stream, CoreDispatcher dispatcher, TextBlock textBlock)
            : base(stream)
        {
            // TODO: Complete member initialization
            this.stream = stream;
            _dispatcher = dispatcher;
            _output = textBlock;
        }

        protected override void WriteLine(string message)
        {
            _dispatcher.RunAsync(CoreDispatcherPriority.Normal,
                () => { _output.Text = _output.Text + "\n" + message; }).AsTask().Wait();
            
        }
    }
}
