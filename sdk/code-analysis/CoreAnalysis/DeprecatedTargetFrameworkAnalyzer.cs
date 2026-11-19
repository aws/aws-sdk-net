using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

using Amazon.CodeAnalysis.Shared;

namespace Amazon.CodeAnalysis
{
    /// <summary>
    /// Ships in the AWSSDK.Core package. Analyzers are not transitive, so the same analyzer is also
    /// generated into every service package for consumers that never reference AWSSDK.Core directly.
    /// </summary>
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class DeprecatedTargetFrameworkAnalyzer : AbstractDeprecatedTargetFrameworkAnalyzer
    {
    }
}
