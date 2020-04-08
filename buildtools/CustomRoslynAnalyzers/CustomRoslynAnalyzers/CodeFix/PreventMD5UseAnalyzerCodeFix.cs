using System;
using System.Composition;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeFixes;

namespace CustomRoslynAnalyzers.CodeFix
{
    [ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(PreventMD5UseAnalyzerCodeFix)), Shared]
    public class PreventMD5UseAnalyzerCodeFix : BaseClassofCodeFix
    {
        public PreventMD5UseAnalyzerCodeFix()
        {
            DiagnosticId = DiagnosticIds.PreventMD5UseRuleId;
            Title = "Suppress Message of MD5";
        }
    }
}
