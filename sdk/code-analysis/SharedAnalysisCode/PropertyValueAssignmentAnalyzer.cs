using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Reflection;
using System.Linq;
using System.Xml.Linq;
using System.Threading;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

namespace Amazon.CodeAnalysis.Shared
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public abstract class AbstractPropertyValueAssignmentAnalyzer : DiagnosticAnalyzer
    {
        static IDictionary<string, PropertyValueRule> _propertyValueRules;

        static AbstractPropertyValueAssignmentAnalyzer()
        {
            _propertyValueRules = new Dictionary<string, PropertyValueRule>();

            foreach (var name in typeof(AbstractPropertyValueAssignmentAnalyzer).GetTypeInfo().Assembly.GetManifestResourceNames())
            {
                if (!name.EndsWith(".PropertyValueRules.xml"))
                    continue;

                using (var stream = typeof(AbstractPropertyValueAssignmentAnalyzer).GetTypeInfo().Assembly.GetManifestResourceStream(name))
                {
                    XDocument doc = XDocument.Load(stream);
                    IEnumerable<PropertyValueRule> result = from c in doc.Descendants("property-value-rule")
                                                            select new PropertyValueRule()
                                                            {
                                                                PropertyName = c.Element("property").Value,
                                                                Min = c.Element("property") != null ? int.Parse(c.Element("min").Value) : (int?)null,
                                                                Max = c.Element("property") != null ? int.Parse(c.Element("max").Value) : (int?)null
                                                            };

                    foreach (var rule in result)
                    {
                        _propertyValueRules[rule.PropertyName] = rule;
                    }
                }
            }
        }

        public abstract string GetSerivceName();


        public string DiagnosticId
        {
            get
            {
                return string.Format("AWS.{0}.PropertyValues", GetSerivceName());
            }
        }

        // You can change these strings in the Resources.resx file. If you do not want your analyzer to be localize-able, you can use regular strings for Title and MessageFormat.

        private const string Category = "Property Values";

        DiagnosticDescriptor _minLengthRule;
        private DiagnosticDescriptor MinLengthRule
        {
            get
            {
                if (this._minLengthRule == null)
                {
                    this._minLengthRule = new DiagnosticDescriptor(
                        DiagnosticId,
                        "Property value too short",
                        "value \"{0}\" is too short for {1}, it must be at least {2} characters",
                        Category,
                        DiagnosticSeverity.Warning,
                        isEnabledByDefault: true,
                        description: "Property value too short");
                }

                return this._minLengthRule;
            }
        }

        DiagnosticDescriptor _maxLengthRule;
        private DiagnosticDescriptor MaxLengthRule
        {
            get
            {
                if (this._maxLengthRule == null)
                {
                    this._maxLengthRule = new DiagnosticDescriptor(
                        DiagnosticId,
                        "Property value too long",
                        "value \"{0}\" is too long for {1}, it must be at least {2} characters",
                        Category,
                        DiagnosticSeverity.Warning,
                        isEnabledByDefault: true,
                        description: "Property value too long");
                }
                return this._maxLengthRule;
            }
        }


        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                return ImmutableArray.Create(MinLengthRule, MaxLengthRule);
            }
        }

        public override void Initialize(AnalysisContext context)
        {
            if (_propertyValueRules.Count != 0)
                context.RegisterSyntaxNodeAction(PropertyAssignmentValidation, SyntaxKind.SimpleAssignmentExpression);
        }

        private void PropertyAssignmentValidation(SyntaxNodeAnalysisContext context)
        {
            if (_propertyValueRules.Count == 0)
                return;

            var assignmentExpr = (AssignmentExpressionSyntax)context.Node;

            var literal = assignmentExpr.Right as LiteralExpressionSyntax;
            if (literal == null)
                return;

            var symbol = context.SemanticModel.GetSymbolInfo(assignmentExpr.Left).Symbol;
            var memberSymbol = context.SemanticModel.GetSymbolInfo(assignmentExpr.Left).Symbol as Microsoft.CodeAnalysis.IPropertySymbol;
            if (memberSymbol == null)
                return;

            PropertyValueRule propertyValueRule;
            if (!_propertyValueRules.TryGetValue(memberSymbol.ToString(), out propertyValueRule))
                return;

            var literalOpt = context.SemanticModel.GetConstantValue(literal);
            if (!literalOpt.HasValue)
                return;

            if (literalOpt.Value is string)
            {
                var value = literalOpt.Value as string;
                if (propertyValueRule.Min.HasValue)
                {
                    if (value.Length < propertyValueRule.Min.Value)
                    {
                        var diagnostic =
                            Diagnostic.Create(MinLengthRule,
                            literal.GetLocation(),
                            new object[] { value, memberSymbol.Name, propertyValueRule.Min.Value });
                        context.ReportDiagnostic(diagnostic);
                    }
                }
            }
        }

        public class PropertyValueRule
        {
            public string PropertyName { get; set; }
            public int? Min { get; set; }
            public int? Max { get; set; }
            public string Regex { get; set; }
        }
    }
}
