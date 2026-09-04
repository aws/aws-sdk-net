using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

using Amazon.CodeAnalysis.Shared;

namespace Amazon.Cloud9.CodeAnalysis
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class DeprecatedTargetFrameworkAnalyzer : AbstractDeprecatedTargetFrameworkAnalyzer
    {
    }
}