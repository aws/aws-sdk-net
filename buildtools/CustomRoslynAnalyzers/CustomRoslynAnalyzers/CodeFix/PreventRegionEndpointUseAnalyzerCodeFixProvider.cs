using System;
using System.Composition;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeFixes;

namespace CustomRoslynAnalyzers.CodeFix
{
    [ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(PreventRegionEndpointUseAnalyzerCodeFixProvider)), Shared]
    public class PreventRegionEndpointUseAnalyzerCodeFixProvider : BaseClassofCodeFix
    {
        public PreventRegionEndpointUseAnalyzerCodeFixProvider()
        {
            DiagnosticId = DiagnosticIds.PreventRegionEndpointUseRuleId;
            Title = "Suppress Message of RegionEndpoint";
        }
    }
}