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
    public class PreventHashAlgorithmCreateAnalyzer : DiagnosticAnalyzer
    {
        private const string Title = "Do not use HashAlgorithm.Create";
        private const string MessageFormat = "Method {0} of member {1} invokes {2}. This method should not be used within the SDK, as it may lead to MD5 use, which is not FIPS compliant.";
        private const string Category = "AwsSdkRules";
        private const string Description = "Checks code for HashAlgorithm.Create uses.";

        private static readonly DiagnosticDescriptor Rule = new DiagnosticDescriptor(DiagnosticIds.PreventHashAlgorithmCreateRuleId,
            Title,
            MessageFormat,
            Category,
            DiagnosticSeverity.Error,
            isEnabledByDefault: true,
            description: Description);

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get { return ImmutableArray.Create(Rule); } }

        public override void Initialize(AnalysisContext context)
        {
            context.RegisterSyntaxNodeAction(AnalyzeNode, SyntaxKind.InvocationExpression);
        }

        private void AnalyzeNode(SyntaxNodeAnalysisContext context)
        {
            var invocationExpr = (InvocationExpressionSyntax)context.Node;
            if (invocationExpr == null)
            {
                return;
            }

            // memeberAccessExpr equals the expression before "(", which is HashAlgorithm.Create
            var memberAccessExpr = invocationExpr.Expression as MemberAccessExpressionSyntax;
            if (memberAccessExpr?.Name.ToString() == "Create")
            {
                var memberSymbol = context.SemanticModel.GetSymbolInfo(memberAccessExpr).Symbol as IMethodSymbol;
                var returnType = memberSymbol?.ReturnType.ToString();
                if (returnType == "HashAlgorithm" || returnType == "System.Security.Cryptography.HashAlgorithm")
                {
                    var ancestorsResult = FindAncestors(context.Node.Ancestors());
                    var diagnostic = Diagnostic.Create(Rule, invocationExpr.GetLocation(), ancestorsResult.MethodIdentifier ?? "null", ancestorsResult.ClassIdentifier, "System.Security.Cryptography." + invocationExpr.ToString());
                    context.ReportDiagnostic(diagnostic);
                }
            }
        }


        // Find the Method and Class that use the HashAlgorithm.Create
        private (string MethodIdentifier, string ClassIdentifier) FindAncestors(IEnumerable<SyntaxNode> ancestors)
        {
            string methodIdentifier = null;
            string classIdentifier = null;
            foreach (var ancestor in ancestors)
            {
                var type = ancestor.GetType();
                if (type.Equals(typeof(MethodDeclarationSyntax)))
                {
                    var methodDeclarationSyntax = ancestor as MethodDeclarationSyntax;
                    methodIdentifier = methodDeclarationSyntax.Identifier.Text;
                }
                if (type.Equals(typeof(ClassDeclarationSyntax)))
                {
                    var classDeclarationSyntax = ancestor as ClassDeclarationSyntax;
                    classIdentifier = classDeclarationSyntax.Identifier.Text;
                }
            }
            return (methodIdentifier, classIdentifier);
        }
    }
}
