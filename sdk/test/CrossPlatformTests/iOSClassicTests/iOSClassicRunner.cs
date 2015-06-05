using CommonTests;
using MonoTouch.UIKit;
using System;
using System.Collections.Generic;
using System.Text;

namespace iOSClassicTests
{
    //public class iOSClassicRunner : TestRunner
    //{
    //    private UITextView _textView = null;
    //    private Action<Action> _uiRunner = null;

    //    public iOSClassicRunner(UITextView txtView, Action<Action> uiRunner)
    //        : base()
    //    {
    //        _textView = txtView;
    //        _uiRunner = uiRunner;
    //    }

    //    protected override void WriteLine(string message)
    //    {
    //        _uiRunner(() => _textView.Text += Environment.NewLine+ message);
    //    }
    //}

    public class iOSClassicRunner : TestRunner
    {
        private UILabel _label = null;
        private UITextView _textView = null;
        private Action<Action> _uiRunner = null;

        public iOSClassicRunner(UILabel label, UITextView txtView, Action<Action> uiRunner)
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

        private void Write(string message, params object[] args)
        {
            var text = string.Format(message, args);
            _uiRunner(() => _textView.Text += Environment.NewLine + text);
        }
    }

}
