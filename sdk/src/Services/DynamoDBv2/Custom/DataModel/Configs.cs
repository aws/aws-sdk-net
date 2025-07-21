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
using Amazon.Util;
using System;
using System.Collections.Generic;

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
    /// Configuration object for setting options on the <see cref="DynamoDBContext"/> that
    /// will apply to all operations that use the context object.
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
            RetrieveDateTimeInUtc = AWSConfigsDynamoDB.Context.RetrieveDateTimeInUtc;
        }

        /// <summary>
        /// Property that directs <see cref="DynamoDBContext"/> to use consistent reads.
        /// If property is not set, behavior defaults to non-consistent reads.
        /// </summary>
        /// <remarks>
        /// Refer to the <see href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/HowItWorks.ReadConsistency.html">
        /// Read Consistency</see> topic in the DynamoDB Developer Guide for more information.
        /// </remarks>
        public bool? ConsistentRead { get; set; }

        /// <summary>
        /// Property that directs <see cref="DynamoDBContext"/> to skip version checks
        /// when saving or deleting an object with a version attribute.
        /// If property is not set, version checks are performed.
        /// </summary>
        public bool? SkipVersionCheck { get; set; }

        /// <summary>
        /// Property that directs <see cref="DynamoDBContext"/> to prefix all table names
        /// with a specific string.
        /// If property is null or empty, no prefix is used and default
        /// table names are used.
        /// </summary>
        public string TableNamePrefix { get; set; }

        /// <summary>
        /// The object persistence model API relies on an internal cache of the DynamoDB table's metadata to construct and validate 
        /// requests. This controls how the cache key is derived, which influences when the SDK will call 
        /// IAmazonDynamoDB.DescribeTable(string) internally to populate the cache.
        /// </summary>
        /// <remarks>
        /// For <see cref="MetadataCachingMode.Default"/> the cache key will be a combination of the table name, credentials, region and service URL. 
        /// For <see cref="MetadataCachingMode.TableNameOnly"/> the cache key will only consist of the table name. This reduces cache misses in contexts
        /// where you are accessing tables with identical structure but using different credentials or endpoints (such as a multi-tenant application).
        /// </remarks>
        public MetadataCachingMode? MetadataCachingMode { get; set; }

        /// <summary>
        /// Property that directs <see cref="DynamoDBContext"/> to ignore null values
        /// on attributes during a Save operation.
        /// If the property is false (or not set), null values will be
        /// interpreted as directives to delete the specific attribute.
        /// </summary>
        public bool? IgnoreNullValues { get; set; }

        /// <summary>
        /// Property that directs <see cref="DynamoDBContext"/> to enable empty string values
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
        /// IAmazonDynamoDB.DescribeTable(string) calls that are used to populate the SDK's cache of 
        /// table metadata. It requires that the table's index schema be accurately described via the above methods, 
        /// otherwise exceptions may be thrown and/or the results of certain DynamoDB operations may change.
        /// </remarks>
        public bool? DisableFetchingTableMetadata { get; set; }

        /// <summary>
        /// If true, all <see cref="DateTime"/> properties are retrieved in UTC timezone while reading data from DynamoDB. Else, the local timezone is used.
        /// </summary>
        /// <remarks>This setting is only applicable to the high-level library. 
        /// Service calls made via <see cref="AmazonDynamoDBClient"/> will always return 
        /// <see cref="DateTime"/> attributes in UTC.</remarks>
        public bool? RetrieveDateTimeInUtc { get; set; }

        /// <summary>
        /// Gets or sets the attribute name used to store the type discriminator for polymorphic types in DynamoDB.
        /// </summary>
        /// <remarks>
        /// When working with polymorphic types—where a base class or interface has multiple derived implementations
        /// it's essential to preserve the specific type information during serialization and deserialization
        /// when using the <see cref="DynamoDBPolymorphicTypeAttribute"/>.
        ///
        /// By default, the SDK uses a predefined attribute name of "$type" to store this type discriminator in your DynamoDB items.
        /// However, you can customize this attribute name to align with your application's naming conventions or to avoid
        /// conflicts with existing attributes.
        /// </remarks>
        public string DerivedTypeAttributeName { get; set; }

    }

    /// <summary>
    /// Configuration object for setting options for individual operations.
    /// This will override any settings specified by the DynamoDBContext's DynamoDBContextConfig object.
    /// </summary>

    public class DynamoDBOperationConfig
    {
        /// <summary>
        /// Property that directs <see cref="DynamoDBContext"/> to use consistent reads.
        /// If property is not set, behavior defaults to non-consistent reads.
        /// </summary>
        /// <remarks>
        /// Refer to the <see href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/HowItWorks.ReadConsistency.html">
        /// Read Consistency</see> topic in the DynamoDB Developer Guide for more information.
        /// </remarks>
        public bool? ConsistentRead { get; set; }

        /// <summary>
        /// Property that directs <see cref="DynamoDBContext"/> to skip version checks
        /// when saving or deleting an object with a version attribute.
        /// If property is not set, version checks are performed.
        /// </summary>
        public bool? SkipVersionCheck { get; set; }

        /// <summary>
        /// Indicates which DynamoDB table to use. This overrides the table specified 
        /// by the <see cref="DynamoDBTableAttribute"/> on the .NET objects that you're saving or loading.
        /// </summary>
        /// <remarks>
        /// If you want to specify this globally instead of for each operation, you can use 
        /// the <see cref="TableAlias"/> or <see cref="TypeMapping"/> collections 
        /// on <see cref="AWSConfigsDynamoDB.Context"/>.
        /// </remarks>
        public string OverrideTableName { get; set; }

        /// <summary>
        /// Property that directs <see cref="DynamoDBContext"/> to prefix all table names
        /// with a specific string.
        /// If property is null, no prefix is used and default table names are used.
        /// </summary>
        public string TableNamePrefix { get; set; }

        /// <summary>
        /// Property that directs  <see cref="DynamoDBContext"/> to ignore null values
        /// on attributes during a Save operation.
        /// If the property is false (or not set), null values will be
        /// interpreted as directives to delete the specific attribute.
        /// </summary>
        public bool? IgnoreNullValues { get; set; }

        /// <summary>
        /// Property that directs  <see cref="DynamoDBContext"/> to enable empty string values
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
        /// If true, all <see cref="DateTime"/> properties are retrieved in UTC timezone while reading data from DynamoDB. Else, the local timezone is used.
        /// </summary>
        /// <remarks>This setting is only applicable to the high-level library. 
        /// Service calls made via <see cref="AmazonDynamoDBClient"/> will always return 
        /// <see cref="DateTime"/> attributes in UTC.</remarks>
        public bool? RetrieveDateTimeInUtc { get; set; }

        /// <summary>
        /// Indicates whether a query should traverse the index backwards in descending order by range key value.
        /// If the property is false (or not set), traversal shall be in ascending order.
        /// </summary>
        public bool? BackwardQuery { get; set; }

        /// <summary>
        /// Property indicating the name of the index to query or scan against.
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
        /// Note: Conditions must be against non-key properties.
        /// </remarks>
        public ContextExpression Expression { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public DynamoDBOperationConfig()
        {
            QueryFilter = new List<ScanCondition>();
        }

        /// <summary>
        /// Checks if the IndexName is set on the config
        /// </summary>
        internal bool IsIndexOperation { get { return !string.IsNullOrEmpty(IndexName); } }

        internal void ValidateFilter()
        {
            if (QueryFilter is { Count: > 0 } && Expression is { Filter: not null } )
            {
                throw new InvalidOperationException("Cannot specify both QueryFilter and ExpressionFilter in the same operation configuration. Please use one or the other.");
            }
        }
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
            IsEmptyStringValueEnabled = null
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

            // These properties can be set at either the operation or context levels
            bool consistentRead = operationConfig.ConsistentRead ?? contextConfig.ConsistentRead ?? false;
            bool skipVersionCheck = operationConfig.SkipVersionCheck ?? contextConfig.SkipVersionCheck ?? false;
            bool ignoreNullValues = operationConfig.IgnoreNullValues ?? contextConfig.IgnoreNullValues ?? false;
            bool retrieveDateTimeInUtc = operationConfig.RetrieveDateTimeInUtc ?? contextConfig.RetrieveDateTimeInUtc ?? true;
            bool isEmptyStringValueEnabled = operationConfig.IsEmptyStringValueEnabled ?? contextConfig.IsEmptyStringValueEnabled ?? false;
            DynamoDBEntryConversion conversion = contextConfig.Conversion ?? DynamoDBEntryConversion.CurrentConversion;
            string tableNamePrefix = operationConfig.TableNamePrefix ?? contextConfig.TableNamePrefix ?? string.Empty;

            // These properties can only be set at the operation level
            bool disableFetchingTableMetadata = contextConfig.DisableFetchingTableMetadata ?? false;
            MetadataCachingMode metadataCachingMode = contextConfig.MetadataCachingMode ?? DynamoDBv2.MetadataCachingMode.Default;

            // We don't support overriding the table name at the context level, since a context object can be used with multiple tables.
            string overrideTableName =
                !string.IsNullOrEmpty(operationConfig.OverrideTableName) ? operationConfig.OverrideTableName : string.Empty;

            // The rest are related to querying or scanning, so only operation level
            bool backwardQuery = operationConfig.BackwardQuery ?? false;
            string indexName =
                !string.IsNullOrEmpty(operationConfig.IndexName) ? operationConfig.IndexName : DefaultIndexName;
            List<ScanCondition> queryFilter = operationConfig.QueryFilter ?? new List<ScanCondition>();
            ConditionalOperatorValues conditionalOperator = operationConfig.ConditionalOperator;
            string derivedTypeAttributeName =
                //!string.IsNullOrEmpty(operationConfig.DerivedTypeAttributeName) ? operationConfig.DerivedTypeAttributeName :
                !string.IsNullOrEmpty(contextConfig.DerivedTypeAttributeName) ? contextConfig.DerivedTypeAttributeName : "$type";

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
            ContextConversion = conversion;
            OperationConversion = operationConfig.Conversion;
            MetadataCachingMode = metadataCachingMode;
            DisableFetchingTableMetadata = disableFetchingTableMetadata;
            RetrieveDateTimeInUtc = retrieveDateTimeInUtc;
            DerivedTypeAttributeName = derivedTypeAttributeName;

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
        /// IAmazonDynamoDB.DescribeTable(string) internally to populate the cache.
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
        /// Specifies the conversion behavior for .NET objects (entities) mapped to DynamoDB items.
        /// 
        /// This setting controls how conversion between .NET and DynamoDB types happens
        /// on classes annotated with <see cref="DynamoDBTableAttribute"/>
        /// </summary>
        public DynamoDBEntryConversion ItemConversion { get; set; }

        
        /// <summary>
        /// Operation Conversion specification which controls how conversion between
        /// .NET and DynamoDB types happens.
        /// </summary>
        private DynamoDBEntryConversion OperationConversion { get; }

        /// <summary>
        /// Context Conversion specification which controls how conversion between
        /// .NET and DynamoDB types happens.
        /// </summary>
        public DynamoDBEntryConversion Conversion => OperationConversion ?? ItemConversion ?? ContextConversion;

        /// <summary>
        /// Context Conversion specification which controls how conversion between
        /// .NET and DynamoDB types happens.
        /// </summary>
        private DynamoDBEntryConversion ContextConversion { get; }

        /// <inheritdoc cref="DynamoDBContextConfig.DisableFetchingTableMetadata"/>
        public bool DisableFetchingTableMetadata { get; set; }

        /// <inheritdoc cref="DynamoDBContextConfig.RetrieveDateTimeInUtc"/>
        public bool RetrieveDateTimeInUtc { get; set; }

        // Checks if the IndexName is set on the config
        internal bool IsIndexOperation => !string.IsNullOrEmpty(IndexName);

        // State of the operation using this config
        internal OperationState State { get; private set; }

        /// <summary>
        /// Property indicating the name of the attribute used to store the type discriminator for polymorphic types in DynamoDB.
        /// Default value is "$type" if not set in the config.
        /// </summary>
        /// <remarks>
        /// When working with polymorphic types—where a base class or interface has multiple derived implementations
        /// it's essential to preserve the specific type information during serialization and deserialization
        /// when using the <see cref="DynamoDBPolymorphicTypeAttribute"/>.
        ///
        /// By default, the SDK uses a predefined attribute name of "$type" to store this type discriminator in your DynamoDB items.
        /// However, you can customize this attribute name to align with your application's naming conventions or to avoid
        /// conflicts with existing attributes.
        /// </remarks>
        public string DerivedTypeAttributeName { get; set; }


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
