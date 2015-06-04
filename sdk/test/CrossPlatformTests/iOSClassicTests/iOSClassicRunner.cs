using CommonTests;
using MonoTouch.UIKit;
using System;
using System.Collections.Generic;
using System.Text;

namespace iOSClassicTests
{
    public class iOSClassicRunner : TestRunner
    {
        private UITextView _textView = null;
        private Action<Action> _uiRunner = null;

        public iOSClassicRunner(UITextView txtView, Action<Action> uiRunner)
            : base()
        {
            _textView = txtView;
            _uiRunner = uiRunner;
        }

        protected override void WriteLine(string message)
        {
            _uiRunner(() => _textView.Text += Environment.NewLine+ message);
        }
    }
}
