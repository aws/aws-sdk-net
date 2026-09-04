using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

using Amazon.CodeAnalysis.Shared;

namespace Amazon.DevOpsAgent.CodeAnalysis
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class DeprecatedTargetFrameworkAnalyzer : AbstractDeprecatedTargetFrameworkAnalyzer
    {
    }
}