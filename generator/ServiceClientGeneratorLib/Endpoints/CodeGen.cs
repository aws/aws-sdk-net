using System;
using System.Linq;
using System.Text;

namespace ServiceClientGenerator.Endpoints
{
    using Json.LitJson;
    using ServiceClientGenerator;
    using ServiceClientGenerator.Endpoints.Partitions;
    using System.Collections.Generic;
    using System.Data;

    /// <summary>
    /// Translates Endpoints RuleSet to valid set of C# IF statements.
    /// Every rule translates to IF(condition1 && condition2 && ...).
    /// Tree rule translates to more inner IFs.
    /// Every condition is a call to standard function, that can have multiple parameters including other function calls.
    /// Condition can return a result that can be stored as internal reference which can be used in other rules/conditions.
    /// Every final IF statement either returns an Endpoint or throws meaningful AmazonClientException.
    /// </summary>
    /// <example>
    /// This shows example of generated code.
    /// <code>
    /// if (StringEquals(refs["Region"], "us-east-1") && BooleanEquals(refs["UseFIPS"], false) && BooleanEquals(refs["UseDualStack"], false))
    /// {
    ///     return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#path}", refs));
    /// }
    /// </code>
    /// </example>
    public static class CodeGen
    {
        const int INITIAL_INDENT = 3;
        const int INDENT_SIZE = 4;

        /// <summary>
        /// Translates Endpoints RuleSet to valid set of C# IF statements
        /// </summary>
        public static string GenerateRules(RuleSet rules)
        {
            var code = new StringBuilder();
            foreach (Rule rule in rules.rules)
            {
                GenerateRule(rule, code, INITIAL_INDENT);
            }
            return code.ToString();
        }

        private static void GenerateRule(Rule rule, StringBuilder code, int indent)
        {
            const string AND = @" && ";
            var codeIndent = new string(' ', indent * INDENT_SIZE);
            var singleIndent = new string(' ', INDENT_SIZE);
            var innerIndent = codeIndent;

            var nonEmptyConditions = rule.conditions.Length > 0;
            if (nonEmptyConditions)
            {
                code.Append($@"{codeIndent}if (");

                foreach (var condition in rule.conditions)
                {
                    GenerateStandardFunction(condition.Function, code, true);
                    code.Append(AND);
                }
                code.Remove(code.Length - AND.Length, AND.Length);

                code.Append($@")");

                code.AppendLine();
                code.AppendLine($@"{codeIndent}{{");

                innerIndent = codeIndent + singleIndent;
            }

            switch (rule.Type)
            {
                case RuleType.Error:
                    {
                        var value = MaybeInterpolate(rule.error);
                        code.AppendLine($@"{innerIndent}throw new AmazonClientException({value});");
                        break;
                    }
                case RuleType.Endpoint: 
                    {
                        string url = GenerateUrl(rule.endpoint.url);
                        var properties = rule.endpoint.properties != null ? rule.endpoint.properties.ToJson().SanitizeQuotes() : String.Empty;
                        var headers = rule.endpoint.headers != null ? rule.endpoint.headers.ToJson().SanitizeQuotes() : String.Empty;
                        code.AppendLine($@"{innerIndent}return new Endpoint({url}, InterpolateJson(@""{properties}"", refs), InterpolateJson(@""{headers}"", refs));");
                        break;
                    }
                case RuleType.Tree: 
                    {
                        foreach(var subRule in rule.rules)
                        {
                            GenerateRule(subRule, code, indent + (nonEmptyConditions ? 1 : 0));
                        }
                        break;
                    }
                default: throw new Exception("Unknown rule type.");
            }

            if (nonEmptyConditions)
            {
                code.AppendLine($@"{codeIndent}}}");
            }
        }

        /// <summary>
        /// Url can be defined as template string | reference | function
        /// </summary>
        private static string GenerateUrl(JsonData url)
        {
            if (url.IsString)
            {
                return MaybeInterpolate((string)url);
            }
            if (url.IsObject)
            {
                if (url.PropertyNames.Contains("ref"))
                {
                    return $"(string)refs[\"{url["ref"]}\"]";
                }
                if (url.PropertyNames.Contains("fn"))
                {
                    var function = new StringBuilder();
                    GenerateStandardFunction(new Function((string)url["fn"], url["argv"]), function);
                    return $"(string){function}";
                }
            }
            throw new Exception("Unknown Endpoint Url definition.");
        }

        private static string MaybeInterpolate(string s)
        {
            s = s.SanitizeQuotes();
            return s.Contains('{') ? $@"Interpolate(@""{s}"", refs)" : $@"""{s}""";
        }

        private static void GenerateStandardFunction(Function function, StringBuilder code, bool isCondition = false)
        {
            const string COMMA_AND_SPACE = @", ";

            if (!string.IsNullOrEmpty(function.Assign))
            {
                code.Append($@"(refs[""{function.Assign}""] = ");
            }

            switch (function.Name)
            {
                case "not":
                    {
                        code.Append(@"!");
                        GenerateFunctionArgument(function.Name, 0, function.Arguments[0], code);
                        break;
                    }
                default:
                    {
                        code.Append($@"{GetFunctionName(function.Name)}(");
                        for (int i = 0; i < function.Arguments.Count; i++)
                        {
                            var arg = function.Arguments[i];
                            GenerateFunctionArgument(function.Name, i, arg, code);
                            code.Append(COMMA_AND_SPACE);
                        }
                        code.Remove(code.Length - COMMA_AND_SPACE.Length, COMMA_AND_SPACE.Length);
                        code.Append(@")");
                        break;
                    }
            }

            if (!string.IsNullOrEmpty(function.Assign))
            {
                code.Append(@") != null");
            }
            else if (isCondition && !IsBooleanFunction(function.Name))
            {
                code.Append(@" != null");
            }
        }

        private static string GetFunctionName(string name)
        {
            if (name == "stringEquals" || name == "booleanEquals") return "Equals";
            return name.Replace("aws.", "").ToUpperFirstCharacter();
        }

        private static bool IsBooleanFunction(string name)
        {
            switch (name)
            {
                case "not":
                case "isSet":
                case "stringEquals":
                case "booleanEquals":
                case "isValidHostLabel":
                case "aws.isVirtualHostableS3Bucket":
                    return true;
                default: 
                    return false;
            }
        }

        // functions parameter types
        private static Dictionary<string, List<string>> functionParamTypes = new Dictionary<string, List<string>>
        {
            ["aws.partition"] = new List<string> { "string" },
            ["aws.parseArn"] = new List<string> { "string" },
            ["aws.isVirtualHostableS3Bucket"] = new List<string> { "string", "bool" },
            ["isValidHostLabel"] = new List<string> { "string", "bool" },
            ["parseURL"] = new List<string> { "string" },
            ["uriEncode"] = new List<string> { "string" },
            ["substring"] = new List<string> { "string", "int", "int", "bool" }
        };

        private static void GenerateFunctionArgument(string functionName, int argumentIndex, Argument argument, StringBuilder code)
        {
            switch (argument)
            {
                case StringArgument arg:
                {
                    var value = MaybeInterpolate(arg.Value);
                    code.Append($"{value}");
                    break;
                }
                case IntegerArgument arg:
                {
                    code.Append($"{arg.Value}");
                    break;
                }
                case BoolArgument arg:
                {
                    code.Append($"{arg.Value.ToString().ToLower()}"); // true | false
                    break;
                }
                case ReferenceArgument arg:
                {
                    AddTypeCast(functionName, argumentIndex, code);
                    code.Append($@"refs[""{arg.ReferenceName}""]");
                    break;
                }
                case FunctionArgument arg:
                {
                    AddTypeCast(functionName, argumentIndex, code);
                    GenerateStandardFunction(arg.Value, code);
                    break;
                }
                default: throw new Exception("Unknown argument type.");
            }
        }

        private static void AddTypeCast(string functionName, int argumentIndex, StringBuilder code)
        {
            if (functionParamTypes.ContainsKey(functionName))
            {
                var argumentType = functionParamTypes[functionName][argumentIndex];
                code.Append($@"({argumentType})");
            }
        }
    }
}
