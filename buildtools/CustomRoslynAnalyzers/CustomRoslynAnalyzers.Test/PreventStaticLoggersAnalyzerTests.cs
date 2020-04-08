using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.Diagnostics;
using CustomRoslynAnalyzers.Test.TestHelper;
using Xunit;
using CustomRoslynAnalyzers.CodeFix;

namespace CustomRoslynAnalyzers.Test
{
    public partial class PreventStaticLoggersAnalyzerTests : CodeFixVerifier
    {
        private const string MessageFormat = "Static member {0} of type {1} implements {2}. Instances of {2} should not be stored in static variables. Logger configuration can change during SDK use, but static references are not impacted by this.";
        protected override DiagnosticAnalyzer GetCSharpDiagnosticAnalyzer()
        {
            return new PreventStaticLoggersAnalyzer();
        }

        protected override CodeFixProvider GetCSharpCodeFixProvider()
        {
            return new PreventStaticLoggerAnalyzerCodeFix();
        }

        // A test for the Correct Case
        [Fact]
        public void CR1002_PreventRegionEndpointUseAnalyzer_Correct_Tests()
        {
            string data = @"
namespace TestPreventStaticLoggersAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}";
            var expectedResult = new DiagnosticResult[0];
            VerifyCSharpDiagnostic(data, expectedResult);
        }

        // A test for all of the senarios including Static Field, Static Property
        [Theory]
        [MemberData(nameof(AllTestData), MemberType = typeof(PreventStaticLoggersAnalyzerTests))]
        public void CR1002_PreventStaticLoggersAnalyzer_Multiple_Tests(string dataWithoutLogger, 
            string declaringTypeName, string selfType, string interfaceName, 
            int row, int column, string codeFixDataWithoutLogger, string dataImplementILogger)
        {
            var data = string.Format(dataWithoutLogger, dataImplementILogger);
            var codeFixData = string.Format(codeFixDataWithoutLogger, dataImplementILogger);

            var expectedResult = new DiagnosticResult
            {
                Id = DiagnosticIds.PreventStaticLoggersRuleId,
                Message = string.Format(MessageFormat, declaringTypeName, selfType, interfaceName),
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
