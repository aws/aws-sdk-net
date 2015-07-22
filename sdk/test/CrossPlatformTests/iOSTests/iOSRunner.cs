using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using CommonTests;
using System.IO;
using CommonTests.Framework;

namespace iOSTests
{
    public class iOSRunner : TestRunner
    {
        private UILabel _label = null;
        private UITextView _textView = null;
        private Action<Action> _uiRunner = null;

        public iOSRunner(UILabel label, UITextView txtView, Action<Action> uiRunner)
            : base()
        {
            _textView = txtView;
            _uiRunner = uiRunner;
            _label = label;
        }

        protected override void WriteLine(string message)
        {
            Write(message);
        }

        protected override void TestCompleted(string testMethodName, bool succeeded)
        {
            Write("{0}: {1}", testMethodName, succeeded ? "PASSED" : "FAILED");
            if (!succeeded)
                _uiRunner(() => _label.Text = "FAILED");
        }

        protected override string TestTypeNamePrefix
        {
            get { return "iOSTests"; }
        }

        private void Write(string message, params object[] args)
        {
            var text = string.Format(message, args);
            _uiRunner(() => _textView.Text = text + Environment.NewLine + _textView.Text);
        }
    }
}