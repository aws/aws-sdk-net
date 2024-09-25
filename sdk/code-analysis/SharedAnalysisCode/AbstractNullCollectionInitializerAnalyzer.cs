using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Data;
using System.Collections.Immutable;

namespace Amazon.CodeAnalysis.Shared
{
    public abstract class AbstractNullCollectionInitializerAnalyzer : DiagnosticAnalyzer
    {
        // Using the AWSSDK2XXX as the range of diagnostic ids for SDK nullability diagnostic messages
        public const string DiagnosticId = "AWSSDK2000";

        private static readonly LocalizableString Title = new LocalizableResourceString(nameof(Resources.CollectionInitializerNullRule_Title), Resources.ResourceManager, typeof(Resources));
        private static readonly LocalizableString MessageFormat = new LocalizableResourceString(nameof(Resources.CollectionInitializerNullRule_MessageFormat), Resources.ResourceManager, typeof(Resources));
        private static readonly LocalizableString Description = new LocalizableResourceString(nameof(Resources.CollectionInitializerNullRule_Description), Resources.ResourceManager, typeof(Resources));
        private const string Category = "AWSSDK.Nullability";

        private static readonly DiagnosticDescriptor CollectionInitializerNullRule = new DiagnosticDescriptor(DiagnosticId, Title, MessageFormat, Category, DiagnosticSeverity.Warning, isEnabledByDefault: true, description: Description);

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get { return ImmutableArray.Create(CollectionInitializerNullRule); } }

        /// <summary>
        /// The abstact method that the service specific code analyzer will generate that identifies 
        /// the model namespace.
        /// </summary>
        /// <returns></returns>
        protected abstract string GetModelNamespace();

        public override void Initialize(AnalysisContext context)
        {
            context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);
            context.EnableConcurrentExecution();

            context.RegisterSyntaxNodeAction(LookForCollectionInitializer, SyntaxKind.CollectionInitializerExpression);
        }

        private void LookForCollectionInitializer(SyntaxNodeAnalysisContext context)
        {
            // If the parent is not an assignment then the collection is being initialized
            // as part of an object initializer. The object initializer will take care
            // of setting the property to a new collection.
            if (context.Node.Parent.Kind() != SyntaxKind.SimpleAssignmentExpression)
                return;

            // Get the property on the left side of the assignment.
            var simpleAssignmentExpression = context.Node.Parent as AssignmentExpressionSyntax;
            var property = context.SemanticModel.GetSymbolInfo(simpleAssignmentExpression.Left).Symbol as IPropertySymbol;
            if (property == null)
                return;

            // Check to see if the property is coming from a type in the SDK's model folder.
            // We already know the property is a collection type because we are evaluating the
            // syntax for a CollectionInitializerExpression.
            var ns = GetFullNamespace(property.ContainingNamespace);
            if (!string.Equals(ns, GetModelNamespace(), StringComparison.Ordinal))
                return;

            // We have determined that the property is for an SDK POCO and CollectionInitializerExpression is 
            // not part of object ObjectInitializerExpression. That most likely means items are being attempted
            // to be added to a null collection. It is a warning because it is possible AWSConfigs.InitializeCollections
            // has been set to false but there is no way for the analyser to know that.
            var diagnostic = Diagnostic.Create(CollectionInitializerNullRule, context.Node.GetLocation(), property.Name);
            context.ReportDiagnostic(diagnostic);
        }

        private string GetFullNamespace(INamespaceSymbol typeSymbol)
        {
            // The containing namespace can have an empty name when we recuse up to the global namespace.
            if (typeSymbol.ContainingNamespace == null || typeSymbol.ContainingNamespace.Name == string.Empty)
                return typeSymbol.Name;

            return GetFullNamespace(typeSymbol.ContainingNamespace) + "." + typeSymbol.Name;
        }
    }
}
