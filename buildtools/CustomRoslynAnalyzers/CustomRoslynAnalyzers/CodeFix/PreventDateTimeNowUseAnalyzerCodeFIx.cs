using System;
using System.Composition;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeFixes;

namespace CustomRoslynAnalyzers.CodeFix
{
    [ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(PreventDateTimeNowUseAnalyzerCodeFix)), Shared]
    public class PreventDateTimeNowUseAnalyzerCodeFix : BaseClassofCodeFix
    {
        public PreventDateTimeNowUseAnalyzerCodeFix()
        {
            DiagnosticId = DiagnosticIds.PreventDateTimeNowUseRuleId;
            Title = "Suppress Message of DateTime";
        }

    }
}
