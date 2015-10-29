using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Linq;
using System.Text.RegularExpressions;
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

                string content;
                using (var stream = typeof(AbstractPropertyValueAssignmentAnalyzer).GetTypeInfo().Assembly.GetManifestResourceStream(name))
                using (var reader = new StreamReader(stream))
                {
                    content = reader.ReadToEnd();
                }

                XDocument doc = XDocument.Parse(content);
                foreach(var element in doc.Descendants("property-value-rule"))
                {
                    var rule = new PropertyValueRule()
                    {
                        PropertyName = element.Element("property").Value,
                        Min = element.Element("min") != null ? int.Parse(element.Element("min").Value) : (int?)null,
                        Max = element.Element("max") != null ? int.Parse(element.Element("max").Value) : (int?)null,
                        Pattern = element.Element("pattern") != null ? element.Element("pattern").Value : null
                    };

                    if (!string.IsNullOrEmpty(rule.Pattern))
                    {
                        try
                        {
                            rule.CompiledExpression = new Regex(element.Element("pattern").Value);
                        }
                        catch { }
                    }

                    _propertyValueRules[rule.PropertyName] = rule;
                }
            }
        }

        public abstract string GetServiceName();


        public string DiagnosticId
        {
            get
            {
                return string.Format("AWS.{0}.PropertyValues", GetServiceName());
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
                        "Value \"{0}\" is too short for {1}, it must be at least {2} characters",
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
                        "Value \"{0}\" is too long for {1}, it must be at least {2} characters",
                        Category,
                        DiagnosticSeverity.Warning,
                        isEnabledByDefault: true,
                        description: "Property value too long");
                }
                return this._maxLengthRule;
            }
        }

        DiagnosticDescriptor _patternRule;
        private DiagnosticDescriptor PatternRule
        {
            get
            {
                if (this._patternRule == null)
                {
                    this._patternRule = new DiagnosticDescriptor(
                        DiagnosticId,
                        "Property value does match required pattern",
                        "Value \"{0}\" does not match required pattern {1} for property {2}",
                        Category,
                        DiagnosticSeverity.Warning,
                        isEnabledByDefault: true,
                        description: "Property value too long");
                }
                return this._patternRule;
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
            // Call the abstract method to make it easier to debug.
            // You can set a breakpoint in the override method so you know you are debugging the 
            // analyzer you care about. 
            this.GetServiceName();

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
                if (propertyValueRule.Max.HasValue)
                {
                    if (value.Length > propertyValueRule.Max.Value)
                    {
                        var diagnostic =
                            Diagnostic.Create(MaxLengthRule,
                            literal.GetLocation(),
                            new object[] { value, memberSymbol.Name, propertyValueRule.Max.Value });
                        context.ReportDiagnostic(diagnostic);
                    }
                }
                if (propertyValueRule.CompiledExpression != null)
                {
                    var match = propertyValueRule.CompiledExpression.Match(value);
                    if (!string.Equals(match.Value, value, StringComparison.Ordinal))
                    {
                        var diagnostic =
                            Diagnostic.Create(PatternRule,
                            literal.GetLocation(),
                            new object[] { value, propertyValueRule.Pattern, memberSymbol.Name });
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
            public Regex CompiledExpression { get; set; }
            public string Pattern { get; set; }
        }
    }
}
