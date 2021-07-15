using Amazon.CodeAnalysis.Shared;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

using MockAnalyzer;

using VerifyCS = AnalyzerUnitTests.CSharpCodeFixVerifier<
    MockAnalyzer.PropertyValueAssignmentAnalyzer,
    Microsoft.CodeAnalysis.Testing.EmptyCodeFixProvider>;

namespace Analyzer1.Test
{
    [TestClass]
    public class PropertyValueTests
    {
        private static readonly AbstractPropertyValueAssignmentAnalyzer Analyzer = new PropertyValueAssignmentAnalyzer();

        //Diagnostic and CodeFix both triggered and checked for
        [TestMethod]
        public async Task TestStringRules()
        {
            var test = @"
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Diagnostics;

    namespace MockCode
    {
        public class Driver
        {   
            public void Execute()
            {
                var code = new AnalyzedClass();
                code.Name = ""aa"";
            }
        }

        public class AnalyzedClass
        {
            public string Name {get; set;}
        }
    }";
            var expected = VerifyCS.Diagnostic(Analyzer.MinLengthRule).WithSpan(16, 29, 16, 33).WithArguments("aa", "Name", "3");

            await VerifyCS.VerifyAnalyzerAsync(test, expected);


            test = test.Replace("\"aa\"", "\"aaa\"");
            await VerifyCS.VerifyAnalyzerAsync(test);

            test = test.Replace("\"aaa\"", "\"aaaaa\"");
            await VerifyCS.VerifyAnalyzerAsync(test);

            test = test.Replace("\"aaaaa\"", "\"aaaaaa\"");

            expected = VerifyCS.Diagnostic(Analyzer.MaxLengthRule).WithSpan(16, 29, 16, 37).WithArguments("aaaaaa", "Name", "5");

            await VerifyCS.VerifyAnalyzerAsync(test, expected);


            test = test.Replace("\"aaaaaa\"", "\"#aaa\"");

            expected = VerifyCS.Diagnostic(Analyzer.PatternRule).WithSpan(16, 29, 16, 35).WithArguments("#aaa", "[0-9a-z\\-_]+", "Name");

            await VerifyCS.VerifyAnalyzerAsync(test, expected);
        }

        [TestMethod]
        public async Task TestIntRules()
        {
            var test = @"
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Diagnostics;

    namespace MockCode
    {
        public class Driver
        {   
            public void Execute()
            {
                var code = new AnalyzedClass();
                code.Size = 9;
            }
        }

        public class AnalyzedClass
        {
            public int Size {get; set;}
        }
    }";
            var expected = VerifyCS.Diagnostic(Analyzer.MinValueRule).WithSpan(16, 29, 16, 30).WithArguments("9", "10", "Size");

            await VerifyCS.VerifyAnalyzerAsync(test, expected);


            test = test.Replace("9", "10");
            await VerifyCS.VerifyAnalyzerAsync(test);

            test = test.Replace("10", "20");
            await VerifyCS.VerifyAnalyzerAsync(test);

            test = test.Replace("20", "21");

            expected = VerifyCS.Diagnostic(Analyzer.MaxValueRule).WithSpan(16, 29, 16, 31).WithArguments("21", "20", "Size");

            await VerifyCS.VerifyAnalyzerAsync(test, expected);
        }

        [TestMethod]
        public async Task TestNonLiteralExpression()
        {
            var test = @"
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Diagnostics;

    namespace MockCode
    {
        public class Driver
        {   
            public void Execute()
            {
                var code = new AnalyzedClass();
                code.Size = expression;
            }
        }

        public class AnalyzedClass
        {
            public int Size {get; set;}
        }
    }";
            var expected = VerifyCS.Diagnostic(Analyzer.MinValueRule).WithArguments("-1", "10", "Size");

            string testCode = test.Replace("expression", "(-1)");
            await VerifyCS.VerifyAnalyzerAsync(testCode, expected.WithSpan(16, 29, 16, 33));

            testCode = test.Replace("expression", "2-3");
            await VerifyCS.VerifyAnalyzerAsync(testCode, expected.WithSpan(16, 29, 16, 32));

            testCode = test.Replace("expression", "(2*3)-7");
            await VerifyCS.VerifyAnalyzerAsync(testCode, expected.WithSpan(16, 29, 16, 36));

            testCode = test.Replace("expression", "(2*3)-someValue");
            await VerifyCS.VerifyAnalyzerAsync(
                testCode,
                DiagnosticResult.CompilerError("CS0103").WithSpan(16, 35, 16, 44).WithMessage("The name 'someValue' does not exist in the current context"));

            test = @"
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Diagnostics;

    namespace MockCode
    {
        public class Driver
        {   
            public void Execute()
            {
                var code = new AnalyzedClass();
                code.Name = expression;
            }
        }

        public class AnalyzedClass
        {
            public string Name {get; set;}
        }
    }";

            expected = VerifyCS.Diagnostic(Analyzer.MinLengthRule).WithSpan(16, 30, 16, 39).WithArguments("aa", "Name", "3");

            testCode = test.Replace("expression", @" ""a"" + ""a"" ");
            await VerifyCS.VerifyAnalyzerAsync(testCode, expected);

            testCode = test.Replace("expression", @"string.Format(""aa"")");
            await VerifyCS.VerifyAnalyzerAsync(testCode);
        }
    }
}