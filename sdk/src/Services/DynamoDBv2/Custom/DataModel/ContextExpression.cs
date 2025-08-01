using Amazon.DynamoDBv2.DocumentModel;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ThirdParty.RuntimeBackports;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using Expression = System.Linq.Expressions.Expression;

namespace Amazon.DynamoDBv2.DataModel
{
    /// <summary>
    /// Represents a context expression for DynamoDB operations in the object-persistence programming model.
    /// Used to encapsulate filter expressions for query and scan operations.
    /// </summary>
    public class ContextExpression
    {
        /// <summary>
        /// Gets the filter expression used to filter results in DynamoDB operations.
        /// This expression is typically constructed from a LINQ expression tree.
        /// </summary>
        public Expression Filter { get; private set; }

        /// <summary>
        /// Sets the filter expression for DynamoDB operations.
        /// Converts the provided LINQ expression into an internal expression tree for use in DynamoDB queries or scans.
        /// </summary>
        /// <typeparam name="T">The type of the object being filtered.</typeparam>
        /// <param name="filterExpression">A LINQ expression representing the filter condition.</param>
        /// <exception cref="ArgumentNullException">Thrown if <paramref name="filterExpression"/> is null.</exception>
        public void SetFilter<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(Expression<Func<T, bool>> filterExpression)
        {
            if (filterExpression == null)
            {
                throw new ArgumentNullException(nameof(filterExpression), "Filter expression cannot be null.");
            }
            Filter = filterExpression.Body;
        }

        /// <summary>
        /// Indicates that the value should be compared to see if it falls inclusively between the specified lower and upper bounds.
        /// Intended for use in LINQ expressions to generate DynamoDB BETWEEN conditions.
        /// This method is only used inside expression trees and should not be called at runtime.
        /// </summary>
        /// <typeparam name="T">The type of the value being compared.</typeparam>
        /// <param name="value">The value to test.</param>
        /// <param name="lower">The inclusive lower bound.</param>
        /// <param name="upper">The inclusive upper bound.</param>
        /// <returns>This method is intended to be used only within expression definitions (such as LINQ expression trees) and should not be called at runtime.</returns>
        public static bool Between<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(T value, T lower, T upper) 
        {
            throw new NotSupportedException("The method 'Between' is intended for use only in LINQ expression trees and should not be called at runtime.");
        }

        /// <summary>
        /// Indicates that the attribute exists in the DynamoDB item.
        /// Intended for use in LINQ expressions to generate DynamoDB attribute_exists conditions.
        /// This method is only used inside expression trees and should not be called at runtime.
        /// </summary>
        /// <param name="_">The object representing the attribute to check.</param>
        /// <returns>True if the attribute exists; otherwise, false.</returns>
        public static bool AttributeExists(object _) => throw new NotSupportedException("This method is only intended for use in LINQ expression trees and should not be called at runtime.");

        /// <summary>
        /// Indicates that the attribute does not exist in the DynamoDB item.
        /// Intended for use in LINQ expressions to generate DynamoDB attribute_not_exists conditions.
        /// This method is only used inside expression trees and should not be called at runtime.
        /// </summary>
        /// <param name="_">The object representing the attribute to check.</param>
        /// <returns>This method is intended to be used only within expression definitions (such as LINQ expression trees) and should not be called at runtime.</returns>
        public static bool AttributeNotExists(object _) => throw new NotSupportedException("This method is intended to be used only within expression definitions (such as LINQ expression trees) and should not be called at runtime.");

        /// <summary>
        /// Indicates that the attribute is of the specified DynamoDB type.
        /// Intended for use in LINQ expressions to generate DynamoDB attribute_type conditions.
        /// This method is only used inside expression trees and should not be called at runtime.
        /// </summary>
        /// <param name="_">The object representing the attribute to check.</param>
        /// <param name="dynamoDbType">The DynamoDB attribute type to compare against.</param>
        /// <returns>This method is intended to be used only within expression definitions (such as LINQ expression trees) and should not be called at runtime.</returns>
        public static bool AttributeType(object _, string dynamoDbType) => throw new NotSupportedException("The method AttributeType is intended for use only in expression trees and should not be called at runtime.");
    }



    internal static class ContextExpressionsUtils
    {
        internal static string GetRangeKeyConditionExpression(string rangeKeyAlias, QueryOperator op)
        {
            return op switch
            {
                QueryOperator.Equal => $" AND {rangeKeyAlias} = :rangeKey0",
                QueryOperator.LessThan => $" AND {rangeKeyAlias} < :rangeKey0",
                QueryOperator.LessThanOrEqual => $" AND {rangeKeyAlias} <= :rangeKey0",
                QueryOperator.GreaterThan => $" AND {rangeKeyAlias} > :rangeKey0",
                QueryOperator.GreaterThanOrEqual => $" AND {rangeKeyAlias} >= :rangeKey0",
                QueryOperator.Between => $" AND {rangeKeyAlias} BETWEEN :rangeKey0 AND :rangeKey0",
                QueryOperator.BeginsWith => $" AND begins_with({rangeKeyAlias}, :rangeKey0)",
                _ => throw new NotSupportedException($"QueryOperator '{op}' is not supported for key conditions.")
            };
        }

        internal static bool IsMember(Expression expr)
        {
            return expr switch
            {
                MemberExpression memberExpr => true,
                UnaryExpression ue => IsMember(ue.Operand),
                _ => false
            };
        }

        internal static object GetConstant(Expression expr)
        {
            return EvaluateExpression(expr);
        }

        private static object EvaluateExpression(Expression expr)
        {
            switch (expr)
            {
                case ConstantExpression c:
                    return c.Value;

                case MemberExpression m:
                    var instance = m.Expression != null ? EvaluateExpression(m.Expression) : null;
                    if (m.Member is FieldInfo fi)
                        return fi.GetValue(instance);
                    if (m.Member is PropertyInfo pi)
                        return pi.GetValue(instance);
                    break;

                case MethodCallExpression call:
                    var method = call.Method;

                    if (method.Name == "get_Item")
                    {
                        var target = EvaluateExpression(call.Object);
                        var indexArgs = call.Arguments.Select(EvaluateExpression).ToArray();
                        return method.Invoke(target, indexArgs);
                    }

                    if (method.Name == "Contains")
                    {
                        throw new NotSupportedException("The 'Contains' method is not supported for constant extraction in expression trees. Use supported property or indexer access instead.");
                    }

                    var targetObj = call.Object != null ? EvaluateExpression(call.Object) : null;
                    var arguments = call.Arguments.Select(EvaluateExpression).ToArray();
                    return method.Invoke(targetObj, arguments);

                case UnaryExpression u when u.NodeType == ExpressionType.Convert:
                    var operand = EvaluateExpression(u.Operand);
                    return Convert.ChangeType(operand, u.Type);

                case NewExpression n:
                    var args = n.Arguments.Select(EvaluateExpression).ToArray();
                    return n.Constructor.Invoke(args);
            }

            throw new NotSupportedException($"Expression type '{expr.NodeType}' not supported.");
        }

        internal static bool IsComparison(ExpressionType type)
        {
            return type is ExpressionType.Equal or ExpressionType.NotEqual or
                ExpressionType.GreaterThan or ExpressionType.GreaterThanOrEqual or
                ExpressionType.LessThan or ExpressionType.LessThanOrEqual;
        }

        internal static MemberExpression GetMember(Expression expr)
        {
            switch (expr)
            {
                case MemberExpression memberExpr:
                    return memberExpr;
                case UnaryExpression ue:
                    return GetMember(ue.Operand);
                // Handle indexer access (get_Item) for lists/arrays/dictionaries
                case MethodCallExpression methodCall:
                    switch (methodCall.Method.Name)
                    {
                        case "get_Item":
                            return GetMember(methodCall.Object);
                        case "First":
                        case "FirstOrDefault":
                            if (methodCall.Arguments.Count > 0)
                                return GetMember(methodCall.Arguments[0]);
                            break;
                    }

                    break;
            }

            return null;
        }

        internal static List<PathNode> ExtractPathNodes(Expression expr)
        {
            var pathNodes = new List<PathNode>();
            int indexDepth = 0;
            string indexed = string.Empty;

            while (expr != null)
            {
                switch (expr)
                {
                    case MemberExpression memberExpr:
                        pathNodes.Insert(0,
                            new PathNode(memberExpr.Member.Name, indexDepth, false, $"#n{indexed}"));
                        indexed = string.Empty;
                        indexDepth = 0;
                        expr = memberExpr.Expression;
                        break;
                    case MethodCallExpression { Method: { Name: "First" or "FirstOrDefault" } } methodCall:
                        expr = methodCall.Arguments.Count > 0 ? methodCall.Arguments[0] : methodCall.Object;
                        indexDepth++;
                        indexed += "[0]";
                        break;
                    case MethodCallExpression { Method: { Name: "get_Item" } } methodCall:
                        {
                            var arg = methodCall.Arguments[0];
                            if (arg is ConstantExpression constArg)
                            {
                                var indexValue = constArg.Value;
                                switch (indexValue)
                                {
                                    case int intValue:
                                        indexDepth++;
                                        indexed += $"[{intValue}]";
                                        break;
                                    case string stringValue:
                                        pathNodes.Insert(0, new PathNode(stringValue, indexDepth, true, $"#n{indexed}"));
                                        indexDepth = 0;
                                        indexed = string.Empty;
                                        break;
                                    default:
                                        throw new NotSupportedException(
                                            $"Indexer argument must be an integer or string, got {indexValue.GetType().Name}.");
                                }
                            }
                            else
                            {
                                throw new NotSupportedException(
                                    $"Method {methodCall.Method.Name} is not supported in property path.");
                            }

                            expr = methodCall.Object;
                            break;
                        }
                    case MethodCallExpression methodCall:
                        throw new NotSupportedException(
                            $"Method {methodCall.Method.Name} is not supported in property path.");
                    case UnaryExpression
                    {
                        NodeType: ExpressionType.Convert or ExpressionType.ConvertChecked
                    } unaryExpr:
                        // Handle conversion expressions (e.g., (int)someEnum)
                        expr = unaryExpr.Operand;
                        break;

                    default:
                        expr = null;
                        break;
                }
            }

            return pathNodes;
        }
    }

    /// <summary>
    /// Represents a node in a path expression for DynamoDB operations.
    /// </summary>
    internal class PathNode
    {
        public string Path { get; }

        public string FormattedPath { get; }

        public int IndexDepth { get; }

        public bool IsMap { get; }

        public PathNode(string path, int indexDepth, bool isMap, string formattedPath)
        {
            Path = path;
            IndexDepth = indexDepth;
            IsMap = isMap;
            FormattedPath = formattedPath;
        }
    }

    internal class PropertyNode
    {
        [DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)]
        public Type PropertyType { get; set; }
    }
}