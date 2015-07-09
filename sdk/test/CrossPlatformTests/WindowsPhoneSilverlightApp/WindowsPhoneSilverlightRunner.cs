using CommonTests.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Windows.UI.Core;

namespace WindowsPhoneSilverlightApp
{
    public class WindowsPhoneSilverlightRunner : TestRunner
    {
        private CoreDispatcher _dispatcher;
        private TextBlock _output;

        public WindowsPhoneSilverlightRunner(CoreDispatcher dispatcher, TextBlock textBlock)
        {
            _dispatcher = dispatcher;
            _output = textBlock;
        }

        protected override string TestTypeNamePrefix
        {
            get { return "Windows Phone Silverlight 8.1"; }
        }

        protected override void WriteLine(string message)
        {
            Output(message);
        }

        protected override void TestCompleted(string testMethodName, bool succeeded)
        {
            Output("{0} : {1}", testMethodName, succeeded ? "PASSED" : "FAILED");
        }

        private void Output(string format, params object[] args)
        {
            var message = string.Format(format, args);
            _dispatcher.RunAsync(CoreDispatcherPriority.Normal,
                () => { _output.Text = _output.Text + "\n" + message; }).AsTask().Wait();
        }
    }
}
