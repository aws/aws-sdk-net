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

namespace Amazon.DynamoDBv2.DataModel
{
    /// <summary>
    /// Input for the BatchWrite operation in the object-persistence programming model
    /// </summary>
#if NET8_0_OR_GREATER
    [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode(Custom.Internal.InternalConstants.RequiresUnreferencedCodeMessage)]
#endif
    public class BatchWriteConfig
    {
        /// <summary>
        /// Property that indicates which DynamoDB table to use, 
        /// overriding the DynamoDBTable attribute declared for the object type.
        /// </summary>
        public string OverrideTableName { get; set; }

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
        /// IAmazonDynamoDB.DescribeTable(string) internally to populate the cache.
        /// </summary>
        /// <remarks>
        /// For <see cref="MetadataCachingMode.Default"/> the cache key will be a combination of the table name, credentials, region and service URL. 
        /// For <see cref="MetadataCachingMode.TableNameOnly"/> the cache key will only consist of the table name. This reduces cache misses in contexts
        /// where you are accessing tables with identical structure but using different credentials or endpoints (such as a multi-tenant application).
        /// </remarks>
        public MetadataCachingMode? MetadataCachingMode { get; set; }

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
        /// Conversion specification which controls how the conversion between
        /// .NET and DynamoDB types happens.
        /// </summary>
        public DynamoDBEntryConversion Conversion { get; set; }

        /// <summary>
        /// Property that directs DynamoDBContext to enable empty string values
        /// on attributes during a Save operation.
        /// If the property is false (or not set), empty string values will be
        /// interpreted as null values.
        /// </summary>
        public bool? IsEmptyStringValueEnabled { get; set; }

        /// <summary>
        /// Property that directs DynamoDBContext to skip version checks
        /// when saving or deleting an object with a version attribute.
        /// If property is not set, version checks are performed.
        /// </summary>
        public bool? SkipVersionCheck { get; set; }

        /// <summary>
        /// Property that directs DynamoDBContext to ignore null values
        /// on attributes during a Save operation.
        /// If the property is false (or not set), null values will be
        /// interpreted as directives to delete the specific attribute.
        /// </summary>
        public bool? IgnoreNullValues { get; set; }

        /// <summary>
        /// Converts this to the shared <see cref="DynamoDBOperationConfig"/>
        /// </summary>
        /// <remarks>
        /// Users should interact with the new, operation-specific configs, but we
        /// convert to the internal shared config for the internal code paths.
        /// </remarks>
        /// <returns>A new <see cref="DynamoDBOperationConfig"/></returns>
        internal DynamoDBOperationConfig ToDynamoDBOperationConfig()
        {
            return new DynamoDBOperationConfig()
            {
                OverrideTableName = OverrideTableName,
                TableNamePrefix = TableNamePrefix,
                MetadataCachingMode = MetadataCachingMode,
                DisableFetchingTableMetadata = DisableFetchingTableMetadata,
                Conversion = Conversion,
                IsEmptyStringValueEnabled = IsEmptyStringValueEnabled,
                SkipVersionCheck = SkipVersionCheck,
                IgnoreNullValues = IgnoreNullValues
            };
        }
    }
}
