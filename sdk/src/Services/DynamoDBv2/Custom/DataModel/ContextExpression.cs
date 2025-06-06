using Amazon.DynamoDBv2.DocumentModel;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Expression = System.Linq.Expressions.Expression;

namespace Amazon.DynamoDBv2.DataModel
{
    /// <summary>
    /// Represents a context expression for DynamoDB operations in the object-persistence programming model.
    /// </summary>
    public class ContextExpression
    {
        /// <summary>
        /// Represents a filter expression that can be used to filter results in DynamoDB operations.
        /// </summary>
        public Expression Filter { get; private set; }

        /// <summary>
        /// Sets the filter expression for DynamoDB operations.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filterExpression"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void SetFilter<T>(Expression<Func<T, bool>> filterExpression)
        {
            if (filterExpression == null)
            {
                throw new ArgumentNullException(nameof(filterExpression), "Filter expression cannot be null.");
            }
            Filter = filterExpression.Body;
        }
    }

    /// <summary>
    /// Extensions for LINQ operations in DynamoDB.
    /// </summary>
    public static class LinqDdbExtensions
    {
        /// <summary>
        /// Checks if a value is between two other values, inclusive.
        /// 
        /// This method is only used inside expression trees; it should never be called at runtime.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <returns></returns>
        public static bool Between<T>(this T value, T lower, T upper) => throw null!;

        /// <summary>
        /// Checks if a value is not between two other values, inclusive.
        /// 
        /// This method is only used inside expression trees; it should never be called at runtime.
        /// </summary>
        /// <param name="_"></param>
        /// <returns></returns>
        public static bool AttributeExists(this object _) => throw null!;

        /// <summary>
        /// Checks if a value does not have a specific attribute.
        /// 
        /// This method is only used inside expression trees; it should never be called at runtime.
        /// </summary>
        /// <param name="_"></param>
        /// <returns></returns>
        public static bool AttributeNotExists(this object _) => throw null!;

        /// <summary>
        /// Checks if a value has a specific attribute type.
        /// 
        /// This method is only used inside expression trees; it should never be called at runtime.
        /// </summary>
        /// <param name="_"></param>
        /// <param name="dynamoDbType"></param>
        /// <returns></returns>
        public static bool AttributeType(this object _, DynamoDBAttributeType dynamoDbType) => throw null!;
    }

    /// <summary>
    /// Represents a node in a path expression for DynamoDB operations.
    /// </summary>
    internal class PathNode
    {
        public string Path { get; }

        public string FormattedPath { get; }

        public int IndexDepth { get; }

        public bool IsMap { get;  }

        public PathNode(string path, int indexDepth, bool isMap, string formattedPath)
        {
            Path = path;
            IndexDepth = indexDepth;
            IsMap = isMap;
            FormattedPath = formattedPath;
        }
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


        internal static ConstantExpression GetConstant(Expression expr)
        {
            return expr switch
            {
                ConstantExpression constant => constant,
                // If the expression is a UnaryExpression, check its Operand
                UnaryExpression unary => unary.Operand as ConstantExpression,
                NewExpression => throw new NotSupportedException($"Unsupported expression type {expr.Type}"),
                _ => null
            };
        }

        internal static bool IsComparison(ExpressionType type)
        {
            return type is ExpressionType.Equal or ExpressionType.NotEqual or
                ExpressionType.GreaterThan or ExpressionType.GreaterThanOrEqual or
                ExpressionType.LessThan or ExpressionType.LessThanOrEqual;
        }

        internal static MemberExpression GetMember(Expression expr)
        {
            if (expr is MemberExpression memberExpr)
                return memberExpr;

            if (expr is UnaryExpression ue)
                return GetMember(ue.Operand);

            // Handle indexer access (get_Item) for lists/arrays/dictionaries
            if (expr is MethodCallExpression methodCall && methodCall.Method.Name == "get_Item")
                return GetMember(methodCall.Object);

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
}