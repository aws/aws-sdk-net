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
    public class MSTestRunner : TestRunner
    {
        public MSTestRunner(string testSuiteExecutable, FileInfo testContainer, DirectoryInfo workingDirectory)
            : base(testSuiteExecutable, testContainer, workingDirectory: null)
        {
        }
    }
}
