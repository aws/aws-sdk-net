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
                code.Name = ""aa""
            }
        }

        public class AnalyzedClass
        {
            public string Name {get; set;}
        }
    }";
            var expected = VerifyCS.Diagnostic(Analyzer.MinLengthRule).WithLocation(16, 29).WithArguments("aa", "Name", "3");

            await VerifyCS.VerifyAnalyzerAsync(
                test,
                expected,
                DiagnosticResult.CompilerError("CS1002").WithSpan(16, 33, 16, 33).WithMessage("; expected"));


            test = test.Replace("\"aa\"", "\"aaa\"");
            await VerifyCS.VerifyAnalyzerAsync(
                test,
                DiagnosticResult.CompilerError("CS1002").WithSpan(16, 34, 16, 34).WithMessage("; expected"));

            test = test.Replace("\"aaa\"", "\"aaaaa\"");
            await VerifyCS.VerifyAnalyzerAsync(
                test,
                DiagnosticResult.CompilerError("CS1002").WithSpan(16, 36, 16, 36).WithMessage("; expected"));

            test = test.Replace("\"aaaaa\"", "\"aaaaaa\"");

            expected = VerifyCS.Diagnostic(Analyzer.MaxLengthRule).WithLocation(16, 29).WithArguments("aaaaaa", "Name", "5");

            await VerifyCS.VerifyAnalyzerAsync(
                test,
                expected,
                DiagnosticResult.CompilerError("CS1002").WithSpan(16, 37, 16, 37).WithMessage("; expected"));


            test = test.Replace("\"aaaaaa\"", "\"#aaa\"");

            expected = VerifyCS.Diagnostic(Analyzer.PatternRule).WithLocation(16, 29).WithArguments("#aaa", "[0-9a-z\\-_]+", "Name");

            await VerifyCS.VerifyAnalyzerAsync(
                test,
                expected,
                DiagnosticResult.CompilerError("CS1002").WithSpan(16, 35, 16, 35).WithMessage("; expected"));
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
            var expected = VerifyCS.Diagnostic(Analyzer.MinValueRule).WithLocation(16, 29).WithArguments("9", "10", "Size");

            await VerifyCS.VerifyAnalyzerAsync(test, expected);


            test = test.Replace("9", "10");
            await VerifyCS.VerifyAnalyzerAsync(test);

            test = test.Replace("10", "20");
            await VerifyCS.VerifyAnalyzerAsync(test);

            test = test.Replace("20", "21");

            expected = VerifyCS.Diagnostic(Analyzer.MaxValueRule).WithLocation(16, 29).WithArguments("21", "20", "Size");

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
            var expected = VerifyCS.Diagnostic(Analyzer.MinValueRule).WithLocation(16, 29).WithArguments("-1", "10", "Size");

            string testCode = test.Replace("expression", "(-1)");
            await VerifyCS.VerifyAnalyzerAsync(testCode, expected);

            testCode = test.Replace("expression", "2-3");
            await VerifyCS.VerifyAnalyzerAsync(testCode, expected);

            testCode = test.Replace("expression", "(2*3)-7");
            await VerifyCS.VerifyAnalyzerAsync(testCode, expected);

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
                code.Name = expression
            }
        }

        public class AnalyzedClass
        {
            public string Name {get; set;}
        }
    }";

            expected = VerifyCS.Diagnostic(Analyzer.MinLengthRule).WithLocation(16, 30).WithArguments("aa", "Name", "3");

            testCode = test.Replace("expression", @" ""a"" + ""a"" ");
            await VerifyCS.VerifyAnalyzerAsync(
                testCode,
                expected,
                DiagnosticResult.CompilerError("CS1002").WithSpan(16, 39, 16, 39).WithMessage("; expected"));

            testCode = test.Replace("expression", @"string.Format(""aa"")");
            await VerifyCS.VerifyAnalyzerAsync(
                testCode,
                DiagnosticResult.CompilerError("CS1002").WithSpan(16, 48, 16, 48).WithMessage("; expected"));
        }
    }
}