using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CustomRoslynAnalyzers.Test.TestHelper;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis;
using CustomRoslynAnalyzers.CodeFix;
using Microsoft.CodeAnalysis.CodeFixes;

namespace CustomRoslynAnalyzers.Test
{
    public partial class PreventMD5AnalyzerTests : CodeFixVerifier
    {
        private const string MessageFormat = "Type {0} of member {1} is a subclass of MD5. MD5 should not be used within the SDK, as it is not FIPS compliant.";
        protected override DiagnosticAnalyzer GetCSharpDiagnosticAnalyzer()
        {
            return new PreventMD5UseAnalyzer();
        }
        protected override CodeFixProvider GetCSharpCodeFixProvider()
        {
            return new PreventMD5UseAnalyzerCodeFix();
        }

        // A test for correct test
        [Fact]
        public void CR1000_PreventMD5UseAnalyzer_Correct_Test()
        {
            string data = @"
using System.Security.Cryptography;

namespace TestPreventMD5UseAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public void test3(object m)
        {
        }
    }
}";
            var expectedResult = new DiagnosticResult[0];
            VerifyCSharpDiagnostic(data, expectedResult);
        }

        /// A test for all of the senarios including 
        /// Field, Property, InsideMethod, 
        /// Declare Method, PassIn Parameter to Method, Lambda Expression, Delegate
        [Theory]
        [MemberData(nameof(TestInsideMethodData), MemberType = typeof(PreventMD5AnalyzerTests))]
        public void CR1000_PreventMD5UseAnalyzer_Multiple_Tests(string data, string typeData, string belongsToData, int row, int column, string codeFixData)
        {
            var expectedResult = new DiagnosticResult
            {
                Id = DiagnosticIds.PreventMD5UseRuleId,
                Message = string.Format(MessageFormat, typeData, belongsToData),
                Severity = DiagnosticSeverity.Error,
                Locations =
                    new[]
                    {
                        new DiagnosticResultLocation("Test0.cs", row, column)
                    }
            };
            VerifyCSharpDiagnostic(data, expectedResult);
            VerifyCSharpFix(data, codeFixData);
        }
    }
}
