using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

namespace CustomRoslynAnalyzers
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class PreventStaticLoggersAnalyzer : DiagnosticAnalyzer
    {
        private const string Title = "Do not store ILogger instances in static members.";
        private const string MessageFormat = "Static member {0} of type {1} implements {2}. Instances of {2} should not be stored in static variables. Logger configuration can change during SDK use, but static references are not impacted by this.";
        private const string Category = "AwsSdkRules";
        private const string Description = "Checks code for static ILogger variables.";
        private const string LoggerInterfaceFullName = "ILogger";

        private static readonly DiagnosticDescriptor Rule = new DiagnosticDescriptor(DiagnosticIds.PreventStaticLoggersRuleId,
            Title,
            MessageFormat,
            Category,
            DiagnosticSeverity.Error,
            true,
            Description);

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get { return ImmutableArray.Create(Rule); } }

        public override void Initialize(AnalysisContext context)
        {
            context.RegisterSyntaxNodeAction(AnalyzeFieldNode, SyntaxKind.FieldDeclaration);
            context.RegisterSyntaxNodeAction(AnalyzePropertyNode, SyntaxKind.PropertyDeclaration);
        }

        // Analyze field
        private void AnalyzeFieldNode(SyntaxNodeAnalysisContext context)
        {
            var fieldDeclaration = (FieldDeclarationSyntax)context.Node;
            if (fieldDeclaration == null)
            {
                return;
            }

            // Check the modifiers of the node contains static
           if (fieldDeclaration.Modifiers.SingleOrDefault(m => m.Text.Contains("static")).Text != "")
            {
                var fieldSymbol = context.SemanticModel.GetSymbolInfo(fieldDeclaration.Declaration.Type).Symbol as INamedTypeSymbol;
                if (fieldSymbol != null && ImplementsILogger(fieldSymbol))
                {
                    var findAncestorsResult = FindAncestors(context.Node.Ancestors());
                    var diagnostic = Diagnostic.Create(Rule, fieldDeclaration.GetLocation(), findAncestorsResult, fieldSymbol.ToString(), LoggerInterfaceFullName);
                    context.ReportDiagnostic(diagnostic);
                }
            }
        }
        // check for property that have a setter 
        private void AnalyzePropertyNode(SyntaxNodeAnalysisContext context)
        {
            var propertyDeclaration = (PropertyDeclarationSyntax)context.Node;
            if (propertyDeclaration == null)
            {
                return;
            }
            var propertySymbol = context.SemanticModel.GetDeclaredSymbol(propertyDeclaration);
            if (propertySymbol != null
                && propertySymbol.IsStatic
                && propertySymbol.SetMethod != null
                && ImplementsILogger(propertySymbol.Type))
            {
                var ancestorsResult = FindAncestors(context.Node.Ancestors());
                var diagnostic = Diagnostic.Create(Rule, propertyDeclaration.GetLocation(), ancestorsResult, propertySymbol.Type.ToString(), LoggerInterfaceFullName);
                context.ReportDiagnostic(diagnostic);
            }
        }

        private bool ImplementsILogger(ITypeSymbol typeSymbol)
        {
            if (typeSymbol == null)
            {
                return false;
            }
            return IsILogger(typeSymbol.Name) || typeSymbol.Interfaces.Any(i => IsILogger(i.Name)) || ImplementsILogger(typeSymbol.BaseType);
        }

        private bool IsILogger(string name)
        {
            return string.Equals(name, LoggerInterfaceFullName);
        }

        // Find the Property and Field that declares the ILogger instance
        private string FindAncestors(IEnumerable<SyntaxNode> ancestors)
        {
            var ancestor = ancestors.SingleOrDefault(tmpAncestor => tmpAncestor.GetType().Equals(typeof(ClassDeclarationSyntax)));
            if (ancestor == null)
            {
                return "No Ancestors";
            }
            var classDeclarationSyntax = ancestor as ClassDeclarationSyntax;
            return classDeclarationSyntax.Identifier.Text;
        }
    }
}
