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

using System;
using System.Collections.Generic;

using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using System.Globalization;
using Amazon.Util;

namespace Amazon.DynamoDBv2.DataModel
{
    /// <summary>
    /// Interface for converting arbitrary objects to DynamoDB-supported
    /// object types.
    /// 
    /// Implementing type must be public, instantiable, and should have
    /// a zero-parameter constructor.
    /// </summary>
    public interface IPropertyConverter
    {
        /// <summary>
        /// Convert object to DynamoDBEntry
        /// </summary>
        /// <param name="value">Object to be deserialized</param>
        /// <returns>Object deserialized as DynamoDBEntry</returns>
        DynamoDBEntry ToEntry(object value);

        /// <summary>
        /// Convert DynamoDBEntry to the specified object
        /// </summary>
        /// <param name="entry">DynamoDBEntry to be serialized</param>
        /// <returns>Serialized object</returns>
        object FromEntry(DynamoDBEntry entry);
    }

    /// <summary>
    /// Configuration object for setting options on the DynamoDBContext.
    /// and individual operations.
    /// </summary>
    public class DynamoDBContextConfig
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public DynamoDBContextConfig()
        {
            TableNamePrefix = AWSConfigsDynamoDB.Context.TableNamePrefix;
            Conversion = DynamoDBEntryConversion.CurrentConversion;
            MetadataCachingMode = AWSConfigsDynamoDB.Context.MetadataCachingMode;
            DisableFetchingTableMetadata = AWSConfigsDynamoDB.Context.DisableFetchingTableMetadata;
        }

        /// <summary>
        /// Property that directs DynamoDBContext to use consistent reads.
        /// If property is not set, behavior defaults to non-consistent reads.
        /// </summary>
        public bool? ConsistentRead { get; set; }

        /// <summary>
        /// Property that directs DynamoDBContext to skip version checks
        /// when saving or deleting an object with a version attribute.
        /// If property is not set, version checks are performed.
        /// </summary>
        public bool? SkipVersionCheck { get; set; }

        /// <summary>
        /// Property that directs DynamoDBContext to prefix all table names
        /// with a specific string.
        /// If property is null or empty, no prefix is used and default
        /// table names are used.
        /// </summary>
        public string TableNamePrefix { get; set; }

        /// <summary>
        /// The object persistence model API relies on an internal cache of the DynamoDB table's metadata to construct and validate 
        /// requests. This controls how the cache key is derived, which influences when the SDK will call 
        /// <see cref="IAmazonDynamoDB.DescribeTable(string)"/> internally to populate the cache.
        /// </summary>
        /// <remarks>
        /// For <see cref="MetadataCachingMode.Default"/> the cache key will be a combination of the table name, credentials, region and service URL. 
        /// For <see cref="MetadataCachingMode.TableNameOnly"/> the cache key will only consist of the table name. This reduces cache misses in contexts
        /// where you are accessing tables with identical structure but using different credentials or endpoints (such as a multi-tenant application).
        /// </remarks>
        public MetadataCachingMode? MetadataCachingMode { get; set; }

        /// <summary>
        /// Property that directs DynamoDBContext to ignore null values
        /// on attributes during a Save operation.
        /// If the property is false (or not set), null values will be
        /// interpreted as directives to delete the specific attribute.
        /// </summary>
        public bool? IgnoreNullValues { get; set; }

        /// <summary>
        /// Property that directs DynamoDBContext to enable empty string values
        /// on attributes during a Save operation.
        /// If the property is false (or not set), empty string values will be
        /// interpreted as null values.
        /// </summary>
        public bool? IsEmptyStringValueEnabled { get; set; }

        /// <summary>
        /// Conversion specification which controls how conversion between
        /// .NET and DynamoDB types happens.
        /// </summary>
        public DynamoDBEntryConversion Conversion { get; set; }

        /// <summary>
        /// If true disables fetching table metadata automatically from DynamoDB. Table metadata must be 
        /// defined by <see cref="DynamoDBAttribute"/> attributes and/or in <see cref = "AWSConfigsDynamoDB"/>.
        /// </summary>
        /// <remarks>
        /// Setting this to true can avoid latency and thread starvation due to blocking asynchronous 
        /// <see cref="IAmazonDynamoDB.DescribeTable(string)"/> calls that are used to populate the SDK's cache of 
        /// table metadata. It requires that the table's index schema be accurately described via the above methods, 
        /// otherwise exceptions may be thrown and/or the results of certain DynamoDB operations may change.
        /// </remarks>
        public bool? DisableFetchingTableMetadata { get; set; }
    }

    /// <summary>
    /// Configuration object for setting options for individual operations.
    /// This will override any settings specified by the DynamoDBContext's DynamoDBContextConfig object.
    /// </summary>
    public class DynamoDBOperationConfig : DynamoDBContextConfig
    {
        /// <summary>
        /// Property that indicates the table to save an object to overriding the DynamoDBTable attribute 
        /// declared for the type.
        /// </summary>
        public string OverrideTableName { get; set; }

        /// <summary>
        /// Property that indicates a query should traverse the index backward.
        /// If the property is false (or not set), traversal shall be forward.
        /// </summary>
        public bool? BackwardQuery { get; set; }

        /// <summary>
        /// Property indicating the name of the index to query or scan against.
        /// This value is optional if the index name can be inferred from the call.
        /// </summary>
        public string IndexName { get; set; }

        /// <summary>
        /// A logical operator to apply to the filter conditions:
        /// AND - If all of the conditions evaluate to true, then the entire filter evaluates to true.
        /// OR - If at least one of the conditions evaluate to true, then the entire filter evaluates to true.
        /// 
        /// Default value is AND.
        /// </summary>
        public ConditionalOperatorValues ConditionalOperator { get; set; }

        /// <summary>
        /// Query filter for the Query operation operation. Evaluates the query results and returns only
        /// the matching values. If you specify more than one condition, then by default all of the
        /// conditions must evaluate to true. To match only some conditions, set ConditionalOperator to Or.
        /// Note: Conditions must be against non-key properties.
        /// </summary>
        public List<ScanCondition> QueryFilter { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public DynamoDBOperationConfig()
        {
            QueryFilter = new List<ScanCondition>();
        }

        // Checks if the IndexName is set on the config
        internal bool IsIndexOperation { get { return !string.IsNullOrEmpty(IndexName); } }
    }

    /// <summary>
    /// Class describing a single scan condition
    /// </summary>
    public class ScanCondition
    {
        #region Public properties

        /// <summary>
        /// Name of the property being tested
        /// </summary>
        public string PropertyName { get; set; }

        /// <summary>
        /// Comparison operator
        /// </summary>
        public ScanOperator Operator { get; set; }

        /// <summary>
        /// Values being tested against.
        /// 
        /// The values should be of the same type as the property.
        /// In the cases where the property is a collection, the values
        /// should be of the same type as the items in the collection.
        /// </summary>
        public object[] Values { get; set; }

        #endregion


        #region Constructor

        /// <summary>
        /// Initializes a ScanCondition with the target property, the
        /// comparison operator and values being tested against.
        /// </summary>
        /// <param name="propertyName">Name of the property</param>
        /// <param name="op">Comparison operator</param>
        /// <param name="values">
        /// Value(s) being tested against.
        /// 
        /// The values should be of the same type as the property.
        /// In the cases where the property is a collection, the values
        /// should be of the same type as the items in the collection.
        /// </param>
        public ScanCondition(string propertyName, ScanOperator op, params object[] values)
        {
            PropertyName = propertyName;
            Operator = op;
            Values = values;
        }

        #endregion
    }

    /// <summary>
    /// Class describing a single query condition
    /// </summary>
    public class QueryCondition
    {
        #region Public properties

        /// <summary>
        /// Name of the property being tested
        /// </summary>
        public string PropertyName { get; set; }

        /// <summary>
        /// Comparison operator
        /// </summary>
        public QueryOperator Operator { get; set; }

        /// <summary>
        /// Values being tested against.
        /// 
        /// The values should be of the same type as the property.
        /// In the cases where the property is a collection, the values
        /// should be of the same type as the items in the collection.
        /// </summary>
        public object[] Values { get; set; }

        #endregion


        #region Constructor

        /// <summary>
        /// Initializes a ScanCondition with the target property, the
        /// comparison operator and values being tested against.
        /// </summary>
        /// <param name="propertyName">Name of the property</param>
        /// <param name="op">Comparison operator</param>
        /// <param name="values">
        /// Value(s) being tested against.
        /// 
        /// The values should be of the same type as the property.
        /// In the cases where the property is a collection, the values
        /// should be of the same type as the items in the collection.
        /// </param>
        public QueryCondition(string propertyName, QueryOperator op, params object[] values)
        {
            PropertyName = propertyName;
            Operator = op;
            Values = values;
        }

        #endregion
    }


    internal class DynamoDBFlatConfig
    {
        public static string DefaultIndexName = string.Empty;

        private static DynamoDBOperationConfig _emptyOperationConfig = new DynamoDBOperationConfig
        {
            ConsistentRead = null,
            OverrideTableName = null,
            SkipVersionCheck = null,
            TableNamePrefix = null,
            IgnoreNullValues = null,
            BackwardQuery = null,
            IndexName = null,
            ConditionalOperator = ConditionalOperatorValues.And,
            Conversion = null,
            IsEmptyStringValueEnabled = null,
            MetadataCachingMode = null
        };
        private static DynamoDBContextConfig _emptyContextConfig = new DynamoDBContextConfig
        {
            ConsistentRead = null,
            SkipVersionCheck = null,
            TableNamePrefix = null,
            IgnoreNullValues = null,
            Conversion = null,
            IsEmptyStringValueEnabled = null,
            MetadataCachingMode = null
        };

        public DynamoDBFlatConfig(DynamoDBOperationConfig operationConfig, DynamoDBContextConfig contextConfig)
        {
            if (operationConfig == null)
                operationConfig = _emptyOperationConfig;
            if (contextConfig == null)
                contextConfig = _emptyContextConfig;

            bool consistentRead = operationConfig.ConsistentRead ?? contextConfig.ConsistentRead ?? false;
            bool skipVersionCheck = operationConfig.SkipVersionCheck ?? contextConfig.SkipVersionCheck ?? false;
            bool ignoreNullValues = operationConfig.IgnoreNullValues ?? contextConfig.IgnoreNullValues ?? false;
            bool disableFetchingTableMetadata = contextConfig.DisableFetchingTableMetadata ?? false;

            bool isEmptyStringValueEnabled = operationConfig.IsEmptyStringValueEnabled ?? contextConfig.IsEmptyStringValueEnabled ?? false;
            string overrideTableName =
                !string.IsNullOrEmpty(operationConfig.OverrideTableName) ? operationConfig.OverrideTableName : string.Empty;
            string tableNamePrefix =
                !string.IsNullOrEmpty(operationConfig.TableNamePrefix) ? operationConfig.TableNamePrefix :
                !string.IsNullOrEmpty(contextConfig.TableNamePrefix) ? contextConfig.TableNamePrefix : string.Empty;
            bool backwardQuery = operationConfig.BackwardQuery ?? false;
            string indexName =
                !string.IsNullOrEmpty(operationConfig.IndexName) ? operationConfig.IndexName : DefaultIndexName;
            List<ScanCondition> queryFilter = operationConfig.QueryFilter ?? new List<ScanCondition>();
            ConditionalOperatorValues conditionalOperator = operationConfig.ConditionalOperator;
            DynamoDBEntryConversion conversion = operationConfig.Conversion ?? contextConfig.Conversion ?? DynamoDBEntryConversion.CurrentConversion;
            MetadataCachingMode metadataCachingMode = operationConfig.MetadataCachingMode ?? contextConfig.MetadataCachingMode ?? DynamoDBv2.MetadataCachingMode.Default;

            ConsistentRead = consistentRead;
            SkipVersionCheck = skipVersionCheck;
            IgnoreNullValues = ignoreNullValues;
            IsEmptyStringValueEnabled = isEmptyStringValueEnabled;
            OverrideTableName = overrideTableName;
            TableNamePrefix = tableNamePrefix;
            BackwardQuery = backwardQuery;
            IndexName = indexName;
            QueryFilter = queryFilter;
            ConditionalOperator = conditionalOperator;
            Conversion = conversion;
            MetadataCachingMode = metadataCachingMode;
            DisableFetchingTableMetadata = disableFetchingTableMetadata;

            State = new OperationState();
        }

        /// <summary>
        /// Property that directs DynamoDBContext to use consistent reads.
        /// If property is not set, behavior defaults to non-consistent reads.
        /// </summary>
        public bool? ConsistentRead { get; set; }

        /// <summary>
        /// Property that directs DynamoDBContext to skip version checks
        /// when saving or deleting an object with a version attribute.
        /// If property is not set, version checks are performed.
        /// </summary>
        public bool? SkipVersionCheck { get; set; }

        /// <summary>
        /// Property that directs DynamoDBContext to prefix all table names
        /// with a specific string.
        /// If property is null or empty, no prefix is used and default
        /// table names are used.
        /// </summary>
        public string TableNamePrefix { get; set; }

        /// <summary>
        /// The object mapping API relies on an internal cache of the DynamoDB table's metadata to construct and validate 
        /// requests. This controls how the cache key is derived, which influences when the SDK will call 
        /// <see cref="IAmazonDynamoDB.DescribeTable(string)"/> internally to populate the cache.
        /// </summary>
        public MetadataCachingMode? MetadataCachingMode { get; set; }

        /// <summary>
        /// Property that directs DynamoDBContext to ignore null values
        /// on attributes during a Save operation.
        /// If the property is false (or not set), null values will be
        /// interpreted as directives to delete the specific attribute.
        /// </summary>
        public bool? IgnoreNullValues { get; set; }

        /// <summary>
        /// Property that directs DynamoDBContext to enable empty string values
        /// on attributes during a Save operation.
        /// If the property is false (or not set), empty string values will be
        /// interpreted as null values.
        /// </summary>
        public bool IsEmptyStringValueEnabled { get; set; }

        /// <summary>
        /// Property that indicates the table to save an object to overriding the DynamoDBTable attribute 
        /// declared for the type.
        /// </summary>
        public string OverrideTableName { get; set; }

        /// <summary>
        /// Property that indicates a query should traverse the index backward.
        /// If the property is false (or not set), traversal shall be forward.
        /// </summary>
        public bool? BackwardQuery { get; set; }

        /// <summary>
        /// Property indicating the name of the index to query or scan against.
        /// This value is optional if the index name can be inferred from the call.
        /// </summary>
        public string IndexName { get; set; }

        /// <summary>
        /// A logical operator to apply to the filter conditions:
        /// AND - If all of the conditions evaluate to true, then the entire filter evaluates to true.
        /// OR - If at least one of the conditions evaluate to true, then the entire filter evaluates to true.
        /// 
        /// Default value is AND.
        /// </summary>
        public ConditionalOperatorValues ConditionalOperator { get; set; }

        /// <summary>
        /// Query filter for the Query operation operation. Evaluates the query results and returns only
        /// the matching values. If you specify more than one condition, then by default all of the
        /// conditions must evaluate to true. To match only some conditions, set ConditionalOperator to Or.
        /// Note: Conditions must be against non-key properties.
        /// </summary>
        public List<ScanCondition> QueryFilter { get; set; }

        /// <summary>
        /// Conversion specification which controls how conversion between
        /// .NET and DynamoDB types happens.
        /// </summary>
        public DynamoDBEntryConversion Conversion { get; set; }

        /// <inheritdoc cref="DynamoDBContextConfig.DisableFetchingTableMetadata"/>
        public bool DisableFetchingTableMetadata { get; set; }

        // Checks if the IndexName is set on the config
        internal bool IsIndexOperation { get { return !string.IsNullOrEmpty(IndexName); } }

        // State of the operation using this config
        internal OperationState State { get; private set; }

        public class OperationState
        {
            private CircularReferenceTracking referenceTracking;

            public OperationState()
            {
                referenceTracking = new CircularReferenceTracking();
            }

            public IDisposable Track(object target)
            {
                return referenceTracking.Track(target);
            }
        }
    }
}
