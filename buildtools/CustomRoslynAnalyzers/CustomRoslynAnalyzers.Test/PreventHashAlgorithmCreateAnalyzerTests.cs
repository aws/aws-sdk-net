using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using System;
using System.Collections.Generic;
using System.Text;
using CustomRoslynAnalyzers.Test.TestHelper;
using Xunit;
using Microsoft.CodeAnalysis.CodeFixes;
using CustomRoslynAnalyzers.CodeFix;

namespace CustomRoslynAnalyzers.Test
{
    public partial class PreventHashAlgorithmCreateAnalyzerTests : CodeFixVerifier
    {
        private const string MessageFormat = "Method {0} of member {1} invokes {2}. This method should not be used within the SDK, as it may lead to MD5 use, which is not FIPS compliant.";
        protected override DiagnosticAnalyzer GetCSharpDiagnosticAnalyzer()
        {
            return new PreventHashAlgorithmCreateAnalyzer();
        }
        protected override CodeFixProvider GetCSharpCodeFixProvider()
        {
            return new PreventHashAlgorithmCreateAnalyzerCodeFix();
        }

        // A Correct Case Test
        [Theory]
        [MemberData(nameof(TestCorrectData), MemberType = typeof(PreventHashAlgorithmCreateAnalyzerTests))]
        public void CR1001_PreventHashAlgorithmCreateAnalyzer_Correct_Test(string data)
        {
            var expectedResult = new DiagnosticResult[0];
            VerifyCSharpDiagnostic(data, expectedResult);
        }

        // A Test for HashAlgorithm.Create() in method
        [Theory]
        [MemberData(nameof(TestMethodData), MemberType = typeof(PreventHashAlgorithmCreateAnalyzerTests))]
        public void CR1001_PreventHashAlgorithmCreateAnalyzer_Method_Test(string data, string invocation, string codeFixData)
        {
            var testData = string.Format(data, invocation);
            var testCodeFixData = string.Format(codeFixData, invocation);
            CompareActualAndExpected(testData, "Main", "Program", invocation, 12, 24, testCodeFixData);   
        }

        // A Test for HashAlgorithm.Create() in field
        [Theory]
        [MemberData(nameof(TestFieldData), MemberType = typeof(PreventHashAlgorithmCreateAnalyzerTests))]
        public void CR1001_PreventHashAlgorithmCreateAnalyze_Field_Test(string data, string invocation, string codeFixData)
        {
            var testData = string.Format(data, invocation);
            var testCodeFixData = string.Format(codeFixData, invocation);
            CompareActualAndExpected(testData, "null", "Program", invocation, 10, 37, testCodeFixData);
        }

        // A Test for HashAlgorithm.Create() in Property
        [Theory]
        [MemberData(nameof(TestPropertyData), MemberType = typeof(PreventHashAlgorithmCreateAnalyzerTests))]
        public void CR1001_PreventHashAlgorithmCreateAnalyze_Property_Test(string data, string invocation, string codeFixData)
        {
            var testData = string.Format(data, invocation);
            var testCodeFixData = string.Format(codeFixData, invocation);
            CompareActualAndExpected(testData, "null", "Program", invocation, 14, 24, testCodeFixData);
        }

        // A Test for HashAlgorithm.Create() in Parameter
        [Theory]
        [MemberData(nameof(TestPassInParameterData), MemberType = typeof(PreventHashAlgorithmCreateAnalyzerTests))]
        public void CR1001_PreventHashAlgorithmCreateAnalyze_Parameter_Test(string data, string invocation, string codeFixData)
        {
            var testData = string.Format(data, invocation);
            var testCodeFixData = string.Format(codeFixData, invocation);
            CompareActualAndExpected(testData, "Main", "Program", invocation, 12, 24, testCodeFixData);
        }

        // A Test for HashAlgorithm.Create() in Lambda Expression
        [Theory]
        [MemberData(nameof(TestLambdaData), MemberType = typeof(PreventHashAlgorithmCreateAnalyzerTests))]
        public void CR1001_PreventHashAlgorithmCreateAnalyze_Lambda_Test(string data, string invocation, string codeFixData)
        {
            var testData = string.Format(data, invocation);
            var testCodeFixData = string.Format(codeFixData, invocation);
            CompareActualAndExpected(testData, "null", "Program", invocation, 10, 67, testCodeFixData);
        }

        // A Test for HashAlgorithm.Create() in Delegate
        [Theory]
        [MemberData(nameof(TestDelegateData), MemberType = typeof(PreventHashAlgorithmCreateAnalyzerTests))]
        public void CR1001_PreventHashAlgorithmCreateAnalyze_Delegate_Test(string data, string invocation, string codeFixData)
        {
            var testData = string.Format(data, invocation);
            var testCodeFixData = string.Format(codeFixData, invocation);
            CompareActualAndExpected(testData, "null", "Program", invocation, 11, 59, testCodeFixData);
        }

        // Compare the actual diagnostic result with expected result
        private void CompareActualAndExpected(string testData, string methodName, string className, string invocation , int row, int column, string testCodeFixData)
        {
            var expectedResult = new DiagnosticResult
            {
                Id = DiagnosticIds.PreventHashAlgorithmCreateRuleId,
                Message = string.Format(MessageFormat, methodName, className, "System.Security.Cryptography." + invocation),
                Severity = DiagnosticSeverity.Error,
                Locations =
                    new[]
                    {
                        new DiagnosticResultLocation("Test0.cs", row, column)
                    }
            };
            VerifyCSharpDiagnostic(testData, expectedResult);
            VerifyCSharpFix(testData, testCodeFixData);
        }
    }
}
