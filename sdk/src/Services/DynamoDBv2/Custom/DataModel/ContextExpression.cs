using System;
using System.Linq.Expressions;
using Amazon.DynamoDBv2.DocumentModel;
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
}