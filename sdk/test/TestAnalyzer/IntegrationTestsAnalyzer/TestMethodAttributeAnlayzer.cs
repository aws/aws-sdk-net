using System;
using System.Collections.Immutable;
using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using System.Reflection;
using System.IO;
using System.Text.RegularExpressions;

namespace IntegrationTestsAnalyzer
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class TestMethodAttributeAnlayzer : DiagnosticAnalyzer
    {
        private static HashSet<string> ValidTestCategories = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "General",   // always run these tests
            "Core",      // changes to Core that's not tied to any particular AWS Service
        };
        
        private static string DiagnosticCategory = "Integration Test";
        private static DiagnosticDescriptor TestCategoryAttributeRequiredRule = new DiagnosticDescriptor(
            "ITA1",
            "Missing [TestCategory] attribute.",
            "An AWS C# SDK integration test method must have a [TestCategory] attribute.",
            DiagnosticCategory,
            DiagnosticSeverity.Error,
            isEnabledByDefault: true);

        private static DiagnosticDescriptor ValidTestCategoryAttributeRule = new DiagnosticDescriptor(
            "ITA2",
            "Invalid [TestCategory] attribute.",
            "'{0}' is not a valid [TestCategory] attribute associated with an AWS service.",
            DiagnosticCategory,
            DiagnosticSeverity.Error,
            isEnabledByDefault: true);

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics => ImmutableArray.Create(TestCategoryAttributeRequiredRule, ValidTestCategoryAttributeRule);

        public override void Initialize(AnalysisContext context)
        {
            PopulateValidTestCategories();
            context.RegisterSymbolAction(AnalyzeTestMethodAttribute, SymbolKind.Method);
        }

        private static void PopulateValidTestCategories()
        {
            var assembly = Assembly.GetExecutingAssembly();
            StreamReader streamReader = new StreamReader(assembly.GetManifestResourceStream("manifest.json"));

            Regex exp = new Regex(".*\"base-name\"\\s*:\\s*\"(\\w*)\".*");
            string line;
            while ((line = streamReader.ReadLine()) != null
                && !streamReader.EndOfStream)
            {
                Match m = exp.Match(line);
                if (m.Success)
                {
                    ValidTestCategories.Add(m.Groups[1].ToString());
                }
            }
        }

        private static void AnalyzeTestMethodAttribute(SymbolAnalysisContext context)
        {
            if (context.Symbol.Kind != SymbolKind.Method) return;

            bool isTestMethod = false;
            bool foundTestCategoryAttribute = false;
            List<Diagnostic> diagnostics = new List<Diagnostic>();

            foreach(AttributeData attribute in context.Symbol.GetAttributes())
            {
                // Since we don't want to introduce a depenedency to MSTest, just validate that we are looking
                // at the correct namespace and symbol.
                System.Diagnostics.Debug.WriteLine(attribute.AttributeClass.ContainingNamespace.ToString());
                if (!attribute.AttributeClass.ContainingNamespace.ToString().Equals("Microsoft.VisualStudio.TestTools.UnitTesting")) continue;
                isTestMethod |= attribute.AttributeClass.Name.Equals("TestMethodAttribute");

                if (attribute.AttributeClass.Name.Equals("TestCategoryAttribute"))
                {
                    foundTestCategoryAttribute = true;

                    // If no parameters are supplied to TestCategory attribute, 
                    // the msvc compiler will complain about missing constructor.
                    // No need to handle this case.
                    if (attribute.ConstructorArguments.Length <= 0) continue;

                    string testCategory = attribute.ConstructorArguments[0].Value.ToString();

                    if (!ValidTestCategories.Contains(testCategory))
                    {
                        foreach(var location in attribute.AttributeConstructor.Locations)
                        {
                            diagnostics.Add(Diagnostic.Create(ValidTestCategoryAttributeRule, context.Symbol.Locations[0], testCategory));
                        }
                    }
                }
            }

            if (isTestMethod)
            {
                if (!foundTestCategoryAttribute)
                {
                    context.ReportDiagnostic(Diagnostic.Create(TestCategoryAttributeRequiredRule, context.Symbol.Locations[0]));
                }
                else
                {
                    diagnostics.ForEach(d => context.ReportDiagnostic(d));
                }
            }
        }
    }
}
