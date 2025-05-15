using Amazon.CodeAnalysis.Shared;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp;

namespace Amazon.CodeAnalysis.Shared.CodeFixes
{
    public class NullCollectionInitializerCodeFixProvider : CodeFixProvider
    {
        public sealed override ImmutableArray<string> FixableDiagnosticIds
        {
            get { return ImmutableArray.Create(AbstractNullCollectionInitializerAnalyzer.DiagnosticId); }
        }

        public sealed override FixAllProvider GetFixAllProvider()
        {
            // See https://github.com/dotnet/roslyn/blob/main/docs/analyzers/FixAllProvider.md for more information on Fix All Providers
            return WellKnownFixAllProviders.BatchFixer;
        }

        public sealed override async Task RegisterCodeFixesAsync(CodeFixContext context)
        {
            var diagnostic = context.Diagnostics.First();
            var document = context.Document;
            var cancellationToken = context.CancellationToken;


            var root = await context.Document.GetSyntaxRootAsync(context.CancellationToken).ConfigureAwait(false);
            var semanticModel = await document.GetSemanticModelAsync(cancellationToken).ConfigureAwait(false);

            var node = root.FindNode(diagnostic.Location.SourceSpan);

            // Look for: SomeProperty = { ... } initializer
            if (node is InitializerExpressionSyntax initializer &&
                initializer.Parent is AssignmentExpressionSyntax assignment &&
                assignment.Right == initializer)
            {
                // Get the property name
                var propertyName = assignment.Left.ToString();

                // Get the property type via semantic model
                var symbolInfo = semanticModel.GetTypeInfo(assignment.Left, cancellationToken);
                var type = symbolInfo.Type as INamedTypeSymbol;

                if (type == null || type.TypeArguments.Length == 0)
                    return;

                // Build `new Type<args>() { ... }`
                var typeName = SyntaxFactory.ParseTypeName(type.ToDisplayString(SymbolDisplayFormat.MinimallyQualifiedFormat));

                var newAssignment = SyntaxFactory.AssignmentExpression(
                    SyntaxKind.SimpleAssignmentExpression,
                    assignment.Left,
                    SyntaxFactory.ObjectCreationExpression(typeName)
                        .WithNewKeyword(SyntaxFactory.Token(SyntaxKind.NewKeyword))
                        .WithArgumentList(SyntaxFactory.ArgumentList())
                        .WithInitializer(initializer));

                var newRoot = root.ReplaceNode(assignment, newAssignment);

                var title = $"Initialize {propertyName} with {type.Name}";

                context.RegisterCodeFix(
                    CodeAction.Create(
                        title,
                        _ => Task.FromResult(document.WithSyntaxRoot(newRoot)),
                        equivalenceKey: title),
                    diagnostic);
            }
        }
    }
}
