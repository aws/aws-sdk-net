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
    public class PreventMD5UseAnalyzer : DiagnosticAnalyzer
    {
        private const string Title = "Do not use MD5";
        private const string MessageFormat = "Type {0} of member {1} is a subclass of MD5. MD5 should not be used within the SDK, as it is not FIPS compliant.";
        private const string Category = "AwsSdkRules";
        private const string Description = "Checks code for MD5 uses.";
        private const string MD5FullName = "System.Security.Cryptography.MD5";
        private const string MD5ShortName = "MD5";

        private static readonly DiagnosticDescriptor Rule = new DiagnosticDescriptor(DiagnosticIds.PreventMD5UseRuleId,
            Title,
            MessageFormat,
            Category,
            DiagnosticSeverity.Error,
            isEnabledByDefault: true,
            description: Description);

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get { return ImmutableArray.Create(Rule); } }

        public override void Initialize(AnalysisContext context)
        {
            context.RegisterSyntaxNodeAction(AnalyzePropertyNode, SyntaxKind.PropertyDeclaration);
            context.RegisterSyntaxNodeAction(AnalyzeFieldNode, SyntaxKind.FieldDeclaration);
            context.RegisterSyntaxNodeAction(AnalyzeMethodNode, SyntaxKind.MethodDeclaration);
            context.RegisterSyntaxNodeAction(AnalyzeInvocationExpressionNode, SyntaxKind.InvocationExpression);
        }

        // Analyze the Property Declaration
        private void AnalyzePropertyNode(SyntaxNodeAnalysisContext context)
        {
            var propertyDeclaration = (PropertyDeclarationSyntax)context.Node;
            if (propertyDeclaration == null)
            {
                return;
            }
            var propertySymbol = context.SemanticModel.GetDeclaredSymbol(propertyDeclaration);
            if (propertySymbol != null)
            {
                CheckType(propertySymbol.Type, context, propertyDeclaration.Type.GetLocation());
            }
        }

        // Analyze the Field Declaration
        private void AnalyzeFieldNode(SyntaxNodeAnalysisContext context)
        {
            var fieldDeclaration = (FieldDeclarationSyntax)context.Node;
            if (fieldDeclaration == null)
            {
                return;
            }
            var fieldSymbol = context.SemanticModel.GetSymbolInfo(fieldDeclaration.Declaration.Type).Symbol as INamedTypeSymbol;
            if (fieldSymbol != null)
            {
                // Check for Lambda expression's type
                var genericTypeofLambdaFunc = fieldDeclaration.Declaration.Type as GenericNameSyntax;
                if (genericTypeofLambdaFunc != null)
                {
                    AnalyzeLambdaExpressionType(context, genericTypeofLambdaFunc);
                }
                // Check for the rest of field symbol
                CheckType(fieldSymbol, context, fieldDeclaration.GetLocation());
            } 
        }

        // Analyze the Method
        private void AnalyzeMethodNode(SyntaxNodeAnalysisContext context)
        {
            var methodDeclaration = (MethodDeclarationSyntax)context.Node;

            // Analyze the parameter
            foreach (var parameter in methodDeclaration.ParameterList.Parameters)
            {
                var typeSymbol = context.SemanticModel.GetSymbolInfo(parameter.Type).Symbol as INamedTypeSymbol;
                if (typeSymbol != null)
                {
                    CheckType(typeSymbol, context, parameter.GetLocation());
                }
            }
            // Analyze the method body
            if (methodDeclaration.Body != null)
            {
                var methodBodyStatement = methodDeclaration.Body.Statements;
                foreach (var statement in methodBodyStatement)
                {
                    var localDeclaration = statement as LocalDeclarationStatementSyntax;
                    if (localDeclaration != null)
                    {
                        var typeSymbol = context.SemanticModel.GetSymbolInfo(localDeclaration.Declaration.Type).Symbol as INamedTypeSymbol;
                        if (typeSymbol != null && !localDeclaration.Declaration.Type.ToString().Equals("var"))
                        {
                            CheckType(typeSymbol, context, localDeclaration.Declaration.Type.GetLocation());
                        }
                    }
                }
            }
        }

        // Analyze the extra senario - Invocation Expression 
        private void AnalyzeInvocationExpressionNode(SyntaxNodeAnalysisContext context)
        {
            var invocationExpr = context.Node as InvocationExpressionSyntax;
            // memeberAccessExpr equals the expression before "(", which is MD5
            var memberAccessExpr = invocationExpr?.Expression as MemberAccessExpressionSyntax;
            if (memberAccessExpr == null)
            {
                return;
            }
            if (memberAccessExpr.Name.ToString() == "Create")
            {
                var memberSymbol = context.SemanticModel.GetSymbolInfo(memberAccessExpr).Symbol;
                if (memberSymbol == null)
                {
                    return;
                }
                var memberSymbolSpecialType = memberSymbol.ContainingType;
                if (memberSymbolSpecialType != null)
                {
                    CheckType(memberSymbolSpecialType, context, invocationExpr.GetLocation());
                }
            }
        }

        // Analyze the Lambda expression's generic type
        private void AnalyzeLambdaExpressionType(SyntaxNodeAnalysisContext context, GenericNameSyntax genericTypeofLambdaFunc)
        {
            if (genericTypeofLambdaFunc.GetType().Equals(typeof(GenericNameSyntax)))
            {
                foreach (var argument in genericTypeofLambdaFunc.TypeArgumentList.Arguments)
                {
                    var argumentNameSyntax = argument as IdentifierNameSyntax;
                    if (argumentNameSyntax?.Identifier.Text == "MD5")
                    {
                        var argumentSymbol = context.SemanticModel.GetSymbolInfo(argument).Symbol as INamedTypeSymbol;
                        CheckType(argumentSymbol, context, argument.GetLocation());
                    }
                }
            }
        }

        private void CheckType(ITypeSymbol type, SyntaxNodeAnalysisContext context, Location location)
        {
            if (IsAssignableToMD5(type))
            {
                var ancestorsResult = FindAncestors(context.Node);
                var diagnostic = Diagnostic.Create(Rule, location, type.ToString(), ancestorsResult);
                context.ReportDiagnostic(diagnostic);
            }
        }

        private bool IsAssignableToMD5(ITypeSymbol type)
        {
            if (string.Equals(type.Name, MD5FullName) || string.Equals(type.Name, MD5ShortName))
            {
                return true;
            }

            var baseType = type.BaseType;
            if (baseType == null)
            {
                return false;
            }

            return IsAssignableToMD5(baseType);
        }


        // Find the Method and Class that uees the MD5
        private string FindAncestors(SyntaxNode node)
        {
            var ancestors = node.Ancestors();
            foreach (var ancestor in ancestors)
            {
                var type = ancestor.GetType();
                if (type.Equals(typeof(ClassDeclarationSyntax)))
                {
                    if (node.GetType().Equals(typeof(MethodDeclarationSyntax)))
                    {
                        return (node as MethodDeclarationSyntax).Identifier.Text;
                    }
                    if (node.GetType().Equals(typeof(FieldDeclarationSyntax))
                        || node.GetType().Equals(typeof(PropertyDeclarationSyntax))
                        || node.GetType().Equals(typeof(InvocationExpressionSyntax)))
                    {
                        return (ancestor as ClassDeclarationSyntax).Identifier.Text;
                    }
                }
                if (type.Equals(typeof(MethodDeclarationSyntax)))
                {
                    var methodDeclarationSyntax = ancestor as MethodDeclarationSyntax;
                    return methodDeclarationSyntax.Identifier.Text;
                }
            }
            return "";
        }
    }
}
