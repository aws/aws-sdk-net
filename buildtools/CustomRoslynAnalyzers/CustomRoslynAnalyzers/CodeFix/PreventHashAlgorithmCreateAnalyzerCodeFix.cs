using System;
using System.Composition;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeFixes;

namespace CustomRoslynAnalyzers.CodeFix
{
    [ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(PreventHashAlgorithmCreateAnalyzerCodeFix)), Shared]
    public class PreventHashAlgorithmCreateAnalyzerCodeFix : BaseClassofCodeFix
    {
        public PreventHashAlgorithmCreateAnalyzerCodeFix()
        {
            DiagnosticId = DiagnosticIds.PreventHashAlgorithmCreateRuleId;
            Title = "Suppress Message of HashAlgorithm.Create()";
        }
    }
}
