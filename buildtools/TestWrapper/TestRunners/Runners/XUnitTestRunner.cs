using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using TestWrapper.TestRunners;
using System.IO;

namespace TestWrapper
{
    public class XUnitTestRunner : TestRunner
    {
        public XUnitTestRunner(string testSuiteExecutable, FileInfo testContainer, DirectoryInfo workingDirectory)
            : base(testSuiteExecutable, testContainer, workingDirectory: null)
        {
        }
    }
}
