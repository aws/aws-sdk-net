using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using CommonTests.Framework;

namespace XFormsPortableTests
{
    public class XFormsPortableRunner : TestRunner
    {
        private Label _testsLabel = null;
        private Label _mainLabel = null;
        private Action<Action> _uiRunner = null;

        public XFormsPortableRunner(Label mainLabel, Label testsLabel, Action<Action> uiRunner)
            : base()
        {
            _mainLabel = mainLabel;
            _testsLabel = testsLabel;
            _uiRunner = uiRunner;
        }

        protected override void WriteLine(string message)
        {
            Write(message);
        }

        protected override void TestCompleted(string testMethodName, bool succeeded)
        {
            //Write("{0}: {1}", testMethodName, succeeded ? "PASSED" : "FAILED");
            if (!succeeded)
                _uiRunner(() => _mainLabel.Text = "FAILED");
        }

        private void Write(string message, params object[] args)
        {
            var text = string.Format(message, args);
            _uiRunner(() => _testsLabel.Text += Environment.NewLine + text);
        }

        protected override string TestTypeNamePrefix
        {
            get
            {
                return "XForms";
            }
        }
    }
}
