using Amazon.CodeAnalysis.Shared;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis;

namespace MockAnalyzer
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class PropertyValueAssignmentAnalyzer : AbstractPropertyValueAssignmentAnalyzer
    {
        public override string GetServiceName()
        {
            return "MockAnalyzer";
        }
    }
}