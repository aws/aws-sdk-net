using System.Collections.Generic;
using Amazon.DynamoDBv2.DocumentModel;

namespace Amazon.DynamoDBv2.DataModel
{
    /// <summary>
    /// Represents a conditional expression for DynamoDB queries, supporting both simple and composite key conditions.
    /// Provides a fluent API for building query conditions with hash keys and range keys.
    /// </summary>
    /// <remarks>
    /// <para>This class supports querying DynamoDB tables and Global Secondary Indexes (GSIs) with various key configurations:</para>
    /// <list type="bullet">
    /// <item><description>Single hash key queries</description></item>
    /// <item><description>Composite hash key queries (multiple hash keys)</description></item>
    /// <item><description>Single rage key queries with various operators</description></item>
    /// <item><description>Composite range key conditions queries (multiple range keys)</description></item>
    /// </list>
    /// </remarks>
    /// <example>
    /// <para>Simple hash key query:</para>
    /// <code>
    /// var condition = QueryConditional.HashKeyEqualTo("UserId", "user123");
    /// var results = context.Query&lt;User&gt;(condition);
    /// </code>
    /// 
    /// <para>Composite hash key query with range condition:</para>
    /// <code>
    /// var condition = QueryConditional.HashKeyEqualTo("UserId", "user123")
    ///     .AndHashKeyEqualTo("OrderId", "order456")
    ///     .AndRangeKeyGreaterThan("Timestamp", 1000);
    /// </code>
    /// 
    /// <para>Multiple range key conditions:</para>
    /// <code>
    /// var condition = QueryConditional.HashKeyEqualTo("Category", "electronics")
    ///     .AndRangeKeyEqualTo("Status", "active")
    ///     .AndRangeKeyBetween("Price", 100, 500);
    /// </code>
    /// </example>
    public class QueryConditional
    {
        internal Dictionary<string, object> HashKeys { get; private set; }

        internal Dictionary<string, RangeKeyCondition> RangeValues { get; private set; }

        private QueryConditional()
        {
            this.HashKeys=new Dictionary<string, object>();
            this.RangeValues=new Dictionary<string, RangeKeyCondition>();
        }

        /// <summary>
        /// Creates a query conditional for a hash key equality condition.
        /// </summary>
        /// <param name="hashKeyName">The hash key attribute name.</param>
        /// <param name="hashKeyValue">The hash key value.</param>
        /// <returns>A QueryConditional instance.</returns>
        public static QueryConditional HashKeyEqualTo(string hashKeyName, object hashKeyValue)
        {
            return new QueryConditional
            {
                HashKeys = new Dictionary<string, object> { [hashKeyName] = hashKeyValue }
            };
        }

        /// <summary>
        /// Adds a condition to the query that specifies the hash key must equal the given value.
        /// </summary>
        /// <param name="hashKeyName">The name of the hash key to be matched.</param>
        /// <param name="value">The value that the hash key must equal.</param>
        /// <returns>The current <see cref="QueryConditional"/> instance with the added condition.</returns>
        public QueryConditional AndHashKeyEqualTo(string hashKeyName, object value)
        {
            HashKeys.Add(hashKeyName, value);
            return this;
        }
        
        /// <summary>
        /// Creates a <see cref="QueryConditional"/> object with the specified hash keys.
        /// </summary>
        /// <remarks>The <paramref name="hashKeys"/> dictionary must contain at least one key-value pair. 
        /// The keys in the dictionary represent the names of the hash keys, and the values represent their
        /// corresponding values.</remarks>
        /// <param name="hashKeys">A dictionary containing the hash key names and their corresponding values.  Each entry represents a
        /// key-value pair used to define the hash key condition.</param>
        /// <returns>A <see cref="QueryConditional"/> object initialized with the provided hash keys.</returns>
        public static QueryConditional HashKeysEqual(Dictionary<string, object> hashKeys)
        {
            return new QueryConditional
            {
                HashKeys = hashKeys
            };
        }

        /// <summary>
        /// Adds a range key equality condition to the query.
        /// </summary>
        /// <param name="rangeKeyName">The range key attribute name.</param>
        /// <param name="value">The value that the range key must equal.</param>
        /// <returns>The current QueryConditional instance.</returns>
        public QueryConditional AndRangeKeyEqualTo(string rangeKeyName, object value)
        {
            RangeValues.Add(rangeKeyName, new RangeKeyCondition(QueryOperator.Equal, new []{value}));
            return this;
        }

        /// <summary>
        /// Adds a range key begins-with condition to the query.
        /// </summary>
        /// <param name="rangeKeyName">The range key attribute name.</param>
        /// <param name="value">The prefix value that the range key must begin with.</param>
        /// <returns>The current QueryConditional instance.</returns>
        public QueryConditional AndRangeKeyBeginsWith(string rangeKeyName, object value)
        {
            RangeValues.Add(rangeKeyName, new RangeKeyCondition(QueryOperator.BeginsWith, new []{value}));
            return this;
        }

        /// <summary>
        /// Adds a range key greater-than condition to the query.
        /// </summary>
        /// <param name="rangeKeyName">The range key attribute name.</param>
        /// <param name="value">The value that the range key must be greater than.</param>
        /// <returns>The current QueryConditional instance.</returns>
        public QueryConditional AndRangeKeyGreaterThan(string rangeKeyName, object value)
        {
            RangeValues.Add(rangeKeyName, new RangeKeyCondition(QueryOperator.GreaterThan, new []{value}));
            return this;
        }

        /// <summary>
        /// Adds a range key greater-than-or-equal condition to the query.
        /// </summary>
        /// <param name="rangeKeyName">The range key attribute name.</param>
        /// <param name="value">The value that the range key must be greater than or equal to.</param>
        /// <returns>The current QueryConditional instance.</returns>
        public QueryConditional AndRangeKeyGreaterThanOrEqual(string rangeKeyName, object value)
        {
            RangeValues.Add(rangeKeyName, new RangeKeyCondition(QueryOperator.GreaterThanOrEqual, new []{value}));
            return this;
        }

        /// <summary>
        /// Adds a range key less-than condition to the query.
        /// </summary>
        /// <param name="rangeKeyName">The range key attribute name.</param>
        /// <param name="value">The value that the range key must be less than.</param>
        /// <returns>The current QueryConditional instance.</returns>
        public QueryConditional AndRangeKeyLessThan(string rangeKeyName, object value)
        {
            RangeValues.Add(rangeKeyName, new RangeKeyCondition(QueryOperator.LessThan, new []{value}));
            return this;
        }

        /// <summary>
        /// Adds a range key less-than-or-equal condition to the query.
        /// </summary>
        /// <param name="rangeKeyName">The range key attribute name.</param>
        /// <param name="value">The value that the range key must be less than or equal to.</param>
        /// <returns>The current QueryConditional instance.</returns>
        public QueryConditional AndRangeKeyLessThanOrEqual(string rangeKeyName, object value)
        {
            RangeValues.Add(rangeKeyName, new RangeKeyCondition(QueryOperator.LessThanOrEqual, new []{value}));
            return this;
        }

        /// <summary>
        /// Adds a range key between condition to the query.
        /// </summary>
        /// <param name="rangeKeyName">The range key attribute name.</param>
        /// <param name="fromValue">The lower bound value (inclusive).</param>
        /// <param name="toValue">The upper bound value (inclusive).</param>
        /// <returns>The current QueryConditional instance.</returns>
        public QueryConditional AndRangeKeyBetween(string rangeKeyName, object fromValue, object toValue)
        {
            RangeValues.Add(rangeKeyName, new RangeKeyCondition(QueryOperator.Between, new []{ fromValue, toValue}));
            return this;
        }
    }

    /// <summary>
    /// Represents a range key condition for DynamoDB queries.
    /// </summary>
    internal class RangeKeyCondition
    {
        /// <summary>
        /// Gets the query operator for the range key condition.
        /// </summary>
        public QueryOperator Operator { get; }

        /// <summary>
        /// Gets the values for the range key condition.
        /// </summary>
        public IEnumerable<object> Values { get; }

        /// <summary>
        /// Initializes a new instance of the RangeKeyCondition class.
        /// </summary>
        /// <param name="operator">The query operator.</param>
        /// <param name="values">The values for the condition.</param>
        public RangeKeyCondition(QueryOperator @operator, IEnumerable<object> values)
        {
            Operator = @operator;
            Values = values;
        }
    }
}