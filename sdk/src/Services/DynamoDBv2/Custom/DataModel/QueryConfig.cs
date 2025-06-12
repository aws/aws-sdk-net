/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using Amazon.DynamoDBv2.DocumentModel;
using System;
using System.Collections.Generic;

namespace Amazon.DynamoDBv2.DataModel
{
    /// <summary>
    /// Input for the Query operation in the object-persistence programming model
    /// </summary>
    public class QueryConfig : BaseOperationConfig
    {
        /// <summary>
        /// Indicates whether a query should traverse the index backwards in descending order by range key value.
        /// If the property is false (or not set), traversal shall be in ascending order.
        /// </summary>
        public bool? BackwardQuery { get; set; }

        /// <summary>
        /// Indicates the name of the index to query against.
        /// This value is optional if the index name can be inferred from the call.
        /// </summary>
        public string IndexName { get; set; }

        /// <summary>
        /// The logical operator to apply to the filter conditions.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        ///     <item>
        ///         <term><see cref="ConditionalOperatorValues.And" /></term>
        ///         <definition>If all of the conditions evaluate to true, then the entire filter evaluates to true.</definition>
        ///     </item>
        ///     <item>
        ///         <term><see cref="ConditionalOperatorValues.Or" /></term>
        ///         <definition>If at least one of the conditions evaluate to true, then the entire filter evaluates to true.</definition>
        ///     </item>
        /// </list>
        /// The default value is <see cref="ConditionalOperatorValues.And" />.
        /// </remarks>
        public ConditionalOperatorValues ConditionalOperator { get; set; }

        /// <summary>
        /// Query filter for the Query operation. Evaluates the query results and returns only
        /// the matching values. If you specify more than one condition, then by default all of the
        /// conditions must evaluate to true. To match only some conditions, set <see cref="ConditionalOperator"/> to <see cref="ConditionalOperatorValues.Or" />.
        /// </summary>
        /// <remarks>
        /// Note: Conditions must be against non-key properties.
        /// </remarks>
        public List<ScanCondition> QueryFilter { get; set; }

        /// <summary>
        /// Represents a filter expression that can be used to filter results in DynamoDB operations.
        /// </summary>
        /// <remarks>
        /// Note: Expression filters must be against non-key properties.
        /// </remarks>
        public ContextExpression Expression { get; set; }

        /// <summary>
        /// Property that directs <see cref="DynamoDBContext" /> to use consistent reads.
        /// If property is not set, behavior defaults to non-consistent reads.
        /// </summary>
        /// <remarks>
        /// Refer to the <see href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/HowItWorks.ReadConsistency.html">
        /// Read Consistency</see> topic in the DynamoDB Developer Guide for more information.
        /// </remarks>
        public bool? ConsistentRead { get; set; }

        /// <summary>
        /// If true, all <see cref="DateTime"/> properties are retrieved in UTC timezone while reading data from DynamoDB. Else, the local timezone is used.
        /// </summary>
        /// <remarks>
        /// This setting is only applicable to the high-level library. Service calls made via 
        /// <see cref="AmazonDynamoDBClient"/> will always return <see cref="DateTime"/> attributes in UTC.
        /// </remarks>
        public bool? RetrieveDateTimeInUtc { get; set; }

        /// <inheritdoc/>
        internal override DynamoDBOperationConfig ToDynamoDBOperationConfig()
        {
            var config = base.ToDynamoDBOperationConfig();
            config.BackwardQuery = BackwardQuery;
            config.IndexName = IndexName;
            config.ConditionalOperator = ConditionalOperator;
            config.QueryFilter = QueryFilter;
            config.Expression = Expression;
            config.ConsistentRead = ConsistentRead;
            config.RetrieveDateTimeInUtc = RetrieveDateTimeInUtc;

            return config;
        }
    }
}
