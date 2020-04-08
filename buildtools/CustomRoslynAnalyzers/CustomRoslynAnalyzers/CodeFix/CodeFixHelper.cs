using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CustomRoslynAnalyzers.CodeFix
{
    class CodeFixHelper
    {
        public async Task<Solution> CodeFixHelperInFieldAsync(Document document, FieldDeclarationSyntax fieldDeclaration, CancellationToken cancellationToken, string diagnosticId)
        {
            var root = await document.GetSyntaxRootAsync(cancellationToken);
            var attributes = fieldDeclaration.AttributeLists.Add(CreateSuppressMessageAttribute(diagnosticId));
            return document.WithSyntaxRoot(
                root.ReplaceNode(
                    fieldDeclaration,
                    fieldDeclaration.WithAttributeLists(attributes)
                    )).Project.Solution;
        }

        public async Task<Solution> CodeFixHelperInPropertyAsync(Document document, PropertyDeclarationSyntax propertyDeclaration, CancellationToken cancellationToken, string diagnosticId)
        {
            var root = await document.GetSyntaxRootAsync(cancellationToken);
            var attributes = propertyDeclaration.AttributeLists.Add(CreateSuppressMessageAttribute(diagnosticId));
            return document.WithSyntaxRoot(
                root.ReplaceNode(
                    propertyDeclaration,
                    propertyDeclaration.WithAttributeLists(attributes)
                    )).Project.Solution;
        }

        public async Task<Solution> CodeFixHelperInMethodAsync(Document document, MethodDeclarationSyntax methodDeclaration, CancellationToken cancellationToken, string diagnosticId)
        {
            var root = await document.GetSyntaxRootAsync(cancellationToken);
            var attributes = methodDeclaration.AttributeLists.Add(CreateSuppressMessageAttribute(diagnosticId));
            return document.WithSyntaxRoot(
                root.ReplaceNode(
                    methodDeclaration,
                    methodDeclaration.WithAttributeLists(attributes)
                    )).Project.Solution;
        }

        // Create Suppress Message by using diagnosticId
        private AttributeListSyntax CreateSuppressMessageAttribute(string diagnosticId)
        {
            return SyntaxFactory.AttributeList(SyntaxFactory.SingletonSeparatedList<AttributeSyntax>(
                    SyntaxFactory.Attribute(SyntaxFactory.IdentifierName("SuppressMessage"))
                    .WithArgumentList(SyntaxFactory.AttributeArgumentList(SyntaxFactory.SeparatedList<AttributeArgumentSyntax>(
                        new SyntaxNodeOrToken[]{
                            SyntaxFactory.AttributeArgument(SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal("AWSSDKRules"))),
                            SyntaxFactory.Token(SyntaxKind.CommaToken),
                            SyntaxFactory.AttributeArgument(SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal(diagnosticId)))
                        }
                        ))).NormalizeWhitespace()));
        }
    }
}
