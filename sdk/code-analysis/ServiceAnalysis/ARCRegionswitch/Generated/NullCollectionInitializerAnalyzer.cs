using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

using Amazon.CodeAnalysis.Shared;

namespace Amazon.ARCRegionswitch.CodeAnalysis
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class NullCollectionInitializerAnalyzer : AbstractNullCollectionInitializerAnalyzer
    {
        protected override string GetModelNamespace()
        {
            return "Amazon.ARCRegionswitch.Model";
        }
    }
}