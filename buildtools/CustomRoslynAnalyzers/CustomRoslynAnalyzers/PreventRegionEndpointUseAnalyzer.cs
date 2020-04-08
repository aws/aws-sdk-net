using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

namespace CustomRoslynAnalyzers
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class PreventRegionEndpointUseAnalyzer : DiagnosticAnalyzer
    {
        private const string Title = "Do not use static readonly RegionEndpoint members from within the SDK.";
        private const string MessageFormat = "Target member uses {0}. This member {1} be used within the SDK. {2}";
        private const string Category = "AwsSdkRules";
        private const string Description = "Makes sure none of the static readonly RegionEndpoint members are used directly within the SDK itself.";

        private const string ExtraResolutionMessage = "Evaluate whether this usage is safe and add a suppression if it is.";
        private const string RegionEndpointTypeName = "RegionEndpoint";
        private const string USEast1EndpointName = "USEast1";

        private static readonly DiagnosticDescriptor Rule = new DiagnosticDescriptor(DiagnosticIds.PreventRegionEndpointUseRuleId,
            Title,
            MessageFormat,
            Category,
            DiagnosticSeverity.Error,
            isEnabledByDefault: true,
            description: Description);

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get { return ImmutableArray.Create(Rule); } }

        public override void Initialize(AnalysisContext context)
        {
            context.RegisterSyntaxNodeAction(AnalyzeNode, SyntaxKind.SimpleMemberAccessExpression);
        }

        private void AnalyzeNode(SyntaxNodeAnalysisContext context)
        {
            var memberAccessExpr = context.Node as MemberAccessExpressionSyntax;
            var memberSymbol = context.SemanticModel.GetSymbolInfo(context.Node).Symbol as IFieldSymbol;

            var memberSymbolTypeName = memberSymbol?.ContainingType.Name;
            if (memberSymbolTypeName?.ToString() == RegionEndpointTypeName)
            {
                var memberAccessExpressionString = memberAccessExpr.ToString();
                if (memberAccessExpressionString.EndsWith(USEast1EndpointName))
                {
                    var diagnostic = Diagnostic.Create(Rule, memberAccessExpr.GetLocation(), memberAccessExpressionString, "shouldn't usually", ExtraResolutionMessage);
                    context.ReportDiagnostic(diagnostic);
                }
                // To check if it is a static readonly member except USEast1 and not a method
                else if (memberSymbol.IsStatic && memberSymbol.IsReadOnly)
                {
                    var diagnostic = Diagnostic.Create(Rule, memberAccessExpr.GetLocation(), memberAccessExpressionString, "should never", ExtraResolutionMessage);
                    context.ReportDiagnostic(diagnostic);
                }
            }
        }
    }
}
