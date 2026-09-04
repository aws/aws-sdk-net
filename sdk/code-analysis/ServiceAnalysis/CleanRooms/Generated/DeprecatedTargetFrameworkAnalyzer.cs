using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

using Amazon.CodeAnalysis.Shared;

namespace Amazon.CleanRooms.CodeAnalysis
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class DeprecatedTargetFrameworkAnalyzer : AbstractDeprecatedTargetFrameworkAnalyzer
    {
    }
}