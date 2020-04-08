using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CustomRoslynAnalyzers.Test.TestHelper;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeFixes;
using CustomRoslynAnalyzers.CodeFix;

namespace CustomRoslynAnalyzers.Test
{
    public partial class PreventRegionEndpointUseAnalyzerTests : CodeFixVerifier
    {
        private const string MessageFormat = "Target member uses {0}. This member {1} be used within the SDK. {2}";
        private const string USEast1ResolutionMessage = "Evaluate whether this usage is safe and add a suppression if it is.";

        protected override DiagnosticAnalyzer GetCSharpDiagnosticAnalyzer()
        {
            return new PreventRegionEndpointUseAnalyzer();
        }
        protected override CodeFixProvider GetCSharpCodeFixProvider()
        {
            return new PreventRegionEndpointUseAnalyzerCodeFixProvider();
        }

        // A Test for the correct test
        [Fact]
        public void CR1004_PreventRegionEndpointUseAnalyzer_Correct_Tests()
        {
            string data = @"
namespace TestPreventRegionEndpointUseAnalyzer
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

        // A test for all of the senarios including Field, Property, InsideMethod, Declare Method, PassIn Parameter to Method, Lambda Expression, Delegate
        [Theory]
        [MemberData(nameof(TestInsideMethodData), MemberType = typeof(PreventRegionEndpointUseAnalyzerTests))]
        public void CR1004_PreventRegionEndpointUseAnalyzer_Multiple_Tests(string data, int row, int column, string codeFixData)
        {
            var expectedResult = new DiagnosticResult
            {
                Id = DiagnosticIds.PreventRegionEndpointUseRuleId,
                Message = string.Format(MessageFormat, "RegionEndpoint.USEast1", "shouldn't usually", USEast1ResolutionMessage),
                Severity = DiagnosticSeverity.Error,
                Locations =
                    new[]
                    {
                        new DiagnosticResultLocation("Test0.cs", row, column)
                    }
            };
            if (!data.Contains("USEast1"))
            {
                expectedResult.Message = string.Format(MessageFormat, "RegionEndpoint.USWest1", "should never", USEast1ResolutionMessage);
            }
            
            VerifyCSharpDiagnostic(data, expectedResult);
            VerifyCSharpFix(data, codeFixData);
        }
    }
}
