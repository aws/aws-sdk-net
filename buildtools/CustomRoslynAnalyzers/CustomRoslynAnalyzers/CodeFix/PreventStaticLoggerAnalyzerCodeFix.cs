using System;
using System.Composition;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeFixes;

namespace CustomRoslynAnalyzers.CodeFix
{
    [ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(PreventStaticLoggerAnalyzerCodeFix)), Shared]
    public class PreventStaticLoggerAnalyzerCodeFix : BaseClassofCodeFix
    {
        public PreventStaticLoggerAnalyzerCodeFix()
        {
            DiagnosticId = DiagnosticIds.PreventStaticLoggersRuleId;
            Title = "Suppress Message of Logger/ILogger";
        }
    }
}
