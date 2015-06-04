using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using CommonTests;
using System.IO;

namespace iOSTests
{
    public class iOSRunner : TestRunner
    {
        private UITextView _textView = null;
        private Action<Action> _uiRunner = null;

        public iOSRunner(UITextView txtView, Action<Action> uiRunner)
            : base()
        {
            _textView = txtView;
            _uiRunner = uiRunner;
        }

        public override void WriteLine(string message)
        {
            _uiRunner(() => _textView.Text += Environment.NewLine+ message);
        }
    }
}